// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloud_siem20220616.Models;

namespace AlibabaCloud.SDK.Cloud_siem20220616
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloud-siem", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Adds a data source to a cloud account that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDataSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDataSourceResponse
        /// </returns>
        public AddDataSourceResponse AddDataSourceWithOptions(AddDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceName))
            {
                body["DataSourceInstanceName"] = request.DataSourceInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceParams))
            {
                body["DataSourceInstanceParams"] = request.DataSourceInstanceParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceRemark))
            {
                body["DataSourceInstanceRemark"] = request.DataSourceInstanceRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a data source to a cloud account that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDataSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDataSourceResponse
        /// </returns>
        public async Task<AddDataSourceResponse> AddDataSourceWithOptionsAsync(AddDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceName))
            {
                body["DataSourceInstanceName"] = request.DataSourceInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceParams))
            {
                body["DataSourceInstanceParams"] = request.DataSourceInstanceParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceRemark))
            {
                body["DataSourceInstanceRemark"] = request.DataSourceInstanceRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a data source to a cloud account that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDataSourceResponse
        /// </returns>
        public AddDataSourceResponse AddDataSource(AddDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDataSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a data source to a cloud account that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDataSourceResponse
        /// </returns>
        public async Task<AddDataSourceResponse> AddDataSourceAsync(AddDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDataSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds logs of a cloud account to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDataSourceLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDataSourceLogResponse
        /// </returns>
        public AddDataSourceLogResponse AddDataSourceLogWithOptions(AddDataSourceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceLogs))
            {
                body["DataSourceInstanceLogs"] = request.DataSourceInstanceLogs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataSourceLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataSourceLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds logs of a cloud account to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDataSourceLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDataSourceLogResponse
        /// </returns>
        public async Task<AddDataSourceLogResponse> AddDataSourceLogWithOptionsAsync(AddDataSourceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceLogs))
            {
                body["DataSourceInstanceLogs"] = request.DataSourceInstanceLogs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataSourceLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataSourceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds logs of a cloud account to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDataSourceLogRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDataSourceLogResponse
        /// </returns>
        public AddDataSourceLogResponse AddDataSourceLog(AddDataSourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDataSourceLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds logs of a cloud account to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDataSourceLogRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDataSourceLogResponse
        /// </returns>
        public async Task<AddDataSourceLogResponse> AddDataSourceLogAsync(AddDataSourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDataSourceLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds the logs of a cloud service within a cloud account to the threat analysis feature for alert and event anslysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserSourceLogConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUserSourceLogConfigResponse
        /// </returns>
        public AddUserSourceLogConfigResponse AddUserSourceLogConfigWithOptions(AddUserSourceLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deleted))
            {
                body["Deleted"] = request.Deleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisPlayLine))
            {
                body["DisPlayLine"] = request.DisPlayLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogCode))
            {
                body["SourceLogCode"] = request.SourceLogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogInfo))
            {
                body["SourceLogInfo"] = request.SourceLogInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProdCode))
            {
                body["SourceProdCode"] = request.SourceProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserSourceLogConfig",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserSourceLogConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds the logs of a cloud service within a cloud account to the threat analysis feature for alert and event anslysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserSourceLogConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUserSourceLogConfigResponse
        /// </returns>
        public async Task<AddUserSourceLogConfigResponse> AddUserSourceLogConfigWithOptionsAsync(AddUserSourceLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deleted))
            {
                body["Deleted"] = request.Deleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisPlayLine))
            {
                body["DisPlayLine"] = request.DisPlayLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogCode))
            {
                body["SourceLogCode"] = request.SourceLogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogInfo))
            {
                body["SourceLogInfo"] = request.SourceLogInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProdCode))
            {
                body["SourceProdCode"] = request.SourceProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserSourceLogConfig",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserSourceLogConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds the logs of a cloud service within a cloud account to the threat analysis feature for alert and event anslysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserSourceLogConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUserSourceLogConfigResponse
        /// </returns>
        public AddUserSourceLogConfigResponse AddUserSourceLogConfig(AddUserSourceLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserSourceLogConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds the logs of a cloud service within a cloud account to the threat analysis feature for alert and event anslysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserSourceLogConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUserSourceLogConfigResponse
        /// </returns>
        public async Task<AddUserSourceLogConfigResponse> AddUserSourceLogConfigAsync(AddUserSourceLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserSourceLogConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a third-party cloud account that is displayed on the Multi-cloud assets tab of the Feature Settings page to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAccountResponse
        /// </returns>
        public BindAccountResponse BindAccountWithOptions(BindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessId))
            {
                body["AccessId"] = request.AccessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAccount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a third-party cloud account that is displayed on the Multi-cloud assets tab of the Feature Settings page to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAccountResponse
        /// </returns>
        public async Task<BindAccountResponse> BindAccountWithOptionsAsync(BindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessId))
            {
                body["AccessId"] = request.AccessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAccount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a third-party cloud account that is displayed on the Multi-cloud assets tab of the Feature Settings page to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAccountResponse
        /// </returns>
        public BindAccountResponse BindAccount(BindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a third-party cloud account that is displayed on the Multi-cloud assets tab of the Feature Settings page to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAccountResponse
        /// </returns>
        public async Task<BindAccountResponse> BindAccountAsync(BindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the log delivery feature for a cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseDeliveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseDeliveryResponse
        /// </returns>
        public CloseDeliveryResponse CloseDeliveryWithOptions(CloseDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseDelivery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseDeliveryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the log delivery feature for a cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseDeliveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseDeliveryResponse
        /// </returns>
        public async Task<CloseDeliveryResponse> CloseDeliveryWithOptionsAsync(CloseDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseDelivery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the log delivery feature for a cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseDeliveryRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseDeliveryResponse
        /// </returns>
        public CloseDeliveryResponse CloseDelivery(CloseDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseDeliveryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the log delivery feature for a cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseDeliveryRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseDeliveryResponse
        /// </returns>
        public async Task<CloseDeliveryResponse> CloseDeliveryAsync(CloseDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseDeliveryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the automated response rule with a specified ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAutomateResponseConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutomateResponseConfigResponse
        /// </returns>
        public DeleteAutomateResponseConfigResponse DeleteAutomateResponseConfigWithOptions(DeleteAutomateResponseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAutomateResponseConfig",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAutomateResponseConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the automated response rule with a specified ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAutomateResponseConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutomateResponseConfigResponse
        /// </returns>
        public async Task<DeleteAutomateResponseConfigResponse> DeleteAutomateResponseConfigWithOptionsAsync(DeleteAutomateResponseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAutomateResponseConfig",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAutomateResponseConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the automated response rule with a specified ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAutomateResponseConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutomateResponseConfigResponse
        /// </returns>
        public DeleteAutomateResponseConfigResponse DeleteAutomateResponseConfig(DeleteAutomateResponseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAutomateResponseConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the automated response rule with a specified ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAutomateResponseConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAutomateResponseConfigResponse
        /// </returns>
        public async Task<DeleteAutomateResponseConfigResponse> DeleteAutomateResponseConfigAsync(DeleteAutomateResponseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAutomateResponseConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a third-party cloud account that is added to the threat analysis feature by using its AccessKey ID. You can add another cloud account based on your business requirements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBindAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBindAccountResponse
        /// </returns>
        public DeleteBindAccountResponse DeleteBindAccountWithOptions(DeleteBindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessId))
            {
                body["AccessId"] = request.AccessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindId))
            {
                body["BindId"] = request.BindId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBindAccount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBindAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a third-party cloud account that is added to the threat analysis feature by using its AccessKey ID. You can add another cloud account based on your business requirements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBindAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBindAccountResponse
        /// </returns>
        public async Task<DeleteBindAccountResponse> DeleteBindAccountWithOptionsAsync(DeleteBindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessId))
            {
                body["AccessId"] = request.AccessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindId))
            {
                body["BindId"] = request.BindId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBindAccount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBindAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a third-party cloud account that is added to the threat analysis feature by using its AccessKey ID. You can add another cloud account based on your business requirements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBindAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBindAccountResponse
        /// </returns>
        public DeleteBindAccountResponse DeleteBindAccount(DeleteBindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBindAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a third-party cloud account that is added to the threat analysis feature by using its AccessKey ID. You can add another cloud account based on your business requirements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBindAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBindAccountResponse
        /// </returns>
        public async Task<DeleteBindAccountResponse> DeleteBindAccountAsync(DeleteBindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBindAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a rule by rule ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomizeRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomizeRuleResponse
        /// </returns>
        public DeleteCustomizeRuleResponse DeleteCustomizeRuleWithOptions(DeleteCustomizeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomizeRule",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomizeRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a rule by rule ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomizeRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomizeRuleResponse
        /// </returns>
        public async Task<DeleteCustomizeRuleResponse> DeleteCustomizeRuleWithOptionsAsync(DeleteCustomizeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomizeRule",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomizeRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a rule by rule ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomizeRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomizeRuleResponse
        /// </returns>
        public DeleteCustomizeRuleResponse DeleteCustomizeRule(DeleteCustomizeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomizeRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a rule by rule ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomizeRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomizeRuleResponse
        /// </returns>
        public async Task<DeleteCustomizeRuleResponse> DeleteCustomizeRuleAsync(DeleteCustomizeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomizeRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a data source that is no longer required.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSourceResponse
        /// </returns>
        public DeleteDataSourceResponse DeleteDataSourceWithOptions(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a data source that is no longer required.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSourceResponse
        /// </returns>
        public async Task<DeleteDataSourceResponse> DeleteDataSourceWithOptionsAsync(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a data source that is no longer required.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSourceResponse
        /// </returns>
        public DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a data source that is no longer required.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSourceResponse
        /// </returns>
        public async Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a log.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSourceLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSourceLogResponse
        /// </returns>
        public DeleteDataSourceLogResponse DeleteDataSourceLogWithOptions(DeleteDataSourceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogInstanceId))
            {
                body["LogInstanceId"] = request.LogInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSourceLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSourceLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a log.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSourceLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSourceLogResponse
        /// </returns>
        public async Task<DeleteDataSourceLogResponse> DeleteDataSourceLogWithOptionsAsync(DeleteDataSourceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogInstanceId))
            {
                body["LogInstanceId"] = request.LogInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSourceLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSourceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a log.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSourceLogRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSourceLogResponse
        /// </returns>
        public DeleteDataSourceLogResponse DeleteDataSourceLog(DeleteDataSourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataSourceLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a log.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSourceLogRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSourceLogResponse
        /// </returns>
        public async Task<DeleteDataSourceLogResponse> DeleteDataSourceLogAsync(DeleteDataSourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataSourceLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alert whitelist rule with a specified ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWhiteRuleListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWhiteRuleListResponse
        /// </returns>
        public DeleteWhiteRuleListResponse DeleteWhiteRuleListWithOptions(DeleteWhiteRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWhiteRuleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWhiteRuleListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alert whitelist rule with a specified ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWhiteRuleListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWhiteRuleListResponse
        /// </returns>
        public async Task<DeleteWhiteRuleListResponse> DeleteWhiteRuleListWithOptionsAsync(DeleteWhiteRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWhiteRuleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWhiteRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alert whitelist rule with a specified ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWhiteRuleListRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWhiteRuleListResponse
        /// </returns>
        public DeleteWhiteRuleListResponse DeleteWhiteRuleList(DeleteWhiteRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWhiteRuleListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alert whitelist rule with a specified ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWhiteRuleListRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWhiteRuleListResponse
        /// </returns>
        public async Task<DeleteWhiteRuleListResponse> DeleteWhiteRuleListAsync(DeleteWhiteRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWhiteRuleListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the aggregate functions that are supported for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAggregateFunctionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAggregateFunctionResponse
        /// </returns>
        public DescribeAggregateFunctionResponse DescribeAggregateFunctionWithOptions(DescribeAggregateFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAggregateFunction",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAggregateFunctionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the aggregate functions that are supported for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAggregateFunctionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAggregateFunctionResponse
        /// </returns>
        public async Task<DescribeAggregateFunctionResponse> DescribeAggregateFunctionWithOptionsAsync(DescribeAggregateFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAggregateFunction",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAggregateFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the aggregate functions that are supported for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAggregateFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAggregateFunctionResponse
        /// </returns>
        public DescribeAggregateFunctionResponse DescribeAggregateFunction(DescribeAggregateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAggregateFunctionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the aggregate functions that are supported for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAggregateFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAggregateFunctionResponse
        /// </returns>
        public async Task<DescribeAggregateFunctionResponse> DescribeAggregateFunctionAsync(DescribeAggregateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAggregateFunctionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the scenarios in which an alert needs to be added to the whitelist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSceneResponse
        /// </returns>
        public DescribeAlertSceneResponse DescribeAlertSceneWithOptions(DescribeAlertSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertScene",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSceneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the scenarios in which an alert needs to be added to the whitelist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSceneResponse
        /// </returns>
        public async Task<DescribeAlertSceneResponse> DescribeAlertSceneWithOptionsAsync(DescribeAlertSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertScene",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the scenarios in which an alert needs to be added to the whitelist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSceneResponse
        /// </returns>
        public DescribeAlertSceneResponse DescribeAlertScene(DescribeAlertSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the scenarios in which an alert needs to be added to the whitelist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSceneResponse
        /// </returns>
        public async Task<DescribeAlertSceneResponse> DescribeAlertSceneAsync(DescribeAlertSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the scenarios and objects that can be added to an alert whitelist rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSceneByEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSceneByEventResponse
        /// </returns>
        public DescribeAlertSceneByEventResponse DescribeAlertSceneByEventWithOptions(DescribeAlertSceneByEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertSceneByEvent",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSceneByEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the scenarios and objects that can be added to an alert whitelist rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSceneByEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSceneByEventResponse
        /// </returns>
        public async Task<DescribeAlertSceneByEventResponse> DescribeAlertSceneByEventWithOptionsAsync(DescribeAlertSceneByEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertSceneByEvent",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSceneByEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the scenarios and objects that can be added to an alert whitelist rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSceneByEventRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSceneByEventResponse
        /// </returns>
        public DescribeAlertSceneByEventResponse DescribeAlertSceneByEvent(DescribeAlertSceneByEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertSceneByEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the scenarios and objects that can be added to an alert whitelist rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSceneByEventRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSceneByEventResponse
        /// </returns>
        public async Task<DescribeAlertSceneByEventResponse> DescribeAlertSceneByEventAsync(DescribeAlertSceneByEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertSceneByEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries alert data sources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSourceResponse
        /// </returns>
        public DescribeAlertSourceResponse DescribeAlertSourceWithOptions(DescribeAlertSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries alert data sources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSourceResponse
        /// </returns>
        public async Task<DescribeAlertSourceResponse> DescribeAlertSourceWithOptionsAsync(DescribeAlertSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries alert data sources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSourceResponse
        /// </returns>
        public DescribeAlertSourceResponse DescribeAlertSource(DescribeAlertSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries alert data sources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSourceResponse
        /// </returns>
        public async Task<DescribeAlertSourceResponse> DescribeAlertSourceAsync(DescribeAlertSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data sources of the alert that is associated with an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSourceWithEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSourceWithEventResponse
        /// </returns>
        public DescribeAlertSourceWithEventResponse DescribeAlertSourceWithEventWithOptions(DescribeAlertSourceWithEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertSourceWithEvent",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSourceWithEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data sources of the alert that is associated with an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSourceWithEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSourceWithEventResponse
        /// </returns>
        public async Task<DescribeAlertSourceWithEventResponse> DescribeAlertSourceWithEventWithOptionsAsync(DescribeAlertSourceWithEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertSourceWithEvent",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSourceWithEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data sources of the alert that is associated with an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSourceWithEventRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSourceWithEventResponse
        /// </returns>
        public DescribeAlertSourceWithEventResponse DescribeAlertSourceWithEvent(DescribeAlertSourceWithEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertSourceWithEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data sources of the alert that is associated with an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertSourceWithEventRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertSourceWithEventResponse
        /// </returns>
        public async Task<DescribeAlertSourceWithEventResponse> DescribeAlertSourceWithEventAsync(DescribeAlertSourceWithEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertSourceWithEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the threat types that you can select when you create a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertTypeResponse
        /// </returns>
        public DescribeAlertTypeResponse DescribeAlertTypeWithOptions(DescribeAlertTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertType",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the threat types that you can select when you create a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertTypeResponse
        /// </returns>
        public async Task<DescribeAlertTypeResponse> DescribeAlertTypeWithOptionsAsync(DescribeAlertTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertType",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the threat types that you can select when you create a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertTypeResponse
        /// </returns>
        public DescribeAlertTypeResponse DescribeAlertType(DescribeAlertTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the threat types that you can select when you create a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertTypeResponse
        /// </returns>
        public async Task<DescribeAlertTypeResponse> DescribeAlertTypeAsync(DescribeAlertTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries alerts within your account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsResponse
        /// </returns>
        public DescribeAlertsResponse DescribeAlertsWithOptions(DescribeAlertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertName))
            {
                body["AlertName"] = request.AlertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertStatus))
            {
                body["AlertStatus"] = request.AlertStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTitle))
            {
                body["AlertTitle"] = request.AlertTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertUuid))
            {
                body["AlertUuid"] = request.AlertUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetId))
            {
                body["AssetId"] = request.AssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetName))
            {
                body["AssetName"] = request.AssetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityName))
            {
                body["EntityName"] = request.EntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDefend))
            {
                body["IsDefend"] = request.IsDefend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelType))
            {
                body["LabelType"] = request.LabelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlerts",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries alerts within your account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsResponse
        /// </returns>
        public async Task<DescribeAlertsResponse> DescribeAlertsWithOptionsAsync(DescribeAlertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertName))
            {
                body["AlertName"] = request.AlertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertStatus))
            {
                body["AlertStatus"] = request.AlertStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTitle))
            {
                body["AlertTitle"] = request.AlertTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertUuid))
            {
                body["AlertUuid"] = request.AlertUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetId))
            {
                body["AssetId"] = request.AssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetName))
            {
                body["AssetName"] = request.AssetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityName))
            {
                body["EntityName"] = request.EntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDefend))
            {
                body["IsDefend"] = request.IsDefend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelType))
            {
                body["LabelType"] = request.LabelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlerts",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries alerts within your account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsResponse
        /// </returns>
        public DescribeAlertsResponse DescribeAlerts(DescribeAlertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries alerts within your account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsResponse
        /// </returns>
        public async Task<DescribeAlertsResponse> DescribeAlertsAsync(DescribeAlertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of alerts of different severities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsCountResponse
        /// </returns>
        public DescribeAlertsCountResponse DescribeAlertsCountWithOptions(DescribeAlertsCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertsCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of alerts of different severities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsCountResponse
        /// </returns>
        public async Task<DescribeAlertsCountResponse> DescribeAlertsCountWithOptionsAsync(DescribeAlertsCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertsCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of alerts of different severities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsCountResponse
        /// </returns>
        public DescribeAlertsCountResponse DescribeAlertsCount(DescribeAlertsCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertsCountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of alerts of different severities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsCountResponse
        /// </returns>
        public async Task<DescribeAlertsCountResponse> DescribeAlertsCountAsync(DescribeAlertsCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertsCountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the alerts that are associated with an entity.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsWithEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsWithEntityResponse
        /// </returns>
        public DescribeAlertsWithEntityResponse DescribeAlertsWithEntityWithOptions(DescribeAlertsWithEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityUuid))
            {
                body["EntityUuid"] = request.EntityUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SophonTaskId))
            {
                body["SophonTaskId"] = request.SophonTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertsWithEntity",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsWithEntityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the alerts that are associated with an entity.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsWithEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsWithEntityResponse
        /// </returns>
        public async Task<DescribeAlertsWithEntityResponse> DescribeAlertsWithEntityWithOptionsAsync(DescribeAlertsWithEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityUuid))
            {
                body["EntityUuid"] = request.EntityUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SophonTaskId))
            {
                body["SophonTaskId"] = request.SophonTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertsWithEntity",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsWithEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the alerts that are associated with an entity.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsWithEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsWithEntityResponse
        /// </returns>
        public DescribeAlertsWithEntityResponse DescribeAlertsWithEntity(DescribeAlertsWithEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertsWithEntityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the alerts that are associated with an entity.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsWithEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsWithEntityResponse
        /// </returns>
        public async Task<DescribeAlertsWithEntityResponse> DescribeAlertsWithEntityAsync(DescribeAlertsWithEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertsWithEntityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the alerts that are associated with an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsWithEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsWithEventResponse
        /// </returns>
        public DescribeAlertsWithEventResponse DescribeAlertsWithEventWithOptions(DescribeAlertsWithEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertName))
            {
                body["AlertName"] = request.AlertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTitle))
            {
                body["AlertTitle"] = request.AlertTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetId))
            {
                body["AssetId"] = request.AssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetName))
            {
                body["AssetName"] = request.AssetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityName))
            {
                body["EntityName"] = request.EntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDefend))
            {
                body["IsDefend"] = request.IsDefend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertsWithEvent",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsWithEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the alerts that are associated with an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsWithEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsWithEventResponse
        /// </returns>
        public async Task<DescribeAlertsWithEventResponse> DescribeAlertsWithEventWithOptionsAsync(DescribeAlertsWithEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertName))
            {
                body["AlertName"] = request.AlertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTitle))
            {
                body["AlertTitle"] = request.AlertTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetId))
            {
                body["AssetId"] = request.AssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetName))
            {
                body["AssetName"] = request.AssetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityName))
            {
                body["EntityName"] = request.EntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDefend))
            {
                body["IsDefend"] = request.IsDefend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertsWithEvent",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsWithEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the alerts that are associated with an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsWithEventRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsWithEventResponse
        /// </returns>
        public DescribeAlertsWithEventResponse DescribeAlertsWithEvent(DescribeAlertsWithEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertsWithEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the alerts that are associated with an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAlertsWithEventRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAlertsWithEventResponse
        /// </returns>
        public async Task<DescribeAlertsWithEventResponse> DescribeAlertsWithEventAsync(DescribeAlertsWithEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertsWithEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the security information and event management (SIEM) system is granted the required permissions to access other cloud resources within your Alibaba Cloud account and whether the AliyunServiceRoleForSasCloudSiem service-linked role is created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAuthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAuthResponse
        /// </returns>
        public DescribeAuthResponse DescribeAuthWithOptions(DescribeAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAuth",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAuthResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the security information and event management (SIEM) system is granted the required permissions to access other cloud resources within your Alibaba Cloud account and whether the AliyunServiceRoleForSasCloudSiem service-linked role is created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAuthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAuthResponse
        /// </returns>
        public async Task<DescribeAuthResponse> DescribeAuthWithOptionsAsync(DescribeAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAuth",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAuthResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the security information and event management (SIEM) system is granted the required permissions to access other cloud resources within your Alibaba Cloud account and whether the AliyunServiceRoleForSasCloudSiem service-linked role is created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAuthResponse
        /// </returns>
        public DescribeAuthResponse DescribeAuth(DescribeAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAuthWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the security information and event management (SIEM) system is granted the required permissions to access other cloud resources within your Alibaba Cloud account and whether the AliyunServiceRoleForSasCloudSiem service-linked role is created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAuthResponse
        /// </returns>
        public async Task<DescribeAuthResponse> DescribeAuthAsync(DescribeAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAuthWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of automated response rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAutomateResponseConfigCounterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutomateResponseConfigCounterResponse
        /// </returns>
        public DescribeAutomateResponseConfigCounterResponse DescribeAutomateResponseConfigCounterWithOptions(DescribeAutomateResponseConfigCounterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutomateResponseConfigCounter",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutomateResponseConfigCounterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of automated response rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAutomateResponseConfigCounterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutomateResponseConfigCounterResponse
        /// </returns>
        public async Task<DescribeAutomateResponseConfigCounterResponse> DescribeAutomateResponseConfigCounterWithOptionsAsync(DescribeAutomateResponseConfigCounterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutomateResponseConfigCounter",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutomateResponseConfigCounterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of automated response rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAutomateResponseConfigCounterRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutomateResponseConfigCounterResponse
        /// </returns>
        public DescribeAutomateResponseConfigCounterResponse DescribeAutomateResponseConfigCounter(DescribeAutomateResponseConfigCounterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutomateResponseConfigCounterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of automated response rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAutomateResponseConfigCounterRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutomateResponseConfigCounterResponse
        /// </returns>
        public async Task<DescribeAutomateResponseConfigCounterResponse> DescribeAutomateResponseConfigCounterAsync(DescribeAutomateResponseConfigCounterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutomateResponseConfigCounterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurable fields and operators of an automated response rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAutomateResponseConfigFeatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutomateResponseConfigFeatureResponse
        /// </returns>
        public DescribeAutomateResponseConfigFeatureResponse DescribeAutomateResponseConfigFeatureWithOptions(DescribeAutomateResponseConfigFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoResponseType))
            {
                body["AutoResponseType"] = request.AutoResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutomateResponseConfigFeature",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutomateResponseConfigFeatureResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurable fields and operators of an automated response rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAutomateResponseConfigFeatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutomateResponseConfigFeatureResponse
        /// </returns>
        public async Task<DescribeAutomateResponseConfigFeatureResponse> DescribeAutomateResponseConfigFeatureWithOptionsAsync(DescribeAutomateResponseConfigFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoResponseType))
            {
                body["AutoResponseType"] = request.AutoResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutomateResponseConfigFeature",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutomateResponseConfigFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurable fields and operators of an automated response rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAutomateResponseConfigFeatureRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutomateResponseConfigFeatureResponse
        /// </returns>
        public DescribeAutomateResponseConfigFeatureResponse DescribeAutomateResponseConfigFeature(DescribeAutomateResponseConfigFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutomateResponseConfigFeatureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurable fields and operators of an automated response rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAutomateResponseConfigFeatureRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutomateResponseConfigFeatureResponse
        /// </returns>
        public async Task<DescribeAutomateResponseConfigFeatureResponse> DescribeAutomateResponseConfigFeatureAsync(DescribeAutomateResponseConfigFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutomateResponseConfigFeatureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the assets that are associated with an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemAssetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemAssetsResponse
        /// </returns>
        public DescribeCloudSiemAssetsResponse DescribeCloudSiemAssetsWithOptions(DescribeCloudSiemAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetName))
            {
                body["AssetName"] = request.AssetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetType))
            {
                body["AssetType"] = request.AssetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetUuid))
            {
                body["AssetUuid"] = request.AssetUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemAssets",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemAssetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the assets that are associated with an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemAssetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemAssetsResponse
        /// </returns>
        public async Task<DescribeCloudSiemAssetsResponse> DescribeCloudSiemAssetsWithOptionsAsync(DescribeCloudSiemAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetName))
            {
                body["AssetName"] = request.AssetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetType))
            {
                body["AssetType"] = request.AssetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetUuid))
            {
                body["AssetUuid"] = request.AssetUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemAssets",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemAssetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the assets that are associated with an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemAssetsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemAssetsResponse
        /// </returns>
        public DescribeCloudSiemAssetsResponse DescribeCloudSiemAssets(DescribeCloudSiemAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudSiemAssetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the assets that are associated with an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemAssetsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemAssetsResponse
        /// </returns>
        public async Task<DescribeCloudSiemAssetsResponse> DescribeCloudSiemAssetsAsync(DescribeCloudSiemAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudSiemAssetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of assets that are associated with an event by asset type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemAssetsCounterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemAssetsCounterResponse
        /// </returns>
        public DescribeCloudSiemAssetsCounterResponse DescribeCloudSiemAssetsCounterWithOptions(DescribeCloudSiemAssetsCounterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemAssetsCounter",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemAssetsCounterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of assets that are associated with an event by asset type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemAssetsCounterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemAssetsCounterResponse
        /// </returns>
        public async Task<DescribeCloudSiemAssetsCounterResponse> DescribeCloudSiemAssetsCounterWithOptionsAsync(DescribeCloudSiemAssetsCounterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemAssetsCounter",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemAssetsCounterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of assets that are associated with an event by asset type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemAssetsCounterRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemAssetsCounterResponse
        /// </returns>
        public DescribeCloudSiemAssetsCounterResponse DescribeCloudSiemAssetsCounter(DescribeCloudSiemAssetsCounterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudSiemAssetsCounterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of assets that are associated with an event by asset type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemAssetsCounterRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemAssetsCounterResponse
        /// </returns>
        public async Task<DescribeCloudSiemAssetsCounterResponse> DescribeCloudSiemAssetsCounterAsync(DescribeCloudSiemAssetsCounterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudSiemAssetsCounterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemEventDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemEventDetailResponse
        /// </returns>
        public DescribeCloudSiemEventDetailResponse DescribeCloudSiemEventDetailWithOptions(DescribeCloudSiemEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemEventDetail",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemEventDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemEventDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemEventDetailResponse
        /// </returns>
        public async Task<DescribeCloudSiemEventDetailResponse> DescribeCloudSiemEventDetailWithOptionsAsync(DescribeCloudSiemEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemEventDetail",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemEventDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemEventDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemEventDetailResponse
        /// </returns>
        public DescribeCloudSiemEventDetailResponse DescribeCloudSiemEventDetail(DescribeCloudSiemEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudSiemEventDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemEventDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemEventDetailResponse
        /// </returns>
        public async Task<DescribeCloudSiemEventDetailResponse> DescribeCloudSiemEventDetailAsync(DescribeCloudSiemEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudSiemEventDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries events in SIEM.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemEventsResponse
        /// </returns>
        public DescribeCloudSiemEventsResponse DescribeCloudSiemEventsWithOptions(DescribeCloudSiemEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetId))
            {
                body["AssetId"] = request.AssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityUuid))
            {
                body["EntityUuid"] = request.EntityUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                body["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadLevel))
            {
                body["ThreadLevel"] = request.ThreadLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemEvents",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries events in SIEM.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemEventsResponse
        /// </returns>
        public async Task<DescribeCloudSiemEventsResponse> DescribeCloudSiemEventsWithOptionsAsync(DescribeCloudSiemEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetId))
            {
                body["AssetId"] = request.AssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityUuid))
            {
                body["EntityUuid"] = request.EntityUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                body["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadLevel))
            {
                body["ThreadLevel"] = request.ThreadLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemEvents",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries events in SIEM.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemEventsResponse
        /// </returns>
        public DescribeCloudSiemEventsResponse DescribeCloudSiemEvents(DescribeCloudSiemEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudSiemEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries events in SIEM.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudSiemEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudSiemEventsResponse
        /// </returns>
        public async Task<DescribeCloudSiemEventsResponse> DescribeCloudSiemEventsAsync(DescribeCloudSiemEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudSiemEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of custom rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomizeRuleCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomizeRuleCountResponse
        /// </returns>
        public DescribeCustomizeRuleCountResponse DescribeCustomizeRuleCountWithOptions(DescribeCustomizeRuleCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomizeRuleCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomizeRuleCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of custom rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomizeRuleCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomizeRuleCountResponse
        /// </returns>
        public async Task<DescribeCustomizeRuleCountResponse> DescribeCustomizeRuleCountWithOptionsAsync(DescribeCustomizeRuleCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomizeRuleCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomizeRuleCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of custom rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomizeRuleCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomizeRuleCountResponse
        /// </returns>
        public DescribeCustomizeRuleCountResponse DescribeCustomizeRuleCount(DescribeCustomizeRuleCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomizeRuleCountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of custom rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomizeRuleCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomizeRuleCountResponse
        /// </returns>
        public async Task<DescribeCustomizeRuleCountResponse> DescribeCustomizeRuleCountAsync(DescribeCustomizeRuleCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomizeRuleCountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical simulation data that is used in a simulation test scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomizeRuleTestRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomizeRuleTestResponse
        /// </returns>
        public DescribeCustomizeRuleTestResponse DescribeCustomizeRuleTestWithOptions(DescribeCustomizeRuleTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomizeRuleTest",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomizeRuleTestResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical simulation data that is used in a simulation test scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomizeRuleTestRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomizeRuleTestResponse
        /// </returns>
        public async Task<DescribeCustomizeRuleTestResponse> DescribeCustomizeRuleTestWithOptionsAsync(DescribeCustomizeRuleTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomizeRuleTest",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomizeRuleTestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical simulation data that is used in a simulation test scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomizeRuleTestRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomizeRuleTestResponse
        /// </returns>
        public DescribeCustomizeRuleTestResponse DescribeCustomizeRuleTest(DescribeCustomizeRuleTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomizeRuleTestWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical simulation data that is used in a simulation test scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomizeRuleTestRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomizeRuleTestResponse
        /// </returns>
        public async Task<DescribeCustomizeRuleTestResponse> DescribeCustomizeRuleTestAsync(DescribeCustomizeRuleTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomizeRuleTestWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the chart that displays the test results of business data for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomizeRuleTestHistogramRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomizeRuleTestHistogramResponse
        /// </returns>
        public DescribeCustomizeRuleTestHistogramResponse DescribeCustomizeRuleTestHistogramWithOptions(DescribeCustomizeRuleTestHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomizeRuleTestHistogram",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomizeRuleTestHistogramResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the chart that displays the test results of business data for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomizeRuleTestHistogramRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomizeRuleTestHistogramResponse
        /// </returns>
        public async Task<DescribeCustomizeRuleTestHistogramResponse> DescribeCustomizeRuleTestHistogramWithOptionsAsync(DescribeCustomizeRuleTestHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomizeRuleTestHistogram",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomizeRuleTestHistogramResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the chart that displays the test results of business data for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomizeRuleTestHistogramRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomizeRuleTestHistogramResponse
        /// </returns>
        public DescribeCustomizeRuleTestHistogramResponse DescribeCustomizeRuleTestHistogram(DescribeCustomizeRuleTestHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomizeRuleTestHistogramWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the chart that displays the test results of business data for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomizeRuleTestHistogramRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomizeRuleTestHistogramResponse
        /// </returns>
        public async Task<DescribeCustomizeRuleTestHistogramResponse> DescribeCustomizeRuleTestHistogramAsync(DescribeCustomizeRuleTestHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomizeRuleTestHistogramWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataSourceInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataSourceInstanceResponse
        /// </returns>
        public DescribeDataSourceInstanceResponse DescribeDataSourceInstanceWithOptions(DescribeDataSourceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataSourceInstance",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataSourceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataSourceInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataSourceInstanceResponse
        /// </returns>
        public async Task<DescribeDataSourceInstanceResponse> DescribeDataSourceInstanceWithOptionsAsync(DescribeDataSourceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataSourceInstance",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataSourceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataSourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataSourceInstanceResponse
        /// </returns>
        public DescribeDataSourceInstanceResponse DescribeDataSourceInstance(DescribeDataSourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataSourceInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataSourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataSourceInstanceResponse
        /// </returns>
        public async Task<DescribeDataSourceInstanceResponse> DescribeDataSourceInstanceAsync(DescribeDataSourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataSourceInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parameters of a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataSourceParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataSourceParametersResponse
        /// </returns>
        public DescribeDataSourceParametersResponse DescribeDataSourceParametersWithOptions(DescribeDataSourceParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataSourceParameters",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataSourceParametersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parameters of a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataSourceParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataSourceParametersResponse
        /// </returns>
        public async Task<DescribeDataSourceParametersResponse> DescribeDataSourceParametersWithOptionsAsync(DescribeDataSourceParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataSourceParameters",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataSourceParametersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parameters of a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataSourceParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataSourceParametersResponse
        /// </returns>
        public DescribeDataSourceParametersResponse DescribeDataSourceParameters(DescribeDataSourceParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataSourceParametersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parameters of a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataSourceParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataSourceParametersResponse
        /// </returns>
        public async Task<DescribeDataSourceParametersResponse> DescribeDataSourceParametersAsync(DescribeDataSourceParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataSourceParametersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of entities and playbooks that need to be handled.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisposeAndPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisposeAndPlaybookResponse
        /// </returns>
        public DescribeDisposeAndPlaybookResponse DescribeDisposeAndPlaybookWithOptions(DescribeDisposeAndPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                body["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityUuid))
            {
                body["EntityUuid"] = request.EntityUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDisposeAndPlaybook",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDisposeAndPlaybookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of entities and playbooks that need to be handled.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisposeAndPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisposeAndPlaybookResponse
        /// </returns>
        public async Task<DescribeDisposeAndPlaybookResponse> DescribeDisposeAndPlaybookWithOptionsAsync(DescribeDisposeAndPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                body["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityUuid))
            {
                body["EntityUuid"] = request.EntityUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDisposeAndPlaybook",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDisposeAndPlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of entities and playbooks that need to be handled.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisposeAndPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisposeAndPlaybookResponse
        /// </returns>
        public DescribeDisposeAndPlaybookResponse DescribeDisposeAndPlaybook(DescribeDisposeAndPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDisposeAndPlaybookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of entities and playbooks that need to be handled.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisposeAndPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisposeAndPlaybookResponse
        /// </returns>
        public async Task<DescribeDisposeAndPlaybookResponse> DescribeDisposeAndPlaybookAsync(DescribeDisposeAndPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDisposeAndPlaybookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of playbooks that are used by a handling policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisposeStrategyPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisposeStrategyPlaybookResponse
        /// </returns>
        public DescribeDisposeStrategyPlaybookResponse DescribeDisposeStrategyPlaybookWithOptions(DescribeDisposeStrategyPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDisposeStrategyPlaybook",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDisposeStrategyPlaybookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of playbooks that are used by a handling policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisposeStrategyPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisposeStrategyPlaybookResponse
        /// </returns>
        public async Task<DescribeDisposeStrategyPlaybookResponse> DescribeDisposeStrategyPlaybookWithOptionsAsync(DescribeDisposeStrategyPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDisposeStrategyPlaybook",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDisposeStrategyPlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of playbooks that are used by a handling policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisposeStrategyPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisposeStrategyPlaybookResponse
        /// </returns>
        public DescribeDisposeStrategyPlaybookResponse DescribeDisposeStrategyPlaybook(DescribeDisposeStrategyPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDisposeStrategyPlaybookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of playbooks that are used by a handling policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisposeStrategyPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisposeStrategyPlaybookResponse
        /// </returns>
        public async Task<DescribeDisposeStrategyPlaybookResponse> DescribeDisposeStrategyPlaybookAsync(DescribeDisposeStrategyPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDisposeStrategyPlaybookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an entity.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEntityInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEntityInfoResponse
        /// </returns>
        public DescribeEntityInfoResponse DescribeEntityInfoWithOptions(DescribeEntityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityIdentity))
            {
                body["EntityIdentity"] = request.EntityIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SophonTaskId))
            {
                body["SophonTaskId"] = request.SophonTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEntityInfo",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEntityInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an entity.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEntityInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEntityInfoResponse
        /// </returns>
        public async Task<DescribeEntityInfoResponse> DescribeEntityInfoWithOptionsAsync(DescribeEntityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityIdentity))
            {
                body["EntityIdentity"] = request.EntityIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SophonTaskId))
            {
                body["SophonTaskId"] = request.SophonTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEntityInfo",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEntityInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an entity.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEntityInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEntityInfoResponse
        /// </returns>
        public DescribeEntityInfoResponse DescribeEntityInfo(DescribeEntityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEntityInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an entity.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEntityInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEntityInfoResponse
        /// </returns>
        public async Task<DescribeEntityInfoResponse> DescribeEntityInfoAsync(DescribeEntityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEntityInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of events by type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventCountByThreatLevelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventCountByThreatLevelResponse
        /// </returns>
        public DescribeEventCountByThreatLevelResponse DescribeEventCountByThreatLevelWithOptions(DescribeEventCountByThreatLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEventCountByThreatLevel",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventCountByThreatLevelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of events by type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventCountByThreatLevelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventCountByThreatLevelResponse
        /// </returns>
        public async Task<DescribeEventCountByThreatLevelResponse> DescribeEventCountByThreatLevelWithOptionsAsync(DescribeEventCountByThreatLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEventCountByThreatLevel",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventCountByThreatLevelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of events by type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventCountByThreatLevelRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventCountByThreatLevelResponse
        /// </returns>
        public DescribeEventCountByThreatLevelResponse DescribeEventCountByThreatLevel(DescribeEventCountByThreatLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventCountByThreatLevelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of events by type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventCountByThreatLevelRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventCountByThreatLevelResponse
        /// </returns>
        public async Task<DescribeEventCountByThreatLevelResponse> DescribeEventCountByThreatLevelAsync(DescribeEventCountByThreatLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventCountByThreatLevelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling policies of a historical event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventDisposeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventDisposeResponse
        /// </returns>
        public DescribeEventDisposeResponse DescribeEventDisposeWithOptions(DescribeEventDisposeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEventDispose",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventDisposeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling policies of a historical event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventDisposeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventDisposeResponse
        /// </returns>
        public async Task<DescribeEventDisposeResponse> DescribeEventDisposeWithOptionsAsync(DescribeEventDisposeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEventDispose",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventDisposeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling policies of a historical event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventDisposeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventDisposeResponse
        /// </returns>
        public DescribeEventDisposeResponse DescribeEventDispose(DescribeEventDisposeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventDisposeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling policies of a historical event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventDisposeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventDisposeResponse
        /// </returns>
        public async Task<DescribeEventDisposeResponse> DescribeEventDisposeAsync(DescribeEventDisposeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventDisposeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of logs that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImportedLogCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeImportedLogCountResponse
        /// </returns>
        public DescribeImportedLogCountResponse DescribeImportedLogCountWithOptions(DescribeImportedLogCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImportedLogCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImportedLogCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of logs that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImportedLogCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeImportedLogCountResponse
        /// </returns>
        public async Task<DescribeImportedLogCountResponse> DescribeImportedLogCountWithOptionsAsync(DescribeImportedLogCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImportedLogCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImportedLogCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of logs that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImportedLogCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeImportedLogCountResponse
        /// </returns>
        public DescribeImportedLogCountResponse DescribeImportedLogCount(DescribeImportedLogCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImportedLogCountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of logs that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImportedLogCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeImportedLogCountResponse
        /// </returns>
        public async Task<DescribeImportedLogCountResponse> DescribeImportedLogCountAsync(DescribeImportedLogCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImportedLogCountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the fields that can be configured for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogFieldsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogFieldsResponse
        /// </returns>
        public DescribeLogFieldsResponse DescribeLogFieldsWithOptions(DescribeLogFieldsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["LogSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogFields",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogFieldsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the fields that can be configured for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogFieldsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogFieldsResponse
        /// </returns>
        public async Task<DescribeLogFieldsResponse> DescribeLogFieldsWithOptionsAsync(DescribeLogFieldsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["LogSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogFields",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogFieldsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the fields that can be configured for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogFieldsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogFieldsResponse
        /// </returns>
        public DescribeLogFieldsResponse DescribeLogFields(DescribeLogFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogFieldsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the fields that can be configured for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogFieldsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogFieldsResponse
        /// </returns>
        public async Task<DescribeLogFieldsResponse> DescribeLogFieldsAsync(DescribeLogFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogFieldsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log sources that can be configured for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogSourceResponse
        /// </returns>
        public DescribeLogSourceResponse DescribeLogSourceWithOptions(DescribeLogSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log sources that can be configured for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogSourceResponse
        /// </returns>
        public async Task<DescribeLogSourceResponse> DescribeLogSourceWithOptionsAsync(DescribeLogSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log sources that can be configured for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogSourceResponse
        /// </returns>
        public DescribeLogSourceResponse DescribeLogSource(DescribeLogSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log sources that can be configured for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogSourceResponse
        /// </returns>
        public async Task<DescribeLogSourceResponse> DescribeLogSourceAsync(DescribeLogSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log types that can be configured for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogTypeResponse
        /// </returns>
        public DescribeLogTypeResponse DescribeLogTypeWithOptions(DescribeLogTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogType",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log types that can be configured for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogTypeResponse
        /// </returns>
        public async Task<DescribeLogTypeResponse> DescribeLogTypeWithOptionsAsync(DescribeLogTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogType",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log types that can be configured for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogTypeResponse
        /// </returns>
        public DescribeLogTypeResponse DescribeLogType(DescribeLogTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log types that can be configured for a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLogTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogTypeResponse
        /// </returns>
        public async Task<DescribeLogTypeResponse> DescribeLogTypeAsync(DescribeLogTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operator of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOperatorsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOperatorsResponse
        /// </returns>
        public DescribeOperatorsResponse DescribeOperatorsWithOptions(DescribeOperatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                body["SceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOperators",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOperatorsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operator of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOperatorsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOperatorsResponse
        /// </returns>
        public async Task<DescribeOperatorsResponse> DescribeOperatorsWithOptionsAsync(DescribeOperatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                body["SceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOperators",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOperatorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operator of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOperatorsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOperatorsResponse
        /// </returns>
        public DescribeOperatorsResponse DescribeOperators(DescribeOperatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOperatorsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operator of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOperatorsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOperatorsResponse
        /// </returns>
        public async Task<DescribeOperatorsResponse> DescribeOperatorsAsync(DescribeOperatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOperatorsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of services that can be added to the threat analysis feature in Alibaba Cloud, Tenant Cloud, and Huawei Cloud.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProdCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProdCountResponse
        /// </returns>
        public DescribeProdCountResponse DescribeProdCountWithOptions(DescribeProdCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProdCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProdCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of services that can be added to the threat analysis feature in Alibaba Cloud, Tenant Cloud, and Huawei Cloud.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProdCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProdCountResponse
        /// </returns>
        public async Task<DescribeProdCountResponse> DescribeProdCountWithOptionsAsync(DescribeProdCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProdCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProdCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of services that can be added to the threat analysis feature in Alibaba Cloud, Tenant Cloud, and Huawei Cloud.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProdCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProdCountResponse
        /// </returns>
        public DescribeProdCountResponse DescribeProdCount(DescribeProdCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProdCountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of services that can be added to the threat analysis feature in Alibaba Cloud, Tenant Cloud, and Huawei Cloud.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProdCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProdCountResponse
        /// </returns>
        public async Task<DescribeProdCountResponse> DescribeProdCountAsync(DescribeProdCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProdCountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of users in the playbook scope.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScopeUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScopeUsersResponse
        /// </returns>
        public DescribeScopeUsersResponse DescribeScopeUsersWithOptions(DescribeScopeUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScopeUsers",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScopeUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of users in the playbook scope.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScopeUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScopeUsersResponse
        /// </returns>
        public async Task<DescribeScopeUsersResponse> DescribeScopeUsersWithOptionsAsync(DescribeScopeUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScopeUsers",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScopeUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of users in the playbook scope.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScopeUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScopeUsersResponse
        /// </returns>
        public DescribeScopeUsersResponse DescribeScopeUsers(DescribeScopeUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScopeUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of users in the playbook scope.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScopeUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScopeUsersResponse
        /// </returns>
        public async Task<DescribeScopeUsersResponse> DescribeScopeUsersAsync(DescribeScopeUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScopeUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the threat analysis feature is authorized to access a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceStatusResponse
        /// </returns>
        public DescribeServiceStatusResponse DescribeServiceStatusWithOptions(DescribeServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the threat analysis feature is authorized to access a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceStatusResponse
        /// </returns>
        public async Task<DescribeServiceStatusResponse> DescribeServiceStatusWithOptionsAsync(DescribeServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the threat analysis feature is authorized to access a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceStatusResponse
        /// </returns>
        public DescribeServiceStatusResponse DescribeServiceStatus(DescribeServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the threat analysis feature is authorized to access a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceStatusResponse
        /// </returns>
        public async Task<DescribeServiceStatusResponse> DescribeServiceStatusAsync(DescribeServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Logstores for the threat analysis feature in Simple Log Service on the user side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStorageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeStorageResponse
        /// </returns>
        public DescribeStorageResponse DescribeStorageWithOptions(DescribeStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStorage",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStorageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Logstores for the threat analysis feature in Simple Log Service on the user side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStorageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeStorageResponse
        /// </returns>
        public async Task<DescribeStorageResponse> DescribeStorageWithOptionsAsync(DescribeStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStorage",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStorageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Logstores for the threat analysis feature in Simple Log Service on the user side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeStorageResponse
        /// </returns>
        public DescribeStorageResponse DescribeStorage(DescribeStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStorageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Logstores for the threat analysis feature in Simple Log Service on the user side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeStorageResponse
        /// </returns>
        public async Task<DescribeStorageResponse> DescribeStorageAsync(DescribeStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStorageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the current Alibaba Cloud account or the management account of a resource directory is used to purchase the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserBuyStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserBuyStatusResponse
        /// </returns>
        public DescribeUserBuyStatusResponse DescribeUserBuyStatusWithOptions(DescribeUserBuyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserBuyStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserBuyStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the current Alibaba Cloud account or the management account of a resource directory is used to purchase the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserBuyStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserBuyStatusResponse
        /// </returns>
        public async Task<DescribeUserBuyStatusResponse> DescribeUserBuyStatusWithOptionsAsync(DescribeUserBuyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserBuyStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserBuyStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the current Alibaba Cloud account or the management account of a resource directory is used to purchase the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserBuyStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserBuyStatusResponse
        /// </returns>
        public DescribeUserBuyStatusResponse DescribeUserBuyStatus(DescribeUserBuyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserBuyStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the current Alibaba Cloud account or the management account of a resource directory is used to purchase the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserBuyStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserBuyStatusResponse
        /// </returns>
        public async Task<DescribeUserBuyStatusResponse> DescribeUserBuyStatusAsync(DescribeUserBuyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserBuyStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the protected domain names of the WAF instance for a user to which an entity belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWafScopeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWafScopeResponse
        /// </returns>
        public DescribeWafScopeResponse DescribeWafScopeWithOptions(DescribeWafScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWafScope",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWafScopeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the protected domain names of the WAF instance for a user to which an entity belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWafScopeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWafScopeResponse
        /// </returns>
        public async Task<DescribeWafScopeResponse> DescribeWafScopeWithOptionsAsync(DescribeWafScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWafScope",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWafScopeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the protected domain names of the WAF instance for a user to which an entity belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWafScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWafScopeResponse
        /// </returns>
        public DescribeWafScopeResponse DescribeWafScope(DescribeWafScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWafScopeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the protected domain names of the WAF instance for a user to which an entity belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWafScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWafScopeResponse
        /// </returns>
        public async Task<DescribeWafScopeResponse> DescribeWafScopeAsync(DescribeWafScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWafScopeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of whitelist rules for alerts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWhiteRuleListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWhiteRuleListResponse
        /// </returns>
        public DescribeWhiteRuleListResponse DescribeWhiteRuleListWithOptions(DescribeWhiteRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertName))
            {
                body["AlertName"] = request.AlertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWhiteRuleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWhiteRuleListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of whitelist rules for alerts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWhiteRuleListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWhiteRuleListResponse
        /// </returns>
        public async Task<DescribeWhiteRuleListResponse> DescribeWhiteRuleListWithOptionsAsync(DescribeWhiteRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertName))
            {
                body["AlertName"] = request.AlertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWhiteRuleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWhiteRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of whitelist rules for alerts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWhiteRuleListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWhiteRuleListResponse
        /// </returns>
        public DescribeWhiteRuleListResponse DescribeWhiteRuleList(DescribeWhiteRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWhiteRuleListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of whitelist rules for alerts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeWhiteRuleListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWhiteRuleListResponse
        /// </returns>
        public async Task<DescribeWhiteRuleListResponse> DescribeWhiteRuleListAsync(DescribeWhiteRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWhiteRuleListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service-linked role named AliyunServiceRoleForSasCloudSiem for the threat analysis feature. The feature can assume this role to access cloud services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableAccessForCloudSiemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableAccessForCloudSiemResponse
        /// </returns>
        public EnableAccessForCloudSiemResponse EnableAccessForCloudSiemWithOptions(EnableAccessForCloudSiemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSubmit))
            {
                body["AutoSubmit"] = request.AutoSubmit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableAccessForCloudSiem",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAccessForCloudSiemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service-linked role named AliyunServiceRoleForSasCloudSiem for the threat analysis feature. The feature can assume this role to access cloud services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableAccessForCloudSiemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableAccessForCloudSiemResponse
        /// </returns>
        public async Task<EnableAccessForCloudSiemResponse> EnableAccessForCloudSiemWithOptionsAsync(EnableAccessForCloudSiemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSubmit))
            {
                body["AutoSubmit"] = request.AutoSubmit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableAccessForCloudSiem",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAccessForCloudSiemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service-linked role named AliyunServiceRoleForSasCloudSiem for the threat analysis feature. The feature can assume this role to access cloud services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableAccessForCloudSiemRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableAccessForCloudSiemResponse
        /// </returns>
        public EnableAccessForCloudSiemResponse EnableAccessForCloudSiem(EnableAccessForCloudSiemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableAccessForCloudSiemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service-linked role named AliyunServiceRoleForSasCloudSiem for the threat analysis feature. The feature can assume this role to access cloud services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableAccessForCloudSiemRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableAccessForCloudSiemResponse
        /// </returns>
        public async Task<EnableAccessForCloudSiemResponse> EnableAccessForCloudSiemAsync(EnableAccessForCloudSiemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableAccessForCloudSiemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authorizes the threat analysis feature to access a resource directory. This operation must be called by the management account of the resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableServiceForCloudSiemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableServiceForCloudSiemResponse
        /// </returns>
        public EnableServiceForCloudSiemResponse EnableServiceForCloudSiemWithOptions(EnableServiceForCloudSiemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableServiceForCloudSiem",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableServiceForCloudSiemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authorizes the threat analysis feature to access a resource directory. This operation must be called by the management account of the resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableServiceForCloudSiemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableServiceForCloudSiemResponse
        /// </returns>
        public async Task<EnableServiceForCloudSiemResponse> EnableServiceForCloudSiemWithOptionsAsync(EnableServiceForCloudSiemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableServiceForCloudSiem",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableServiceForCloudSiemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authorizes the threat analysis feature to access a resource directory. This operation must be called by the management account of the resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableServiceForCloudSiemRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableServiceForCloudSiemResponse
        /// </returns>
        public EnableServiceForCloudSiemResponse EnableServiceForCloudSiem(EnableServiceForCloudSiemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableServiceForCloudSiemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Authorizes the threat analysis feature to access a resource directory. This operation must be called by the management account of the resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableServiceForCloudSiemRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableServiceForCloudSiemResponse
        /// </returns>
        public async Task<EnableServiceForCloudSiemResponse> EnableServiceForCloudSiemAsync(EnableServiceForCloudSiemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableServiceForCloudSiemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage capacity usage of the threat analysis feature and the purchased storage capacity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCapacityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCapacityResponse
        /// </returns>
        public GetCapacityResponse GetCapacityWithOptions(GetCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCapacity",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCapacityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage capacity usage of the threat analysis feature and the purchased storage capacity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCapacityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCapacityResponse
        /// </returns>
        public async Task<GetCapacityResponse> GetCapacityWithOptionsAsync(GetCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCapacity",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCapacityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage capacity usage of the threat analysis feature and the purchased storage capacity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCapacityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCapacityResponse
        /// </returns>
        public GetCapacityResponse GetCapacity(GetCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCapacityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage capacity usage of the threat analysis feature and the purchased storage capacity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCapacityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCapacityResponse
        /// </returns>
        public async Task<GetCapacityResponse> GetCapacityAsync(GetCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCapacityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage configurations for the threat analysis feature on the user side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStorageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStorageResponse
        /// </returns>
        public GetStorageResponse GetStorageWithOptions(GetStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStorage",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStorageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage configurations for the threat analysis feature on the user side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStorageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStorageResponse
        /// </returns>
        public async Task<GetStorageResponse> GetStorageWithOptionsAsync(GetStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStorage",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStorageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage configurations for the threat analysis feature on the user side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStorageResponse
        /// </returns>
        public GetStorageResponse GetStorage(GetStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStorageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage configurations for the threat analysis feature on the user side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStorageResponse
        /// </returns>
        public async Task<GetStorageResponse> GetStorageAsync(GetStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStorageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of AccessKey IDs of third-party cloud accounts that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccountAccessIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccountAccessIdResponse
        /// </returns>
        public ListAccountAccessIdResponse ListAccountAccessIdWithOptions(ListAccountAccessIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccountAccessId",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountAccessIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of AccessKey IDs of third-party cloud accounts that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccountAccessIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccountAccessIdResponse
        /// </returns>
        public async Task<ListAccountAccessIdResponse> ListAccountAccessIdWithOptionsAsync(ListAccountAccessIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccountAccessId",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountAccessIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of AccessKey IDs of third-party cloud accounts that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccountAccessIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccountAccessIdResponse
        /// </returns>
        public ListAccountAccessIdResponse ListAccountAccessId(ListAccountAccessIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccountAccessIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of AccessKey IDs of third-party cloud accounts that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccountAccessIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccountAccessIdResponse
        /// </returns>
        public async Task<ListAccountAccessIdResponse> ListAccountAccessIdAsync(ListAccountAccessIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccountAccessIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query accounts by log.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccountsByLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccountsByLogResponse
        /// </returns>
        public ListAccountsByLogResponse ListAccountsByLogWithOptions(ListAccountsByLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCodes))
            {
                body["LogCodes"] = request.LogCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                body["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccountsByLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountsByLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query accounts by log.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccountsByLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccountsByLogResponse
        /// </returns>
        public async Task<ListAccountsByLogResponse> ListAccountsByLogWithOptionsAsync(ListAccountsByLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCodes))
            {
                body["LogCodes"] = request.LogCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                body["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccountsByLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountsByLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query accounts by log.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccountsByLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccountsByLogResponse
        /// </returns>
        public ListAccountsByLogResponse ListAccountsByLog(ListAccountsByLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccountsByLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query accounts by log.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccountsByLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccountsByLogResponse
        /// </returns>
        public async Task<ListAccountsByLogResponse> ListAccountsByLogAsync(ListAccountsByLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccountsByLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of cloud services that can be added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllProdsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllProdsResponse
        /// </returns>
        public ListAllProdsResponse ListAllProdsWithOptions(ListAllProdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllProds",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllProdsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of cloud services that can be added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllProdsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllProdsResponse
        /// </returns>
        public async Task<ListAllProdsResponse> ListAllProdsWithOptionsAsync(ListAllProdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllProds",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllProdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of cloud services that can be added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllProdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllProdsResponse
        /// </returns>
        public ListAllProdsResponse ListAllProds(ListAllProdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllProdsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of cloud services that can be added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllProdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllProdsResponse
        /// </returns>
        public async Task<ListAllProdsResponse> ListAllProdsAsync(ListAllProdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllProdsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries automated response rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutomateResponseConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAutomateResponseConfigsResponse
        /// </returns>
        public ListAutomateResponseConfigsResponse ListAutomateResponseConfigsWithOptions(ListAutomateResponseConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoResponseType))
            {
                body["AutoResponseType"] = request.AutoResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseRuleType))
            {
                body["ResponseRuleType"] = request.ResponseRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAutomateResponseConfigs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAutomateResponseConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries automated response rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutomateResponseConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAutomateResponseConfigsResponse
        /// </returns>
        public async Task<ListAutomateResponseConfigsResponse> ListAutomateResponseConfigsWithOptionsAsync(ListAutomateResponseConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoResponseType))
            {
                body["AutoResponseType"] = request.AutoResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseRuleType))
            {
                body["ResponseRuleType"] = request.ResponseRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAutomateResponseConfigs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAutomateResponseConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries automated response rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutomateResponseConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAutomateResponseConfigsResponse
        /// </returns>
        public ListAutomateResponseConfigsResponse ListAutomateResponseConfigs(ListAutomateResponseConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAutomateResponseConfigsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries automated response rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAutomateResponseConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAutomateResponseConfigsResponse
        /// </returns>
        public async Task<ListAutomateResponseConfigsResponse> ListAutomateResponseConfigsAsync(ListAutomateResponseConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAutomateResponseConfigsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of cloud accounts that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBindAccountResponse
        /// </returns>
        public ListBindAccountResponse ListBindAccountWithOptions(ListBindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindAccount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of cloud accounts that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBindAccountResponse
        /// </returns>
        public async Task<ListBindAccountResponse> ListBindAccountWithOptionsAsync(ListBindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindAccount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of cloud accounts that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBindAccountResponse
        /// </returns>
        public ListBindAccountResponse ListBindAccount(ListBindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBindAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of cloud accounts that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBindAccountResponse
        /// </returns>
        public async Task<ListBindAccountResponse> ListBindAccountAsync(ListBindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBindAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data sources that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindDataSourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBindDataSourcesResponse
        /// </returns>
        public ListBindDataSourcesResponse ListBindDataSourcesWithOptions(ListBindDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindDataSources",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindDataSourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data sources that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindDataSourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBindDataSourcesResponse
        /// </returns>
        public async Task<ListBindDataSourcesResponse> ListBindDataSourcesWithOptionsAsync(ListBindDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindDataSources",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindDataSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data sources that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindDataSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBindDataSourcesResponse
        /// </returns>
        public ListBindDataSourcesResponse ListBindDataSources(ListBindDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBindDataSourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data sources that are added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindDataSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBindDataSourcesResponse
        /// </returns>
        public async Task<ListBindDataSourcesResponse> ListBindDataSourcesAsync(ListBindDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBindDataSourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries custom rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloudSiemCustomizeRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCloudSiemCustomizeRulesResponse
        /// </returns>
        public ListCloudSiemCustomizeRulesResponse ListCloudSiemCustomizeRulesWithOptions(ListCloudSiemCustomizeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloudSiemCustomizeRules",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloudSiemCustomizeRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries custom rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloudSiemCustomizeRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCloudSiemCustomizeRulesResponse
        /// </returns>
        public async Task<ListCloudSiemCustomizeRulesResponse> ListCloudSiemCustomizeRulesWithOptionsAsync(ListCloudSiemCustomizeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloudSiemCustomizeRules",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloudSiemCustomizeRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries custom rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloudSiemCustomizeRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCloudSiemCustomizeRulesResponse
        /// </returns>
        public ListCloudSiemCustomizeRulesResponse ListCloudSiemCustomizeRules(ListCloudSiemCustomizeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCloudSiemCustomizeRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries custom rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloudSiemCustomizeRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCloudSiemCustomizeRulesResponse
        /// </returns>
        public async Task<ListCloudSiemCustomizeRulesResponse> ListCloudSiemCustomizeRulesAsync(ListCloudSiemCustomizeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCloudSiemCustomizeRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries predefined rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloudSiemPredefinedRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCloudSiemPredefinedRulesResponse
        /// </returns>
        public ListCloudSiemPredefinedRulesResponse ListCloudSiemPredefinedRulesWithOptions(ListCloudSiemPredefinedRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttCk))
            {
                body["AttCk"] = request.AttCk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferType))
            {
                body["EventTransferType"] = request.EventTransferType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["LogSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloudSiemPredefinedRules",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloudSiemPredefinedRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries predefined rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloudSiemPredefinedRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCloudSiemPredefinedRulesResponse
        /// </returns>
        public async Task<ListCloudSiemPredefinedRulesResponse> ListCloudSiemPredefinedRulesWithOptionsAsync(ListCloudSiemPredefinedRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttCk))
            {
                body["AttCk"] = request.AttCk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferType))
            {
                body["EventTransferType"] = request.EventTransferType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["LogSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloudSiemPredefinedRules",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloudSiemPredefinedRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries predefined rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloudSiemPredefinedRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCloudSiemPredefinedRulesResponse
        /// </returns>
        public ListCloudSiemPredefinedRulesResponse ListCloudSiemPredefinedRules(ListCloudSiemPredefinedRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCloudSiemPredefinedRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries predefined rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCloudSiemPredefinedRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCloudSiemPredefinedRulesResponse
        /// </returns>
        public async Task<ListCloudSiemPredefinedRulesResponse> ListCloudSiemPredefinedRulesAsync(ListCloudSiemPredefinedRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCloudSiemPredefinedRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the test results of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomizeRuleTestResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomizeRuleTestResultResponse
        /// </returns>
        public ListCustomizeRuleTestResultResponse ListCustomizeRuleTestResultWithOptions(ListCustomizeRuleTestResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleId))
            {
                body["DetectionRuleId"] = request.DetectionRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                body["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomizeRuleTestResult",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomizeRuleTestResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the test results of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomizeRuleTestResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomizeRuleTestResultResponse
        /// </returns>
        public async Task<ListCustomizeRuleTestResultResponse> ListCustomizeRuleTestResultWithOptionsAsync(ListCustomizeRuleTestResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleId))
            {
                body["DetectionRuleId"] = request.DetectionRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                body["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomizeRuleTestResult",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomizeRuleTestResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the test results of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomizeRuleTestResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomizeRuleTestResultResponse
        /// </returns>
        public ListCustomizeRuleTestResultResponse ListCustomizeRuleTestResult(ListCustomizeRuleTestResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomizeRuleTestResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the test results of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomizeRuleTestResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomizeRuleTestResultResponse
        /// </returns>
        public async Task<ListCustomizeRuleTestResultResponse> ListCustomizeRuleTestResultAsync(ListCustomizeRuleTestResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomizeRuleTestResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSourceLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceLogsResponse
        /// </returns>
        public ListDataSourceLogsResponse ListDataSourceLogsWithOptions(ListDataSourceLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceLogs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSourceLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceLogsResponse
        /// </returns>
        public async Task<ListDataSourceLogsResponse> ListDataSourceLogsWithOptionsAsync(ListDataSourceLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceLogs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSourceLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceLogsResponse
        /// </returns>
        public ListDataSourceLogsResponse ListDataSourceLogs(ListDataSourceLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSourceLogsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSourceLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceLogsResponse
        /// </returns>
        public async Task<ListDataSourceLogsResponse> ListDataSourceLogsAsync(ListDataSourceLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourceLogsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data source types in third-party cloud services that can be added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSourceTypesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceTypesResponse
        /// </returns>
        public ListDataSourceTypesResponse ListDataSourceTypesWithOptions(ListDataSourceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceTypes",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceTypesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data source types in third-party cloud services that can be added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSourceTypesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceTypesResponse
        /// </returns>
        public async Task<ListDataSourceTypesResponse> ListDataSourceTypesWithOptionsAsync(ListDataSourceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceTypes",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data source types in third-party cloud services that can be added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSourceTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceTypesResponse
        /// </returns>
        public ListDataSourceTypesResponse ListDataSourceTypes(ListDataSourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSourceTypesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data source types in third-party cloud services that can be added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSourceTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceTypesResponse
        /// </returns>
        public async Task<ListDataSourceTypesResponse> ListDataSourceTypesAsync(ListDataSourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourceTypesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the cloud services that are integrated with the threat analysis feature, the logs of the cloud services, and the delivery of the logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeliveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeliveryResponse
        /// </returns>
        public ListDeliveryResponse ListDeliveryWithOptions(ListDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDelivery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeliveryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the cloud services that are integrated with the threat analysis feature, the logs of the cloud services, and the delivery of the logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeliveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeliveryResponse
        /// </returns>
        public async Task<ListDeliveryResponse> ListDeliveryWithOptionsAsync(ListDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDelivery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the cloud services that are integrated with the threat analysis feature, the logs of the cloud services, and the delivery of the logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeliveryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeliveryResponse
        /// </returns>
        public ListDeliveryResponse ListDelivery(ListDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeliveryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the cloud services that are integrated with the threat analysis feature, the logs of the cloud services, and the delivery of the logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeliveryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeliveryResponse
        /// </returns>
        public async Task<ListDeliveryResponse> ListDeliveryAsync(ListDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeliveryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries handling policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDisposeStrategyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDisposeStrategyResponse
        /// </returns>
        public ListDisposeStrategyResponse ListDisposeStrategyWithOptions(ListDisposeStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveStatus))
            {
                body["EffectiveStatus"] = request.EffectiveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityIdentity))
            {
                body["EntityIdentity"] = request.EntityIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                body["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookName))
            {
                body["PlaybookName"] = request.PlaybookName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookTypes))
            {
                body["PlaybookTypes"] = request.PlaybookTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SophonTaskId))
            {
                body["SophonTaskId"] = request.SophonTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDisposeStrategy",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDisposeStrategyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries handling policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDisposeStrategyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDisposeStrategyResponse
        /// </returns>
        public async Task<ListDisposeStrategyResponse> ListDisposeStrategyWithOptionsAsync(ListDisposeStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveStatus))
            {
                body["EffectiveStatus"] = request.EffectiveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityIdentity))
            {
                body["EntityIdentity"] = request.EntityIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                body["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookName))
            {
                body["PlaybookName"] = request.PlaybookName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookTypes))
            {
                body["PlaybookTypes"] = request.PlaybookTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SophonTaskId))
            {
                body["SophonTaskId"] = request.SophonTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDisposeStrategy",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDisposeStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries handling policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDisposeStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDisposeStrategyResponse
        /// </returns>
        public ListDisposeStrategyResponse ListDisposeStrategy(ListDisposeStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDisposeStrategyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries handling policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDisposeStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDisposeStrategyResponse
        /// </returns>
        public async Task<ListDisposeStrategyResponse> ListDisposeStrategyAsync(ListDisposeStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDisposeStrategyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries entities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEntitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEntitiesResponse
        /// </returns>
        public ListEntitiesResponse ListEntitiesWithOptions(ListEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityName))
            {
                body["EntityName"] = request.EntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                body["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityUuid))
            {
                body["EntityUuid"] = request.EntityUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityUuids))
            {
                body["EntityUuids"] = request.EntityUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMalwareEntity))
            {
                body["IsMalwareEntity"] = request.IsMalwareEntity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MalwareType))
            {
                body["MalwareType"] = request.MalwareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEntities",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEntitiesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries entities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEntitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEntitiesResponse
        /// </returns>
        public async Task<ListEntitiesResponse> ListEntitiesWithOptionsAsync(ListEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityName))
            {
                body["EntityName"] = request.EntityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                body["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityUuid))
            {
                body["EntityUuid"] = request.EntityUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityUuids))
            {
                body["EntityUuids"] = request.EntityUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMalwareEntity))
            {
                body["IsMalwareEntity"] = request.IsMalwareEntity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MalwareType))
            {
                body["MalwareType"] = request.MalwareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEntities",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEntitiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries entities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEntitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEntitiesResponse
        /// </returns>
        public ListEntitiesResponse ListEntities(ListEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEntitiesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries entities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEntitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEntitiesResponse
        /// </returns>
        public async Task<ListEntitiesResponse> ListEntitiesAsync(ListEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEntitiesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the logs in a cloud service that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImportedLogsByProdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImportedLogsByProdResponse
        /// </returns>
        public ListImportedLogsByProdResponse ListImportedLogsByProdWithOptions(ListImportedLogsByProdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                body["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImportedLogsByProd",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImportedLogsByProdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the logs in a cloud service that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImportedLogsByProdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImportedLogsByProdResponse
        /// </returns>
        public async Task<ListImportedLogsByProdResponse> ListImportedLogsByProdWithOptionsAsync(ListImportedLogsByProdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                body["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImportedLogsByProd",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImportedLogsByProdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the logs in a cloud service that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImportedLogsByProdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImportedLogsByProdResponse
        /// </returns>
        public ListImportedLogsByProdResponse ListImportedLogsByProd(ListImportedLogsByProdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListImportedLogsByProdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the logs in a cloud service that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImportedLogsByProdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImportedLogsByProdResponse
        /// </returns>
        public async Task<ListImportedLogsByProdResponse> ListImportedLogsByProdAsync(ListImportedLogsByProdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListImportedLogsByProdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dedicated Simple Log Service project and Logstore for a cloud service based on the patterns of the project and Logstore names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectLogStoresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectLogStoresResponse
        /// </returns>
        public ListProjectLogStoresResponse ListProjectLogStoresWithOptions(ListProjectLogStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogCode))
            {
                body["SourceLogCode"] = request.SourceLogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProdCode))
            {
                body["SourceProdCode"] = request.SourceProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectLogStores",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectLogStoresResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dedicated Simple Log Service project and Logstore for a cloud service based on the patterns of the project and Logstore names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectLogStoresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectLogStoresResponse
        /// </returns>
        public async Task<ListProjectLogStoresResponse> ListProjectLogStoresWithOptionsAsync(ListProjectLogStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogCode))
            {
                body["SourceLogCode"] = request.SourceLogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProdCode))
            {
                body["SourceProdCode"] = request.SourceProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectLogStores",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectLogStoresResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dedicated Simple Log Service project and Logstore for a cloud service based on the patterns of the project and Logstore names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectLogStoresRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProjectLogStoresResponse
        /// </returns>
        public ListProjectLogStoresResponse ListProjectLogStores(ListProjectLogStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectLogStoresWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dedicated Simple Log Service project and Logstore for a cloud service based on the patterns of the project and Logstore names.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectLogStoresRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProjectLogStoresResponse
        /// </returns>
        public async Task<ListProjectLogStoresResponse> ListProjectLogStoresAsync(ListProjectLogStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectLogStoresWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Alibaba Cloud accounts that are added to the threat analysis feature for centralized management. These accounts can be used to perform operations supported by the threat analysis feature, such as adding logs and handling events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRdUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRdUsersResponse
        /// </returns>
        public ListRdUsersResponse ListRdUsersWithOptions(ListRdUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRdUsers",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRdUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Alibaba Cloud accounts that are added to the threat analysis feature for centralized management. These accounts can be used to perform operations supported by the threat analysis feature, such as adding logs and handling events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRdUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRdUsersResponse
        /// </returns>
        public async Task<ListRdUsersResponse> ListRdUsersWithOptionsAsync(ListRdUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRdUsers",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRdUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Alibaba Cloud accounts that are added to the threat analysis feature for centralized management. These accounts can be used to perform operations supported by the threat analysis feature, such as adding logs and handling events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRdUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRdUsersResponse
        /// </returns>
        public ListRdUsersResponse ListRdUsers(ListRdUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRdUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Alibaba Cloud accounts that are added to the threat analysis feature for centralized management. These accounts can be used to perform operations supported by the threat analysis feature, such as adding logs and handling events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRdUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRdUsersResponse
        /// </returns>
        public async Task<ListRdUsersResponse> ListRdUsersAsync(ListRdUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRdUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a third-party cloud account that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBindAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBindAccountResponse
        /// </returns>
        public ModifyBindAccountResponse ModifyBindAccountWithOptions(ModifyBindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessId))
            {
                body["AccessId"] = request.AccessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindId))
            {
                body["BindId"] = request.BindId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBindAccount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBindAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a third-party cloud account that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBindAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBindAccountResponse
        /// </returns>
        public async Task<ModifyBindAccountResponse> ModifyBindAccountWithOptionsAsync(ModifyBindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessId))
            {
                body["AccessId"] = request.AccessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindId))
            {
                body["BindId"] = request.BindId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBindAccount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBindAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a third-party cloud account that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBindAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBindAccountResponse
        /// </returns>
        public ModifyBindAccountResponse ModifyBindAccount(ModifyBindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBindAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a third-party cloud account that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBindAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBindAccountResponse
        /// </returns>
        public async Task<ModifyBindAccountResponse> ModifyBindAccountAsync(ModifyBindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBindAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a data source that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDataSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataSourceResponse
        /// </returns>
        public ModifyDataSourceResponse ModifyDataSourceWithOptions(ModifyDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceName))
            {
                body["DataSourceInstanceName"] = request.DataSourceInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceParams))
            {
                body["DataSourceInstanceParams"] = request.DataSourceInstanceParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceRemark))
            {
                body["DataSourceInstanceRemark"] = request.DataSourceInstanceRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a data source that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDataSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataSourceResponse
        /// </returns>
        public async Task<ModifyDataSourceResponse> ModifyDataSourceWithOptionsAsync(ModifyDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceName))
            {
                body["DataSourceInstanceName"] = request.DataSourceInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceParams))
            {
                body["DataSourceInstanceParams"] = request.DataSourceInstanceParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceRemark))
            {
                body["DataSourceInstanceRemark"] = request.DataSourceInstanceRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a data source that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataSourceResponse
        /// </returns>
        public ModifyDataSourceResponse ModifyDataSource(ModifyDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDataSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a data source that is added to the threat analysis feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataSourceResponse
        /// </returns>
        public async Task<ModifyDataSourceResponse> ModifyDataSourceAsync(ModifyDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDataSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of the logs that are added to the threat analysis feature for a data source within a cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDataSourceLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataSourceLogResponse
        /// </returns>
        public ModifyDataSourceLogResponse ModifyDataSourceLogWithOptions(ModifyDataSourceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceLogs))
            {
                body["DataSourceInstanceLogs"] = request.DataSourceInstanceLogs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogInstanceId))
            {
                body["LogInstanceId"] = request.LogInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataSourceLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataSourceLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of the logs that are added to the threat analysis feature for a data source within a cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDataSourceLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataSourceLogResponse
        /// </returns>
        public async Task<ModifyDataSourceLogResponse> ModifyDataSourceLogWithOptionsAsync(ModifyDataSourceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceLogs))
            {
                body["DataSourceInstanceLogs"] = request.DataSourceInstanceLogs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogInstanceId))
            {
                body["LogInstanceId"] = request.LogInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataSourceLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataSourceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of the logs that are added to the threat analysis feature for a data source within a cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDataSourceLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataSourceLogResponse
        /// </returns>
        public ModifyDataSourceLogResponse ModifyDataSourceLog(ModifyDataSourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDataSourceLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of the logs that are added to the threat analysis feature for a data source within a cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDataSourceLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataSourceLogResponse
        /// </returns>
        public async Task<ModifyDataSourceLogResponse> ModifyDataSourceLogAsync(ModifyDataSourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDataSourceLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the log delivery feature for a cloud service that is integrated with Simple Log Service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenDeliveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenDeliveryResponse
        /// </returns>
        public OpenDeliveryResponse OpenDeliveryWithOptions(OpenDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenDelivery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenDeliveryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the log delivery feature for a cloud service that is integrated with Simple Log Service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenDeliveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenDeliveryResponse
        /// </returns>
        public async Task<OpenDeliveryResponse> OpenDeliveryWithOptionsAsync(OpenDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenDelivery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the log delivery feature for a cloud service that is integrated with Simple Log Service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenDeliveryRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenDeliveryResponse
        /// </returns>
        public OpenDeliveryResponse OpenDelivery(OpenDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenDeliveryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the log delivery feature for a cloud service that is integrated with Simple Log Service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenDeliveryRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenDeliveryResponse
        /// </returns>
        public async Task<OpenDeliveryResponse> OpenDeliveryAsync(OpenDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenDeliveryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates an automatic response rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostAutomateResponseConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostAutomateResponseConfigResponse
        /// </returns>
        public PostAutomateResponseConfigResponse PostAutomateResponseConfigWithOptions(PostAutomateResponseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionConfig))
            {
                body["ActionConfig"] = request.ActionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoResponseType))
            {
                body["AutoResponseType"] = request.AutoResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionCondition))
            {
                body["ExecutionCondition"] = request.ExecutionCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostAutomateResponseConfig",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostAutomateResponseConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates an automatic response rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostAutomateResponseConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostAutomateResponseConfigResponse
        /// </returns>
        public async Task<PostAutomateResponseConfigResponse> PostAutomateResponseConfigWithOptionsAsync(PostAutomateResponseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionConfig))
            {
                body["ActionConfig"] = request.ActionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoResponseType))
            {
                body["AutoResponseType"] = request.AutoResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionCondition))
            {
                body["ExecutionCondition"] = request.ExecutionCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostAutomateResponseConfig",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostAutomateResponseConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates an automatic response rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostAutomateResponseConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// PostAutomateResponseConfigResponse
        /// </returns>
        public PostAutomateResponseConfigResponse PostAutomateResponseConfig(PostAutomateResponseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostAutomateResponseConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates an automatic response rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostAutomateResponseConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// PostAutomateResponseConfigResponse
        /// </returns>
        public async Task<PostAutomateResponseConfigResponse> PostAutomateResponseConfigAsync(PostAutomateResponseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostAutomateResponseConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostCustomizeRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostCustomizeRuleResponse
        /// </returns>
        public PostCustomizeRuleResponse PostCustomizeRuleWithOptions(PostCustomizeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTypeMds))
            {
                body["AlertTypeMds"] = request.AlertTypeMds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttCk))
            {
                body["AttCk"] = request.AttCk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferExt))
            {
                body["EventTransferExt"] = request.EventTransferExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferSwitch))
            {
                body["EventTransferSwitch"] = request.EventTransferSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferType))
            {
                body["EventTransferType"] = request.EventTransferType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["LogSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSourceMds))
            {
                body["LogSourceMds"] = request.LogSourceMds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogTypeMds))
            {
                body["LogTypeMds"] = request.LogTypeMds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCycle))
            {
                body["QueryCycle"] = request.QueryCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCondition))
            {
                body["RuleCondition"] = request.RuleCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleDesc))
            {
                body["RuleDesc"] = request.RuleDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleGroup))
            {
                body["RuleGroup"] = request.RuleGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleThreshold))
            {
                body["RuleThreshold"] = request.RuleThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostCustomizeRule",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostCustomizeRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostCustomizeRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostCustomizeRuleResponse
        /// </returns>
        public async Task<PostCustomizeRuleResponse> PostCustomizeRuleWithOptionsAsync(PostCustomizeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTypeMds))
            {
                body["AlertTypeMds"] = request.AlertTypeMds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttCk))
            {
                body["AttCk"] = request.AttCk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferExt))
            {
                body["EventTransferExt"] = request.EventTransferExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferSwitch))
            {
                body["EventTransferSwitch"] = request.EventTransferSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferType))
            {
                body["EventTransferType"] = request.EventTransferType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["LogSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSourceMds))
            {
                body["LogSourceMds"] = request.LogSourceMds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogTypeMds))
            {
                body["LogTypeMds"] = request.LogTypeMds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCycle))
            {
                body["QueryCycle"] = request.QueryCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCondition))
            {
                body["RuleCondition"] = request.RuleCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleDesc))
            {
                body["RuleDesc"] = request.RuleDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleGroup))
            {
                body["RuleGroup"] = request.RuleGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleThreshold))
            {
                body["RuleThreshold"] = request.RuleThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostCustomizeRule",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostCustomizeRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostCustomizeRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// PostCustomizeRuleResponse
        /// </returns>
        public PostCustomizeRuleResponse PostCustomizeRule(PostCustomizeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostCustomizeRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostCustomizeRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// PostCustomizeRuleResponse
        /// </returns>
        public async Task<PostCustomizeRuleResponse> PostCustomizeRuleAsync(PostCustomizeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostCustomizeRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a custom rule for testing.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostCustomizeRuleTestRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostCustomizeRuleTestResponse
        /// </returns>
        public PostCustomizeRuleTestResponse PostCustomizeRuleTestWithOptions(PostCustomizeRuleTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimulatedData))
            {
                body["SimulatedData"] = request.SimulatedData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestType))
            {
                body["TestType"] = request.TestType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostCustomizeRuleTest",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostCustomizeRuleTestResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a custom rule for testing.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostCustomizeRuleTestRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostCustomizeRuleTestResponse
        /// </returns>
        public async Task<PostCustomizeRuleTestResponse> PostCustomizeRuleTestWithOptionsAsync(PostCustomizeRuleTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimulatedData))
            {
                body["SimulatedData"] = request.SimulatedData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestType))
            {
                body["TestType"] = request.TestType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostCustomizeRuleTest",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostCustomizeRuleTestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a custom rule for testing.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostCustomizeRuleTestRequest
        /// </param>
        /// 
        /// <returns>
        /// PostCustomizeRuleTestResponse
        /// </returns>
        public PostCustomizeRuleTestResponse PostCustomizeRuleTest(PostCustomizeRuleTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostCustomizeRuleTestWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a custom rule for testing.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostCustomizeRuleTestRequest
        /// </param>
        /// 
        /// <returns>
        /// PostCustomizeRuleTestResponse
        /// </returns>
        public async Task<PostCustomizeRuleTestResponse> PostCustomizeRuleTestAsync(PostCustomizeRuleTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostCustomizeRuleTestWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits event handling information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostEventDisposeAndWhiteruleListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostEventDisposeAndWhiteruleListResponse
        /// </returns>
        public PostEventDisposeAndWhiteruleListResponse PostEventDisposeAndWhiteruleListWithOptions(PostEventDisposeAndWhiteruleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisposeStrategyIds))
            {
                body["DisposeStrategyIds"] = request.DisposeStrategyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventDispose))
            {
                body["EventDispose"] = request.EventDispose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverInfo))
            {
                body["ReceiverInfo"] = request.ReceiverInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseSource))
            {
                body["ResponseSource"] = request.ResponseSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostEventDisposeAndWhiteruleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostEventDisposeAndWhiteruleListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits event handling information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostEventDisposeAndWhiteruleListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostEventDisposeAndWhiteruleListResponse
        /// </returns>
        public async Task<PostEventDisposeAndWhiteruleListResponse> PostEventDisposeAndWhiteruleListWithOptionsAsync(PostEventDisposeAndWhiteruleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisposeStrategyIds))
            {
                body["DisposeStrategyIds"] = request.DisposeStrategyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventDispose))
            {
                body["EventDispose"] = request.EventDispose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                body["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverInfo))
            {
                body["ReceiverInfo"] = request.ReceiverInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseSource))
            {
                body["ResponseSource"] = request.ResponseSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostEventDisposeAndWhiteruleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostEventDisposeAndWhiteruleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits event handling information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostEventDisposeAndWhiteruleListRequest
        /// </param>
        /// 
        /// <returns>
        /// PostEventDisposeAndWhiteruleListResponse
        /// </returns>
        public PostEventDisposeAndWhiteruleListResponse PostEventDisposeAndWhiteruleList(PostEventDisposeAndWhiteruleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostEventDisposeAndWhiteruleListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits event handling information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostEventDisposeAndWhiteruleListRequest
        /// </param>
        /// 
        /// <returns>
        /// PostEventDisposeAndWhiteruleListResponse
        /// </returns>
        public async Task<PostEventDisposeAndWhiteruleListResponse> PostEventDisposeAndWhiteruleListAsync(PostEventDisposeAndWhiteruleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostEventDisposeAndWhiteruleListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an alert whitelist rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostEventWhiteruleListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostEventWhiteruleListResponse
        /// </returns>
        public PostEventWhiteruleListResponse PostEventWhiteruleListWithOptions(PostEventWhiteruleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteruleList))
            {
                body["WhiteruleList"] = request.WhiteruleList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostEventWhiteruleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostEventWhiteruleListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an alert whitelist rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostEventWhiteruleListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostEventWhiteruleListResponse
        /// </returns>
        public async Task<PostEventWhiteruleListResponse> PostEventWhiteruleListWithOptionsAsync(PostEventWhiteruleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteruleList))
            {
                body["WhiteruleList"] = request.WhiteruleList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostEventWhiteruleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostEventWhiteruleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an alert whitelist rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostEventWhiteruleListRequest
        /// </param>
        /// 
        /// <returns>
        /// PostEventWhiteruleListResponse
        /// </returns>
        public PostEventWhiteruleListResponse PostEventWhiteruleList(PostEventWhiteruleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostEventWhiteruleListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an alert whitelist rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostEventWhiteruleListRequest
        /// </param>
        /// 
        /// <returns>
        /// PostEventWhiteruleListResponse
        /// </returns>
        public async Task<PostEventWhiteruleListResponse> PostEventWhiteruleListAsync(PostEventWhiteruleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostEventWhiteruleListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Ends the test of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostFinishCustomizeRuleTestRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostFinishCustomizeRuleTestResponse
        /// </returns>
        public PostFinishCustomizeRuleTestResponse PostFinishCustomizeRuleTestWithOptions(PostFinishCustomizeRuleTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostFinishCustomizeRuleTest",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostFinishCustomizeRuleTestResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Ends the test of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostFinishCustomizeRuleTestRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostFinishCustomizeRuleTestResponse
        /// </returns>
        public async Task<PostFinishCustomizeRuleTestResponse> PostFinishCustomizeRuleTestWithOptionsAsync(PostFinishCustomizeRuleTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostFinishCustomizeRuleTest",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostFinishCustomizeRuleTestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Ends the test of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostFinishCustomizeRuleTestRequest
        /// </param>
        /// 
        /// <returns>
        /// PostFinishCustomizeRuleTestResponse
        /// </returns>
        public PostFinishCustomizeRuleTestResponse PostFinishCustomizeRuleTest(PostFinishCustomizeRuleTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostFinishCustomizeRuleTestWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Ends the test of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostFinishCustomizeRuleTestRequest
        /// </param>
        /// 
        /// <returns>
        /// PostFinishCustomizeRuleTestResponse
        /// </returns>
        public async Task<PostFinishCustomizeRuleTestResponse> PostFinishCustomizeRuleTestAsync(PostFinishCustomizeRuleTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostFinishCustomizeRuleTestWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostRuleStatusChangeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostRuleStatusChangeResponse
        /// </returns>
        public PostRuleStatusChangeResponse PostRuleStatusChangeWithOptions(PostRuleStatusChangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InUse))
            {
                body["InUse"] = request.InUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostRuleStatusChange",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostRuleStatusChangeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostRuleStatusChangeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PostRuleStatusChangeResponse
        /// </returns>
        public async Task<PostRuleStatusChangeResponse> PostRuleStatusChangeWithOptionsAsync(PostRuleStatusChangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InUse))
            {
                body["InUse"] = request.InUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostRuleStatusChange",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostRuleStatusChangeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostRuleStatusChangeRequest
        /// </param>
        /// 
        /// <returns>
        /// PostRuleStatusChangeResponse
        /// </returns>
        public PostRuleStatusChangeResponse PostRuleStatusChange(PostRuleStatusChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostRuleStatusChangeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of a custom rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PostRuleStatusChangeRequest
        /// </param>
        /// 
        /// <returns>
        /// PostRuleStatusChangeResponse
        /// </returns>
        public async Task<PostRuleStatusChangeResponse> PostRuleStatusChangeAsync(PostRuleStatusChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostRuleStatusChangeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases storage to reduce the storage usage. The release operation is irreversible and may cause data loss. Proceed with caution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreCapacityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestoreCapacityResponse
        /// </returns>
        public RestoreCapacityResponse RestoreCapacityWithOptions(RestoreCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreCapacity",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreCapacityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases storage to reduce the storage usage. The release operation is irreversible and may cause data loss. Proceed with caution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreCapacityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestoreCapacityResponse
        /// </returns>
        public async Task<RestoreCapacityResponse> RestoreCapacityWithOptionsAsync(RestoreCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreCapacity",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreCapacityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases storage to reduce the storage usage. The release operation is irreversible and may cause data loss. Proceed with caution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreCapacityRequest
        /// </param>
        /// 
        /// <returns>
        /// RestoreCapacityResponse
        /// </returns>
        public RestoreCapacityResponse RestoreCapacity(RestoreCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreCapacityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases storage to reduce the storage usage. The release operation is irreversible and may cause data loss. Proceed with caution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreCapacityRequest
        /// </param>
        /// 
        /// <returns>
        /// RestoreCapacityResponse
        /// </returns>
        public async Task<RestoreCapacityResponse> RestoreCapacityAsync(RestoreCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreCapacityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the settings of log storage, such as the storage duration and storage region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetStorageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetStorageResponse
        /// </returns>
        public SetStorageResponse SetStorageWithOptions(SetStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["Ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetStorage",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetStorageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the settings of log storage, such as the storage duration and storage region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetStorageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetStorageResponse
        /// </returns>
        public async Task<SetStorageResponse> SetStorageWithOptionsAsync(SetStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["Ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetStorage",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetStorageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the settings of log storage, such as the storage duration and storage region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// SetStorageResponse
        /// </returns>
        public SetStorageResponse SetStorage(SetStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetStorageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the settings of log storage, such as the storage duration and storage region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// SetStorageResponse
        /// </returns>
        public async Task<SetStorageResponse> SetStorageAsync(SetStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetStorageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits log collection tasks at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImportLogTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitImportLogTasksResponse
        /// </returns>
        public SubmitImportLogTasksResponse SubmitImportLogTasksWithOptions(SubmitImportLogTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accounts))
            {
                body["Accounts"] = request.Accounts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoImported))
            {
                body["AutoImported"] = request.AutoImported;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCodes))
            {
                body["LogCodes"] = request.LogCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                body["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitImportLogTasks",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitImportLogTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits log collection tasks at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImportLogTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitImportLogTasksResponse
        /// </returns>
        public async Task<SubmitImportLogTasksResponse> SubmitImportLogTasksWithOptionsAsync(SubmitImportLogTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accounts))
            {
                body["Accounts"] = request.Accounts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoImported))
            {
                body["AutoImported"] = request.AutoImported;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCodes))
            {
                body["LogCodes"] = request.LogCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                body["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitImportLogTasks",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitImportLogTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits log collection tasks at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImportLogTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitImportLogTasksResponse
        /// </returns>
        public SubmitImportLogTasksResponse SubmitImportLogTasks(SubmitImportLogTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitImportLogTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits log collection tasks at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImportLogTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitImportLogTasksResponse
        /// </returns>
        public async Task<SubmitImportLogTasksResponse> SubmitImportLogTasksAsync(SubmitImportLogTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitImportLogTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of an automatic response rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAutomateResponseConfigStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutomateResponseConfigStatusResponse
        /// </returns>
        public UpdateAutomateResponseConfigStatusResponse UpdateAutomateResponseConfigStatusWithOptions(UpdateAutomateResponseConfigStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InUse))
            {
                body["InUse"] = request.InUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutomateResponseConfigStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutomateResponseConfigStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of an automatic response rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAutomateResponseConfigStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutomateResponseConfigStatusResponse
        /// </returns>
        public async Task<UpdateAutomateResponseConfigStatusResponse> UpdateAutomateResponseConfigStatusWithOptionsAsync(UpdateAutomateResponseConfigStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InUse))
            {
                body["InUse"] = request.InUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutomateResponseConfigStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutomateResponseConfigStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of an automatic response rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAutomateResponseConfigStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutomateResponseConfigStatusResponse
        /// </returns>
        public UpdateAutomateResponseConfigStatusResponse UpdateAutomateResponseConfigStatus(UpdateAutomateResponseConfigStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAutomateResponseConfigStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of an automatic response rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAutomateResponseConfigStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutomateResponseConfigStatusResponse
        /// </returns>
        public async Task<UpdateAutomateResponseConfigStatusResponse> UpdateAutomateResponseConfigStatusAsync(UpdateAutomateResponseConfigStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAutomateResponseConfigStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates an alert whitelist rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWhiteRuleListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWhiteRuleListResponse
        /// </returns>
        public UpdateWhiteRuleListResponse UpdateWhiteRuleListWithOptions(UpdateWhiteRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                body["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteRuleId))
            {
                body["WhiteRuleId"] = request.WhiteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWhiteRuleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWhiteRuleListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates an alert whitelist rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWhiteRuleListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWhiteRuleListResponse
        /// </returns>
        public async Task<UpdateWhiteRuleListResponse> UpdateWhiteRuleListWithOptionsAsync(UpdateWhiteRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                body["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteRuleId))
            {
                body["WhiteRuleId"] = request.WhiteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWhiteRuleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWhiteRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates an alert whitelist rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWhiteRuleListRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWhiteRuleListResponse
        /// </returns>
        public UpdateWhiteRuleListResponse UpdateWhiteRuleList(UpdateWhiteRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWhiteRuleListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates or updates an alert whitelist rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWhiteRuleListRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWhiteRuleListResponse
        /// </returns>
        public async Task<UpdateWhiteRuleListResponse> UpdateWhiteRuleListAsync(UpdateWhiteRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWhiteRuleListWithOptionsAsync(request, runtime);
        }

    }
}
