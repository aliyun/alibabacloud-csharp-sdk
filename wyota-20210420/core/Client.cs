// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Wyota20210420.Models;

namespace AlibabaCloud.SDK.Wyota20210420
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("wyota", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalResponse
        /// </returns>
        public AddTerminalResponse AddTerminalWithOptions(AddTerminalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTerminal",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTerminalResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalResponse
        /// </returns>
        public async Task<AddTerminalResponse> AddTerminalWithOptionsAsync(AddTerminalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTerminal",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTerminalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalResponse
        /// </returns>
        public AddTerminalResponse AddTerminal(AddTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTerminalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalResponse
        /// </returns>
        public async Task<AddTerminalResponse> AddTerminalAsync(AddTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTerminalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalsResponse
        /// </returns>
        public AddTerminalsResponse AddTerminalsWithOptions(AddTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddTerminalParams))
            {
                bodyFlat["AddTerminalParams"] = request.AddTerminalParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTerminals",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTerminalsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalsResponse
        /// </returns>
        public async Task<AddTerminalsResponse> AddTerminalsWithOptionsAsync(AddTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddTerminalParams))
            {
                bodyFlat["AddTerminalParams"] = request.AddTerminalParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTerminals",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTerminalsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalsResponse
        /// </returns>
        public AddTerminalsResponse AddTerminals(AddTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTerminalsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加终端</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTerminalsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTerminalsResponse
        /// </returns>
        public async Task<AddTerminalsResponse> AddTerminalsAsync(AddTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTerminalsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAccountLessLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAccountLessLoginUserResponse
        /// </returns>
        public BindAccountLessLoginUserResponse BindAccountLessLoginUserWithOptions(BindAccountLessLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAccountLessLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAccountLessLoginUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAccountLessLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAccountLessLoginUserResponse
        /// </returns>
        public async Task<BindAccountLessLoginUserResponse> BindAccountLessLoginUserWithOptionsAsync(BindAccountLessLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAccountLessLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAccountLessLoginUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAccountLessLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAccountLessLoginUserResponse
        /// </returns>
        public BindAccountLessLoginUserResponse BindAccountLessLoginUser(BindAccountLessLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAccountLessLoginUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAccountLessLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAccountLessLoginUserResponse
        /// </returns>
        public async Task<BindAccountLessLoginUserResponse> BindAccountLessLoginUserAsync(BindAccountLessLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAccountLessLoginUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindPasswordFreeLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindPasswordFreeLoginUserResponse
        /// </returns>
        public BindPasswordFreeLoginUserResponse BindPasswordFreeLoginUserWithOptions(BindPasswordFreeLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindPasswordFreeLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindPasswordFreeLoginUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindPasswordFreeLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindPasswordFreeLoginUserResponse
        /// </returns>
        public async Task<BindPasswordFreeLoginUserResponse> BindPasswordFreeLoginUserWithOptionsAsync(BindPasswordFreeLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindPasswordFreeLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindPasswordFreeLoginUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindPasswordFreeLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// BindPasswordFreeLoginUserResponse
        /// </returns>
        public BindPasswordFreeLoginUserResponse BindPasswordFreeLoginUser(BindPasswordFreeLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindPasswordFreeLoginUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindPasswordFreeLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// BindPasswordFreeLoginUserResponse
        /// </returns>
        public async Task<BindPasswordFreeLoginUserResponse> BindPasswordFreeLoginUserAsync(BindPasswordFreeLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindPasswordFreeLoginUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备座位</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDeviceSeatsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeviceSeatsResponse
        /// </returns>
        public DescribeDeviceSeatsResponse DescribeDeviceSeatsWithOptions(DescribeDeviceSeatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNoList))
            {
                body["SerialNoList"] = request.SerialNoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeviceSeats",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeviceSeatsResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备座位</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDeviceSeatsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeviceSeatsResponse
        /// </returns>
        public async Task<DescribeDeviceSeatsResponse> DescribeDeviceSeatsWithOptionsAsync(DescribeDeviceSeatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNoList))
            {
                body["SerialNoList"] = request.SerialNoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeviceSeats",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeviceSeatsResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备座位</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDeviceSeatsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeviceSeatsResponse
        /// </returns>
        public DescribeDeviceSeatsResponse DescribeDeviceSeats(DescribeDeviceSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceSeatsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备座位</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDeviceSeatsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeviceSeatsResponse
        /// </returns>
        public async Task<DescribeDeviceSeatsResponse> DescribeDeviceSeatsAsync(DescribeDeviceSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceSeatsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTerminalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTerminalResponse
        /// </returns>
        public ListTerminalResponse ListTerminalWithOptions(ListTerminalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildId))
            {
                body["BuildId"] = request.BuildId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InManage))
            {
                body["InManage"] = request.InManage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv4))
            {
                body["Ipv4"] = request.Ipv4;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationInfo))
            {
                body["LocationInfo"] = request.LocationInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyword))
            {
                body["SearchKeyword"] = request.SearchKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTerminal",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTerminalResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTerminalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTerminalResponse
        /// </returns>
        public async Task<ListTerminalResponse> ListTerminalWithOptionsAsync(ListTerminalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildId))
            {
                body["BuildId"] = request.BuildId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InManage))
            {
                body["InManage"] = request.InManage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv4))
            {
                body["Ipv4"] = request.Ipv4;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationInfo))
            {
                body["LocationInfo"] = request.LocationInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyword))
            {
                body["SearchKeyword"] = request.SearchKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTerminal",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTerminalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTerminalRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTerminalResponse
        /// </returns>
        public ListTerminalResponse ListTerminal(ListTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTerminalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询终端列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTerminalRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTerminalResponse
        /// </returns>
        public async Task<ListTerminalResponse> ListTerminalAsync(ListTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTerminalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向终端发送运维命令</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOpsMessageToTerminalsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendOpsMessageToTerminalsResponse
        /// </returns>
        public SendOpsMessageToTerminalsResponse SendOpsMessageToTerminalsWithOptions(SendOpsMessageToTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delay))
            {
                query["Delay"] = request.Delay;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msg))
            {
                body["Msg"] = request.Msg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsAction))
            {
                body["OpsAction"] = request.OpsAction;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                bodyFlat["Uuids"] = request.Uuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitForAck))
            {
                body["WaitForAck"] = request.WaitForAck;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendOpsMessageToTerminals",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendOpsMessageToTerminalsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向终端发送运维命令</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOpsMessageToTerminalsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendOpsMessageToTerminalsResponse
        /// </returns>
        public async Task<SendOpsMessageToTerminalsResponse> SendOpsMessageToTerminalsWithOptionsAsync(SendOpsMessageToTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delay))
            {
                query["Delay"] = request.Delay;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msg))
            {
                body["Msg"] = request.Msg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsAction))
            {
                body["OpsAction"] = request.OpsAction;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                bodyFlat["Uuids"] = request.Uuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitForAck))
            {
                body["WaitForAck"] = request.WaitForAck;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendOpsMessageToTerminals",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendOpsMessageToTerminalsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向终端发送运维命令</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOpsMessageToTerminalsRequest
        /// </param>
        /// 
        /// <returns>
        /// SendOpsMessageToTerminalsResponse
        /// </returns>
        public SendOpsMessageToTerminalsResponse SendOpsMessageToTerminals(SendOpsMessageToTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendOpsMessageToTerminalsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向终端发送运维命令</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOpsMessageToTerminalsRequest
        /// </param>
        /// 
        /// <returns>
        /// SendOpsMessageToTerminalsResponse
        /// </returns>
        public async Task<SendOpsMessageToTerminalsResponse> SendOpsMessageToTerminalsAsync(SendOpsMessageToTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendOpsMessageToTerminalsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAccountLessLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindAccountLessLoginUserResponse
        /// </returns>
        public UnbindAccountLessLoginUserResponse UnbindAccountLessLoginUserWithOptions(UnbindAccountLessLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindAccountLessLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAccountLessLoginUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAccountLessLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindAccountLessLoginUserResponse
        /// </returns>
        public async Task<UnbindAccountLessLoginUserResponse> UnbindAccountLessLoginUserWithOptionsAsync(UnbindAccountLessLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindAccountLessLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAccountLessLoginUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAccountLessLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindAccountLessLoginUserResponse
        /// </returns>
        public UnbindAccountLessLoginUserResponse UnbindAccountLessLoginUser(UnbindAccountLessLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindAccountLessLoginUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免账号登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAccountLessLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindAccountLessLoginUserResponse
        /// </returns>
        public async Task<UnbindAccountLessLoginUserResponse> UnbindAccountLessLoginUserAsync(UnbindAccountLessLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindAccountLessLoginUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑设备座位</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UnbindDeviceSeatsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindDeviceSeatsResponse
        /// </returns>
        public UnbindDeviceSeatsResponse UnbindDeviceSeatsWithOptions(UnbindDeviceSeatsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UnbindDeviceSeatsShrinkRequest request = new UnbindDeviceSeatsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SerialNoList))
            {
                request.SerialNoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SerialNoList, "SerialNoList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNoListShrink))
            {
                body["SerialNoList"] = request.SerialNoListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindDeviceSeats",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindDeviceSeatsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑设备座位</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UnbindDeviceSeatsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindDeviceSeatsResponse
        /// </returns>
        public async Task<UnbindDeviceSeatsResponse> UnbindDeviceSeatsWithOptionsAsync(UnbindDeviceSeatsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UnbindDeviceSeatsShrinkRequest request = new UnbindDeviceSeatsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SerialNoList))
            {
                request.SerialNoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SerialNoList, "SerialNoList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNoListShrink))
            {
                body["SerialNoList"] = request.SerialNoListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindDeviceSeats",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindDeviceSeatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑设备座位</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindDeviceSeatsRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindDeviceSeatsResponse
        /// </returns>
        public UnbindDeviceSeatsResponse UnbindDeviceSeats(UnbindDeviceSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindDeviceSeatsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑设备座位</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindDeviceSeatsRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindDeviceSeatsResponse
        /// </returns>
        public async Task<UnbindDeviceSeatsResponse> UnbindDeviceSeatsAsync(UnbindDeviceSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindDeviceSeatsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免密登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindPasswordFreeLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindPasswordFreeLoginUserResponse
        /// </returns>
        public UnbindPasswordFreeLoginUserResponse UnbindPasswordFreeLoginUserWithOptions(UnbindPasswordFreeLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindPasswordFreeLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindPasswordFreeLoginUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免密登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindPasswordFreeLoginUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindPasswordFreeLoginUserResponse
        /// </returns>
        public async Task<UnbindPasswordFreeLoginUserResponse> UnbindPasswordFreeLoginUserWithOptionsAsync(UnbindPasswordFreeLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainBizType))
            {
                body["MainBizType"] = request.MainBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindPasswordFreeLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindPasswordFreeLoginUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免密登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindPasswordFreeLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindPasswordFreeLoginUserResponse
        /// </returns>
        public UnbindPasswordFreeLoginUserResponse UnbindPasswordFreeLoginUser(UnbindPasswordFreeLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindPasswordFreeLoginUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑免密登录用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindPasswordFreeLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindPasswordFreeLoginUserResponse
        /// </returns>
        public async Task<UnbindPasswordFreeLoginUserResponse> UnbindPasswordFreeLoginUserAsync(UnbindPasswordFreeLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindPasswordFreeLoginUserWithOptionsAsync(request, runtime);
        }

    }
}
