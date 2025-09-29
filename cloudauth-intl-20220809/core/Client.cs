// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudauth_intl20220809.Models;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudauth-intl", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }

        public Dictionary<string, object> _postOSSObject(string bucketName, Dictionary<string, object> data)
        {
            TeaRequest request_ = new TeaRequest();
            Dictionary<string, object> form = AlibabaCloud.TeaUtil.Common.AssertAsMap(data);
            string boundary = AlibabaCloud.SDK.TeaFileform.Client.GetBoundary();
            string host = AlibabaCloud.TeaUtil.Common.AssertAsString(form.Get("host"));
            request_.Protocol = "HTTPS";
            request_.Method = "POST";
            request_.Pathname = "/";
            request_.Headers = new Dictionary<string, string>
            {
                {"host", host},
                {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                {"user-agent", AlibabaCloud.TeaUtil.Common.GetUserAgent("")},
            };
            request_.Headers["content-type"] = "multipart/form-data; boundary=" + boundary;
            request_.Body = AlibabaCloud.SDK.TeaFileform.Client.ToFileForm(form, boundary);
            TeaResponse response_ = TeaCore.DoAction(request_);

            Dictionary<string, object> respMap = null;
            string bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
            if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
            {
                respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, null);
                Dictionary<string, object> err = AlibabaCloud.TeaUtil.Common.AssertAsMap(respMap.Get("Error"));
                throw new TeaException(new Dictionary<string, object>
                {
                    {"code", err.Get("Code")},
                    {"message", err.Get("Message")},
                    {"data", new Dictionary<string, object>
                    {
                        {"httpCode", response_.StatusCode},
                        {"requestId", err.Get("RequestId")},
                        {"hostId", err.Get("HostId")},
                    }},
                });
            }
            respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, null);
            return TeaConverter.merge<object>
            (
                respMap
            );
        }

        public async Task<Dictionary<string, object>> _postOSSObjectAsync(string bucketName, Dictionary<string, object> data)
        {
            TeaRequest request_ = new TeaRequest();
            Dictionary<string, object> form = AlibabaCloud.TeaUtil.Common.AssertAsMap(data);
            string boundary = AlibabaCloud.SDK.TeaFileform.Client.GetBoundary();
            string host = AlibabaCloud.TeaUtil.Common.AssertAsString(form.Get("host"));
            request_.Protocol = "HTTPS";
            request_.Method = "POST";
            request_.Pathname = "/";
            request_.Headers = new Dictionary<string, string>
            {
                {"host", host},
                {"date", AlibabaCloud.TeaUtil.Common.GetDateUTCString()},
                {"user-agent", AlibabaCloud.TeaUtil.Common.GetUserAgent("")},
            };
            request_.Headers["content-type"] = "multipart/form-data; boundary=" + boundary;
            request_.Body = AlibabaCloud.SDK.TeaFileform.Client.ToFileForm(form, boundary);
            TeaResponse response_ = await TeaCore.DoActionAsync(request_);

            Dictionary<string, object> respMap = null;
            string bodyStr = AlibabaCloud.TeaUtil.Common.ReadAsString(response_.Body);
            if (AlibabaCloud.TeaUtil.Common.Is4xx(response_.StatusCode) || AlibabaCloud.TeaUtil.Common.Is5xx(response_.StatusCode))
            {
                respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, null);
                Dictionary<string, object> err = AlibabaCloud.TeaUtil.Common.AssertAsMap(respMap.Get("Error"));
                throw new TeaException(new Dictionary<string, object>
                {
                    {"code", err.Get("Code")},
                    {"message", err.Get("Message")},
                    {"data", new Dictionary<string, object>
                    {
                        {"httpCode", response_.StatusCode},
                        {"requestId", err.Get("RequestId")},
                        {"hostId", err.Get("HostId")},
                    }},
                });
            }
            respMap = AlibabaCloud.TeaXML.Client.ParseXml(bodyStr, null);
            return TeaConverter.merge<object>
            (
                respMap
            );
        }

        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Address Similarity Comparison</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>API for comparing two addresses, standardizing and checking address consistency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddressCompareIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddressCompareIntlResponse
        /// </returns>
        public AddressCompareIntlResponse AddressCompareIntlWithOptions(AddressCompareIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCountry))
            {
                query["DefaultCountry"] = request.DefaultCountry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text1))
            {
                query["Text1"] = request.Text1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text2))
            {
                query["Text2"] = request.Text2;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddressCompareIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddressCompareIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Address Similarity Comparison</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>API for comparing two addresses, standardizing and checking address consistency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddressCompareIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddressCompareIntlResponse
        /// </returns>
        public async Task<AddressCompareIntlResponse> AddressCompareIntlWithOptionsAsync(AddressCompareIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCountry))
            {
                query["DefaultCountry"] = request.DefaultCountry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text1))
            {
                query["Text1"] = request.Text1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text2))
            {
                query["Text2"] = request.Text2;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddressCompareIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddressCompareIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Address Similarity Comparison</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>API for comparing two addresses, standardizing and checking address consistency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddressCompareIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// AddressCompareIntlResponse
        /// </returns>
        public AddressCompareIntlResponse AddressCompareIntl(AddressCompareIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddressCompareIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Address Similarity Comparison</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>API for comparing two addresses, standardizing and checking address consistency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddressCompareIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// AddressCompareIntlResponse
        /// </returns>
        public async Task<AddressCompareIntlResponse> AddressCompareIntlAsync(AddressCompareIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddressCompareIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Address Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Based on the operator\&quot;s capabilities, input the phone number and address (or latitude and longitude) to verify whether the provided address is the user\&quot;s usual residence.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddressVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddressVerifyIntlResponse
        /// </returns>
        public AddressVerifyIntlResponse AddressVerifyIntlWithOptions(AddressVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                query["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCountry))
            {
                query["DefaultCountry"] = request.DefaultCountry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                query["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                query["DefaultProvince"] = request.DefaultProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Latitude))
            {
                query["Latitude"] = request.Latitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Longitude))
            {
                query["Longitude"] = request.Longitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                query["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddressVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddressVerifyIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Address Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Based on the operator\&quot;s capabilities, input the phone number and address (or latitude and longitude) to verify whether the provided address is the user\&quot;s usual residence.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddressVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddressVerifyIntlResponse
        /// </returns>
        public async Task<AddressVerifyIntlResponse> AddressVerifyIntlWithOptionsAsync(AddressVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCity))
            {
                query["DefaultCity"] = request.DefaultCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCountry))
            {
                query["DefaultCountry"] = request.DefaultCountry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDistrict))
            {
                query["DefaultDistrict"] = request.DefaultDistrict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultProvince))
            {
                query["DefaultProvince"] = request.DefaultProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Latitude))
            {
                query["Latitude"] = request.Latitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Longitude))
            {
                query["Longitude"] = request.Longitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                query["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddressVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddressVerifyIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Address Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Based on the operator\&quot;s capabilities, input the phone number and address (or latitude and longitude) to verify whether the provided address is the user\&quot;s usual residence.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddressVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// AddressVerifyIntlResponse
        /// </returns>
        public AddressVerifyIntlResponse AddressVerifyIntl(AddressVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddressVerifyIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Address Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Based on the operator\&quot;s capabilities, input the phone number and address (or latitude and longitude) to verify whether the provided address is the user\&quot;s usual residence.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddressVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// AddressVerifyIntlResponse
        /// </returns>
        public async Task<AddressVerifyIntlResponse> AddressVerifyIntlAsync(AddressVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddressVerifyIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes the address verification API operation, which verifies the region and address of a device using device data and carrier big data capabilities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddressVerifyV2IntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddressVerifyV2IntlResponse
        /// </returns>
        public AddressVerifyV2IntlResponse AddressVerifyV2IntlWithOptions(AddressVerifyV2IntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceToken))
            {
                query["DeviceToken"] = request.DeviceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegCountry))
            {
                query["RegCountry"] = request.RegCountry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                query["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddressVerifyV2Intl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddressVerifyV2IntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes the address verification API operation, which verifies the region and address of a device using device data and carrier big data capabilities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddressVerifyV2IntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddressVerifyV2IntlResponse
        /// </returns>
        public async Task<AddressVerifyV2IntlResponse> AddressVerifyV2IntlWithOptionsAsync(AddressVerifyV2IntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceToken))
            {
                query["DeviceToken"] = request.DeviceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegCountry))
            {
                query["RegCountry"] = request.RegCountry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                query["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddressVerifyV2Intl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddressVerifyV2IntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes the address verification API operation, which verifies the region and address of a device using device data and carrier big data capabilities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddressVerifyV2IntlRequest
        /// </param>
        /// 
        /// <returns>
        /// AddressVerifyV2IntlResponse
        /// </returns>
        public AddressVerifyV2IntlResponse AddressVerifyV2Intl(AddressVerifyV2IntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddressVerifyV2IntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes the address verification API operation, which verifies the region and address of a device using device data and carrier big data capabilities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddressVerifyV2IntlRequest
        /// </param>
        /// 
        /// <returns>
        /// AddressVerifyV2IntlResponse
        /// </returns>
        public async Task<AddressVerifyV2IntlResponse> AddressVerifyV2IntlAsync(AddressVerifyV2IntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddressVerifyV2IntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Bank Card Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Verification of bank card elements, including: two-element verification (name + bank card number), three-element verification (name + ID number + bank card number), and four-element verification (name + ID number + phone number + bank card number) for consistency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BankMetaVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BankMetaVerifyIntlResponse
        /// </returns>
        public BankMetaVerifyIntlResponse BankMetaVerifyIntlWithOptions(BankMetaVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCard))
            {
                query["BankCard"] = request.BankCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                query["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyMode))
            {
                query["VerifyMode"] = request.VerifyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BankMetaVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BankMetaVerifyIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Bank Card Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Verification of bank card elements, including: two-element verification (name + bank card number), three-element verification (name + ID number + bank card number), and four-element verification (name + ID number + phone number + bank card number) for consistency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BankMetaVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BankMetaVerifyIntlResponse
        /// </returns>
        public async Task<BankMetaVerifyIntlResponse> BankMetaVerifyIntlWithOptionsAsync(BankMetaVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCard))
            {
                query["BankCard"] = request.BankCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                query["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyMode))
            {
                query["VerifyMode"] = request.VerifyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BankMetaVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BankMetaVerifyIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Bank Card Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Verification of bank card elements, including: two-element verification (name + bank card number), three-element verification (name + ID number + bank card number), and four-element verification (name + ID number + phone number + bank card number) for consistency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BankMetaVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// BankMetaVerifyIntlResponse
        /// </returns>
        public BankMetaVerifyIntlResponse BankMetaVerifyIntl(BankMetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BankMetaVerifyIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Bank Card Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Verification of bank card elements, including: two-element verification (name + bank card number), three-element verification (name + ID number + bank card number), and four-element verification (name + ID number + phone number + bank card number) for consistency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BankMetaVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// BankMetaVerifyIntlResponse
        /// </returns>
        public async Task<BankMetaVerifyIntlResponse> BankMetaVerifyIntlAsync(BankMetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BankMetaVerifyIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pure server-side interface for document OCR recognition</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CardOcrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CardOcrResponse
        /// </returns>
        [Obsolete("OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.")]
        // Deprecated
        public CardOcrResponse CardOcrWithOptions(CardOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdFaceQuality))
            {
                query["IdFaceQuality"] = request.IdFaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureUrl))
            {
                query["IdOcrPictureUrl"] = request.IdOcrPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                query["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spoof))
            {
                query["Spoof"] = request.Spoof;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureBase64))
            {
                body["IdOcrPictureBase64"] = request.IdOcrPictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CardOcr",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CardOcrResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pure server-side interface for document OCR recognition</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CardOcrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CardOcrResponse
        /// </returns>
        [Obsolete("OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.")]
        // Deprecated
        public async Task<CardOcrResponse> CardOcrWithOptionsAsync(CardOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdFaceQuality))
            {
                query["IdFaceQuality"] = request.IdFaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureUrl))
            {
                query["IdOcrPictureUrl"] = request.IdOcrPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                query["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spoof))
            {
                query["Spoof"] = request.Spoof;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureBase64))
            {
                body["IdOcrPictureBase64"] = request.IdOcrPictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CardOcr",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CardOcrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pure server-side interface for document OCR recognition</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CardOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// CardOcrResponse
        /// </returns>
        [Obsolete("OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.")]
        // Deprecated
        public CardOcrResponse CardOcr(CardOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CardOcrWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pure server-side interface for document OCR recognition</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CardOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// CardOcrResponse
        /// </returns>
        [Obsolete("OpenAPI CardOcr is deprecated, please use Cloudauth-intl::2022-08-09::DocOcr instead.")]
        // Deprecated
        public async Task<CardOcrResponse> CardOcrAsync(CardOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CardOcrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Result Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckResultResponse
        /// </returns>
        public CheckResultResponse CheckResultWithOptions(CheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraImageControlList))
            {
                query["ExtraImageControlList"] = request.ExtraImageControlList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsReturnImage))
            {
                query["IsReturnImage"] = request.IsReturnImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFiveCategorySpoofResult))
            {
                query["ReturnFiveCategorySpoofResult"] = request.ReturnFiveCategorySpoofResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                query["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckResult",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Result Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckResultResponse
        /// </returns>
        public async Task<CheckResultResponse> CheckResultWithOptionsAsync(CheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraImageControlList))
            {
                query["ExtraImageControlList"] = request.ExtraImageControlList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsReturnImage))
            {
                query["IsReturnImage"] = request.IsReturnImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFiveCategorySpoofResult))
            {
                query["ReturnFiveCategorySpoofResult"] = request.ReturnFiveCategorySpoofResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                query["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckResult",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Result Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResultRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckResultResponse
        /// </returns>
        public CheckResultResponse CheckResult(CheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Result Query</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResultRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckResultResponse
        /// </returns>
        public async Task<CheckResultResponse> CheckResultAsync(CheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authentication Log Query Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckVerifyLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckVerifyLogResponse
        /// </returns>
        public CheckVerifyLogResponse CheckVerifyLogWithOptions(CheckVerifyLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                body["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                body["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckVerifyLog",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckVerifyLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authentication Log Query Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckVerifyLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckVerifyLogResponse
        /// </returns>
        public async Task<CheckVerifyLogResponse> CheckVerifyLogWithOptionsAsync(CheckVerifyLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                body["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                body["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckVerifyLog",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckVerifyLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authentication Log Query Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckVerifyLogRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckVerifyLogResponse
        /// </returns>
        public CheckVerifyLogResponse CheckVerifyLog(CheckVerifyLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckVerifyLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authentication Log Query Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckVerifyLogRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckVerifyLogResponse
        /// </returns>
        public async Task<CheckVerifyLogResponse> CheckVerifyLogAsync(CheckVerifyLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckVerifyLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>凭证识别查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CredentialGetResultIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CredentialGetResultIntlResponse
        /// </returns>
        public CredentialGetResultIntlResponse CredentialGetResultIntlWithOptions(CredentialGetResultIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                query["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CredentialGetResultIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CredentialGetResultIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>凭证识别查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CredentialGetResultIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CredentialGetResultIntlResponse
        /// </returns>
        public async Task<CredentialGetResultIntlResponse> CredentialGetResultIntlWithOptionsAsync(CredentialGetResultIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                query["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CredentialGetResultIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CredentialGetResultIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>凭证识别查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CredentialGetResultIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// CredentialGetResultIntlResponse
        /// </returns>
        public CredentialGetResultIntlResponse CredentialGetResultIntl(CredentialGetResultIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CredentialGetResultIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>凭证识别查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CredentialGetResultIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// CredentialGetResultIntlResponse
        /// </returns>
        public async Task<CredentialGetResultIntlResponse> CredentialGetResultIntlAsync(CredentialGetResultIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CredentialGetResultIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential Recognition</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Detects whether a voucher (such as water, electricity, gas, credit card, etc., e-bills) is forged using AI technology and extracts key information from the voucher.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CredentialRecognitionIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CredentialRecognitionIntlResponse
        /// </returns>
        public CredentialRecognitionIntlResponse CredentialRecognitionIntlWithOptions(CredentialRecognitionIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FraudCheck))
            {
                query["FraudCheck"] = request.FraudCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OcrArea))
            {
                query["OcrArea"] = request.OcrArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialOcrPictureBase64))
            {
                body["CredentialOcrPictureBase64"] = request.CredentialOcrPictureBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialOcrPictureUrl))
            {
                body["CredentialOcrPictureUrl"] = request.CredentialOcrPictureUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CredentialRecognitionIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CredentialRecognitionIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential Recognition</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Detects whether a voucher (such as water, electricity, gas, credit card, etc., e-bills) is forged using AI technology and extracts key information from the voucher.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CredentialRecognitionIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CredentialRecognitionIntlResponse
        /// </returns>
        public async Task<CredentialRecognitionIntlResponse> CredentialRecognitionIntlWithOptionsAsync(CredentialRecognitionIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FraudCheck))
            {
                query["FraudCheck"] = request.FraudCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OcrArea))
            {
                query["OcrArea"] = request.OcrArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialOcrPictureBase64))
            {
                body["CredentialOcrPictureBase64"] = request.CredentialOcrPictureBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialOcrPictureUrl))
            {
                body["CredentialOcrPictureUrl"] = request.CredentialOcrPictureUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CredentialRecognitionIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CredentialRecognitionIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential Recognition</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Detects whether a voucher (such as water, electricity, gas, credit card, etc., e-bills) is forged using AI technology and extracts key information from the voucher.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CredentialRecognitionIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// CredentialRecognitionIntlResponse
        /// </returns>
        public CredentialRecognitionIntlResponse CredentialRecognitionIntl(CredentialRecognitionIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CredentialRecognitionIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential Recognition</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Detects whether a voucher (such as water, electricity, gas, credit card, etc., e-bills) is forged using AI technology and extracts key information from the voucher.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CredentialRecognitionIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// CredentialRecognitionIntlResponse
        /// </returns>
        public async Task<CredentialRecognitionIntlResponse> CredentialRecognitionIntlAsync(CredentialRecognitionIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CredentialRecognitionIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>凭证识别提交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CredentialSubmitIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CredentialSubmitIntlResponse
        /// </returns>
        public CredentialSubmitIntlResponse CredentialSubmitIntlWithOptions(CredentialSubmitIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FraudCheck))
            {
                query["FraudCheck"] = request.FraudCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OcrArea))
            {
                query["OcrArea"] = request.OcrArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialOcrPictureBase64))
            {
                body["CredentialOcrPictureBase64"] = request.CredentialOcrPictureBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialOcrPictureUrl))
            {
                body["CredentialOcrPictureUrl"] = request.CredentialOcrPictureUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CredentialSubmitIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CredentialSubmitIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>凭证识别提交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CredentialSubmitIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CredentialSubmitIntlResponse
        /// </returns>
        public async Task<CredentialSubmitIntlResponse> CredentialSubmitIntlWithOptionsAsync(CredentialSubmitIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FraudCheck))
            {
                query["FraudCheck"] = request.FraudCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OcrArea))
            {
                query["OcrArea"] = request.OcrArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialOcrPictureBase64))
            {
                body["CredentialOcrPictureBase64"] = request.CredentialOcrPictureBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialOcrPictureUrl))
            {
                body["CredentialOcrPictureUrl"] = request.CredentialOcrPictureUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CredentialSubmitIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CredentialSubmitIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>凭证识别提交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CredentialSubmitIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// CredentialSubmitIntlResponse
        /// </returns>
        public CredentialSubmitIntlResponse CredentialSubmitIntl(CredentialSubmitIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CredentialSubmitIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>凭证识别提交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CredentialSubmitIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// CredentialSubmitIntlResponse
        /// </returns>
        public async Task<CredentialSubmitIntlResponse> CredentialSubmitIntlAsync(CredentialSubmitIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CredentialSubmitIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input credential image information, perform image quality, tampering, and forgery detection, and return the detection results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CredentialVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CredentialVerifyIntlResponse
        /// </returns>
        public CredentialVerifyIntlResponse CredentialVerifyIntlWithOptions(CredentialVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredName))
            {
                query["CredName"] = request.CredName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredType))
            {
                query["CredType"] = request.CredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFile))
            {
                body["ImageFile"] = request.ImageFile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CredentialVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CredentialVerifyIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input credential image information, perform image quality, tampering, and forgery detection, and return the detection results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CredentialVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CredentialVerifyIntlResponse
        /// </returns>
        public async Task<CredentialVerifyIntlResponse> CredentialVerifyIntlWithOptionsAsync(CredentialVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredName))
            {
                query["CredName"] = request.CredName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredType))
            {
                query["CredType"] = request.CredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFile))
            {
                body["ImageFile"] = request.ImageFile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CredentialVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CredentialVerifyIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input credential image information, perform image quality, tampering, and forgery detection, and return the detection results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CredentialVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// CredentialVerifyIntlResponse
        /// </returns>
        public CredentialVerifyIntlResponse CredentialVerifyIntl(CredentialVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CredentialVerifyIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input credential image information, perform image quality, tampering, and forgery detection, and return the detection results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CredentialVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// CredentialVerifyIntlResponse
        /// </returns>
        public async Task<CredentialVerifyIntlResponse> CredentialVerifyIntlAsync(CredentialVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CredentialVerifyIntlWithOptionsAsync(request, runtime);
        }

        public CredentialVerifyIntlResponse CredentialVerifyIntlAdvance(CredentialVerifyIntlAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            Aliyun.Credentials.Models.CredentialModel credentialModel = null;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_credential))
            {
                throw new TeaException(new Dictionary<string, string>
                {
                    {"code", "InvalidCredentials"},
                    {"message", "Please set up the credentials correctly. If you are setting them through environment variables, please ensure that ALIBABA_CLOUD_ACCESS_KEY_ID and ALIBABA_CLOUD_ACCESS_KEY_SECRET are set correctly. See https://help.aliyun.com/zh/sdk/developer-reference/configure-the-alibaba-cloud-accesskey-environment-variable-on-linux-macos-and-windows-systems for more details."},
                });
            }
            credentialModel = this._credential.GetCredential();
            string accessKeyId = credentialModel.AccessKeyId;
            string accessKeySecret = credentialModel.AccessKeySecret;
            string securityToken = credentialModel.SecurityToken;
            string credentialType = credentialModel.Type;
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OpenApiClient.Client authClient = new AlibabaCloud.OpenApiClient.Client(authConfig);
            Dictionary<string, string> authRequest = new Dictionary<string, string>
            {
                {"Product", "Cloudauth-intl"},
                {"RegionId", _regionId},
            };
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest authReq = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(authRequest),
            };
            AlibabaCloud.OpenApiClient.Models.Params authParams = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeFileUpload",
                Version = "2019-12-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            Dictionary<string, object> authResponse = new Dictionary<string, object>(){};
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            Dictionary<string, object> ossHeader = new Dictionary<string, object>(){};
            Dictionary<string, object> tmpBody = new Dictionary<string, object>(){};
            bool? useAccelerate = false;
            Dictionary<string, string> authResponseBody = new Dictionary<string, string>(){};
            CredentialVerifyIntlRequest credentialVerifyIntlReq = new CredentialVerifyIntlRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, credentialVerifyIntlReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFileObject))
            {
                object tmpResp0 = authClient.CallApi(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageFileObject,
                    ContentType = "",
                };
                ossHeader = new Dictionary<string, object>
                {
                    {"host", "" + authResponseBody.Get("Bucket") + "." + AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponseBody.Get("Endpoint"), useAccelerate, _endpointType)},
                    {"OSSAccessKeyId", authResponseBody.Get("AccessKeyId")},
                    {"policy", authResponseBody.Get("EncodedPolicy")},
                    {"Signature", authResponseBody.Get("Signature")},
                    {"key", authResponseBody.Get("ObjectKey")},
                    {"file", fileObj},
                    {"success_action_status", "201"},
                };
                _postOSSObject(authResponseBody.Get("Bucket"), ossHeader);
                credentialVerifyIntlReq.ImageFile = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            CredentialVerifyIntlResponse credentialVerifyIntlResp = CredentialVerifyIntlWithOptions(credentialVerifyIntlReq, runtime);
            return credentialVerifyIntlResp;
        }

        public async Task<CredentialVerifyIntlResponse> CredentialVerifyIntlAdvanceAsync(CredentialVerifyIntlAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            Aliyun.Credentials.Models.CredentialModel credentialModel = null;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_credential))
            {
                throw new TeaException(new Dictionary<string, string>
                {
                    {"code", "InvalidCredentials"},
                    {"message", "Please set up the credentials correctly. If you are setting them through environment variables, please ensure that ALIBABA_CLOUD_ACCESS_KEY_ID and ALIBABA_CLOUD_ACCESS_KEY_SECRET are set correctly. See https://help.aliyun.com/zh/sdk/developer-reference/configure-the-alibaba-cloud-accesskey-environment-variable-on-linux-macos-and-windows-systems for more details."},
                });
            }
            credentialModel = await this._credential.GetCredentialAsync();
            string accessKeyId = credentialModel.AccessKeyId;
            string accessKeySecret = credentialModel.AccessKeySecret;
            string securityToken = credentialModel.SecurityToken;
            string credentialType = credentialModel.Type;
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OpenApiClient.Client authClient = new AlibabaCloud.OpenApiClient.Client(authConfig);
            Dictionary<string, string> authRequest = new Dictionary<string, string>
            {
                {"Product", "Cloudauth-intl"},
                {"RegionId", _regionId},
            };
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest authReq = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(authRequest),
            };
            AlibabaCloud.OpenApiClient.Models.Params authParams = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeFileUpload",
                Version = "2019-12-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            Dictionary<string, object> authResponse = new Dictionary<string, object>(){};
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            Dictionary<string, object> ossHeader = new Dictionary<string, object>(){};
            Dictionary<string, object> tmpBody = new Dictionary<string, object>(){};
            bool? useAccelerate = false;
            Dictionary<string, string> authResponseBody = new Dictionary<string, string>(){};
            CredentialVerifyIntlRequest credentialVerifyIntlReq = new CredentialVerifyIntlRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, credentialVerifyIntlReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFileObject))
            {
                object tmpResp0 = await authClient.CallApiAsync(authParams, authReq, runtime);
                authResponse = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmpResp0);
                tmpBody = AlibabaCloud.TeaUtil.Common.AssertAsMap(authResponse.Get("body"));
                useAccelerate = AlibabaCloud.TeaUtil.Common.AssertAsBoolean(tmpBody.Get("UseAccelerate"));
                authResponseBody = AlibabaCloud.TeaUtil.Common.StringifyMapValue(tmpBody);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponseBody.Get("ObjectKey"),
                    Content = request.ImageFileObject,
                    ContentType = "",
                };
                ossHeader = new Dictionary<string, object>
                {
                    {"host", "" + authResponseBody.Get("Bucket") + "." + AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponseBody.Get("Endpoint"), useAccelerate, _endpointType)},
                    {"OSSAccessKeyId", authResponseBody.Get("AccessKeyId")},
                    {"policy", authResponseBody.Get("EncodedPolicy")},
                    {"Signature", authResponseBody.Get("Signature")},
                    {"key", authResponseBody.Get("ObjectKey")},
                    {"file", fileObj},
                    {"success_action_status", "201"},
                };
                await _postOSSObjectAsync(authResponseBody.Get("Bucket"), ossHeader);
                credentialVerifyIntlReq.ImageFile = "http://" + authResponseBody.Get("Bucket") + "." + authResponseBody.Get("Endpoint") + "/" + authResponseBody.Get("ObjectKey");
            }
            CredentialVerifyIntlResponse credentialVerifyIntlResp = await CredentialVerifyIntlWithOptionsAsync(credentialVerifyIntlReq, runtime);
            return credentialVerifyIntlResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Face Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input a face image and use the algorithm to detect if there is a risk of deep forgery. This includes risk scenarios such as AIGC-generated faces, deepfake face swapping, template faces, and rephotographed faces, and outputs risk labels and confidence levels.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeepfakeDetectIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeepfakeDetectIntlResponse
        /// </returns>
        public DeepfakeDetectIntlResponse DeepfakeDetectIntlWithOptions(DeepfakeDetectIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceInputType))
            {
                query["FaceInputType"] = request.FaceInputType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceUrl))
            {
                query["FaceUrl"] = request.FaceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceBase64))
            {
                body["FaceBase64"] = request.FaceBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeepfakeDetectIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeepfakeDetectIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Face Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input a face image and use the algorithm to detect if there is a risk of deep forgery. This includes risk scenarios such as AIGC-generated faces, deepfake face swapping, template faces, and rephotographed faces, and outputs risk labels and confidence levels.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeepfakeDetectIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeepfakeDetectIntlResponse
        /// </returns>
        public async Task<DeepfakeDetectIntlResponse> DeepfakeDetectIntlWithOptionsAsync(DeepfakeDetectIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceInputType))
            {
                query["FaceInputType"] = request.FaceInputType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceUrl))
            {
                query["FaceUrl"] = request.FaceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceBase64))
            {
                body["FaceBase64"] = request.FaceBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeepfakeDetectIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeepfakeDetectIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Face Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input a face image and use the algorithm to detect if there is a risk of deep forgery. This includes risk scenarios such as AIGC-generated faces, deepfake face swapping, template faces, and rephotographed faces, and outputs risk labels and confidence levels.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeepfakeDetectIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// DeepfakeDetectIntlResponse
        /// </returns>
        public DeepfakeDetectIntlResponse DeepfakeDetectIntl(DeepfakeDetectIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeepfakeDetectIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Face Credential Verification</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Input a face image and use the algorithm to detect if there is a risk of deep forgery. This includes risk scenarios such as AIGC-generated faces, deepfake face swapping, template faces, and rephotographed faces, and outputs risk labels and confidence levels.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeepfakeDetectIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// DeepfakeDetectIntlResponse
        /// </returns>
        public async Task<DeepfakeDetectIntlResponse> DeepfakeDetectIntlAsync(DeepfakeDetectIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeepfakeDetectIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Face Group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFaceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFaceGroupResponse
        /// </returns>
        public DeleteFaceGroupResponse DeleteFaceGroupWithOptions(DeleteFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFaceGroup",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Face Group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFaceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFaceGroupResponse
        /// </returns>
        public async Task<DeleteFaceGroupResponse> DeleteFaceGroupWithOptionsAsync(DeleteFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFaceGroup",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Face Group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFaceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFaceGroupResponse
        /// </returns>
        public DeleteFaceGroupResponse DeleteFaceGroup(DeleteFaceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFaceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Face Group</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFaceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFaceGroupResponse
        /// </returns>
        public async Task<DeleteFaceGroupResponse> DeleteFaceGroupAsync(DeleteFaceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFaceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Face</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFaceRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFaceRecordResponse
        /// </returns>
        public DeleteFaceRecordResponse DeleteFaceRecordWithOptions(DeleteFaceRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFaceRecord",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Face</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFaceRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFaceRecordResponse
        /// </returns>
        public async Task<DeleteFaceRecordResponse> DeleteFaceRecordWithOptionsAsync(DeleteFaceRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFaceRecord",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Face</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFaceRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFaceRecordResponse
        /// </returns>
        public DeleteFaceRecordResponse DeleteFaceRecord(DeleteFaceRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFaceRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Face</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFaceRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFaceRecordResponse
        /// </returns>
        public async Task<DeleteFaceRecordResponse> DeleteFaceRecordAsync(DeleteFaceRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFaceRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete user authentication record results</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVerifyResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVerifyResultResponse
        /// </returns>
        public DeleteVerifyResultResponse DeleteVerifyResultWithOptions(DeleteVerifyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAfterQuery))
            {
                query["DeleteAfterQuery"] = request.DeleteAfterQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteType))
            {
                query["DeleteType"] = request.DeleteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                query["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVerifyResult",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVerifyResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete user authentication record results</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVerifyResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVerifyResultResponse
        /// </returns>
        public async Task<DeleteVerifyResultResponse> DeleteVerifyResultWithOptionsAsync(DeleteVerifyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAfterQuery))
            {
                query["DeleteAfterQuery"] = request.DeleteAfterQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteType))
            {
                query["DeleteType"] = request.DeleteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                query["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVerifyResult",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVerifyResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete user authentication record results</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVerifyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVerifyResultResponse
        /// </returns>
        public DeleteVerifyResultResponse DeleteVerifyResult(DeleteVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVerifyResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete user authentication record results</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVerifyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVerifyResultResponse
        /// </returns>
        public async Task<DeleteVerifyResultResponse> DeleteVerifyResultAsync(DeleteVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVerifyResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Card and document OCR pure server-side</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocOcrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocOcrResponse
        /// </returns>
        public DocOcrResponse DocOcrWithOptions(DocOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardSide))
            {
                query["CardSide"] = request.CardSide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdFaceQuality))
            {
                query["IdFaceQuality"] = request.IdFaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureUrl))
            {
                query["IdOcrPictureUrl"] = request.IdOcrPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdThreshold))
            {
                query["IdThreshold"] = request.IdThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                query["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spoof))
            {
                query["Spoof"] = request.Spoof;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureBase64))
            {
                body["IdOcrPictureBase64"] = request.IdOcrPictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocOcr",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocOcrResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Card and document OCR pure server-side</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocOcrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocOcrResponse
        /// </returns>
        public async Task<DocOcrResponse> DocOcrWithOptionsAsync(DocOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardSide))
            {
                query["CardSide"] = request.CardSide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdFaceQuality))
            {
                query["IdFaceQuality"] = request.IdFaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureUrl))
            {
                query["IdOcrPictureUrl"] = request.IdOcrPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdThreshold))
            {
                query["IdThreshold"] = request.IdThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                query["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spoof))
            {
                query["Spoof"] = request.Spoof;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureBase64))
            {
                body["IdOcrPictureBase64"] = request.IdOcrPictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocOcr",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocOcrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Card and document OCR pure server-side</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// DocOcrResponse
        /// </returns>
        public DocOcrResponse DocOcr(DocOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DocOcrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Card and document OCR pure server-side</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// DocOcrResponse
        /// </returns>
        public async Task<DocOcrResponse> DocOcrAsync(DocOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DocOcrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Global Document OCR Recognition Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocOcrMaxRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocOcrMaxResponse
        /// </returns>
        public DocOcrMaxResponse DocOcrMaxWithOptions(DocOcrMaxRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocPage))
            {
                body["DocPage"] = request.DocPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureBase64))
            {
                body["IdOcrPictureBase64"] = request.IdOcrPictureBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureUrl))
            {
                body["IdOcrPictureUrl"] = request.IdOcrPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdSpoof))
            {
                body["IdSpoof"] = request.IdSpoof;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdThreshold))
            {
                body["IdThreshold"] = request.IdThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                body["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                body["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OcrModel))
            {
                body["OcrModel"] = request.OcrModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                body["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spoof))
            {
                body["Spoof"] = request.Spoof;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocOcrMax",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocOcrMaxResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Global Document OCR Recognition Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocOcrMaxRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocOcrMaxResponse
        /// </returns>
        public async Task<DocOcrMaxResponse> DocOcrMaxWithOptionsAsync(DocOcrMaxRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocPage))
            {
                body["DocPage"] = request.DocPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureBase64))
            {
                body["IdOcrPictureBase64"] = request.IdOcrPictureBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureUrl))
            {
                body["IdOcrPictureUrl"] = request.IdOcrPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdSpoof))
            {
                body["IdSpoof"] = request.IdSpoof;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdThreshold))
            {
                body["IdThreshold"] = request.IdThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                body["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                body["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OcrModel))
            {
                body["OcrModel"] = request.OcrModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                body["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spoof))
            {
                body["Spoof"] = request.Spoof;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocOcrMax",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocOcrMaxResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Global Document OCR Recognition Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocOcrMaxRequest
        /// </param>
        /// 
        /// <returns>
        /// DocOcrMaxResponse
        /// </returns>
        public DocOcrMaxResponse DocOcrMax(DocOcrMaxRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DocOcrMaxWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Global Document OCR Recognition Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocOcrMaxRequest
        /// </param>
        /// 
        /// <returns>
        /// DocOcrMaxResponse
        /// </returns>
        public async Task<DocOcrMaxResponse> DocOcrMaxAsync(DocOcrMaxRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DocOcrMaxWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to integrate with ID Verification using only the server-side API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EkycVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EkycVerifyResponse
        /// </returns>
        public EkycVerifyResponse EkycVerifyWithOptions(EkycVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorize))
            {
                query["Authorize"] = request.Authorize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                query["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                query["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocNo))
            {
                query["DocNo"] = request.DocNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                query["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureUrl))
            {
                query["IdOcrPictureUrl"] = request.IdOcrPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdThreshold))
            {
                query["IdThreshold"] = request.IdThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureBase64))
            {
                body["FacePictureBase64"] = request.FacePictureBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureBase64))
            {
                body["IdOcrPictureBase64"] = request.IdOcrPictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EkycVerify",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EkycVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to integrate with ID Verification using only the server-side API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EkycVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EkycVerifyResponse
        /// </returns>
        public async Task<EkycVerifyResponse> EkycVerifyWithOptionsAsync(EkycVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorize))
            {
                query["Authorize"] = request.Authorize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                query["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                query["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocNo))
            {
                query["DocNo"] = request.DocNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                query["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureUrl))
            {
                query["IdOcrPictureUrl"] = request.IdOcrPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdThreshold))
            {
                query["IdThreshold"] = request.IdThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureBase64))
            {
                body["FacePictureBase64"] = request.FacePictureBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdOcrPictureBase64))
            {
                body["IdOcrPictureBase64"] = request.IdOcrPictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EkycVerify",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EkycVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to integrate with ID Verification using only the server-side API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EkycVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// EkycVerifyResponse
        /// </returns>
        public EkycVerifyResponse EkycVerify(EkycVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EkycVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to integrate with ID Verification using only the server-side API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EkycVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// EkycVerifyResponse
        /// </returns>
        public async Task<EkycVerifyResponse> EkycVerifyAsync(EkycVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EkycVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to integrate FaceCompare using only the server-side API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceCompareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceCompareResponse
        /// </returns>
        public FaceCompareResponse FaceCompareWithOptions(FaceCompareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureQualityCheck))
            {
                query["FacePictureQualityCheck"] = request.FacePictureQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFacePictureUrl))
            {
                query["SourceFacePictureUrl"] = request.SourceFacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePictureUrl))
            {
                query["TargetFacePictureUrl"] = request.TargetFacePictureUrl;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFacePicture))
            {
                body["SourceFacePicture"] = request.SourceFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePicture))
            {
                body["TargetFacePicture"] = request.TargetFacePicture;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceCompare",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceCompareResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to integrate FaceCompare using only the server-side API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceCompareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceCompareResponse
        /// </returns>
        public async Task<FaceCompareResponse> FaceCompareWithOptionsAsync(FaceCompareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureQualityCheck))
            {
                query["FacePictureQualityCheck"] = request.FacePictureQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFacePictureUrl))
            {
                query["SourceFacePictureUrl"] = request.SourceFacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePictureUrl))
            {
                query["TargetFacePictureUrl"] = request.TargetFacePictureUrl;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFacePicture))
            {
                body["SourceFacePicture"] = request.SourceFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePicture))
            {
                body["TargetFacePicture"] = request.TargetFacePicture;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceCompare",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceCompareResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to integrate FaceCompare using only the server-side API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceCompareRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceCompareResponse
        /// </returns>
        public FaceCompareResponse FaceCompare(FaceCompareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FaceCompareWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to integrate FaceCompare using only the server-side API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceCompareRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceCompareResponse
        /// </returns>
        public async Task<FaceCompareResponse> FaceCompareAsync(FaceCompareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FaceCompareWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人脸交叉比对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceCrossCompareIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceCrossCompareIntlResponse
        /// </returns>
        public FaceCrossCompareIntlResponse FaceCrossCompareIntlWithOptions(FaceCrossCompareIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompareModel))
            {
                query["CompareModel"] = request.CompareModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceVerifyThreshold))
            {
                query["FaceVerifyThreshold"] = request.FaceVerifyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceAFacePicture))
            {
                query["SourceAFacePicture"] = request.SourceAFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceAFacePictureUrl))
            {
                query["SourceAFacePictureUrl"] = request.SourceAFacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceBFacePicture))
            {
                query["SourceBFacePicture"] = request.SourceBFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceBFacePictureUrl))
            {
                query["SourceBFacePictureUrl"] = request.SourceBFacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCFacePicture))
            {
                query["SourceCFacePicture"] = request.SourceCFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCFacePictureUrl))
            {
                query["SourceCFacePictureUrl"] = request.SourceCFacePictureUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceCrossCompareIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceCrossCompareIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人脸交叉比对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceCrossCompareIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceCrossCompareIntlResponse
        /// </returns>
        public async Task<FaceCrossCompareIntlResponse> FaceCrossCompareIntlWithOptionsAsync(FaceCrossCompareIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompareModel))
            {
                query["CompareModel"] = request.CompareModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceVerifyThreshold))
            {
                query["FaceVerifyThreshold"] = request.FaceVerifyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceAFacePicture))
            {
                query["SourceAFacePicture"] = request.SourceAFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceAFacePictureUrl))
            {
                query["SourceAFacePictureUrl"] = request.SourceAFacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceBFacePicture))
            {
                query["SourceBFacePicture"] = request.SourceBFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceBFacePictureUrl))
            {
                query["SourceBFacePictureUrl"] = request.SourceBFacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCFacePicture))
            {
                query["SourceCFacePicture"] = request.SourceCFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCFacePictureUrl))
            {
                query["SourceCFacePictureUrl"] = request.SourceCFacePictureUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceCrossCompareIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceCrossCompareIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人脸交叉比对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceCrossCompareIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceCrossCompareIntlResponse
        /// </returns>
        public FaceCrossCompareIntlResponse FaceCrossCompareIntl(FaceCrossCompareIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FaceCrossCompareIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人脸交叉比对</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceCrossCompareIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceCrossCompareIntlResponse
        /// </returns>
        public async Task<FaceCrossCompareIntlResponse> FaceCrossCompareIntlAsync(FaceCrossCompareIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FaceCrossCompareIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Face Duplication Detection API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceDuplicationCheckIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceDuplicationCheckIntlResponse
        /// </returns>
        public FaceDuplicationCheckIntlResponse FaceDuplicationCheckIntlWithOptions(FaceDuplicationCheckIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRegistration))
            {
                body["AutoRegistration"] = request.AutoRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceGroupCodes))
            {
                body["FaceGroupCodes"] = request.FaceGroupCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceRegisterGroupCode))
            {
                body["FaceRegisterGroupCode"] = request.FaceRegisterGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceVerifyThreshold))
            {
                body["FaceVerifyThreshold"] = request.FaceVerifyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                body["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                body["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                body["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFaces))
            {
                body["ReturnFaces"] = request.ReturnFaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveFacePicture))
            {
                body["SaveFacePicture"] = request.SaveFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                body["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFacePicture))
            {
                body["SourceFacePicture"] = request.SourceFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFacePictureUrl))
            {
                body["SourceFacePictureUrl"] = request.SourceFacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePicture))
            {
                body["TargetFacePicture"] = request.TargetFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePictureUrl))
            {
                body["TargetFacePictureUrl"] = request.TargetFacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyModel))
            {
                body["VerifyModel"] = request.VerifyModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceDuplicationCheckIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceDuplicationCheckIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Face Duplication Detection API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceDuplicationCheckIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceDuplicationCheckIntlResponse
        /// </returns>
        public async Task<FaceDuplicationCheckIntlResponse> FaceDuplicationCheckIntlWithOptionsAsync(FaceDuplicationCheckIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRegistration))
            {
                body["AutoRegistration"] = request.AutoRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceGroupCodes))
            {
                body["FaceGroupCodes"] = request.FaceGroupCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceRegisterGroupCode))
            {
                body["FaceRegisterGroupCode"] = request.FaceRegisterGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceVerifyThreshold))
            {
                body["FaceVerifyThreshold"] = request.FaceVerifyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                body["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                body["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                body["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFaces))
            {
                body["ReturnFaces"] = request.ReturnFaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveFacePicture))
            {
                body["SaveFacePicture"] = request.SaveFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                body["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFacePicture))
            {
                body["SourceFacePicture"] = request.SourceFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFacePictureUrl))
            {
                body["SourceFacePictureUrl"] = request.SourceFacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePicture))
            {
                body["TargetFacePicture"] = request.TargetFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePictureUrl))
            {
                body["TargetFacePictureUrl"] = request.TargetFacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyModel))
            {
                body["VerifyModel"] = request.VerifyModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceDuplicationCheckIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceDuplicationCheckIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Face Duplication Detection API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceDuplicationCheckIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceDuplicationCheckIntlResponse
        /// </returns>
        public FaceDuplicationCheckIntlResponse FaceDuplicationCheckIntl(FaceDuplicationCheckIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FaceDuplicationCheckIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Face Duplication Detection API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceDuplicationCheckIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceDuplicationCheckIntlResponse
        /// </returns>
        public async Task<FaceDuplicationCheckIntlResponse> FaceDuplicationCheckIntlAsync(FaceDuplicationCheckIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FaceDuplicationCheckIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to set up the server for FACE_GUARD.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceGuardRiskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceGuardRiskResponse
        /// </returns>
        public FaceGuardRiskResponse FaceGuardRiskWithOptions(FaceGuardRiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceToken))
            {
                query["DeviceToken"] = request.DeviceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceGuardRisk",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceGuardRiskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to set up the server for FACE_GUARD.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceGuardRiskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceGuardRiskResponse
        /// </returns>
        public async Task<FaceGuardRiskResponse> FaceGuardRiskWithOptionsAsync(FaceGuardRiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceToken))
            {
                query["DeviceToken"] = request.DeviceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceGuardRisk",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceGuardRiskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to set up the server for FACE_GUARD.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceGuardRiskRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceGuardRiskResponse
        /// </returns>
        public FaceGuardRiskResponse FaceGuardRisk(FaceGuardRiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FaceGuardRiskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to set up the server for FACE_GUARD.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceGuardRiskRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceGuardRiskResponse
        /// </returns>
        public async Task<FaceGuardRiskResponse> FaceGuardRiskAsync(FaceGuardRiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FaceGuardRiskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Passive liveness detection (FaceLiveness) is a service that detects whether a pre-captured facial image, submitted to an API operation, is a real face. The algorithm primarily detects presentation attacks, such as screen replays and printed photos. This service is suitable for low-risk business scen</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceLivenessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceLivenessResponse
        /// </returns>
        public FaceLivenessResponse FaceLivenessWithOptions(FaceLivenessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                query["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                query["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceQuality))
            {
                query["FaceQuality"] = request.FaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Occlusion))
            {
                query["Occlusion"] = request.Occlusion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureBase64))
            {
                body["FacePictureBase64"] = request.FacePictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceLiveness",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceLivenessResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Passive liveness detection (FaceLiveness) is a service that detects whether a pre-captured facial image, submitted to an API operation, is a real face. The algorithm primarily detects presentation attacks, such as screen replays and printed photos. This service is suitable for low-risk business scen</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceLivenessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FaceLivenessResponse
        /// </returns>
        public async Task<FaceLivenessResponse> FaceLivenessWithOptionsAsync(FaceLivenessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                query["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                query["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceQuality))
            {
                query["FaceQuality"] = request.FaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Occlusion))
            {
                query["Occlusion"] = request.Occlusion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureBase64))
            {
                body["FacePictureBase64"] = request.FacePictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FaceLiveness",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FaceLivenessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Passive liveness detection (FaceLiveness) is a service that detects whether a pre-captured facial image, submitted to an API operation, is a real face. The algorithm primarily detects presentation attacks, such as screen replays and printed photos. This service is suitable for low-risk business scen</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceLivenessRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceLivenessResponse
        /// </returns>
        public FaceLivenessResponse FaceLiveness(FaceLivenessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FaceLivenessWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Passive liveness detection (FaceLiveness) is a service that detects whether a pre-captured facial image, submitted to an API operation, is a real face. The algorithm primarily detects presentation attacks, such as screen replays and printed photos. This service is suitable for low-risk business scen</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FaceLivenessRequest
        /// </param>
        /// 
        /// <returns>
        /// FaceLivenessResponse
        /// </returns>
        public async Task<FaceLivenessResponse> FaceLivenessAsync(FaceLivenessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FaceLivenessWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Anti-Fraud Callback Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FraudResultCallBackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FraudResultCallBackResponse
        /// </returns>
        public FraudResultCallBackResponse FraudResultCallBackWithOptions(FraudResultCallBackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParams))
            {
                query["ExtParams"] = request.ExtParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultCode))
            {
                query["ResultCode"] = request.ResultCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyDeployEnv))
            {
                query["VerifyDeployEnv"] = request.VerifyDeployEnv;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FraudResultCallBack",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FraudResultCallBackResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Anti-Fraud Callback Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FraudResultCallBackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FraudResultCallBackResponse
        /// </returns>
        public async Task<FraudResultCallBackResponse> FraudResultCallBackWithOptionsAsync(FraudResultCallBackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertifyId))
            {
                query["CertifyId"] = request.CertifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParams))
            {
                query["ExtParams"] = request.ExtParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultCode))
            {
                query["ResultCode"] = request.ResultCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyDeployEnv))
            {
                query["VerifyDeployEnv"] = request.VerifyDeployEnv;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FraudResultCallBack",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FraudResultCallBackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Anti-Fraud Callback Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FraudResultCallBackRequest
        /// </param>
        /// 
        /// <returns>
        /// FraudResultCallBackResponse
        /// </returns>
        public FraudResultCallBackResponse FraudResultCallBack(FraudResultCallBackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FraudResultCallBackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Anti-Fraud Callback Interface</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FraudResultCallBackRequest
        /// </param>
        /// 
        /// <returns>
        /// FraudResultCallBackResponse
        /// </returns>
        public async Task<FraudResultCallBackResponse> FraudResultCallBackAsync(FraudResultCallBackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FraudResultCallBackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation verifies the authenticity and consistency of a name, ID card number, and the start and end dates of the ID card\&quot;s validity period against an authoritative source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaPeriodVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaPeriodVerifyIntlResponse
        /// </returns>
        public Id2MetaPeriodVerifyIntlResponse Id2MetaPeriodVerifyIntlWithOptions(Id2MetaPeriodVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                body["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocNo))
            {
                body["DocNo"] = request.DocNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                body["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                body["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                body["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityEndDate))
            {
                body["ValidityEndDate"] = request.ValidityEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityStartDate))
            {
                body["ValidityStartDate"] = request.ValidityStartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id2MetaPeriodVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id2MetaPeriodVerifyIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation verifies the authenticity and consistency of a name, ID card number, and the start and end dates of the ID card\&quot;s validity period against an authoritative source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaPeriodVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaPeriodVerifyIntlResponse
        /// </returns>
        public async Task<Id2MetaPeriodVerifyIntlResponse> Id2MetaPeriodVerifyIntlWithOptionsAsync(Id2MetaPeriodVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                body["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocNo))
            {
                body["DocNo"] = request.DocNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                body["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                body["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                body["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityEndDate))
            {
                body["ValidityEndDate"] = request.ValidityEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityStartDate))
            {
                body["ValidityStartDate"] = request.ValidityStartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id2MetaPeriodVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id2MetaPeriodVerifyIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation verifies the authenticity and consistency of a name, ID card number, and the start and end dates of the ID card\&quot;s validity period against an authoritative source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaPeriodVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaPeriodVerifyIntlResponse
        /// </returns>
        public Id2MetaPeriodVerifyIntlResponse Id2MetaPeriodVerifyIntl(Id2MetaPeriodVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Id2MetaPeriodVerifyIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation verifies the authenticity and consistency of a name, ID card number, and the start and end dates of the ID card\&quot;s validity period against an authoritative source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaPeriodVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaPeriodVerifyIntlResponse
        /// </returns>
        public async Task<Id2MetaPeriodVerifyIntlResponse> Id2MetaPeriodVerifyIntlAsync(Id2MetaPeriodVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Id2MetaPeriodVerifyIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies that a name and an ID card number are consistent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyIntlResponse
        /// </returns>
        public Id2MetaVerifyIntlResponse Id2MetaVerifyIntlWithOptions(Id2MetaVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id2MetaVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id2MetaVerifyIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies that a name and an ID card number are consistent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyIntlResponse
        /// </returns>
        public async Task<Id2MetaVerifyIntlResponse> Id2MetaVerifyIntlWithOptionsAsync(Id2MetaVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Id2MetaVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Id2MetaVerifyIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies that a name and an ID card number are consistent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyIntlResponse
        /// </returns>
        public Id2MetaVerifyIntlResponse Id2MetaVerifyIntl(Id2MetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Id2MetaVerifyIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies that a name and an ID card number are consistent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Id2MetaVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// Id2MetaVerifyIntlResponse
        /// </returns>
        public async Task<Id2MetaVerifyIntlResponse> Id2MetaVerifyIntlAsync(Id2MetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Id2MetaVerifyIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authentication Initialization</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InitializeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitializeResponse
        /// </returns>
        public InitializeResponse InitializeWithOptions(InitializeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InitializeShrinkRequest request = new InitializeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocPageConfig))
            {
                request.DocPageConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocPageConfig, "DocPageConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppQualityCheck))
            {
                query["AppQualityCheck"] = request.AppQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorize))
            {
                query["Authorize"] = request.Authorize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRegistration))
            {
                query["AutoRegistration"] = request.AutoRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackToken))
            {
                query["CallbackToken"] = request.CallbackToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChameleonFrameEnable))
            {
                query["ChameleonFrameEnable"] = request.ChameleonFrameEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                query["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateOfBirth))
            {
                query["DateOfBirth"] = request.DateOfBirth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateOfExpiry))
            {
                query["DateOfExpiry"] = request.DateOfExpiry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                query["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocNo))
            {
                query["DocNo"] = request.DocNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocPageConfigShrink))
            {
                query["DocPageConfig"] = request.DocPageConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocScanMode))
            {
                query["DocScanMode"] = request.DocScanMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocVideo))
            {
                query["DocVideo"] = request.DocVideo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentNumber))
            {
                query["DocumentNumber"] = request.DocumentNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditOcrResult))
            {
                query["EditOcrResult"] = request.EditOcrResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperienceCode))
            {
                query["ExperienceCode"] = request.ExperienceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceGroupCodes))
            {
                query["FaceGroupCodes"] = request.FaceGroupCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                query["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceRegisterGroupCode))
            {
                query["FaceRegisterGroupCode"] = request.FaceRegisterGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceVerifyThreshold))
            {
                query["FaceVerifyThreshold"] = request.FaceVerifyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdFaceQuality))
            {
                query["IdFaceQuality"] = request.IdFaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdSpoof))
            {
                query["IdSpoof"] = request.IdSpoof;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdThreshold))
            {
                query["IdThreshold"] = request.IdThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageConfig))
            {
                query["LanguageConfig"] = request.LanguageConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MRTDInput))
            {
                query["MRTDInput"] = request.MRTDInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaInfo))
            {
                query["MetaInfo"] = request.MetaInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                query["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pages))
            {
                query["Pages"] = request.Pages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcedurePriority))
            {
                query["ProcedurePriority"] = request.ProcedurePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductFlow))
            {
                query["ProductFlow"] = request.ProductFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFaces))
            {
                query["ReturnFaces"] = request.ReturnFaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnUrl))
            {
                query["ReturnUrl"] = request.ReturnUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveFacePicture))
            {
                query["SaveFacePicture"] = request.SaveFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityLevel))
            {
                query["SecurityLevel"] = request.SecurityLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowAlbumIcon))
            {
                query["ShowAlbumIcon"] = request.ShowAlbumIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowGuidePage))
            {
                query["ShowGuidePage"] = request.ShowGuidePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowOcrResult))
            {
                query["ShowOcrResult"] = request.ShowOcrResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleConfig))
            {
                query["StyleConfig"] = request.StyleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePicture))
            {
                query["TargetFacePicture"] = request.TargetFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePictureUrl))
            {
                query["TargetFacePictureUrl"] = request.TargetFacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseNFC))
            {
                query["UseNFC"] = request.UseNFC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyModel))
            {
                query["VerifyModel"] = request.VerifyModel;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureBase64))
            {
                body["FacePictureBase64"] = request.FacePictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Initialize",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitializeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authentication Initialization</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InitializeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitializeResponse
        /// </returns>
        public async Task<InitializeResponse> InitializeWithOptionsAsync(InitializeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InitializeShrinkRequest request = new InitializeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocPageConfig))
            {
                request.DocPageConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocPageConfig, "DocPageConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppQualityCheck))
            {
                query["AppQualityCheck"] = request.AppQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorize))
            {
                query["Authorize"] = request.Authorize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRegistration))
            {
                query["AutoRegistration"] = request.AutoRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackToken))
            {
                query["CallbackToken"] = request.CallbackToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChameleonFrameEnable))
            {
                query["ChameleonFrameEnable"] = request.ChameleonFrameEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Crop))
            {
                query["Crop"] = request.Crop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateOfBirth))
            {
                query["DateOfBirth"] = request.DateOfBirth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateOfExpiry))
            {
                query["DateOfExpiry"] = request.DateOfExpiry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                query["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocNo))
            {
                query["DocNo"] = request.DocNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocPageConfigShrink))
            {
                query["DocPageConfig"] = request.DocPageConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocScanMode))
            {
                query["DocScanMode"] = request.DocScanMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                query["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocVideo))
            {
                query["DocVideo"] = request.DocVideo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentNumber))
            {
                query["DocumentNumber"] = request.DocumentNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditOcrResult))
            {
                query["EditOcrResult"] = request.EditOcrResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperienceCode))
            {
                query["ExperienceCode"] = request.ExperienceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceGroupCodes))
            {
                query["FaceGroupCodes"] = request.FaceGroupCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureUrl))
            {
                query["FacePictureUrl"] = request.FacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceRegisterGroupCode))
            {
                query["FaceRegisterGroupCode"] = request.FaceRegisterGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceVerifyThreshold))
            {
                query["FaceVerifyThreshold"] = request.FaceVerifyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdFaceQuality))
            {
                query["IdFaceQuality"] = request.IdFaceQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdSpoof))
            {
                query["IdSpoof"] = request.IdSpoof;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdThreshold))
            {
                query["IdThreshold"] = request.IdThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageConfig))
            {
                query["LanguageConfig"] = request.LanguageConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MRTDInput))
            {
                query["MRTDInput"] = request.MRTDInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantBizId))
            {
                query["MerchantBizId"] = request.MerchantBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaInfo))
            {
                query["MetaInfo"] = request.MetaInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ocr))
            {
                query["Ocr"] = request.Ocr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pages))
            {
                query["Pages"] = request.Pages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcedurePriority))
            {
                query["ProcedurePriority"] = request.ProcedurePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductFlow))
            {
                query["ProductFlow"] = request.ProductFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFaces))
            {
                query["ReturnFaces"] = request.ReturnFaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnUrl))
            {
                query["ReturnUrl"] = request.ReturnUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveFacePicture))
            {
                query["SaveFacePicture"] = request.SaveFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["SceneCode"] = request.SceneCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityLevel))
            {
                query["SecurityLevel"] = request.SecurityLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowAlbumIcon))
            {
                query["ShowAlbumIcon"] = request.ShowAlbumIcon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowGuidePage))
            {
                query["ShowGuidePage"] = request.ShowGuidePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowOcrResult))
            {
                query["ShowOcrResult"] = request.ShowOcrResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleConfig))
            {
                query["StyleConfig"] = request.StyleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePicture))
            {
                query["TargetFacePicture"] = request.TargetFacePicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFacePictureUrl))
            {
                query["TargetFacePictureUrl"] = request.TargetFacePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseNFC))
            {
                query["UseNFC"] = request.UseNFC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyModel))
            {
                query["VerifyModel"] = request.VerifyModel;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePictureBase64))
            {
                body["FacePictureBase64"] = request.FacePictureBase64;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Initialize",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitializeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authentication Initialization</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitializeRequest
        /// </param>
        /// 
        /// <returns>
        /// InitializeResponse
        /// </returns>
        public InitializeResponse Initialize(InitializeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitializeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authentication Initialization</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitializeRequest
        /// </param>
        /// 
        /// <returns>
        /// InitializeResponse
        /// </returns>
        public async Task<InitializeResponse> InitializeAsync(InitializeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitializeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If your server makes infrequent calls to the ID Verification API, you can call the KeepaliveIntl operation to maintain the client connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KeepaliveIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KeepaliveIntlResponse
        /// </returns>
        public KeepaliveIntlResponse KeepaliveIntlWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KeepaliveIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KeepaliveIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If your server makes infrequent calls to the ID Verification API, you can call the KeepaliveIntl operation to maintain the client connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KeepaliveIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KeepaliveIntlResponse
        /// </returns>
        public async Task<KeepaliveIntlResponse> KeepaliveIntlWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KeepaliveIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KeepaliveIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If your server makes infrequent calls to the ID Verification API, you can call the KeepaliveIntl operation to maintain the client connection.</para>
        /// </summary>
        /// 
        /// <returns>
        /// KeepaliveIntlResponse
        /// </returns>
        public KeepaliveIntlResponse KeepaliveIntl()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KeepaliveIntlWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If your server makes infrequent calls to the ID Verification API, you can call the KeepaliveIntl operation to maintain the client connection.</para>
        /// </summary>
        /// 
        /// <returns>
        /// KeepaliveIntlResponse
        /// </returns>
        public async Task<KeepaliveIntlResponse> KeepaliveIntlAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KeepaliveIntlWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the authenticity and consistency of a mobile number and name against an authoritative data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Mobile2MetaVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile2MetaVerifyIntlResponse
        /// </returns>
        public Mobile2MetaVerifyIntlResponse Mobile2MetaVerifyIntlWithOptions(Mobile2MetaVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile2MetaVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile2MetaVerifyIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the authenticity and consistency of a mobile number and name against an authoritative data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Mobile2MetaVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile2MetaVerifyIntlResponse
        /// </returns>
        public async Task<Mobile2MetaVerifyIntlResponse> Mobile2MetaVerifyIntlWithOptionsAsync(Mobile2MetaVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile2MetaVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile2MetaVerifyIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the authenticity and consistency of a mobile number and name against an authoritative data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Mobile2MetaVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile2MetaVerifyIntlResponse
        /// </returns>
        public Mobile2MetaVerifyIntlResponse Mobile2MetaVerifyIntl(Mobile2MetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Mobile2MetaVerifyIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the authenticity and consistency of a mobile number and name against an authoritative data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Mobile2MetaVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile2MetaVerifyIntlResponse
        /// </returns>
        public async Task<Mobile2MetaVerifyIntlResponse> Mobile2MetaVerifyIntlAsync(Mobile2MetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Mobile2MetaVerifyIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>International Version of Mobile Three Elements API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Mobile3MetaVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaVerifyIntlResponse
        /// </returns>
        public Mobile3MetaVerifyIntlResponse Mobile3MetaVerifyIntlWithOptions(Mobile3MetaVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile3MetaVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile3MetaVerifyIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>International Version of Mobile Three Elements API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Mobile3MetaVerifyIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaVerifyIntlResponse
        /// </returns>
        public async Task<Mobile3MetaVerifyIntlResponse> Mobile3MetaVerifyIntlWithOptionsAsync(Mobile3MetaVerifyIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyNum))
            {
                query["IdentifyNum"] = request.IdentifyNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Mobile3MetaVerifyIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<Mobile3MetaVerifyIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>International Version of Mobile Three Elements API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Mobile3MetaVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaVerifyIntlResponse
        /// </returns>
        public Mobile3MetaVerifyIntlResponse Mobile3MetaVerifyIntl(Mobile3MetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Mobile3MetaVerifyIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>International Version of Mobile Three Elements API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Mobile3MetaVerifyIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// Mobile3MetaVerifyIntlResponse
        /// </returns>
        public async Task<Mobile3MetaVerifyIntlResponse> Mobile3MetaVerifyIntlAsync(Mobile3MetaVerifyIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await Mobile3MetaVerifyIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改人脸库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFaceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFaceGroupResponse
        /// </returns>
        public ModifyFaceGroupResponse ModifyFaceGroupWithOptions(ModifyFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFaceGroup",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFaceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改人脸库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFaceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFaceGroupResponse
        /// </returns>
        public async Task<ModifyFaceGroupResponse> ModifyFaceGroupWithOptionsAsync(ModifyFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFaceGroup",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFaceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改人脸库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFaceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFaceGroupResponse
        /// </returns>
        public ModifyFaceGroupResponse ModifyFaceGroup(ModifyFaceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFaceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改人脸库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFaceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFaceGroupResponse
        /// </returns>
        public async Task<ModifyFaceGroupResponse> ModifyFaceGroupAsync(ModifyFaceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFaceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增人脸</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFaceRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFaceRecordResponse
        /// </returns>
        public ModifyFaceRecordResponse ModifyFaceRecordWithOptions(ModifyFaceRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceGroupCode))
            {
                body["FaceGroupCode"] = request.FaceGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImgOssInfos))
            {
                body["ImgOssInfos"] = request.ImgOssInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFaceRecord",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFaceRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增人脸</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFaceRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFaceRecordResponse
        /// </returns>
        public async Task<ModifyFaceRecordResponse> ModifyFaceRecordWithOptionsAsync(ModifyFaceRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceGroupCode))
            {
                body["FaceGroupCode"] = request.FaceGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImgOssInfos))
            {
                body["ImgOssInfos"] = request.ImgOssInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFaceRecord",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFaceRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增人脸</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFaceRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFaceRecordResponse
        /// </returns>
        public ModifyFaceRecordResponse ModifyFaceRecord(ModifyFaceRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFaceRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增人脸</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFaceRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFaceRecordResponse
        /// </returns>
        public async Task<ModifyFaceRecordResponse> ModifyFaceRecordAsync(ModifyFaceRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFaceRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询人脸库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFaceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFaceGroupResponse
        /// </returns>
        public QueryFaceGroupResponse QueryFaceGroupWithOptions(QueryFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCode))
            {
                query["GroupCode"] = request.GroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFaceGroup",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询人脸库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFaceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFaceGroupResponse
        /// </returns>
        public async Task<QueryFaceGroupResponse> QueryFaceGroupWithOptionsAsync(QueryFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCode))
            {
                query["GroupCode"] = request.GroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFaceGroup",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询人脸库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFaceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFaceGroupResponse
        /// </returns>
        public QueryFaceGroupResponse QueryFaceGroup(QueryFaceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFaceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询人脸库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFaceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFaceGroupResponse
        /// </returns>
        public async Task<QueryFaceGroupResponse> QueryFaceGroupAsync(QueryFaceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFaceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询人脸记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFaceRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFaceRecordResponse
        /// </returns>
        public QueryFaceRecordResponse QueryFaceRecordWithOptions(QueryFaceRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceGroupCode))
            {
                query["FaceGroupCode"] = request.FaceGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceId))
            {
                query["FaceId"] = request.FaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationType))
            {
                query["RegistrationType"] = request.RegistrationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFaceRecord",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询人脸记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFaceRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFaceRecordResponse
        /// </returns>
        public async Task<QueryFaceRecordResponse> QueryFaceRecordWithOptionsAsync(QueryFaceRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceGroupCode))
            {
                query["FaceGroupCode"] = request.FaceGroupCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceId))
            {
                query["FaceId"] = request.FaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantUserId))
            {
                query["MerchantUserId"] = request.MerchantUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationType))
            {
                query["RegistrationType"] = request.RegistrationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFaceRecord",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询人脸记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFaceRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFaceRecordResponse
        /// </returns>
        public QueryFaceRecordResponse QueryFaceRecord(QueryFaceRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFaceRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询人脸记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFaceRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFaceRecordResponse
        /// </returns>
        public async Task<QueryFaceRecordResponse> QueryFaceRecordAsync(QueryFaceRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFaceRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取临时token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TempAccessTokenIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TempAccessTokenIntlResponse
        /// </returns>
        public TempAccessTokenIntlResponse TempAccessTokenIntlWithOptions(TempAccessTokenIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TempAccessTokenIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TempAccessTokenIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取临时token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TempAccessTokenIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TempAccessTokenIntlResponse
        /// </returns>
        public async Task<TempAccessTokenIntlResponse> TempAccessTokenIntlWithOptionsAsync(TempAccessTokenIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TempAccessTokenIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TempAccessTokenIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取临时token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TempAccessTokenIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// TempAccessTokenIntlResponse
        /// </returns>
        public TempAccessTokenIntlResponse TempAccessTokenIntl(TempAccessTokenIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TempAccessTokenIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取临时token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TempAccessTokenIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// TempAccessTokenIntlResponse
        /// </returns>
        public async Task<TempAccessTokenIntlResponse> TempAccessTokenIntlAsync(TempAccessTokenIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TempAccessTokenIntlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件临时地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TempOssUrlIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TempOssUrlIntlResponse
        /// </returns>
        public TempOssUrlIntlResponse TempOssUrlIntlWithOptions(TempOssUrlIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                body["ObjectName"] = request.ObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TempOssUrlIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TempOssUrlIntlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件临时地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TempOssUrlIntlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TempOssUrlIntlResponse
        /// </returns>
        public async Task<TempOssUrlIntlResponse> TempOssUrlIntlWithOptionsAsync(TempOssUrlIntlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                body["ObjectName"] = request.ObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TempOssUrlIntl",
                Version = "2022-08-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TempOssUrlIntlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件临时地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TempOssUrlIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// TempOssUrlIntlResponse
        /// </returns>
        public TempOssUrlIntlResponse TempOssUrlIntl(TempOssUrlIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TempOssUrlIntlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件临时地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TempOssUrlIntlRequest
        /// </param>
        /// 
        /// <returns>
        /// TempOssUrlIntlResponse
        /// </returns>
        public async Task<TempOssUrlIntlResponse> TempOssUrlIntlAsync(TempOssUrlIntlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TempOssUrlIntlWithOptionsAsync(request, runtime);
        }

    }
}
