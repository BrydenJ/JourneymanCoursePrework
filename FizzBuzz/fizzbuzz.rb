class FizzBuzz
	def self.getFizzBuzzValue(value)
		result = ""
		fizz = value % 3 == 0 ? result += "Fizz" : false
		buzz = value % 5 == 0 ? result += "Buzz" : false
		
		!fizz && !buzz ? value.to_s : result.to_s
	end
end