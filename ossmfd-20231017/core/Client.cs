// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.OssMfd20231017.Models;

namespace AlibabaCloud.SDK.OssMfd20231017
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ossmfd", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>检查服务是否开通</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckMfdServiceOpenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckMfdServiceOpenResponse
        /// </returns>
        public CheckMfdServiceOpenResponse CheckMfdServiceOpenWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckMfdServiceOpen",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckMfdServiceOpenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查服务是否开通</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckMfdServiceOpenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckMfdServiceOpenResponse
        /// </returns>
        public async Task<CheckMfdServiceOpenResponse> CheckMfdServiceOpenWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckMfdServiceOpen",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckMfdServiceOpenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查服务是否开通</para>
        /// </summary>
        /// 
        /// <returns>
        /// CheckMfdServiceOpenResponse
        /// </returns>
        public CheckMfdServiceOpenResponse CheckMfdServiceOpen()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMfdServiceOpenWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查服务是否开通</para>
        /// </summary>
        /// 
        /// <returns>
        /// CheckMfdServiceOpenResponse
        /// </returns>
        public async Task<CheckMfdServiceOpenResponse> CheckMfdServiceOpenAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMfdServiceOpenWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建bucket扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOssBucketScanTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOssBucketScanTaskResponse
        /// </returns>
        public CreateOssBucketScanTaskResponse CreateOssBucketScanTaskWithOptions(CreateOssBucketScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllKeyPrefix))
            {
                query["AllKeyPrefix"] = request.AllKeyPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketNameList))
            {
                query["BucketNameList"] = request.BucketNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecompressMaxFileCount))
            {
                query["DecompressMaxFileCount"] = request.DecompressMaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecompressMaxLayer))
            {
                query["DecompressMaxLayer"] = request.DecompressMaxLayer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecryptionList))
            {
                query["DecryptionList"] = request.DecryptionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeKeySuffixList))
            {
                query["ExcludeKeySuffixList"] = request.ExcludeKeySuffixList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPrefixList))
            {
                query["KeyPrefixList"] = request.KeyPrefixList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySuffixList))
            {
                query["KeySuffixList"] = request.KeySuffixList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastModifiedStartTime))
            {
                query["LastModifiedStartTime"] = request.LastModifiedStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanMode))
            {
                query["ScanMode"] = request.ScanMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOssBucketScanTask",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOssBucketScanTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建bucket扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOssBucketScanTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOssBucketScanTaskResponse
        /// </returns>
        public async Task<CreateOssBucketScanTaskResponse> CreateOssBucketScanTaskWithOptionsAsync(CreateOssBucketScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllKeyPrefix))
            {
                query["AllKeyPrefix"] = request.AllKeyPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketNameList))
            {
                query["BucketNameList"] = request.BucketNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecompressMaxFileCount))
            {
                query["DecompressMaxFileCount"] = request.DecompressMaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecompressMaxLayer))
            {
                query["DecompressMaxLayer"] = request.DecompressMaxLayer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecryptionList))
            {
                query["DecryptionList"] = request.DecryptionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeKeySuffixList))
            {
                query["ExcludeKeySuffixList"] = request.ExcludeKeySuffixList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPrefixList))
            {
                query["KeyPrefixList"] = request.KeyPrefixList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySuffixList))
            {
                query["KeySuffixList"] = request.KeySuffixList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastModifiedStartTime))
            {
                query["LastModifiedStartTime"] = request.LastModifiedStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanMode))
            {
                query["ScanMode"] = request.ScanMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOssBucketScanTask",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOssBucketScanTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建bucket扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOssBucketScanTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOssBucketScanTaskResponse
        /// </returns>
        public CreateOssBucketScanTaskResponse CreateOssBucketScanTask(CreateOssBucketScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOssBucketScanTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建bucket扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOssBucketScanTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOssBucketScanTaskResponse
        /// </returns>
        public async Task<CreateOssBucketScanTaskResponse> CreateOssBucketScanTaskAsync(CreateOssBucketScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOssBucketScanTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Bucket检测策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOssScanConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOssScanConfigResponse
        /// </returns>
        public CreateOssScanConfigResponse CreateOssScanConfigWithOptions(CreateOssScanConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllKeyPrefix))
            {
                query["AllKeyPrefix"] = request.AllKeyPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecompressMaxFileCount))
            {
                query["DecompressMaxFileCount"] = request.DecompressMaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecompressMaxLayer))
            {
                query["DecompressMaxLayer"] = request.DecompressMaxLayer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecryptionList))
            {
                query["DecryptionList"] = request.DecryptionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPrefixList))
            {
                query["KeyPrefixList"] = request.KeyPrefixList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySuffixList))
            {
                query["KeySuffixList"] = request.KeySuffixList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastModifiedStartTime))
            {
                query["LastModifiedStartTime"] = request.LastModifiedStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealTimeIncr))
            {
                query["RealTimeIncr"] = request.RealTimeIncr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanDayList))
            {
                query["ScanDayList"] = request.ScanDayList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOssScanConfig",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOssScanConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Bucket检测策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOssScanConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOssScanConfigResponse
        /// </returns>
        public async Task<CreateOssScanConfigResponse> CreateOssScanConfigWithOptionsAsync(CreateOssScanConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllKeyPrefix))
            {
                query["AllKeyPrefix"] = request.AllKeyPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecompressMaxFileCount))
            {
                query["DecompressMaxFileCount"] = request.DecompressMaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecompressMaxLayer))
            {
                query["DecompressMaxLayer"] = request.DecompressMaxLayer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecryptionList))
            {
                query["DecryptionList"] = request.DecryptionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPrefixList))
            {
                query["KeyPrefixList"] = request.KeyPrefixList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySuffixList))
            {
                query["KeySuffixList"] = request.KeySuffixList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastModifiedStartTime))
            {
                query["LastModifiedStartTime"] = request.LastModifiedStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealTimeIncr))
            {
                query["RealTimeIncr"] = request.RealTimeIncr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanDayList))
            {
                query["ScanDayList"] = request.ScanDayList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOssScanConfig",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOssScanConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Bucket检测策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOssScanConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOssScanConfigResponse
        /// </returns>
        public CreateOssScanConfigResponse CreateOssScanConfig(CreateOssScanConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOssScanConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Bucket检测策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOssScanConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOssScanConfigResponse
        /// </returns>
        public async Task<CreateOssScanConfigResponse> CreateOssScanConfigAsync(CreateOssScanConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOssScanConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExportInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExportInfoResponse
        /// </returns>
        public DescribeExportInfoResponse DescribeExportInfoWithOptions(DescribeExportInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportId))
            {
                query["ExportId"] = request.ExportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExportInfo",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExportInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExportInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExportInfoResponse
        /// </returns>
        public async Task<DescribeExportInfoResponse> DescribeExportInfoWithOptionsAsync(DescribeExportInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportId))
            {
                query["ExportId"] = request.ExportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExportInfo",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExportInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExportInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExportInfoResponse
        /// </returns>
        public DescribeExportInfoResponse DescribeExportInfo(DescribeExportInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExportInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExportInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExportInfoResponse
        /// </returns>
        public async Task<DescribeExportInfoResponse> DescribeExportInfoAsync(DescribeExportInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExportInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询您是否已创建云安全中心服务关联角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceLinkedRoleStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceLinkedRoleStatusResponse
        /// </returns>
        public DescribeServiceLinkedRoleStatusResponse DescribeServiceLinkedRoleStatusWithOptions(DescribeServiceLinkedRoleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLinkedRole))
            {
                query["ServiceLinkedRole"] = request.ServiceLinkedRole;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceLinkedRoleStatus",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceLinkedRoleStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询您是否已创建云安全中心服务关联角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceLinkedRoleStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceLinkedRoleStatusResponse
        /// </returns>
        public async Task<DescribeServiceLinkedRoleStatusResponse> DescribeServiceLinkedRoleStatusWithOptionsAsync(DescribeServiceLinkedRoleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLinkedRole))
            {
                query["ServiceLinkedRole"] = request.ServiceLinkedRole;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceLinkedRoleStatus",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceLinkedRoleStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询您是否已创建云安全中心服务关联角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceLinkedRoleStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceLinkedRoleStatusResponse
        /// </returns>
        public DescribeServiceLinkedRoleStatusResponse DescribeServiceLinkedRoleStatus(DescribeServiceLinkedRoleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceLinkedRoleStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询您是否已创建云安全中心服务关联角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceLinkedRoleStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceLinkedRoleStatusResponse
        /// </returns>
        public async Task<DescribeServiceLinkedRoleStatusResponse> DescribeServiceLinkedRoleStatusAsync(DescribeServiceLinkedRoleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceLinkedRoleStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出恶意文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportRecordResponse
        /// </returns>
        public ExportRecordResponse ExportRecordWithOptions(ExportRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportType))
            {
                query["ExportType"] = request.ExportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportRecord",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出恶意文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportRecordResponse
        /// </returns>
        public async Task<ExportRecordResponse> ExportRecordWithOptionsAsync(ExportRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportType))
            {
                query["ExportType"] = request.ExportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportRecord",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出恶意文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportRecordResponse
        /// </returns>
        public ExportRecordResponse ExportRecord(ExportRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出恶意文件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportRecordResponse
        /// </returns>
        public async Task<ExportRecordResponse> ExportRecordAsync(ExportRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取沙箱检测报告。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileDetectReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileDetectReportResponse
        /// </returns>
        public GetFileDetectReportResponse GetFileDetectReportWithOptions(GetFileDetectReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Field))
            {
                query["Field"] = request.Field;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileHash))
            {
                query["FileHash"] = request.FileHash;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileDetectReport",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileDetectReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取沙箱检测报告。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileDetectReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileDetectReportResponse
        /// </returns>
        public async Task<GetFileDetectReportResponse> GetFileDetectReportWithOptionsAsync(GetFileDetectReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Field))
            {
                query["Field"] = request.Field;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileHash))
            {
                query["FileHash"] = request.FileHash;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileDetectReport",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileDetectReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取沙箱检测报告。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileDetectReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileDetectReportResponse
        /// </returns>
        public GetFileDetectReportResponse GetFileDetectReport(GetFileDetectReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFileDetectReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取沙箱检测报告。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileDetectReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileDetectReportResponse
        /// </returns>
        public async Task<GetFileDetectReportResponse> GetFileDetectReportAsync(GetFileDetectReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileDetectReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取bucket检测统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOssBucketScanStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOssBucketScanStatisticResponse
        /// </returns>
        public GetOssBucketScanStatisticResponse GetOssBucketScanStatisticWithOptions(GetOssBucketScanStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketNameList))
            {
                query["BucketNameList"] = request.BucketNameList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOssBucketScanStatistic",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssBucketScanStatisticResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取bucket检测统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOssBucketScanStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOssBucketScanStatisticResponse
        /// </returns>
        public async Task<GetOssBucketScanStatisticResponse> GetOssBucketScanStatisticWithOptionsAsync(GetOssBucketScanStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketNameList))
            {
                query["BucketNameList"] = request.BucketNameList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOssBucketScanStatistic",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssBucketScanStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取bucket检测统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOssBucketScanStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOssBucketScanStatisticResponse
        /// </returns>
        public GetOssBucketScanStatisticResponse GetOssBucketScanStatistic(GetOssBucketScanStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOssBucketScanStatisticWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取bucket检测统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOssBucketScanStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOssBucketScanStatisticResponse
        /// </returns>
        public async Task<GetOssBucketScanStatisticResponse> GetOssBucketScanStatisticAsync(GetOssBucketScanStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOssBucketScanStatisticWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Bucket检测配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOssScanConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOssScanConfigResponse
        /// </returns>
        public GetOssScanConfigResponse GetOssScanConfigWithOptions(GetOssScanConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOssScanConfig",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssScanConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Bucket检测配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOssScanConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOssScanConfigResponse
        /// </returns>
        public async Task<GetOssScanConfigResponse> GetOssScanConfigWithOptionsAsync(GetOssScanConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOssScanConfig",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssScanConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Bucket检测配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOssScanConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOssScanConfigResponse
        /// </returns>
        public GetOssScanConfigResponse GetOssScanConfig(GetOssScanConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOssScanConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Bucket检测配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOssScanConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOssScanConfigResponse
        /// </returns>
        public async Task<GetOssScanConfigResponse> GetOssScanConfigAsync(GetOssScanConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOssScanConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件检测告警列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListObjectScanEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListObjectScanEventResponse
        /// </returns>
        public ListObjectScanEventResponse ListObjectScanEventWithOptions(ListObjectScanEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                query["Md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentEventId))
            {
                query["ParentEventId"] = request.ParentEventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeEnd))
            {
                query["TimeEnd"] = request.TimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStart))
            {
                query["TimeStart"] = request.TimeStart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListObjectScanEvent",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListObjectScanEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件检测告警列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListObjectScanEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListObjectScanEventResponse
        /// </returns>
        public async Task<ListObjectScanEventResponse> ListObjectScanEventWithOptionsAsync(ListObjectScanEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                query["Md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentEventId))
            {
                query["ParentEventId"] = request.ParentEventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeEnd))
            {
                query["TimeEnd"] = request.TimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStart))
            {
                query["TimeStart"] = request.TimeStart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListObjectScanEvent",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListObjectScanEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件检测告警列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListObjectScanEventRequest
        /// </param>
        /// 
        /// <returns>
        /// ListObjectScanEventResponse
        /// </returns>
        public ListObjectScanEventResponse ListObjectScanEvent(ListObjectScanEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListObjectScanEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件检测告警列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListObjectScanEventRequest
        /// </param>
        /// 
        /// <returns>
        /// ListObjectScanEventResponse
        /// </returns>
        public async Task<ListObjectScanEventResponse> ListObjectScanEventAsync(ListObjectScanEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListObjectScanEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举用户所有的bucket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOssBucketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOssBucketResponse
        /// </returns>
        public ListOssBucketResponse ListOssBucketWithOptions(ListOssBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOssBucket",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOssBucketResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举用户所有的bucket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOssBucketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOssBucketResponse
        /// </returns>
        public async Task<ListOssBucketResponse> ListOssBucketWithOptionsAsync(ListOssBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOssBucket",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOssBucketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举用户所有的bucket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOssBucketRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOssBucketResponse
        /// </returns>
        public ListOssBucketResponse ListOssBucket(ListOssBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOssBucketWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举用户所有的bucket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOssBucketRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOssBucketResponse
        /// </returns>
        public async Task<ListOssBucketResponse> ListOssBucketAsync(ListOssBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOssBucketWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取bucket详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOssBucketScanInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOssBucketScanInfoResponse
        /// </returns>
        public ListOssBucketScanInfoResponse ListOssBucketScanInfoWithOptions(ListOssBucketScanInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuzzBucketName))
            {
                query["FuzzBucketName"] = request.FuzzBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasRisk))
            {
                query["HasRisk"] = request.HasRisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOssBucketScanInfo",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOssBucketScanInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取bucket详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOssBucketScanInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOssBucketScanInfoResponse
        /// </returns>
        public async Task<ListOssBucketScanInfoResponse> ListOssBucketScanInfoWithOptionsAsync(ListOssBucketScanInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FuzzBucketName))
            {
                query["FuzzBucketName"] = request.FuzzBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasRisk))
            {
                query["HasRisk"] = request.HasRisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOssBucketScanInfo",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOssBucketScanInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取bucket详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOssBucketScanInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOssBucketScanInfoResponse
        /// </returns>
        public ListOssBucketScanInfoResponse ListOssBucketScanInfo(ListOssBucketScanInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOssBucketScanInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取bucket详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOssBucketScanInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOssBucketScanInfoResponse
        /// </returns>
        public async Task<ListOssBucketScanInfoResponse> ListOssBucketScanInfoAsync(ListOssBucketScanInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOssBucketScanInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取支持的文件后缀</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSupportObjectSuffixRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSupportObjectSuffixResponse
        /// </returns>
        public ListSupportObjectSuffixResponse ListSupportObjectSuffixWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSupportObjectSuffix",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSupportObjectSuffixResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取支持的文件后缀</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSupportObjectSuffixRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSupportObjectSuffixResponse
        /// </returns>
        public async Task<ListSupportObjectSuffixResponse> ListSupportObjectSuffixWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSupportObjectSuffix",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSupportObjectSuffixResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取支持的文件后缀</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListSupportObjectSuffixResponse
        /// </returns>
        public ListSupportObjectSuffixResponse ListSupportObjectSuffix()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSupportObjectSuffixWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取支持的文件后缀</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListSupportObjectSuffixResponse
        /// </returns>
        public async Task<ListSupportObjectSuffixResponse> ListSupportObjectSuffixAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSupportObjectSuffixWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作oss检测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateBucketScanTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateBucketScanTaskResponse
        /// </returns>
        public OperateBucketScanTaskResponse OperateBucketScanTaskWithOptions(OperateBucketScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateCode))
            {
                query["OperateCode"] = request.OperateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateBucketScanTask",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateBucketScanTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作oss检测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateBucketScanTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateBucketScanTaskResponse
        /// </returns>
        public async Task<OperateBucketScanTaskResponse> OperateBucketScanTaskWithOptionsAsync(OperateBucketScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateCode))
            {
                query["OperateCode"] = request.OperateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateBucketScanTask",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateBucketScanTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作oss检测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateBucketScanTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateBucketScanTaskResponse
        /// </returns>
        public OperateBucketScanTaskResponse OperateBucketScanTask(OperateBucketScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateBucketScanTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作oss检测任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateBucketScanTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateBucketScanTaskResponse
        /// </returns>
        public async Task<OperateBucketScanTaskResponse> OperateBucketScanTaskAsync(OperateBucketScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateBucketScanTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改Bucket检测配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOssScanConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOssScanConfigResponse
        /// </returns>
        public UpdateOssScanConfigResponse UpdateOssScanConfigWithOptions(UpdateOssScanConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllKeyPrefix))
            {
                query["AllKeyPrefix"] = request.AllKeyPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecompressMaxFileCount))
            {
                query["DecompressMaxFileCount"] = request.DecompressMaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecompressMaxLayer))
            {
                query["DecompressMaxLayer"] = request.DecompressMaxLayer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecryptionList))
            {
                query["DecryptionList"] = request.DecryptionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPrefixList))
            {
                query["KeyPrefixList"] = request.KeyPrefixList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySuffixList))
            {
                query["KeySuffixList"] = request.KeySuffixList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastModifiedStartTime))
            {
                query["LastModifiedStartTime"] = request.LastModifiedStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealTimeIncr))
            {
                query["RealTimeIncr"] = request.RealTimeIncr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanDayList))
            {
                query["ScanDayList"] = request.ScanDayList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOssScanConfig",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOssScanConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改Bucket检测配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOssScanConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOssScanConfigResponse
        /// </returns>
        public async Task<UpdateOssScanConfigResponse> UpdateOssScanConfigWithOptionsAsync(UpdateOssScanConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllKeyPrefix))
            {
                query["AllKeyPrefix"] = request.AllKeyPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecompressMaxFileCount))
            {
                query["DecompressMaxFileCount"] = request.DecompressMaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecompressMaxLayer))
            {
                query["DecompressMaxLayer"] = request.DecompressMaxLayer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecryptionList))
            {
                query["DecryptionList"] = request.DecryptionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPrefixList))
            {
                query["KeyPrefixList"] = request.KeyPrefixList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySuffixList))
            {
                query["KeySuffixList"] = request.KeySuffixList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastModifiedStartTime))
            {
                query["LastModifiedStartTime"] = request.LastModifiedStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealTimeIncr))
            {
                query["RealTimeIncr"] = request.RealTimeIncr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanDayList))
            {
                query["ScanDayList"] = request.ScanDayList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOssScanConfig",
                Version = "2023-10-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOssScanConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改Bucket检测配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOssScanConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOssScanConfigResponse
        /// </returns>
        public UpdateOssScanConfigResponse UpdateOssScanConfig(UpdateOssScanConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOssScanConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改Bucket检测配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOssScanConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOssScanConfigResponse
        /// </returns>
        public async Task<UpdateOssScanConfigResponse> UpdateOssScanConfigAsync(UpdateOssScanConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOssScanConfigWithOptionsAsync(request, runtime);
        }

    }
}
