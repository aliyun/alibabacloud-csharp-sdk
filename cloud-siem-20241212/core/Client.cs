// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloud_siem20241212.Models;

namespace AlibabaCloud.SDK.Cloud_siem20241212
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
        /// <para>检查升级项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckUpgradeItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckUpgradeItemResponse
        /// </returns>
        public CheckUpgradeItemResponse CheckUpgradeItemWithOptions(CheckUpgradeItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeItemId))
            {
                body["UpgradeItemId"] = request.UpgradeItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckUpgradeItem",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUpgradeItemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查升级项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckUpgradeItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckUpgradeItemResponse
        /// </returns>
        public async Task<CheckUpgradeItemResponse> CheckUpgradeItemWithOptionsAsync(CheckUpgradeItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeItemId))
            {
                body["UpgradeItemId"] = request.UpgradeItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckUpgradeItem",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUpgradeItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查升级项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckUpgradeItemRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckUpgradeItemResponse
        /// </returns>
        public CheckUpgradeItemResponse CheckUpgradeItem(CheckUpgradeItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckUpgradeItemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查升级项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckUpgradeItemRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckUpgradeItemResponse
        /// </returns>
        public async Task<CheckUpgradeItemResponse> CheckUpgradeItemAsync(CheckUpgradeItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckUpgradeItemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataIngestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataIngestionResponse
        /// </returns>
        public CreateDataIngestionResponse CreateDataIngestionWithOptions(CreateDataIngestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CapacityCount))
            {
                body["CapacityCount"] = request.CapacityCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionMode))
            {
                body["DataIngestionMode"] = request.DataIngestionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionStateCode))
            {
                body["DataIngestionStateCode"] = request.DataIngestionStateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionType))
            {
                body["DataIngestionType"] = request.DataIngestionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceEditable))
            {
                body["DataSourceEditable"] = request.DataSourceEditable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleEditable))
            {
                body["NormalizationRuleEditable"] = request.NormalizationRuleEditable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanDataSourceId))
            {
                body["ScanDataSourceId"] = request.ScanDataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamJobId))
            {
                body["StreamJobId"] = request.StreamJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTime))
            {
                body["UpdateTime"] = request.UpdateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataIngestion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataIngestionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataIngestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataIngestionResponse
        /// </returns>
        public async Task<CreateDataIngestionResponse> CreateDataIngestionWithOptionsAsync(CreateDataIngestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CapacityCount))
            {
                body["CapacityCount"] = request.CapacityCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionMode))
            {
                body["DataIngestionMode"] = request.DataIngestionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionStateCode))
            {
                body["DataIngestionStateCode"] = request.DataIngestionStateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionType))
            {
                body["DataIngestionType"] = request.DataIngestionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceEditable))
            {
                body["DataSourceEditable"] = request.DataSourceEditable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleEditable))
            {
                body["NormalizationRuleEditable"] = request.NormalizationRuleEditable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanDataSourceId))
            {
                body["ScanDataSourceId"] = request.ScanDataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamJobId))
            {
                body["StreamJobId"] = request.StreamJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTime))
            {
                body["UpdateTime"] = request.UpdateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataIngestion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataIngestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataIngestionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataIngestionResponse
        /// </returns>
        public CreateDataIngestionResponse CreateDataIngestion(CreateDataIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataIngestionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataIngestionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataIngestionResponse
        /// </returns>
        public async Task<CreateDataIngestionResponse> CreateDataIngestionAsync(CreateDataIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataIngestionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSetResponse
        /// </returns>
        public CreateDataSetResponse CreateDataSetWithOptions(CreateDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetDescription))
            {
                body["DataSetDescription"] = request.DataSetDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetFieldKeyName))
            {
                body["DataSetFieldKeyName"] = request.DataSetFieldKeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetFileName))
            {
                body["DataSetFileName"] = request.DataSetFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetName))
            {
                body["DataSetName"] = request.DataSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetStatus))
            {
                body["DataSetStatus"] = request.DataSetStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetType))
            {
                body["DataSetType"] = request.DataSetType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelistRecognizers))
            {
                bodyFlat["IpWhitelistRecognizers"] = request.IpWhitelistRecognizers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
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
                Action = "CreateDataSet",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSetResponse
        /// </returns>
        public async Task<CreateDataSetResponse> CreateDataSetWithOptionsAsync(CreateDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetDescription))
            {
                body["DataSetDescription"] = request.DataSetDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetFieldKeyName))
            {
                body["DataSetFieldKeyName"] = request.DataSetFieldKeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetFileName))
            {
                body["DataSetFileName"] = request.DataSetFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetName))
            {
                body["DataSetName"] = request.DataSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetStatus))
            {
                body["DataSetStatus"] = request.DataSetStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetType))
            {
                body["DataSetType"] = request.DataSetType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelistRecognizers))
            {
                bodyFlat["IpWhitelistRecognizers"] = request.IpWhitelistRecognizers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
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
                Action = "CreateDataSet",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataSetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSetResponse
        /// </returns>
        public CreateDataSetResponse CreateDataSet(CreateDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataSetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataSetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSetResponse
        /// </returns>
        public async Task<CreateDataSetResponse> CreateDataSetAsync(CreateDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataSetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据源</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSourceResponse
        /// </returns>
        public CreateDataSourceResponse CreateDataSourceWithOptions(CreateDataSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataSourceShrinkRequest request = new CreateDataSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceIds))
            {
                request.DataSourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceIds, "DataSourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceReferences))
            {
                request.DataSourceReferencesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceReferences, "DataSourceReferences", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceFrom))
            {
                body["DataSourceFrom"] = request.DataSourceFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceIdsShrink))
            {
                body["DataSourceIds"] = request.DataSourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["DataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceRecognizeEnabled))
            {
                body["DataSourceRecognizeEnabled"] = request.DataSourceRecognizeEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceRecognizer))
            {
                body["DataSourceRecognizer"] = request.DataSourceRecognizer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceReferencesShrink))
            {
                body["DataSourceReferences"] = request.DataSourceReferencesShrink;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceStores))
            {
                bodyFlat["DataSourceStores"] = request.DataSourceStores;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceTemplateId))
            {
                body["DataSourceTemplateId"] = request.DataSourceTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTime))
            {
                body["UpdateTime"] = request.UpdateTime;
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
                Action = "CreateDataSource",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据源</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSourceResponse
        /// </returns>
        public async Task<CreateDataSourceResponse> CreateDataSourceWithOptionsAsync(CreateDataSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataSourceShrinkRequest request = new CreateDataSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceIds))
            {
                request.DataSourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceIds, "DataSourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceReferences))
            {
                request.DataSourceReferencesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceReferences, "DataSourceReferences", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceFrom))
            {
                body["DataSourceFrom"] = request.DataSourceFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceIdsShrink))
            {
                body["DataSourceIds"] = request.DataSourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["DataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceRecognizeEnabled))
            {
                body["DataSourceRecognizeEnabled"] = request.DataSourceRecognizeEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceRecognizer))
            {
                body["DataSourceRecognizer"] = request.DataSourceRecognizer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceReferencesShrink))
            {
                body["DataSourceReferences"] = request.DataSourceReferencesShrink;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceStores))
            {
                bodyFlat["DataSourceStores"] = request.DataSourceStores;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceTemplateId))
            {
                body["DataSourceTemplateId"] = request.DataSourceTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTime))
            {
                body["UpdateTime"] = request.UpdateTime;
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
                Action = "CreateDataSource",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSourceResponse
        /// </returns>
        public CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSourceResponse
        /// </returns>
        public async Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDetectionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDetectionRuleResponse
        /// </returns>
        public CreateDetectionRuleResponse CreateDetectionRuleWithOptions(CreateDetectionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertAttCk))
            {
                body["AlertAttCk"] = request.AlertAttCk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertLevel))
            {
                body["AlertLevel"] = request.AlertLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertSchemaId))
            {
                body["AlertSchemaId"] = request.AlertSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTacticId))
            {
                body["AlertTacticId"] = request.AlertTacticId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertThresholdCount))
            {
                body["AlertThresholdCount"] = request.AlertThresholdCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertThresholdGroup))
            {
                body["AlertThresholdGroup"] = request.AlertThresholdGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertThresholdPeriod))
            {
                body["AlertThresholdPeriod"] = request.AlertThresholdPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionExpressionContent))
            {
                body["DetectionExpressionContent"] = request.DetectionExpressionContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionExpressionType))
            {
                body["DetectionExpressionType"] = request.DetectionExpressionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleDescription))
            {
                body["DetectionRuleDescription"] = request.DetectionRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleName))
            {
                body["DetectionRuleName"] = request.DetectionRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleStatus))
            {
                body["DetectionRuleStatus"] = request.DetectionRuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleType))
            {
                body["DetectionRuleType"] = request.DetectionRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityMappings))
            {
                body["EntityMappings"] = request.EntityMappings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentAggregationExpression))
            {
                body["IncidentAggregationExpression"] = request.IncidentAggregationExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentAggregationType))
            {
                body["IncidentAggregationType"] = request.IncidentAggregationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCategoryId))
            {
                body["LogCategoryId"] = request.LogCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSchemaId))
            {
                body["LogSchemaId"] = request.LogSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookParameters))
            {
                body["PlaybookParameters"] = request.PlaybookParameters;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleBeginTime))
            {
                body["ScheduleBeginTime"] = request.ScheduleBeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleExpression))
            {
                body["ScheduleExpression"] = request.ScheduleExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleMaxRetries))
            {
                body["ScheduleMaxRetries"] = request.ScheduleMaxRetries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleMaxTimeout))
            {
                body["ScheduleMaxTimeout"] = request.ScheduleMaxTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                body["ScheduleType"] = request.ScheduleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleWindow))
            {
                body["ScheduleWindow"] = request.ScheduleWindow;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDetectionRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDetectionRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDetectionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDetectionRuleResponse
        /// </returns>
        public async Task<CreateDetectionRuleResponse> CreateDetectionRuleWithOptionsAsync(CreateDetectionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertAttCk))
            {
                body["AlertAttCk"] = request.AlertAttCk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertLevel))
            {
                body["AlertLevel"] = request.AlertLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertSchemaId))
            {
                body["AlertSchemaId"] = request.AlertSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTacticId))
            {
                body["AlertTacticId"] = request.AlertTacticId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertThresholdCount))
            {
                body["AlertThresholdCount"] = request.AlertThresholdCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertThresholdGroup))
            {
                body["AlertThresholdGroup"] = request.AlertThresholdGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertThresholdPeriod))
            {
                body["AlertThresholdPeriod"] = request.AlertThresholdPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionExpressionContent))
            {
                body["DetectionExpressionContent"] = request.DetectionExpressionContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionExpressionType))
            {
                body["DetectionExpressionType"] = request.DetectionExpressionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleDescription))
            {
                body["DetectionRuleDescription"] = request.DetectionRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleName))
            {
                body["DetectionRuleName"] = request.DetectionRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleStatus))
            {
                body["DetectionRuleStatus"] = request.DetectionRuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleType))
            {
                body["DetectionRuleType"] = request.DetectionRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityMappings))
            {
                body["EntityMappings"] = request.EntityMappings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentAggregationExpression))
            {
                body["IncidentAggregationExpression"] = request.IncidentAggregationExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentAggregationType))
            {
                body["IncidentAggregationType"] = request.IncidentAggregationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCategoryId))
            {
                body["LogCategoryId"] = request.LogCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSchemaId))
            {
                body["LogSchemaId"] = request.LogSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookParameters))
            {
                body["PlaybookParameters"] = request.PlaybookParameters;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleBeginTime))
            {
                body["ScheduleBeginTime"] = request.ScheduleBeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleExpression))
            {
                body["ScheduleExpression"] = request.ScheduleExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleMaxRetries))
            {
                body["ScheduleMaxRetries"] = request.ScheduleMaxRetries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleMaxTimeout))
            {
                body["ScheduleMaxTimeout"] = request.ScheduleMaxTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                body["ScheduleType"] = request.ScheduleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleWindow))
            {
                body["ScheduleWindow"] = request.ScheduleWindow;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDetectionRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDetectionRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDetectionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDetectionRuleResponse
        /// </returns>
        public CreateDetectionRuleResponse CreateDetectionRule(CreateDetectionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDetectionRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDetectionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDetectionRuleResponse
        /// </returns>
        public async Task<CreateDetectionRuleResponse> CreateDetectionRuleAsync(CreateDetectionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDetectionRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExportTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExportTaskResponse
        /// </returns>
        public CreateExportTaskResponse CreateExportTaskWithOptions(CreateExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportTaskParameter))
            {
                body["ExportTaskParameter"] = request.ExportTaskParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportTaskType))
            {
                body["ExportTaskType"] = request.ExportTaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExportTask",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExportTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExportTaskResponse
        /// </returns>
        public async Task<CreateExportTaskResponse> CreateExportTaskWithOptionsAsync(CreateExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportTaskParameter))
            {
                body["ExportTaskParameter"] = request.ExportTaskParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportTaskType))
            {
                body["ExportTaskType"] = request.ExportTaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExportTask",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExportTaskResponse
        /// </returns>
        public CreateExportTaskResponse CreateExportTask(CreateExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateExportTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExportTaskResponse
        /// </returns>
        public async Task<CreateExportTaskResponse> CreateExportTaskAsync(CreateExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateExportTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLogStoreResponse
        /// </returns>
        public CreateLogStoreResponse CreateLogStoreWithOptions(CreateLogStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLogStore",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLogStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLogStoreResponse
        /// </returns>
        public async Task<CreateLogStoreResponse> CreateLogStoreWithOptionsAsync(CreateLogStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLogStore",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLogStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLogStoreResponse
        /// </returns>
        public CreateLogStoreResponse CreateLogStore(CreateLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLogStoreWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLogStoreResponse
        /// </returns>
        public async Task<CreateLogStoreResponse> CreateLogStoreAsync(CreateLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLogStoreWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建标准化规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateNormalizationRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNormalizationRuleResponse
        /// </returns>
        public CreateNormalizationRuleResponse CreateNormalizationRuleWithOptions(CreateNormalizationRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateNormalizationRuleShrinkRequest request = new CreateNormalizationRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NormalizationRuleIds))
            {
                request.NormalizationRuleIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NormalizationRuleIds, "NormalizationRuleIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendContentPacked))
            {
                body["ExtendContentPacked"] = request.ExtendContentPacked;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationCategoryId))
            {
                body["NormalizationCategoryId"] = request.NormalizationCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleDescription))
            {
                body["NormalizationRuleDescription"] = request.NormalizationRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleExpression))
            {
                body["NormalizationRuleExpression"] = request.NormalizationRuleExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleFormat))
            {
                body["NormalizationRuleFormat"] = request.NormalizationRuleFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleIdsShrink))
            {
                body["NormalizationRuleIds"] = request.NormalizationRuleIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleMode))
            {
                body["NormalizationRuleMode"] = request.NormalizationRuleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleName))
            {
                body["NormalizationRuleName"] = request.NormalizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleType))
            {
                body["NormalizationRuleType"] = request.NormalizationRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleVersion))
            {
                body["NormalizationRuleVersion"] = request.NormalizationRuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaId))
            {
                body["NormalizationSchemaId"] = request.NormalizationSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorId))
            {
                body["VendorId"] = request.VendorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNormalizationRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNormalizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建标准化规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateNormalizationRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNormalizationRuleResponse
        /// </returns>
        public async Task<CreateNormalizationRuleResponse> CreateNormalizationRuleWithOptionsAsync(CreateNormalizationRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateNormalizationRuleShrinkRequest request = new CreateNormalizationRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NormalizationRuleIds))
            {
                request.NormalizationRuleIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NormalizationRuleIds, "NormalizationRuleIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendContentPacked))
            {
                body["ExtendContentPacked"] = request.ExtendContentPacked;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationCategoryId))
            {
                body["NormalizationCategoryId"] = request.NormalizationCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleDescription))
            {
                body["NormalizationRuleDescription"] = request.NormalizationRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleExpression))
            {
                body["NormalizationRuleExpression"] = request.NormalizationRuleExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleFormat))
            {
                body["NormalizationRuleFormat"] = request.NormalizationRuleFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleIdsShrink))
            {
                body["NormalizationRuleIds"] = request.NormalizationRuleIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleMode))
            {
                body["NormalizationRuleMode"] = request.NormalizationRuleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleName))
            {
                body["NormalizationRuleName"] = request.NormalizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleType))
            {
                body["NormalizationRuleType"] = request.NormalizationRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleVersion))
            {
                body["NormalizationRuleVersion"] = request.NormalizationRuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaId))
            {
                body["NormalizationSchemaId"] = request.NormalizationSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorId))
            {
                body["VendorId"] = request.VendorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNormalizationRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNormalizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建标准化规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNormalizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNormalizationRuleResponse
        /// </returns>
        public CreateNormalizationRuleResponse CreateNormalizationRule(CreateNormalizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNormalizationRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建标准化规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNormalizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNormalizationRuleResponse
        /// </returns>
        public async Task<CreateNormalizationRuleResponse> CreateNormalizationRuleAsync(CreateNormalizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNormalizationRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProductResponse
        /// </returns>
        public CreateProductResponse CreateProductWithOptions(CreateProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["ProductName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorName))
            {
                body["VendorName"] = request.VendorName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProduct",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProductResponse
        /// </returns>
        public async Task<CreateProductResponse> CreateProductWithOptionsAsync(CreateProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["ProductName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorName))
            {
                body["VendorName"] = request.VendorName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProduct",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProductResponse
        /// </returns>
        public CreateProductResponse CreateProduct(CreateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProductWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProductResponse
        /// </returns>
        public async Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProductWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建厂商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVendorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVendorResponse
        /// </returns>
        public CreateVendorResponse CreateVendorWithOptions(CreateVendorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorName))
            {
                body["VendorName"] = request.VendorName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVendor",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVendorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建厂商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVendorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVendorResponse
        /// </returns>
        public async Task<CreateVendorResponse> CreateVendorWithOptionsAsync(CreateVendorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorName))
            {
                body["VendorName"] = request.VendorName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVendor",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVendorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建厂商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVendorRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVendorResponse
        /// </returns>
        public CreateVendorResponse CreateVendor(CreateVendorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVendorWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建厂商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVendorRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVendorResponse
        /// </returns>
        public async Task<CreateVendorResponse> CreateVendorAsync(CreateVendorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVendorWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataIngestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataIngestionResponse
        /// </returns>
        public DeleteDataIngestionResponse DeleteDataIngestionWithOptions(DeleteDataIngestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionId))
            {
                body["DataIngestionId"] = request.DataIngestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataIngestion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataIngestionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataIngestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataIngestionResponse
        /// </returns>
        public async Task<DeleteDataIngestionResponse> DeleteDataIngestionWithOptionsAsync(DeleteDataIngestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionId))
            {
                body["DataIngestionId"] = request.DataIngestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataIngestion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataIngestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataIngestionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataIngestionResponse
        /// </returns>
        public DeleteDataIngestionResponse DeleteDataIngestion(DeleteDataIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataIngestionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataIngestionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataIngestionResponse
        /// </returns>
        public async Task<DeleteDataIngestionResponse> DeleteDataIngestionAsync(DeleteDataIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataIngestionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSetResponse
        /// </returns>
        public DeleteDataSetResponse DeleteDataSetWithOptions(DeleteDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetId))
            {
                body["DataSetId"] = request.DataSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSet",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSetResponse
        /// </returns>
        public async Task<DeleteDataSetResponse> DeleteDataSetWithOptionsAsync(DeleteDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetId))
            {
                body["DataSetId"] = request.DataSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSet",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSetResponse
        /// </returns>
        public DeleteDataSetResponse DeleteDataSet(DeleteDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataSetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSetResponse
        /// </returns>
        public async Task<DeleteDataSetResponse> DeleteDataSetAsync(DeleteDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataSetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSetRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSetRecordResponse
        /// </returns>
        public DeleteDataSetRecordResponse DeleteDataSetRecordWithOptions(DeleteDataSetRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetId))
            {
                body["DataSetId"] = request.DataSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetRecordIds))
            {
                body["DataSetRecordIds"] = request.DataSetRecordIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSetRecord",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSetRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSetRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSetRecordResponse
        /// </returns>
        public async Task<DeleteDataSetRecordResponse> DeleteDataSetRecordWithOptionsAsync(DeleteDataSetRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetId))
            {
                body["DataSetId"] = request.DataSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetRecordIds))
            {
                body["DataSetRecordIds"] = request.DataSetRecordIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSetRecord",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSetRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSetRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSetRecordResponse
        /// </returns>
        public DeleteDataSetRecordResponse DeleteDataSetRecord(DeleteDataSetRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataSetRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataSetRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSetRecordResponse
        /// </returns>
        public async Task<DeleteDataSetRecordResponse> DeleteDataSetRecordAsync(DeleteDataSetRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataSetRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据源</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSource",
                Version = "2024-12-12",
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
        /// <para>删除数据源</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSource",
                Version = "2024-12-12",
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
        /// <para>删除数据源</para>
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
        /// <para>删除数据源</para>
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
        /// <para>删除检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDetectionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDetectionRuleResponse
        /// </returns>
        public DeleteDetectionRuleResponse DeleteDetectionRuleWithOptions(DeleteDetectionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleId))
            {
                body["DetectionRuleId"] = request.DetectionRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDetectionRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDetectionRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDetectionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDetectionRuleResponse
        /// </returns>
        public async Task<DeleteDetectionRuleResponse> DeleteDetectionRuleWithOptionsAsync(DeleteDetectionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleId))
            {
                body["DetectionRuleId"] = request.DetectionRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDetectionRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDetectionRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDetectionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDetectionRuleResponse
        /// </returns>
        public DeleteDetectionRuleResponse DeleteDetectionRule(DeleteDetectionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDetectionRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDetectionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDetectionRuleResponse
        /// </returns>
        public async Task<DeleteDetectionRuleResponse> DeleteDetectionRuleAsync(DeleteDetectionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDetectionRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLogStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLogStoreResponse
        /// </returns>
        public DeleteLogStoreResponse DeleteLogStoreWithOptions(DeleteLogStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLogStore",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLogStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLogStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLogStoreResponse
        /// </returns>
        public async Task<DeleteLogStoreResponse> DeleteLogStoreWithOptionsAsync(DeleteLogStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLogStore",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLogStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLogStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLogStoreResponse
        /// </returns>
        public DeleteLogStoreResponse DeleteLogStore(DeleteLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLogStoreWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLogStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLogStoreResponse
        /// </returns>
        public async Task<DeleteLogStoreResponse> DeleteLogStoreAsync(DeleteLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLogStoreWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除标准化规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNormalizationRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNormalizationRuleResponse
        /// </returns>
        public DeleteNormalizationRuleResponse DeleteNormalizationRuleWithOptions(DeleteNormalizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNormalizationRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNormalizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除标准化规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNormalizationRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNormalizationRuleResponse
        /// </returns>
        public async Task<DeleteNormalizationRuleResponse> DeleteNormalizationRuleWithOptionsAsync(DeleteNormalizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNormalizationRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNormalizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除标准化规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNormalizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNormalizationRuleResponse
        /// </returns>
        public DeleteNormalizationRuleResponse DeleteNormalizationRule(DeleteNormalizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNormalizationRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除标准化规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNormalizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNormalizationRuleResponse
        /// </returns>
        public async Task<DeleteNormalizationRuleResponse> DeleteNormalizationRuleAsync(DeleteNormalizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNormalizationRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除标准化规则版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNormalizationRuleVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNormalizationRuleVersionResponse
        /// </returns>
        public DeleteNormalizationRuleVersionResponse DeleteNormalizationRuleVersionWithOptions(DeleteNormalizationRuleVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleVersion))
            {
                body["NormalizationRuleVersion"] = request.NormalizationRuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNormalizationRuleVersion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNormalizationRuleVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除标准化规则版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNormalizationRuleVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNormalizationRuleVersionResponse
        /// </returns>
        public async Task<DeleteNormalizationRuleVersionResponse> DeleteNormalizationRuleVersionWithOptionsAsync(DeleteNormalizationRuleVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleVersion))
            {
                body["NormalizationRuleVersion"] = request.NormalizationRuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNormalizationRuleVersion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNormalizationRuleVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除标准化规则版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNormalizationRuleVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNormalizationRuleVersionResponse
        /// </returns>
        public DeleteNormalizationRuleVersionResponse DeleteNormalizationRuleVersion(DeleteNormalizationRuleVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNormalizationRuleVersionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除标准化规则版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNormalizationRuleVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNormalizationRuleVersionResponse
        /// </returns>
        public async Task<DeleteNormalizationRuleVersionResponse> DeleteNormalizationRuleVersionAsync(DeleteNormalizationRuleVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNormalizationRuleVersionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProductResponse
        /// </returns>
        public DeleteProductResponse DeleteProductWithOptions(DeleteProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProduct",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProductResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProductResponse
        /// </returns>
        public async Task<DeleteProductResponse> DeleteProductWithOptionsAsync(DeleteProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProduct",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProductRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProductResponse
        /// </returns>
        public DeleteProductResponse DeleteProduct(DeleteProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProductWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProductRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProductResponse
        /// </returns>
        public async Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProductWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除厂商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVendorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVendorResponse
        /// </returns>
        public DeleteVendorResponse DeleteVendorWithOptions(DeleteVendorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorId))
            {
                body["VendorId"] = request.VendorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorName))
            {
                body["VendorName"] = request.VendorName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVendor",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVendorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除厂商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVendorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVendorResponse
        /// </returns>
        public async Task<DeleteVendorResponse> DeleteVendorWithOptionsAsync(DeleteVendorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorId))
            {
                body["VendorId"] = request.VendorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorName))
            {
                body["VendorName"] = request.VendorName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVendor",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVendorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除厂商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVendorRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVendorResponse
        /// </returns>
        public DeleteVendorResponse DeleteVendor(DeleteVendorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVendorWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除厂商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVendorRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVendorResponse
        /// </returns>
        public async Task<DeleteVendorResponse> DeleteVendorAsync(DeleteVendorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVendorWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止数据接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableDataIngestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableDataIngestionResponse
        /// </returns>
        public DisableDataIngestionResponse DisableDataIngestionWithOptions(DisableDataIngestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionId))
            {
                body["DataIngestionId"] = request.DataIngestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableDataIngestion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDataIngestionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止数据接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableDataIngestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableDataIngestionResponse
        /// </returns>
        public async Task<DisableDataIngestionResponse> DisableDataIngestionWithOptionsAsync(DisableDataIngestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionId))
            {
                body["DataIngestionId"] = request.DataIngestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableDataIngestion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDataIngestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止数据接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableDataIngestionRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableDataIngestionResponse
        /// </returns>
        public DisableDataIngestionResponse DisableDataIngestion(DisableDataIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableDataIngestionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止数据接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableDataIngestionRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableDataIngestionResponse
        /// </returns>
        public async Task<DisableDataIngestionResponse> DisableDataIngestionAsync(DisableDataIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableDataIngestionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动数据接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableDataIngestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableDataIngestionResponse
        /// </returns>
        public EnableDataIngestionResponse EnableDataIngestionWithOptions(EnableDataIngestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionId))
            {
                body["DataIngestionId"] = request.DataIngestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableDataIngestion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDataIngestionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动数据接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableDataIngestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableDataIngestionResponse
        /// </returns>
        public async Task<EnableDataIngestionResponse> EnableDataIngestionWithOptionsAsync(EnableDataIngestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionId))
            {
                body["DataIngestionId"] = request.DataIngestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableDataIngestion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDataIngestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动数据接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableDataIngestionRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableDataIngestionResponse
        /// </returns>
        public EnableDataIngestionResponse EnableDataIngestion(EnableDataIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableDataIngestionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动数据接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableDataIngestionRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableDataIngestionResponse
        /// </returns>
        public async Task<EnableDataIngestionResponse> EnableDataIngestionAsync(EnableDataIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableDataIngestionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteLogQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteLogQueryResponse
        /// </returns>
        public ExecuteLogQueryResponse ExecuteLogQueryWithOptions(ExecuteLogQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendContentPacked))
            {
                body["ExtendContentPacked"] = request.ExtendContentPacked;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogQuery))
            {
                body["LogQuery"] = request.LogQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaId))
            {
                body["NormalizationSchemaId"] = request.NormalizationSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
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
                Action = "ExecuteLogQuery",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteLogQueryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteLogQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteLogQueryResponse
        /// </returns>
        public async Task<ExecuteLogQueryResponse> ExecuteLogQueryWithOptionsAsync(ExecuteLogQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendContentPacked))
            {
                body["ExtendContentPacked"] = request.ExtendContentPacked;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogQuery))
            {
                body["LogQuery"] = request.LogQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaId))
            {
                body["NormalizationSchemaId"] = request.NormalizationSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
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
                Action = "ExecuteLogQuery",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteLogQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteLogQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteLogQueryResponse
        /// </returns>
        public ExecuteLogQueryResponse ExecuteLogQuery(ExecuteLogQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteLogQueryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteLogQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteLogQueryResponse
        /// </returns>
        public async Task<ExecuteLogQueryResponse> ExecuteLogQueryAsync(ExecuteLogQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteLogQueryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteUpgradeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteUpgradeResponse
        /// </returns>
        public ExecuteUpgradeResponse ExecuteUpgradeWithOptions(ExecuteUpgradeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteUpgrade",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteUpgradeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteUpgradeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteUpgradeResponse
        /// </returns>
        public async Task<ExecuteUpgradeResponse> ExecuteUpgradeWithOptionsAsync(ExecuteUpgradeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteUpgrade",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteUpgradeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteUpgradeRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteUpgradeResponse
        /// </returns>
        public ExecuteUpgradeResponse ExecuteUpgrade(ExecuteUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteUpgradeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行升级</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteUpgradeRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteUpgradeResponse
        /// </returns>
        public async Task<ExecuteUpgradeResponse> ExecuteUpgradeAsync(ExecuteUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteUpgradeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据批量接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataBatchIngestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataBatchIngestionResponse
        /// </returns>
        public GetDataBatchIngestionResponse GetDataBatchIngestionWithOptions(GetDataBatchIngestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataBatchIngestion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataBatchIngestionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据批量接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataBatchIngestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataBatchIngestionResponse
        /// </returns>
        public async Task<GetDataBatchIngestionResponse> GetDataBatchIngestionWithOptionsAsync(GetDataBatchIngestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataBatchIngestion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataBatchIngestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据批量接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataBatchIngestionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataBatchIngestionResponse
        /// </returns>
        public GetDataBatchIngestionResponse GetDataBatchIngestion(GetDataBatchIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataBatchIngestionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据批量接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataBatchIngestionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataBatchIngestionResponse
        /// </returns>
        public async Task<GetDataBatchIngestionResponse> GetDataBatchIngestionAsync(GetDataBatchIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataBatchIngestionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志管理页面里用户数据存储的详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataStorageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataStorageResponse
        /// </returns>
        public GetDataStorageResponse GetDataStorageWithOptions(GetDataStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataStorage",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataStorageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志管理页面里用户数据存储的详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataStorageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataStorageResponse
        /// </returns>
        public async Task<GetDataStorageResponse> GetDataStorageWithOptionsAsync(GetDataStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataStorage",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataStorageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志管理页面里用户数据存储的详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataStorageResponse
        /// </returns>
        public GetDataStorageResponse GetDataStorage(GetDataStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataStorageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志管理页面里用户数据存储的详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataStorageResponse
        /// </returns>
        public async Task<GetDataStorageResponse> GetDataStorageAsync(GetDataStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataStorageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDetectionStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDetectionStatisticResponse
        /// </returns>
        public GetDetectionStatisticResponse GetDetectionStatisticWithOptions(GetDetectionStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDetectionStatistic",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDetectionStatisticResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDetectionStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDetectionStatisticResponse
        /// </returns>
        public async Task<GetDetectionStatisticResponse> GetDetectionStatisticWithOptionsAsync(GetDetectionStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDetectionStatistic",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDetectionStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDetectionStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDetectionStatisticResponse
        /// </returns>
        public GetDetectionStatisticResponse GetDetectionStatistic(GetDetectionStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDetectionStatisticWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDetectionStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDetectionStatisticResponse
        /// </returns>
        public async Task<GetDetectionStatisticResponse> GetDetectionStatisticAsync(GetDetectionStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDetectionStatisticWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取导出任务进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExportTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExportTaskResponse
        /// </returns>
        public GetExportTaskResponse GetExportTaskWithOptions(GetExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportId))
            {
                body["ExportId"] = request.ExportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExportTask",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取导出任务进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExportTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExportTaskResponse
        /// </returns>
        public async Task<GetExportTaskResponse> GetExportTaskWithOptionsAsync(GetExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportId))
            {
                body["ExportId"] = request.ExportId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExportTask",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取导出任务进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExportTaskResponse
        /// </returns>
        public GetExportTaskResponse GetExportTask(GetExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetExportTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取导出任务进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExportTaskResponse
        /// </returns>
        public async Task<GetExportTaskResponse> GetExportTaskAsync(GetExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetExportTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取事件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIncidentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIncidentResponse
        /// </returns>
        public GetIncidentResponse GetIncidentWithOptions(GetIncidentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIncident",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIncidentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取事件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIncidentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIncidentResponse
        /// </returns>
        public async Task<GetIncidentResponse> GetIncidentWithOptionsAsync(GetIncidentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIncident",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIncidentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取事件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIncidentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIncidentResponse
        /// </returns>
        public GetIncidentResponse GetIncident(GetIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIncidentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取事件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIncidentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIncidentResponse
        /// </returns>
        public async Task<GetIncidentResponse> GetIncidentAsync(GetIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIncidentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLogTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLogTicketResponse
        /// </returns>
        public GetLogTicketResponse GetLogTicketWithOptions(GetLogTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogTicket",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogTicketResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLogTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLogTicketResponse
        /// </returns>
        public async Task<GetLogTicketResponse> GetLogTicketWithOptionsAsync(GetLogTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogTicket",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLogTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLogTicketResponse
        /// </returns>
        public GetLogTicketResponse GetLogTicket(GetLogTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogTicketWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLogTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLogTicketResponse
        /// </returns>
        public async Task<GetLogTicketResponse> GetLogTicketAsync(GetLogTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogTicketWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNormalizationRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNormalizationRuleResponse
        /// </returns>
        public GetNormalizationRuleResponse GetNormalizationRuleWithOptions(GetNormalizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNormalizationRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNormalizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNormalizationRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNormalizationRuleResponse
        /// </returns>
        public async Task<GetNormalizationRuleResponse> GetNormalizationRuleWithOptionsAsync(GetNormalizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNormalizationRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNormalizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNormalizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNormalizationRuleResponse
        /// </returns>
        public GetNormalizationRuleResponse GetNormalizationRule(GetNormalizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNormalizationRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNormalizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNormalizationRuleResponse
        /// </returns>
        public async Task<GetNormalizationRuleResponse> GetNormalizationRuleAsync(GetNormalizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNormalizationRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则指定版本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNormalizationRuleVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNormalizationRuleVersionResponse
        /// </returns>
        public GetNormalizationRuleVersionResponse GetNormalizationRuleVersionWithOptions(GetNormalizationRuleVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleVersion))
            {
                body["NormalizationRuleVersion"] = request.NormalizationRuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNormalizationRuleVersion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNormalizationRuleVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则指定版本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNormalizationRuleVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNormalizationRuleVersionResponse
        /// </returns>
        public async Task<GetNormalizationRuleVersionResponse> GetNormalizationRuleVersionWithOptionsAsync(GetNormalizationRuleVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleVersion))
            {
                body["NormalizationRuleVersion"] = request.NormalizationRuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNormalizationRuleVersion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNormalizationRuleVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则指定版本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNormalizationRuleVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNormalizationRuleVersionResponse
        /// </returns>
        public GetNormalizationRuleVersionResponse GetNormalizationRuleVersion(GetNormalizationRuleVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNormalizationRuleVersionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则指定版本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNormalizationRuleVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNormalizationRuleVersionResponse
        /// </returns>
        public async Task<GetNormalizationRuleVersionResponse> GetNormalizationRuleVersionAsync(GetNormalizationRuleVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNormalizationRuleVersionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Schema信息以及字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNormalizationSchemaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNormalizationSchemaResponse
        /// </returns>
        public GetNormalizationSchemaResponse GetNormalizationSchemaWithOptions(GetNormalizationSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaId))
            {
                body["NormalizationSchemaId"] = request.NormalizationSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaType))
            {
                body["NormalizationSchemaType"] = request.NormalizationSchemaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNormalizationSchema",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNormalizationSchemaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Schema信息以及字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNormalizationSchemaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNormalizationSchemaResponse
        /// </returns>
        public async Task<GetNormalizationSchemaResponse> GetNormalizationSchemaWithOptionsAsync(GetNormalizationSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaId))
            {
                body["NormalizationSchemaId"] = request.NormalizationSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaType))
            {
                body["NormalizationSchemaType"] = request.NormalizationSchemaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNormalizationSchema",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNormalizationSchemaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Schema信息以及字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNormalizationSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNormalizationSchemaResponse
        /// </returns>
        public GetNormalizationSchemaResponse GetNormalizationSchema(GetNormalizationSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNormalizationSchemaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Schema信息以及字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNormalizationSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNormalizationSchemaResponse
        /// </returns>
        public async Task<GetNormalizationSchemaResponse> GetNormalizationSchemaAsync(GetNormalizationSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNormalizationSchemaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserConfigResponse
        /// </returns>
        public GetUserConfigResponse GetUserConfigWithOptions(GetUserConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserConfig",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserConfigResponse
        /// </returns>
        public async Task<GetUserConfigResponse> GetUserConfigWithOptionsAsync(GetUserConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserConfig",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserConfigResponse
        /// </returns>
        public GetUserConfigResponse GetUserConfig(GetUserConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserConfigResponse
        /// </returns>
        public async Task<GetUserConfigResponse> GetUserConfigAsync(GetUserConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询接入模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataIngestionTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataIngestionTemplatesResponse
        /// </returns>
        public ListDataIngestionTemplatesResponse ListDataIngestionTemplatesWithOptions(ListDataIngestionTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionTemplateStatus))
            {
                body["DataIngestionTemplateStatus"] = request.DataIngestionTemplateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceTemplateIds))
            {
                body["DataSourceTemplateIds"] = request.DataSourceTemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataIngestionTemplates",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataIngestionTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询接入模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataIngestionTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataIngestionTemplatesResponse
        /// </returns>
        public async Task<ListDataIngestionTemplatesResponse> ListDataIngestionTemplatesWithOptionsAsync(ListDataIngestionTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionTemplateStatus))
            {
                body["DataIngestionTemplateStatus"] = request.DataIngestionTemplateStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceTemplateIds))
            {
                body["DataSourceTemplateIds"] = request.DataSourceTemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataIngestionTemplates",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataIngestionTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询接入模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataIngestionTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataIngestionTemplatesResponse
        /// </returns>
        public ListDataIngestionTemplatesResponse ListDataIngestionTemplates(ListDataIngestionTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataIngestionTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询接入模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataIngestionTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataIngestionTemplatesResponse
        /// </returns>
        public async Task<ListDataIngestionTemplatesResponse> ListDataIngestionTemplatesAsync(ListDataIngestionTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataIngestionTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据接入任务列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDataIngestionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataIngestionsResponse
        /// </returns>
        public ListDataIngestionsResponse ListDataIngestionsWithOptions(ListDataIngestionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataIngestionsShrinkRequest request = new ListDataIngestionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataIngestionIds))
            {
                request.DataIngestionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataIngestionIds, "DataIngestionIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataIngestionTemplateIds))
            {
                request.DataIngestionTemplateIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataIngestionTemplateIds, "DataIngestionTemplateIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionIdsShrink))
            {
                body["DataIngestionIds"] = request.DataIngestionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionStatus))
            {
                body["DataIngestionStatus"] = request.DataIngestionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionTemplateIdsShrink))
            {
                body["DataIngestionTemplateIds"] = request.DataIngestionTemplateIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataIngestions",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataIngestionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据接入任务列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDataIngestionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataIngestionsResponse
        /// </returns>
        public async Task<ListDataIngestionsResponse> ListDataIngestionsWithOptionsAsync(ListDataIngestionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataIngestionsShrinkRequest request = new ListDataIngestionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataIngestionIds))
            {
                request.DataIngestionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataIngestionIds, "DataIngestionIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataIngestionTemplateIds))
            {
                request.DataIngestionTemplateIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataIngestionTemplateIds, "DataIngestionTemplateIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionIdsShrink))
            {
                body["DataIngestionIds"] = request.DataIngestionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionStatus))
            {
                body["DataIngestionStatus"] = request.DataIngestionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionTemplateIdsShrink))
            {
                body["DataIngestionTemplateIds"] = request.DataIngestionTemplateIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataIngestions",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataIngestionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据接入任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataIngestionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataIngestionsResponse
        /// </returns>
        public ListDataIngestionsResponse ListDataIngestions(ListDataIngestionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataIngestionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据接入任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataIngestionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataIngestionsResponse
        /// </returns>
        public async Task<ListDataIngestionsResponse> ListDataIngestionsAsync(ListDataIngestionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataIngestionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSetRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSetRecordsResponse
        /// </returns>
        public ListDataSetRecordsResponse ListDataSetRecordsWithOptions(ListDataSetRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetId))
            {
                body["DataSetId"] = request.DataSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSetRecords",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSetRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSetRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSetRecordsResponse
        /// </returns>
        public async Task<ListDataSetRecordsResponse> ListDataSetRecordsWithOptionsAsync(ListDataSetRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetId))
            {
                body["DataSetId"] = request.DataSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSetRecords",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSetRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSetRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSetRecordsResponse
        /// </returns>
        public ListDataSetRecordsResponse ListDataSetRecords(ListDataSetRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSetRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSetRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSetRecordsResponse
        /// </returns>
        public async Task<ListDataSetRecordsResponse> ListDataSetRecordsAsync(ListDataSetRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSetRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDataSetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSetsResponse
        /// </returns>
        public ListDataSetsResponse ListDataSetsWithOptions(ListDataSetsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataSetsShrinkRequest request = new ListDataSetsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSetIds))
            {
                request.DataSetIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSetIds, "DataSetIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetId))
            {
                body["DataSetId"] = request.DataSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetIdsShrink))
            {
                body["DataSetIds"] = request.DataSetIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetName))
            {
                body["DataSetName"] = request.DataSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetStatus))
            {
                body["DataSetStatus"] = request.DataSetStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetType))
            {
                body["DataSetType"] = request.DataSetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["OrderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderFieldName))
            {
                body["OrderFieldName"] = request.OrderFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSets",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDataSetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSetsResponse
        /// </returns>
        public async Task<ListDataSetsResponse> ListDataSetsWithOptionsAsync(ListDataSetsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataSetsShrinkRequest request = new ListDataSetsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSetIds))
            {
                request.DataSetIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSetIds, "DataSetIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetId))
            {
                body["DataSetId"] = request.DataSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetIdsShrink))
            {
                body["DataSetIds"] = request.DataSetIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetName))
            {
                body["DataSetName"] = request.DataSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetStatus))
            {
                body["DataSetStatus"] = request.DataSetStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetType))
            {
                body["DataSetType"] = request.DataSetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["OrderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderFieldName))
            {
                body["OrderFieldName"] = request.OrderFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSets",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSetsResponse
        /// </returns>
        public ListDataSetsResponse ListDataSets(ListDataSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSetsResponse
        /// </returns>
        public async Task<ListDataSetsResponse> ListDataSetsAsync(ListDataSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据源模板</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDataSourceTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceTemplatesResponse
        /// </returns>
        public ListDataSourceTemplatesResponse ListDataSourceTemplatesWithOptions(ListDataSourceTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataSourceTemplatesShrinkRequest request = new ListDataSourceTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceTemplateIds))
            {
                request.DataSourceTemplateIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceTemplateIds, "DataSourceTemplateIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceTemplateIdsShrink))
            {
                body["DataSourceTemplateIds"] = request.DataSourceTemplateIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceTemplates",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据源模板</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDataSourceTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceTemplatesResponse
        /// </returns>
        public async Task<ListDataSourceTemplatesResponse> ListDataSourceTemplatesWithOptionsAsync(ListDataSourceTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataSourceTemplatesShrinkRequest request = new ListDataSourceTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceTemplateIds))
            {
                request.DataSourceTemplateIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceTemplateIds, "DataSourceTemplateIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceTemplateIdsShrink))
            {
                body["DataSourceTemplateIds"] = request.DataSourceTemplateIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceTemplates",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据源模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSourceTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceTemplatesResponse
        /// </returns>
        public ListDataSourceTemplatesResponse ListDataSourceTemplates(ListDataSourceTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSourceTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据源模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSourceTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceTemplatesResponse
        /// </returns>
        public async Task<ListDataSourceTemplatesResponse> ListDataSourceTemplatesAsync(ListDataSourceTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourceTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取厂商列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDataSourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
        public ListDataSourcesResponse ListDataSourcesWithOptions(ListDataSourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataSourcesShrinkRequest request = new ListDataSourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceIds))
            {
                request.DataSourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceIds, "DataSourceIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceTemplateIds))
            {
                request.DataSourceTemplateIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceTemplateIds, "DataSourceTemplateIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LogUserIds))
            {
                request.LogUserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LogUserIds, "LogUserIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceFrom))
            {
                body["DataSourceFrom"] = request.DataSourceFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceIdsShrink))
            {
                body["DataSourceIds"] = request.DataSourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["DataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceStatus))
            {
                body["DataSourceStatus"] = request.DataSourceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceStoreStatus))
            {
                body["DataSourceStoreStatus"] = request.DataSourceStoreStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceTemplateIdsShrink))
            {
                body["DataSourceTemplateIds"] = request.DataSourceTemplateIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserIdsShrink))
            {
                body["LogUserIds"] = request.LogUserIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSources",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取厂商列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDataSourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
        public async Task<ListDataSourcesResponse> ListDataSourcesWithOptionsAsync(ListDataSourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataSourcesShrinkRequest request = new ListDataSourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceIds))
            {
                request.DataSourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceIds, "DataSourceIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceTemplateIds))
            {
                request.DataSourceTemplateIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceTemplateIds, "DataSourceTemplateIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LogUserIds))
            {
                request.LogUserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LogUserIds, "LogUserIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceFrom))
            {
                body["DataSourceFrom"] = request.DataSourceFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceIdsShrink))
            {
                body["DataSourceIds"] = request.DataSourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["DataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceStatus))
            {
                body["DataSourceStatus"] = request.DataSourceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceStoreStatus))
            {
                body["DataSourceStoreStatus"] = request.DataSourceStoreStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceTemplateIdsShrink))
            {
                body["DataSourceTemplateIds"] = request.DataSourceTemplateIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserIdsShrink))
            {
                body["LogUserIds"] = request.LogUserIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSources",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取厂商列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
        public ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取厂商列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
        public async Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取检测规则列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDetectionRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDetectionRulesResponse
        /// </returns>
        public ListDetectionRulesResponse ListDetectionRulesWithOptions(ListDetectionRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDetectionRulesShrinkRequest request = new ListDetectionRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DetectionRuleIds))
            {
                request.DetectionRuleIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DetectionRuleIds, "DetectionRuleIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertAttCk))
            {
                body["AlertAttCk"] = request.AlertAttCk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertLevel))
            {
                body["AlertLevel"] = request.AlertLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTacticId))
            {
                body["AlertTacticId"] = request.AlertTacticId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionExpressionType))
            {
                body["DetectionExpressionType"] = request.DetectionExpressionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleId))
            {
                body["DetectionRuleId"] = request.DetectionRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleIdsShrink))
            {
                body["DetectionRuleIds"] = request.DetectionRuleIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleName))
            {
                body["DetectionRuleName"] = request.DetectionRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleStatus))
            {
                body["DetectionRuleStatus"] = request.DetectionRuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleType))
            {
                body["DetectionRuleType"] = request.DetectionRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentAggregationType))
            {
                body["IncidentAggregationType"] = request.IncidentAggregationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCategoryId))
            {
                body["LogCategoryId"] = request.LogCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSchemaId))
            {
                body["LogSchemaId"] = request.LogSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["OrderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderFieldName))
            {
                body["OrderFieldName"] = request.OrderFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDetectionRules",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDetectionRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取检测规则列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDetectionRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDetectionRulesResponse
        /// </returns>
        public async Task<ListDetectionRulesResponse> ListDetectionRulesWithOptionsAsync(ListDetectionRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDetectionRulesShrinkRequest request = new ListDetectionRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DetectionRuleIds))
            {
                request.DetectionRuleIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DetectionRuleIds, "DetectionRuleIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertAttCk))
            {
                body["AlertAttCk"] = request.AlertAttCk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertLevel))
            {
                body["AlertLevel"] = request.AlertLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTacticId))
            {
                body["AlertTacticId"] = request.AlertTacticId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionExpressionType))
            {
                body["DetectionExpressionType"] = request.DetectionExpressionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleId))
            {
                body["DetectionRuleId"] = request.DetectionRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleIdsShrink))
            {
                body["DetectionRuleIds"] = request.DetectionRuleIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleName))
            {
                body["DetectionRuleName"] = request.DetectionRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleStatus))
            {
                body["DetectionRuleStatus"] = request.DetectionRuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleType))
            {
                body["DetectionRuleType"] = request.DetectionRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentAggregationType))
            {
                body["IncidentAggregationType"] = request.IncidentAggregationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCategoryId))
            {
                body["LogCategoryId"] = request.LogCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSchemaId))
            {
                body["LogSchemaId"] = request.LogSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["OrderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderFieldName))
            {
                body["OrderFieldName"] = request.OrderFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDetectionRules",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDetectionRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取检测规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDetectionRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDetectionRulesResponse
        /// </returns>
        public ListDetectionRulesResponse ListDetectionRules(ListDetectionRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDetectionRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取检测规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDetectionRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDetectionRulesResponse
        /// </returns>
        public async Task<ListDetectionRulesResponse> ListDetectionRulesAsync(ListDetectionRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDetectionRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取事件列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListIncidentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIncidentsResponse
        /// </returns>
        public ListIncidentsResponse ListIncidentsWithOptions(ListIncidentsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListIncidentsShrinkRequest request = new ListIncidentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IncidentUuids))
            {
                request.IncidentUuidsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IncidentUuids, "IncidentUuids", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentName))
            {
                query["IncidentName"] = request.IncidentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuidsShrink))
            {
                query["IncidentUuids"] = request.IncidentUuidsShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertUuid))
            {
                body["AlertUuid"] = request.AlertUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentStatus))
            {
                body["IncidentStatus"] = request.IncidentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentTags))
            {
                body["IncidentTags"] = request.IncidentTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["OrderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderFieldName))
            {
                body["OrderFieldName"] = request.OrderFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateAssetId))
            {
                body["RelateAssetId"] = request.RelateAssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateEntityId))
            {
                body["RelateEntityId"] = request.RelateEntityId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIncidents",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIncidentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取事件列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListIncidentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIncidentsResponse
        /// </returns>
        public async Task<ListIncidentsResponse> ListIncidentsWithOptionsAsync(ListIncidentsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListIncidentsShrinkRequest request = new ListIncidentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IncidentUuids))
            {
                request.IncidentUuidsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IncidentUuids, "IncidentUuids", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentName))
            {
                query["IncidentName"] = request.IncidentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuidsShrink))
            {
                query["IncidentUuids"] = request.IncidentUuidsShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertUuid))
            {
                body["AlertUuid"] = request.AlertUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentStatus))
            {
                body["IncidentStatus"] = request.IncidentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentTags))
            {
                body["IncidentTags"] = request.IncidentTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["OrderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderFieldName))
            {
                body["OrderFieldName"] = request.OrderFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateAssetId))
            {
                body["RelateAssetId"] = request.RelateAssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateEntityId))
            {
                body["RelateEntityId"] = request.RelateEntityId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIncidents",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIncidentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取事件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIncidentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIncidentsResponse
        /// </returns>
        public ListIncidentsResponse ListIncidents(ListIncidentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIncidentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取事件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIncidentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIncidentsResponse
        /// </returns>
        public async Task<ListIncidentsResponse> ListIncidentsAsync(ListIncidentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIncidentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志Project列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogProjectsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogProjectsResponse
        /// </returns>
        public ListLogProjectsResponse ListLogProjectsWithOptions(ListLogProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogProjects",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogProjectsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志Project列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogProjectsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogProjectsResponse
        /// </returns>
        public async Task<ListLogProjectsResponse> ListLogProjectsWithOptionsAsync(ListLogProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogProjects",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志Project列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogProjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLogProjectsResponse
        /// </returns>
        public ListLogProjectsResponse ListLogProjects(ListLogProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLogProjectsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志Project列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogProjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLogProjectsResponse
        /// </returns>
        public async Task<ListLogProjectsResponse> ListLogProjectsAsync(ListLogProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLogProjectsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有的区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogRegionsResponse
        /// </returns>
        public ListLogRegionsResponse ListLogRegionsWithOptions(ListLogRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogRegions",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有的区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogRegionsResponse
        /// </returns>
        public async Task<ListLogRegionsResponse> ListLogRegionsWithOptionsAsync(ListLogRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogRegions",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有的区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLogRegionsResponse
        /// </returns>
        public ListLogRegionsResponse ListLogRegions(ListLogRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLogRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有的区域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLogRegionsResponse
        /// </returns>
        public async Task<ListLogRegionsResponse> ListLogRegionsAsync(ListLogRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLogRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志store列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogStoresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogStoresResponse
        /// </returns>
        public ListLogStoresResponse ListLogStoresWithOptions(ListLogStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogStores",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogStoresResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志store列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogStoresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogStoresResponse
        /// </returns>
        public async Task<ListLogStoresResponse> ListLogStoresWithOptionsAsync(ListLogStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogStores",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogStoresResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志store列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogStoresRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLogStoresResponse
        /// </returns>
        public ListLogStoresResponse ListLogStores(ListLogStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLogStoresWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志store列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogStoresRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLogStoresResponse
        /// </returns>
        public async Task<ListLogStoresResponse> ListLogStoresAsync(ListLogStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLogStoresWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationCategoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationCategoriesResponse
        /// </returns>
        public ListNormalizationCategoriesResponse ListNormalizationCategoriesWithOptions(ListNormalizationCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationCategoryType))
            {
                body["NormalizationCategoryType"] = request.NormalizationCategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNormalizationCategories",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNormalizationCategoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationCategoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationCategoriesResponse
        /// </returns>
        public async Task<ListNormalizationCategoriesResponse> ListNormalizationCategoriesWithOptionsAsync(ListNormalizationCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationCategoryType))
            {
                body["NormalizationCategoryType"] = request.NormalizationCategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNormalizationCategories",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNormalizationCategoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationCategoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationCategoriesResponse
        /// </returns>
        public ListNormalizationCategoriesResponse ListNormalizationCategories(ListNormalizationCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNormalizationCategoriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationCategoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationCategoriesResponse
        /// </returns>
        public async Task<ListNormalizationCategoriesResponse> ListNormalizationCategoriesAsync(ListNormalizationCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNormalizationCategoriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化日志所有字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationFieldsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationFieldsResponse
        /// </returns>
        public ListNormalizationFieldsResponse ListNormalizationFieldsWithOptions(ListNormalizationFieldsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNormalizationFields",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNormalizationFieldsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化日志所有字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationFieldsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationFieldsResponse
        /// </returns>
        public async Task<ListNormalizationFieldsResponse> ListNormalizationFieldsWithOptionsAsync(ListNormalizationFieldsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNormalizationFields",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNormalizationFieldsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化日志所有字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationFieldsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationFieldsResponse
        /// </returns>
        public ListNormalizationFieldsResponse ListNormalizationFields(ListNormalizationFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNormalizationFieldsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化日志所有字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationFieldsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationFieldsResponse
        /// </returns>
        public async Task<ListNormalizationFieldsResponse> ListNormalizationFieldsAsync(ListNormalizationFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNormalizationFieldsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取规则的安全能力</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListNormalizationRuleCapacitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationRuleCapacitiesResponse
        /// </returns>
        public ListNormalizationRuleCapacitiesResponse ListNormalizationRuleCapacitiesWithOptions(ListNormalizationRuleCapacitiesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListNormalizationRuleCapacitiesShrinkRequest request = new ListNormalizationRuleCapacitiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NormalizationRuleIds))
            {
                request.NormalizationRuleIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NormalizationRuleIds, "NormalizationRuleIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleIdsShrink))
            {
                body["NormalizationRuleIds"] = request.NormalizationRuleIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNormalizationRuleCapacities",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNormalizationRuleCapacitiesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取规则的安全能力</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListNormalizationRuleCapacitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationRuleCapacitiesResponse
        /// </returns>
        public async Task<ListNormalizationRuleCapacitiesResponse> ListNormalizationRuleCapacitiesWithOptionsAsync(ListNormalizationRuleCapacitiesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListNormalizationRuleCapacitiesShrinkRequest request = new ListNormalizationRuleCapacitiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NormalizationRuleIds))
            {
                request.NormalizationRuleIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NormalizationRuleIds, "NormalizationRuleIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleIdsShrink))
            {
                body["NormalizationRuleIds"] = request.NormalizationRuleIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNormalizationRuleCapacities",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNormalizationRuleCapacitiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取规则的安全能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationRuleCapacitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationRuleCapacitiesResponse
        /// </returns>
        public ListNormalizationRuleCapacitiesResponse ListNormalizationRuleCapacities(ListNormalizationRuleCapacitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNormalizationRuleCapacitiesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取规则的安全能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationRuleCapacitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationRuleCapacitiesResponse
        /// </returns>
        public async Task<ListNormalizationRuleCapacitiesResponse> ListNormalizationRuleCapacitiesAsync(ListNormalizationRuleCapacitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNormalizationRuleCapacitiesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationRuleVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationRuleVersionsResponse
        /// </returns>
        public ListNormalizationRuleVersionsResponse ListNormalizationRuleVersionsWithOptions(ListNormalizationRuleVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNormalizationRuleVersions",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNormalizationRuleVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationRuleVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationRuleVersionsResponse
        /// </returns>
        public async Task<ListNormalizationRuleVersionsResponse> ListNormalizationRuleVersionsWithOptionsAsync(ListNormalizationRuleVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNormalizationRuleVersions",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNormalizationRuleVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationRuleVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationRuleVersionsResponse
        /// </returns>
        public ListNormalizationRuleVersionsResponse ListNormalizationRuleVersions(ListNormalizationRuleVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNormalizationRuleVersionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationRuleVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationRuleVersionsResponse
        /// </returns>
        public async Task<ListNormalizationRuleVersionsResponse> ListNormalizationRuleVersionsAsync(ListNormalizationRuleVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNormalizationRuleVersionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListNormalizationRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationRulesResponse
        /// </returns>
        public ListNormalizationRulesResponse ListNormalizationRulesWithOptions(ListNormalizationRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListNormalizationRulesShrinkRequest request = new ListNormalizationRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NormalizationRuleIds))
            {
                request.NormalizationRuleIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NormalizationRuleIds, "NormalizationRuleIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationCategoryId))
            {
                body["NormalizationCategoryId"] = request.NormalizationCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleIdsShrink))
            {
                body["NormalizationRuleIds"] = request.NormalizationRuleIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleName))
            {
                body["NormalizationRuleName"] = request.NormalizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleType))
            {
                body["NormalizationRuleType"] = request.NormalizationRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaId))
            {
                body["NormalizationSchemaId"] = request.NormalizationSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                body["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorId))
            {
                body["VendorId"] = request.VendorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNormalizationRules",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNormalizationRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListNormalizationRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationRulesResponse
        /// </returns>
        public async Task<ListNormalizationRulesResponse> ListNormalizationRulesWithOptionsAsync(ListNormalizationRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListNormalizationRulesShrinkRequest request = new ListNormalizationRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NormalizationRuleIds))
            {
                request.NormalizationRuleIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NormalizationRuleIds, "NormalizationRuleIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationCategoryId))
            {
                body["NormalizationCategoryId"] = request.NormalizationCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleIdsShrink))
            {
                body["NormalizationRuleIds"] = request.NormalizationRuleIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleName))
            {
                body["NormalizationRuleName"] = request.NormalizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleType))
            {
                body["NormalizationRuleType"] = request.NormalizationRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaId))
            {
                body["NormalizationSchemaId"] = request.NormalizationSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                body["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorId))
            {
                body["VendorId"] = request.VendorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNormalizationRules",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNormalizationRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationRulesResponse
        /// </returns>
        public ListNormalizationRulesResponse ListNormalizationRules(ListNormalizationRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNormalizationRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationRulesResponse
        /// </returns>
        public async Task<ListNormalizationRulesResponse> ListNormalizationRulesAsync(ListNormalizationRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNormalizationRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化类目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationSchemasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationSchemasResponse
        /// </returns>
        public ListNormalizationSchemasResponse ListNormalizationSchemasWithOptions(ListNormalizationSchemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationCategoryId))
            {
                body["NormalizationCategoryId"] = request.NormalizationCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaType))
            {
                body["NormalizationSchemaType"] = request.NormalizationSchemaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNormalizationSchemas",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNormalizationSchemasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化类目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationSchemasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationSchemasResponse
        /// </returns>
        public async Task<ListNormalizationSchemasResponse> ListNormalizationSchemasWithOptionsAsync(ListNormalizationSchemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationCategoryId))
            {
                body["NormalizationCategoryId"] = request.NormalizationCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaType))
            {
                body["NormalizationSchemaType"] = request.NormalizationSchemaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNormalizationSchemas",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNormalizationSchemasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化类目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationSchemasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationSchemasResponse
        /// </returns>
        public ListNormalizationSchemasResponse ListNormalizationSchemas(ListNormalizationSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNormalizationSchemasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取标准化类目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNormalizationSchemasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNormalizationSchemasResponse
        /// </returns>
        public async Task<ListNormalizationSchemasResponse> ListNormalizationSchemasAsync(ListNormalizationSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNormalizationSchemasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListProductsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
        public ListProductsResponse ListProductsWithOptions(ListProductsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProductsShrinkRequest request = new ListProductsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProductIds))
            {
                request.ProductIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProductIds, "ProductIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIdsShrink))
            {
                body["ProductIds"] = request.ProductIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["ProductName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorId))
            {
                body["VendorId"] = request.VendorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProducts",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListProductsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
        public async Task<ListProductsResponse> ListProductsWithOptionsAsync(ListProductsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProductsShrinkRequest request = new ListProductsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProductIds))
            {
                request.ProductIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProductIds, "ProductIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIdsShrink))
            {
                body["ProductIds"] = request.ProductIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["ProductName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorId))
            {
                body["VendorId"] = request.VendorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProducts",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
        public ListProductsResponse ListProducts(ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
        public async Task<ListProductsResponse> ListProductsAsync(ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接入流量统计</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTrafficStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTrafficStatisticsResponse
        /// </returns>
        public ListTrafficStatisticsResponse ListTrafficStatisticsWithOptions(ListTrafficStatisticsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTrafficStatisticsShrinkRequest request = new ListTrafficStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LogUserIds))
            {
                request.LogUserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LogUserIds, "LogUserIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserIdsShrink))
            {
                body["LogUserIds"] = request.LogUserIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionTag))
            {
                body["RegionTag"] = request.RegionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficStatisticPeriod))
            {
                body["TrafficStatisticPeriod"] = request.TrafficStatisticPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficStatisticPeriodType))
            {
                body["TrafficStatisticPeriodType"] = request.TrafficStatisticPeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficStatisticType))
            {
                body["TrafficStatisticType"] = request.TrafficStatisticType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrafficStatistics",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrafficStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接入流量统计</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTrafficStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTrafficStatisticsResponse
        /// </returns>
        public async Task<ListTrafficStatisticsResponse> ListTrafficStatisticsWithOptionsAsync(ListTrafficStatisticsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTrafficStatisticsShrinkRequest request = new ListTrafficStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LogUserIds))
            {
                request.LogUserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LogUserIds, "LogUserIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserIdsShrink))
            {
                body["LogUserIds"] = request.LogUserIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionTag))
            {
                body["RegionTag"] = request.RegionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficStatisticPeriod))
            {
                body["TrafficStatisticPeriod"] = request.TrafficStatisticPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficStatisticPeriodType))
            {
                body["TrafficStatisticPeriodType"] = request.TrafficStatisticPeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficStatisticType))
            {
                body["TrafficStatisticType"] = request.TrafficStatisticType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrafficStatistics",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrafficStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接入流量统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTrafficStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTrafficStatisticsResponse
        /// </returns>
        public ListTrafficStatisticsResponse ListTrafficStatistics(ListTrafficStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTrafficStatisticsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接入流量统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTrafficStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTrafficStatisticsResponse
        /// </returns>
        public async Task<ListTrafficStatisticsResponse> ListTrafficStatisticsAsync(ListTrafficStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTrafficStatisticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取升级项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUpgradeItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUpgradeItemsResponse
        /// </returns>
        public ListUpgradeItemsResponse ListUpgradeItemsWithOptions(ListUpgradeItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUpgradeItems",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUpgradeItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取升级项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUpgradeItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUpgradeItemsResponse
        /// </returns>
        public async Task<ListUpgradeItemsResponse> ListUpgradeItemsWithOptionsAsync(ListUpgradeItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUpgradeItems",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUpgradeItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取升级项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUpgradeItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUpgradeItemsResponse
        /// </returns>
        public ListUpgradeItemsResponse ListUpgradeItems(ListUpgradeItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUpgradeItemsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取升级项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUpgradeItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUpgradeItemsResponse
        /// </returns>
        public async Task<ListUpgradeItemsResponse> ListUpgradeItemsAsync(ListUpgradeItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUpgradeItemsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取厂商列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListVendorsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVendorsResponse
        /// </returns>
        public ListVendorsResponse ListVendorsWithOptions(ListVendorsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListVendorsShrinkRequest request = new ListVendorsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VendorIds))
            {
                request.VendorIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VendorIds, "VendorIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorIdsShrink))
            {
                body["VendorIds"] = request.VendorIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorName))
            {
                body["VendorName"] = request.VendorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorType))
            {
                body["VendorType"] = request.VendorType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVendors",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVendorsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取厂商列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListVendorsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVendorsResponse
        /// </returns>
        public async Task<ListVendorsResponse> ListVendorsWithOptionsAsync(ListVendorsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListVendorsShrinkRequest request = new ListVendorsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VendorIds))
            {
                request.VendorIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VendorIds, "VendorIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorIdsShrink))
            {
                body["VendorIds"] = request.VendorIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorName))
            {
                body["VendorName"] = request.VendorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorType))
            {
                body["VendorType"] = request.VendorType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVendors",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVendorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取厂商列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVendorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVendorsResponse
        /// </returns>
        public ListVendorsResponse ListVendors(ListVendorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVendorsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取厂商列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVendorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVendorsResponse
        /// </returns>
        public async Task<ListVendorsResponse> ListVendorsAsync(ListVendorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVendorsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据存储的清空操作，该动作会删除已有的数据，重新初始化物理存储。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetDataStorageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetDataStorageResponse
        /// </returns>
        public ResetDataStorageResponse ResetDataStorageWithOptions(ResetDataStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetDataStorage",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetDataStorageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据存储的清空操作，该动作会删除已有的数据，重新初始化物理存储。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetDataStorageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetDataStorageResponse
        /// </returns>
        public async Task<ResetDataStorageResponse> ResetDataStorageWithOptionsAsync(ResetDataStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetDataStorage",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetDataStorageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据存储的清空操作，该动作会删除已有的数据，重新初始化物理存储。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetDataStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetDataStorageResponse
        /// </returns>
        public ResetDataStorageResponse ResetDataStorage(ResetDataStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetDataStorageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据存储的清空操作，该动作会删除已有的数据，重新初始化物理存储。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetDataStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetDataStorageResponse
        /// </returns>
        public async Task<ResetDataStorageResponse> ResetDataStorageAsync(ResetDataStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetDataStorageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置标准化规则默认版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDefaultNormalizationRuleVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDefaultNormalizationRuleVersionResponse
        /// </returns>
        public SetDefaultNormalizationRuleVersionResponse SetDefaultNormalizationRuleVersionWithOptions(SetDefaultNormalizationRuleVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleVersion))
            {
                body["NormalizationRuleVersion"] = request.NormalizationRuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultNormalizationRuleVersion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultNormalizationRuleVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置标准化规则默认版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDefaultNormalizationRuleVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDefaultNormalizationRuleVersionResponse
        /// </returns>
        public async Task<SetDefaultNormalizationRuleVersionResponse> SetDefaultNormalizationRuleVersionWithOptionsAsync(SetDefaultNormalizationRuleVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleVersion))
            {
                body["NormalizationRuleVersion"] = request.NormalizationRuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultNormalizationRuleVersion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultNormalizationRuleVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置标准化规则默认版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDefaultNormalizationRuleVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDefaultNormalizationRuleVersionResponse
        /// </returns>
        public SetDefaultNormalizationRuleVersionResponse SetDefaultNormalizationRuleVersion(SetDefaultNormalizationRuleVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultNormalizationRuleVersionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置标准化规则默认版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDefaultNormalizationRuleVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDefaultNormalizationRuleVersionResponse
        /// </returns>
        public async Task<SetDefaultNormalizationRuleVersionResponse> SetDefaultNormalizationRuleVersionAsync(SetDefaultNormalizationRuleVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultNormalizationRuleVersionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据批量接入</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataBatchIngestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataBatchIngestionResponse
        /// </returns>
        public UpdateDataBatchIngestionResponse UpdateDataBatchIngestionWithOptions(UpdateDataBatchIngestionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataBatchIngestionShrinkRequest request = new UpdateDataBatchIngestionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataIngestionIds))
            {
                request.DataIngestionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataIngestionIds, "DataIngestionIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LogUserIds))
            {
                request.LogUserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LogUserIds, "LogUserIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScanNew))
            {
                body["AutoScanNew"] = request.AutoScanNew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataBatchIngestionMode))
            {
                body["DataBatchIngestionMode"] = request.DataBatchIngestionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionIdsShrink))
            {
                body["DataIngestionIds"] = request.DataIngestionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceRecognizeEnabled))
            {
                body["DataSourceRecognizeEnabled"] = request.DataSourceRecognizeEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserIdsShrink))
            {
                body["LogUserIds"] = request.LogUserIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataBatchIngestion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataBatchIngestionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据批量接入</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataBatchIngestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataBatchIngestionResponse
        /// </returns>
        public async Task<UpdateDataBatchIngestionResponse> UpdateDataBatchIngestionWithOptionsAsync(UpdateDataBatchIngestionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataBatchIngestionShrinkRequest request = new UpdateDataBatchIngestionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataIngestionIds))
            {
                request.DataIngestionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataIngestionIds, "DataIngestionIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LogUserIds))
            {
                request.LogUserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LogUserIds, "LogUserIds", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScanNew))
            {
                body["AutoScanNew"] = request.AutoScanNew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataBatchIngestionMode))
            {
                body["DataBatchIngestionMode"] = request.DataBatchIngestionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionIdsShrink))
            {
                body["DataIngestionIds"] = request.DataIngestionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceRecognizeEnabled))
            {
                body["DataSourceRecognizeEnabled"] = request.DataSourceRecognizeEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserIdsShrink))
            {
                body["LogUserIds"] = request.LogUserIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataBatchIngestion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataBatchIngestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据批量接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataBatchIngestionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataBatchIngestionResponse
        /// </returns>
        public UpdateDataBatchIngestionResponse UpdateDataBatchIngestion(UpdateDataBatchIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataBatchIngestionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据批量接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataBatchIngestionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataBatchIngestionResponse
        /// </returns>
        public async Task<UpdateDataBatchIngestionResponse> UpdateDataBatchIngestionAsync(UpdateDataBatchIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataBatchIngestionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据接入信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataIngestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataIngestionResponse
        /// </returns>
        public UpdateDataIngestionResponse UpdateDataIngestionWithOptions(UpdateDataIngestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionId))
            {
                body["DataIngestionId"] = request.DataIngestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionMode))
            {
                body["DataIngestionMode"] = request.DataIngestionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataIngestion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataIngestionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据接入信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataIngestionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataIngestionResponse
        /// </returns>
        public async Task<UpdateDataIngestionResponse> UpdateDataIngestionWithOptionsAsync(UpdateDataIngestionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionId))
            {
                body["DataIngestionId"] = request.DataIngestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionMode))
            {
                body["DataIngestionMode"] = request.DataIngestionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataIngestion",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataIngestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据接入信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataIngestionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataIngestionResponse
        /// </returns>
        public UpdateDataIngestionResponse UpdateDataIngestion(UpdateDataIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataIngestionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据接入信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataIngestionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataIngestionResponse
        /// </returns>
        public async Task<UpdateDataIngestionResponse> UpdateDataIngestionAsync(UpdateDataIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataIngestionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新接入模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataIngestionTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataIngestionTemplateResponse
        /// </returns>
        public UpdateDataIngestionTemplateResponse UpdateDataIngestionTemplateWithOptions(UpdateDataIngestionTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionStatus))
            {
                body["DataIngestionStatus"] = request.DataIngestionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionTemplateId))
            {
                body["DataIngestionTemplateId"] = request.DataIngestionTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionTemplateName))
            {
                body["DataIngestionTemplateName"] = request.DataIngestionTemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataIngestionTemplate",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataIngestionTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新接入模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataIngestionTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataIngestionTemplateResponse
        /// </returns>
        public async Task<UpdateDataIngestionTemplateResponse> UpdateDataIngestionTemplateWithOptionsAsync(UpdateDataIngestionTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionStatus))
            {
                body["DataIngestionStatus"] = request.DataIngestionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionTemplateId))
            {
                body["DataIngestionTemplateId"] = request.DataIngestionTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataIngestionTemplateName))
            {
                body["DataIngestionTemplateName"] = request.DataIngestionTemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataIngestionTemplate",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataIngestionTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新接入模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataIngestionTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataIngestionTemplateResponse
        /// </returns>
        public UpdateDataIngestionTemplateResponse UpdateDataIngestionTemplate(UpdateDataIngestionTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataIngestionTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新接入模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataIngestionTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataIngestionTemplateResponse
        /// </returns>
        public async Task<UpdateDataIngestionTemplateResponse> UpdateDataIngestionTemplateAsync(UpdateDataIngestionTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataIngestionTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSetResponse
        /// </returns>
        public UpdateDataSetResponse UpdateDataSetWithOptions(UpdateDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetDescription))
            {
                body["DataSetDescription"] = request.DataSetDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetFileName))
            {
                body["DataSetFileName"] = request.DataSetFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetId))
            {
                body["DataSetId"] = request.DataSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetName))
            {
                body["DataSetName"] = request.DataSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetStatus))
            {
                body["DataSetStatus"] = request.DataSetStatus;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelistRecognizers))
            {
                bodyFlat["IpWhitelistRecognizers"] = request.IpWhitelistRecognizers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
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
                Action = "UpdateDataSet",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSetResponse
        /// </returns>
        public async Task<UpdateDataSetResponse> UpdateDataSetWithOptionsAsync(UpdateDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetDescription))
            {
                body["DataSetDescription"] = request.DataSetDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetFileName))
            {
                body["DataSetFileName"] = request.DataSetFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetId))
            {
                body["DataSetId"] = request.DataSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetName))
            {
                body["DataSetName"] = request.DataSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetStatus))
            {
                body["DataSetStatus"] = request.DataSetStatus;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelistRecognizers))
            {
                bodyFlat["IpWhitelistRecognizers"] = request.IpWhitelistRecognizers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
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
                Action = "UpdateDataSet",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSetResponse
        /// </returns>
        public UpdateDataSetResponse UpdateDataSet(UpdateDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataSetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSetResponse
        /// </returns>
        public async Task<UpdateDataSetResponse> UpdateDataSetAsync(UpdateDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataSetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据集记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSetRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSetRecordResponse
        /// </returns>
        public UpdateDataSetRecordResponse UpdateDataSetRecordWithOptions(UpdateDataSetRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetFileName))
            {
                body["DataSetFileName"] = request.DataSetFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetId))
            {
                body["DataSetId"] = request.DataSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetRecords))
            {
                body["DataSetRecords"] = request.DataSetRecords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataSetRecord",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataSetRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据集记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSetRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSetRecordResponse
        /// </returns>
        public async Task<UpdateDataSetRecordResponse> UpdateDataSetRecordWithOptionsAsync(UpdateDataSetRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetFileName))
            {
                body["DataSetFileName"] = request.DataSetFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetId))
            {
                body["DataSetId"] = request.DataSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetRecords))
            {
                body["DataSetRecords"] = request.DataSetRecords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataSetRecord",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataSetRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据集记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSetRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSetRecordResponse
        /// </returns>
        public UpdateDataSetRecordResponse UpdateDataSetRecord(UpdateDataSetRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataSetRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据集记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSetRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSetRecordResponse
        /// </returns>
        public async Task<UpdateDataSetRecordResponse> UpdateDataSetRecordAsync(UpdateDataSetRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataSetRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceResponse
        /// </returns>
        public UpdateDataSourceResponse UpdateDataSourceWithOptions(UpdateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceFrom))
            {
                body["DataSourceFrom"] = request.DataSourceFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["DataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceRecognizeEnabled))
            {
                body["DataSourceRecognizeEnabled"] = request.DataSourceRecognizeEnabled;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceStores))
            {
                bodyFlat["DataSourceStores"] = request.DataSourceStores;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
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
                Action = "UpdateDataSource",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceResponse
        /// </returns>
        public async Task<UpdateDataSourceResponse> UpdateDataSourceWithOptionsAsync(UpdateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceFrom))
            {
                body["DataSourceFrom"] = request.DataSourceFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["DataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceRecognizeEnabled))
            {
                body["DataSourceRecognizeEnabled"] = request.DataSourceRecognizeEnabled;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceStores))
            {
                bodyFlat["DataSourceStores"] = request.DataSourceStores;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
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
                Action = "UpdateDataSource",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceResponse
        /// </returns>
        public UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceResponse
        /// </returns>
        public async Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据源模板</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataSourceTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceTemplateResponse
        /// </returns>
        public UpdateDataSourceTemplateResponse UpdateDataSourceTemplateWithOptions(UpdateDataSourceTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataSourceTemplateShrinkRequest request = new UpdateDataSourceTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LogUserIds))
            {
                request.LogUserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LogUserIds, "LogUserIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceRecognizeEnabled))
            {
                query["DataSourceRecognizeEnabled"] = request.DataSourceRecognizeEnabled;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScanNew))
            {
                body["AutoScanNew"] = request.AutoScanNew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceTemplateId))
            {
                body["DataSourceTemplateId"] = request.DataSourceTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceTemplateName))
            {
                body["DataSourceTemplateName"] = request.DataSourceTemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectPattern))
            {
                body["LogProjectPattern"] = request.LogProjectPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionIds))
            {
                body["LogRegionIds"] = request.LogRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStorePattern))
            {
                body["LogStorePattern"] = request.LogStorePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserIdsShrink))
            {
                body["LogUserIds"] = request.LogUserIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataSourceTemplate",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataSourceTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据源模板</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataSourceTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceTemplateResponse
        /// </returns>
        public async Task<UpdateDataSourceTemplateResponse> UpdateDataSourceTemplateWithOptionsAsync(UpdateDataSourceTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataSourceTemplateShrinkRequest request = new UpdateDataSourceTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LogUserIds))
            {
                request.LogUserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LogUserIds, "LogUserIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceRecognizeEnabled))
            {
                query["DataSourceRecognizeEnabled"] = request.DataSourceRecognizeEnabled;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScanNew))
            {
                body["AutoScanNew"] = request.AutoScanNew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceTemplateId))
            {
                body["DataSourceTemplateId"] = request.DataSourceTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceTemplateName))
            {
                body["DataSourceTemplateName"] = request.DataSourceTemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectPattern))
            {
                body["LogProjectPattern"] = request.LogProjectPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionIds))
            {
                body["LogRegionIds"] = request.LogRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStorePattern))
            {
                body["LogStorePattern"] = request.LogStorePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserIdsShrink))
            {
                body["LogUserIds"] = request.LogUserIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataSourceTemplate",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataSourceTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据源模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSourceTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceTemplateResponse
        /// </returns>
        public UpdateDataSourceTemplateResponse UpdateDataSourceTemplate(UpdateDataSourceTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataSourceTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据源模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataSourceTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataSourceTemplateResponse
        /// </returns>
        public async Task<UpdateDataSourceTemplateResponse> UpdateDataSourceTemplateAsync(UpdateDataSourceTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataSourceTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志管理页面里用户数据存储的详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataStorageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataStorageResponse
        /// </returns>
        public UpdateDataStorageResponse UpdateDataStorageWithOptions(UpdateDataStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataStorageRegionId))
            {
                body["DataStorageRegionId"] = request.DataStorageRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryStatus))
            {
                body["DeliveryStatus"] = request.DeliveryStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataStorage",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataStorageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志管理页面里用户数据存储的详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataStorageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataStorageResponse
        /// </returns>
        public async Task<UpdateDataStorageResponse> UpdateDataStorageWithOptionsAsync(UpdateDataStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataStorageRegionId))
            {
                body["DataStorageRegionId"] = request.DataStorageRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryStatus))
            {
                body["DeliveryStatus"] = request.DeliveryStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataStorage",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataStorageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志管理页面里用户数据存储的详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataStorageResponse
        /// </returns>
        public UpdateDataStorageResponse UpdateDataStorage(UpdateDataStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataStorageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日志管理页面里用户数据存储的详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataStorageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataStorageResponse
        /// </returns>
        public async Task<UpdateDataStorageResponse> UpdateDataStorageAsync(UpdateDataStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataStorageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作日志投递.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataStorageDeliveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataStorageDeliveryResponse
        /// </returns>
        public UpdateDataStorageDeliveryResponse UpdateDataStorageDeliveryWithOptions(UpdateDataStorageDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDeliveryStatus))
            {
                body["LogDeliveryStatus"] = request.LogDeliveryStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataStorageDelivery",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataStorageDeliveryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作日志投递.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataStorageDeliveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataStorageDeliveryResponse
        /// </returns>
        public async Task<UpdateDataStorageDeliveryResponse> UpdateDataStorageDeliveryWithOptionsAsync(UpdateDataStorageDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDeliveryStatus))
            {
                body["LogDeliveryStatus"] = request.LogDeliveryStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataStorageDelivery",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataStorageDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作日志投递.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataStorageDeliveryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataStorageDeliveryResponse
        /// </returns>
        public UpdateDataStorageDeliveryResponse UpdateDataStorageDelivery(UpdateDataStorageDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataStorageDeliveryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作日志投递.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataStorageDeliveryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataStorageDeliveryResponse
        /// </returns>
        public async Task<UpdateDataStorageDeliveryResponse> UpdateDataStorageDeliveryAsync(UpdateDataStorageDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataStorageDeliveryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据存储中日志的数据保存天数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataStorageTtlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataStorageTtlResponse
        /// </returns>
        public UpdateDataStorageTtlResponse UpdateDataStorageTtlWithOptions(UpdateDataStorageTtlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreColdTtl))
            {
                body["LogStoreColdTtl"] = request.LogStoreColdTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreHotTtl))
            {
                body["LogStoreHotTtl"] = request.LogStoreHotTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreTtl))
            {
                body["LogStoreTtl"] = request.LogStoreTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataStorageTtl",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataStorageTtlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据存储中日志的数据保存天数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataStorageTtlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataStorageTtlResponse
        /// </returns>
        public async Task<UpdateDataStorageTtlResponse> UpdateDataStorageTtlWithOptionsAsync(UpdateDataStorageTtlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreColdTtl))
            {
                body["LogStoreColdTtl"] = request.LogStoreColdTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreHotTtl))
            {
                body["LogStoreHotTtl"] = request.LogStoreHotTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreTtl))
            {
                body["LogStoreTtl"] = request.LogStoreTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataStorageTtl",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataStorageTtlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据存储中日志的数据保存天数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataStorageTtlRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataStorageTtlResponse
        /// </returns>
        public UpdateDataStorageTtlResponse UpdateDataStorageTtl(UpdateDataStorageTtlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataStorageTtlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据存储中日志的数据保存天数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataStorageTtlRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataStorageTtlResponse
        /// </returns>
        public async Task<UpdateDataStorageTtlResponse> UpdateDataStorageTtlAsync(UpdateDataStorageTtlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataStorageTtlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDetectionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDetectionRuleResponse
        /// </returns>
        public UpdateDetectionRuleResponse UpdateDetectionRuleWithOptions(UpdateDetectionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertAttCk))
            {
                body["AlertAttCk"] = request.AlertAttCk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertLevel))
            {
                body["AlertLevel"] = request.AlertLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertSchemaId))
            {
                body["AlertSchemaId"] = request.AlertSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTacticId))
            {
                body["AlertTacticId"] = request.AlertTacticId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertThresholdCount))
            {
                body["AlertThresholdCount"] = request.AlertThresholdCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertThresholdGroup))
            {
                body["AlertThresholdGroup"] = request.AlertThresholdGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertThresholdPeriod))
            {
                body["AlertThresholdPeriod"] = request.AlertThresholdPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionExpressionContent))
            {
                body["DetectionExpressionContent"] = request.DetectionExpressionContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionExpressionType))
            {
                body["DetectionExpressionType"] = request.DetectionExpressionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleDescription))
            {
                body["DetectionRuleDescription"] = request.DetectionRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleId))
            {
                body["DetectionRuleId"] = request.DetectionRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleName))
            {
                body["DetectionRuleName"] = request.DetectionRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleStatus))
            {
                body["DetectionRuleStatus"] = request.DetectionRuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleType))
            {
                body["DetectionRuleType"] = request.DetectionRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityMappings))
            {
                body["EntityMappings"] = request.EntityMappings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentAggregationExpression))
            {
                body["IncidentAggregationExpression"] = request.IncidentAggregationExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentAggregationType))
            {
                body["IncidentAggregationType"] = request.IncidentAggregationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCategoryId))
            {
                body["LogCategoryId"] = request.LogCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSchemaId))
            {
                body["LogSchemaId"] = request.LogSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookParameters))
            {
                body["PlaybookParameters"] = request.PlaybookParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleBeginTime))
            {
                body["ScheduleBeginTime"] = request.ScheduleBeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleExpression))
            {
                body["ScheduleExpression"] = request.ScheduleExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleMaxRetries))
            {
                body["ScheduleMaxRetries"] = request.ScheduleMaxRetries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleMaxTimeout))
            {
                body["ScheduleMaxTimeout"] = request.ScheduleMaxTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                body["ScheduleType"] = request.ScheduleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleWindow))
            {
                body["ScheduleWindow"] = request.ScheduleWindow;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDetectionRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDetectionRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDetectionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDetectionRuleResponse
        /// </returns>
        public async Task<UpdateDetectionRuleResponse> UpdateDetectionRuleWithOptionsAsync(UpdateDetectionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertAttCk))
            {
                body["AlertAttCk"] = request.AlertAttCk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertLevel))
            {
                body["AlertLevel"] = request.AlertLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertSchemaId))
            {
                body["AlertSchemaId"] = request.AlertSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTacticId))
            {
                body["AlertTacticId"] = request.AlertTacticId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertThresholdCount))
            {
                body["AlertThresholdCount"] = request.AlertThresholdCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertThresholdGroup))
            {
                body["AlertThresholdGroup"] = request.AlertThresholdGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertThresholdPeriod))
            {
                body["AlertThresholdPeriod"] = request.AlertThresholdPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionExpressionContent))
            {
                body["DetectionExpressionContent"] = request.DetectionExpressionContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionExpressionType))
            {
                body["DetectionExpressionType"] = request.DetectionExpressionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleDescription))
            {
                body["DetectionRuleDescription"] = request.DetectionRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleId))
            {
                body["DetectionRuleId"] = request.DetectionRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleName))
            {
                body["DetectionRuleName"] = request.DetectionRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleStatus))
            {
                body["DetectionRuleStatus"] = request.DetectionRuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectionRuleType))
            {
                body["DetectionRuleType"] = request.DetectionRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityMappings))
            {
                body["EntityMappings"] = request.EntityMappings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentAggregationExpression))
            {
                body["IncidentAggregationExpression"] = request.IncidentAggregationExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentAggregationType))
            {
                body["IncidentAggregationType"] = request.IncidentAggregationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCategoryId))
            {
                body["LogCategoryId"] = request.LogCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSchemaId))
            {
                body["LogSchemaId"] = request.LogSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookParameters))
            {
                body["PlaybookParameters"] = request.PlaybookParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleBeginTime))
            {
                body["ScheduleBeginTime"] = request.ScheduleBeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleExpression))
            {
                body["ScheduleExpression"] = request.ScheduleExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleMaxRetries))
            {
                body["ScheduleMaxRetries"] = request.ScheduleMaxRetries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleMaxTimeout))
            {
                body["ScheduleMaxTimeout"] = request.ScheduleMaxTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                body["ScheduleType"] = request.ScheduleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleWindow))
            {
                body["ScheduleWindow"] = request.ScheduleWindow;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDetectionRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDetectionRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDetectionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDetectionRuleResponse
        /// </returns>
        public UpdateDetectionRuleResponse UpdateDetectionRule(UpdateDetectionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDetectionRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新检测规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDetectionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDetectionRuleResponse
        /// </returns>
        public async Task<UpdateDetectionRuleResponse> UpdateDetectionRuleAsync(UpdateDetectionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDetectionRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新标准化规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateNormalizationRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNormalizationRuleResponse
        /// </returns>
        public UpdateNormalizationRuleResponse UpdateNormalizationRuleWithOptions(UpdateNormalizationRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateNormalizationRuleShrinkRequest request = new UpdateNormalizationRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NormalizationRuleIds))
            {
                request.NormalizationRuleIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NormalizationRuleIds, "NormalizationRuleIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendContentPacked))
            {
                body["ExtendContentPacked"] = request.ExtendContentPacked;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleDescription))
            {
                body["NormalizationRuleDescription"] = request.NormalizationRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleExpression))
            {
                body["NormalizationRuleExpression"] = request.NormalizationRuleExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleFormat))
            {
                body["NormalizationRuleFormat"] = request.NormalizationRuleFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleIdsShrink))
            {
                body["NormalizationRuleIds"] = request.NormalizationRuleIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleMode))
            {
                body["NormalizationRuleMode"] = request.NormalizationRuleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleName))
            {
                body["NormalizationRuleName"] = request.NormalizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleType))
            {
                body["NormalizationRuleType"] = request.NormalizationRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaId))
            {
                body["NormalizationSchemaId"] = request.NormalizationSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorId))
            {
                body["VendorId"] = request.VendorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNormalizationRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNormalizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新标准化规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateNormalizationRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNormalizationRuleResponse
        /// </returns>
        public async Task<UpdateNormalizationRuleResponse> UpdateNormalizationRuleWithOptionsAsync(UpdateNormalizationRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateNormalizationRuleShrinkRequest request = new UpdateNormalizationRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NormalizationRuleIds))
            {
                request.NormalizationRuleIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NormalizationRuleIds, "NormalizationRuleIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendContentPacked))
            {
                body["ExtendContentPacked"] = request.ExtendContentPacked;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleDescription))
            {
                body["NormalizationRuleDescription"] = request.NormalizationRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleExpression))
            {
                body["NormalizationRuleExpression"] = request.NormalizationRuleExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleFormat))
            {
                body["NormalizationRuleFormat"] = request.NormalizationRuleFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleId))
            {
                body["NormalizationRuleId"] = request.NormalizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleIdsShrink))
            {
                body["NormalizationRuleIds"] = request.NormalizationRuleIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleMode))
            {
                body["NormalizationRuleMode"] = request.NormalizationRuleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleName))
            {
                body["NormalizationRuleName"] = request.NormalizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationRuleType))
            {
                body["NormalizationRuleType"] = request.NormalizationRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaId))
            {
                body["NormalizationSchemaId"] = request.NormalizationSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorId))
            {
                body["VendorId"] = request.VendorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNormalizationRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNormalizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新标准化规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNormalizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNormalizationRuleResponse
        /// </returns>
        public UpdateNormalizationRuleResponse UpdateNormalizationRule(UpdateNormalizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNormalizationRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新标准化规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNormalizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNormalizationRuleResponse
        /// </returns>
        public async Task<UpdateNormalizationRuleResponse> UpdateNormalizationRuleAsync(UpdateNormalizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNormalizationRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新产品品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProductResponse
        /// </returns>
        public UpdateProductResponse UpdateProductWithOptions(UpdateProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["ProductName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorName))
            {
                body["VendorName"] = request.VendorName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProduct",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProductResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新产品品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProductResponse
        /// </returns>
        public async Task<UpdateProductResponse> UpdateProductWithOptionsAsync(UpdateProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["ProductName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorName))
            {
                body["VendorName"] = request.VendorName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProduct",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新产品品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProductRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProductResponse
        /// </returns>
        public UpdateProductResponse UpdateProduct(UpdateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProductWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新产品品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProductRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProductResponse
        /// </returns>
        public async Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProductWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新厂商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVendorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVendorResponse
        /// </returns>
        public UpdateVendorResponse UpdateVendorWithOptions(UpdateVendorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorId))
            {
                body["VendorId"] = request.VendorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorName))
            {
                body["VendorName"] = request.VendorName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVendor",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVendorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新厂商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVendorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVendorResponse
        /// </returns>
        public async Task<UpdateVendorResponse> UpdateVendorWithOptionsAsync(UpdateVendorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorId))
            {
                body["VendorId"] = request.VendorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorName))
            {
                body["VendorName"] = request.VendorName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVendor",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVendorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新厂商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVendorRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVendorResponse
        /// </returns>
        public UpdateVendorResponse UpdateVendor(UpdateVendorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVendorWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新厂商</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVendorRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVendorResponse
        /// </returns>
        public async Task<UpdateVendorResponse> UpdateVendorAsync(UpdateVendorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVendorWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateLogStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateLogStoreResponse
        /// </returns>
        public ValidateLogStoreResponse ValidateLogStoreWithOptions(ValidateLogStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateLogStore",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateLogStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateLogStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateLogStoreResponse
        /// </returns>
        public async Task<ValidateLogStoreResponse> ValidateLogStoreWithOptionsAsync(ValidateLogStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProjectName))
            {
                body["LogProjectName"] = request.LogProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                body["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                body["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateLogStore",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateLogStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateLogStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateLogStoreResponse
        /// </returns>
        public ValidateLogStoreResponse ValidateLogStore(ValidateLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateLogStoreWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验LogStore</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateLogStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateLogStoreResponse
        /// </returns>
        public async Task<ValidateLogStoreResponse> ValidateLogStoreAsync(ValidateLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateLogStoreWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验规则和数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateNormalizationRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateNormalizationRuleResponse
        /// </returns>
        public ValidateNormalizationRuleResponse ValidateNormalizationRuleWithOptions(ValidateNormalizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationCategoryId))
            {
                body["NormalizationCategoryId"] = request.NormalizationCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaId))
            {
                body["NormalizationSchemaId"] = request.NormalizationSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateNormalizationRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateNormalizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验规则和数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateNormalizationRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateNormalizationRuleResponse
        /// </returns>
        public async Task<ValidateNormalizationRuleResponse> ValidateNormalizationRuleWithOptionsAsync(ValidateNormalizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationCategoryId))
            {
                body["NormalizationCategoryId"] = request.NormalizationCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NormalizationSchemaId))
            {
                body["NormalizationSchemaId"] = request.NormalizationSchemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateNormalizationRule",
                Version = "2024-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateNormalizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验规则和数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateNormalizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateNormalizationRuleResponse
        /// </returns>
        public ValidateNormalizationRuleResponse ValidateNormalizationRule(ValidateNormalizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateNormalizationRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验规则和数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateNormalizationRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateNormalizationRuleResponse
        /// </returns>
        public async Task<ValidateNormalizationRuleResponse> ValidateNormalizationRuleAsync(ValidateNormalizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateNormalizationRuleWithOptionsAsync(request, runtime);
        }

    }
}
