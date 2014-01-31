require 'test/unit'
require 'fizzbuzz'

class FizzBuzzTest < Test::Unit::TestCase
	def test_can_call_getFizzBuzzValue
		assert_respond_to FizzBuzz, :getFizzBuzzValue, "The getFizzBuzzValue method is required"
	end

	def test_should_print_fizz_if_value_is_devisable_by_3
		assert_equal "Fizz", FizzBuzz.getFizzBuzzValue(3), "Passed in 3, the result should have been Fizz"
	end
	
	def test_should_print_buzz_if_value_is_devisable_by_5
		assert_equal "Buzz", FizzBuzz.getFizzBuzzValue(5), "Passed in 5, the result should have been Buzz"
	end
	
	def test_should_print_fizzbuzz_if_value_is_devisable_by_3_and_5
		assert_equal "FizzBuzz", FizzBuzz.getFizzBuzzValue(15), "Passed in 15, the result should have been FizzBuzz"
	end
	
	def test_should_print_supplied_value_if_not_devisable_by_3_or_5
		assert_equal "1", FizzBuzz.getFizzBuzzValue(1), "Passed in 1, the result should have been 1"
	end
end