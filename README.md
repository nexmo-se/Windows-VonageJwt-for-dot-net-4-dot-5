# A Stand alone Vonage JWT Generator for .Net 4.5

## VonageJwt.cs
- CreateUserToken(appId, privatekey, subject, [expiryInSeconds])
- CreateAdminToken(appId, privatekey, [expiryInSeconds])
- CreateTokenWithClaims(appId, privatekey, [expiryInSeconds], [claims])

## Tester.cs
- Add your application ID on line 15
- Run this for samples on usage

## privatekey.pem
- Put your Private Key here for testing
