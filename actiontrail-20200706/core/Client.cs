// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Actiontrail20200706.Models;

namespace AlibabaCloud.SDK.Actiontrail20200706
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "actiontrail.ap-northeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "actiontrail.aliyuncs.com"},
                {"cn-beijing-finance-pop", "actiontrail.aliyuncs.com"},
                {"cn-beijing-gov-1", "actiontrail.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "actiontrail.aliyuncs.com"},
                {"cn-edge-1", "actiontrail.aliyuncs.com"},
                {"cn-fujian", "actiontrail.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "actiontrail.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "actiontrail.aliyuncs.com"},
                {"cn-hangzhou-finance", "actiontrail.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "actiontrail.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "actiontrail.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "actiontrail.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "actiontrail.aliyuncs.com"},
                {"cn-hangzhou-test-306", "actiontrail.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "actiontrail.aliyuncs.com"},
                {"cn-qingdao-nebula", "actiontrail.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "actiontrail.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "actiontrail.aliyuncs.com"},
                {"cn-shanghai-inner", "actiontrail.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "actiontrail.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "actiontrail.aliyuncs.com"},
                {"cn-shenzhen-inner", "actiontrail.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "actiontrail.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "actiontrail.aliyuncs.com"},
                {"cn-wuhan", "actiontrail.aliyuncs.com"},
                {"cn-yushanfang", "actiontrail.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "actiontrail.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "actiontrail.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "actiontrail.aliyuncs.com"},
                {"eu-west-1-oxs", "actiontrail.ap-northeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "actiontrail.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("actiontrail", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
          * Take note of the following limits:
          * - You must have created and configured a single-account trail to deliver events to Log Service by calling the [CreateTrail](~~212313~~) operation.
          * - Only one historical event delivery task can be running at a time within an Alibaba Cloud account.
          * This topic shows you how to create a historical event delivery task for a sample trail named `trail-name`.
          *
          * @param request CreateDeliveryHistoryJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateDeliveryHistoryJobResponse
         */
        public CreateDeliveryHistoryJobResponse CreateDeliveryHistoryJobWithOptions(CreateDeliveryHistoryJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrailName))
            {
                query["TrailName"] = request.TrailName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeliveryHistoryJob",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeliveryHistoryJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Take note of the following limits:
          * - You must have created and configured a single-account trail to deliver events to Log Service by calling the [CreateTrail](~~212313~~) operation.
          * - Only one historical event delivery task can be running at a time within an Alibaba Cloud account.
          * This topic shows you how to create a historical event delivery task for a sample trail named `trail-name`.
          *
          * @param request CreateDeliveryHistoryJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateDeliveryHistoryJobResponse
         */
        public async Task<CreateDeliveryHistoryJobResponse> CreateDeliveryHistoryJobWithOptionsAsync(CreateDeliveryHistoryJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrailName))
            {
                query["TrailName"] = request.TrailName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeliveryHistoryJob",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeliveryHistoryJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Take note of the following limits:
          * - You must have created and configured a single-account trail to deliver events to Log Service by calling the [CreateTrail](~~212313~~) operation.
          * - Only one historical event delivery task can be running at a time within an Alibaba Cloud account.
          * This topic shows you how to create a historical event delivery task for a sample trail named `trail-name`.
          *
          * @param request CreateDeliveryHistoryJobRequest
          * @return CreateDeliveryHistoryJobResponse
         */
        public CreateDeliveryHistoryJobResponse CreateDeliveryHistoryJob(CreateDeliveryHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeliveryHistoryJobWithOptions(request, runtime);
        }

        /**
          * Take note of the following limits:
          * - You must have created and configured a single-account trail to deliver events to Log Service by calling the [CreateTrail](~~212313~~) operation.
          * - Only one historical event delivery task can be running at a time within an Alibaba Cloud account.
          * This topic shows you how to create a historical event delivery task for a sample trail named `trail-name`.
          *
          * @param request CreateDeliveryHistoryJobRequest
          * @return CreateDeliveryHistoryJobResponse
         */
        public async Task<CreateDeliveryHistoryJobResponse> CreateDeliveryHistoryJobAsync(CreateDeliveryHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeliveryHistoryJobWithOptionsAsync(request, runtime);
        }

        /**
          * You can create a trail to deliver events to Log Service, Object Storage Service (OSS), or both. Before you call this operation to create a trail, make sure that the following requirements are met:
          * *   Deliver events to Log Service: A project is created in Log Service.
          * **
          * **Description** After you create a trail to deliver events to Log Service, a Logstore whose name is in the `actiontrail_<Trail name>` format is automatically created and optimally configured for subsequent auditing. Indexes and a dashboard are created for the Logstore to facilitate event queries. You cannot manually write data to the Logstore. This ensures data accuracy. You do not need to create a Logstore in advance.
          * *   Deliver events to OSS: A bucket is created in OSS. This topic provides an example on how to call the API operation to create a single-account trail named `trail-test` to deliver events to an OSS bucket named `audit-log`.
          *
          * @param request CreateTrailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateTrailResponse
         */
        public CreateTrailResponse CreateTrailWithOptions(CreateTrailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRW))
            {
                query["EventRW"] = request.EventRW;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOrganizationTrail))
            {
                query["IsOrganizationTrail"] = request.IsOrganizationTrail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKeyPrefix))
            {
                query["OssKeyPrefix"] = request.OssKeyPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssWriteRoleArn))
            {
                query["OssWriteRoleArn"] = request.OssWriteRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProjectArn))
            {
                query["SlsProjectArn"] = request.SlsProjectArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsWriteRoleArn))
            {
                query["SlsWriteRoleArn"] = request.SlsWriteRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrailRegion))
            {
                query["TrailRegion"] = request.TrailRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrail",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrailResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can create a trail to deliver events to Log Service, Object Storage Service (OSS), or both. Before you call this operation to create a trail, make sure that the following requirements are met:
          * *   Deliver events to Log Service: A project is created in Log Service.
          * **
          * **Description** After you create a trail to deliver events to Log Service, a Logstore whose name is in the `actiontrail_<Trail name>` format is automatically created and optimally configured for subsequent auditing. Indexes and a dashboard are created for the Logstore to facilitate event queries. You cannot manually write data to the Logstore. This ensures data accuracy. You do not need to create a Logstore in advance.
          * *   Deliver events to OSS: A bucket is created in OSS. This topic provides an example on how to call the API operation to create a single-account trail named `trail-test` to deliver events to an OSS bucket named `audit-log`.
          *
          * @param request CreateTrailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateTrailResponse
         */
        public async Task<CreateTrailResponse> CreateTrailWithOptionsAsync(CreateTrailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRW))
            {
                query["EventRW"] = request.EventRW;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOrganizationTrail))
            {
                query["IsOrganizationTrail"] = request.IsOrganizationTrail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKeyPrefix))
            {
                query["OssKeyPrefix"] = request.OssKeyPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssWriteRoleArn))
            {
                query["OssWriteRoleArn"] = request.OssWriteRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProjectArn))
            {
                query["SlsProjectArn"] = request.SlsProjectArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsWriteRoleArn))
            {
                query["SlsWriteRoleArn"] = request.SlsWriteRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrailRegion))
            {
                query["TrailRegion"] = request.TrailRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrail",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can create a trail to deliver events to Log Service, Object Storage Service (OSS), or both. Before you call this operation to create a trail, make sure that the following requirements are met:
          * *   Deliver events to Log Service: A project is created in Log Service.
          * **
          * **Description** After you create a trail to deliver events to Log Service, a Logstore whose name is in the `actiontrail_<Trail name>` format is automatically created and optimally configured for subsequent auditing. Indexes and a dashboard are created for the Logstore to facilitate event queries. You cannot manually write data to the Logstore. This ensures data accuracy. You do not need to create a Logstore in advance.
          * *   Deliver events to OSS: A bucket is created in OSS. This topic provides an example on how to call the API operation to create a single-account trail named `trail-test` to deliver events to an OSS bucket named `audit-log`.
          *
          * @param request CreateTrailRequest
          * @return CreateTrailResponse
         */
        public CreateTrailResponse CreateTrail(CreateTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTrailWithOptions(request, runtime);
        }

        /**
          * You can create a trail to deliver events to Log Service, Object Storage Service (OSS), or both. Before you call this operation to create a trail, make sure that the following requirements are met:
          * *   Deliver events to Log Service: A project is created in Log Service.
          * **
          * **Description** After you create a trail to deliver events to Log Service, a Logstore whose name is in the `actiontrail_<Trail name>` format is automatically created and optimally configured for subsequent auditing. Indexes and a dashboard are created for the Logstore to facilitate event queries. You cannot manually write data to the Logstore. This ensures data accuracy. You do not need to create a Logstore in advance.
          * *   Deliver events to OSS: A bucket is created in OSS. This topic provides an example on how to call the API operation to create a single-account trail named `trail-test` to deliver events to an OSS bucket named `audit-log`.
          *
          * @param request CreateTrailRequest
          * @return CreateTrailResponse
         */
        public async Task<CreateTrailResponse> CreateTrailAsync(CreateTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTrailWithOptionsAsync(request, runtime);
        }

        /**
          * This topic describes how to delete a sample historical event delivery task whose ID is `16602`.
          *
          * @param request DeleteDeliveryHistoryJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteDeliveryHistoryJobResponse
         */
        public DeleteDeliveryHistoryJobResponse DeleteDeliveryHistoryJobWithOptions(DeleteDeliveryHistoryJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeliveryHistoryJob",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeliveryHistoryJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic describes how to delete a sample historical event delivery task whose ID is `16602`.
          *
          * @param request DeleteDeliveryHistoryJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteDeliveryHistoryJobResponse
         */
        public async Task<DeleteDeliveryHistoryJobResponse> DeleteDeliveryHistoryJobWithOptionsAsync(DeleteDeliveryHistoryJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeliveryHistoryJob",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeliveryHistoryJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic describes how to delete a sample historical event delivery task whose ID is `16602`.
          *
          * @param request DeleteDeliveryHistoryJobRequest
          * @return DeleteDeliveryHistoryJobResponse
         */
        public DeleteDeliveryHistoryJobResponse DeleteDeliveryHistoryJob(DeleteDeliveryHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeliveryHistoryJobWithOptions(request, runtime);
        }

        /**
          * This topic describes how to delete a sample historical event delivery task whose ID is `16602`.
          *
          * @param request DeleteDeliveryHistoryJobRequest
          * @return DeleteDeliveryHistoryJobResponse
         */
        public async Task<DeleteDeliveryHistoryJobResponse> DeleteDeliveryHistoryJobAsync(DeleteDeliveryHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeliveryHistoryJobWithOptionsAsync(request, runtime);
        }

        /**
          * This topic describes how to delete a sample trail named `trail-test`.
          *
          * @param request DeleteTrailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteTrailResponse
         */
        public DeleteTrailResponse DeleteTrailWithOptions(DeleteTrailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrail",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrailResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic describes how to delete a sample trail named `trail-test`.
          *
          * @param request DeleteTrailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteTrailResponse
         */
        public async Task<DeleteTrailResponse> DeleteTrailWithOptionsAsync(DeleteTrailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrail",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic describes how to delete a sample trail named `trail-test`.
          *
          * @param request DeleteTrailRequest
          * @return DeleteTrailResponse
         */
        public DeleteTrailResponse DeleteTrail(DeleteTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTrailWithOptions(request, runtime);
        }

        /**
          * This topic describes how to delete a sample trail named `trail-test`.
          *
          * @param request DeleteTrailRequest
          * @return DeleteTrailResponse
         */
        public async Task<DeleteTrailResponse> DeleteTrailAsync(DeleteTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTrailWithOptionsAsync(request, runtime);
        }

        /**
          * For more information, see [Regions and zones](~~40654~~).
          *
          * @param request DescribeRegionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * For more information, see [Regions and zones](~~40654~~).
          *
          * @param request DescribeRegionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * For more information, see [Regions and zones](~~40654~~).
          *
          * @param request DescribeRegionsRequest
          * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /**
          * For more information, see [Regions and zones](~~40654~~).
          *
          * @param request DescribeRegionsRequest
          * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /**
          * This topic shows you how to query the information about the single-account trails within an Alibaba Cloud account. In this example, the information about a trail named `test-4` is returned.
          *
          * @param request DescribeTrailsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeTrailsResponse
         */
        public DescribeTrailsResponse DescribeTrailsWithOptions(DescribeTrailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeOrganizationTrail))
            {
                query["IncludeOrganizationTrail"] = request.IncludeOrganizationTrail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeShadowTrails))
            {
                query["IncludeShadowTrails"] = request.IncludeShadowTrails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameList))
            {
                query["NameList"] = request.NameList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrails",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrailsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic shows you how to query the information about the single-account trails within an Alibaba Cloud account. In this example, the information about a trail named `test-4` is returned.
          *
          * @param request DescribeTrailsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeTrailsResponse
         */
        public async Task<DescribeTrailsResponse> DescribeTrailsWithOptionsAsync(DescribeTrailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeOrganizationTrail))
            {
                query["IncludeOrganizationTrail"] = request.IncludeOrganizationTrail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeShadowTrails))
            {
                query["IncludeShadowTrails"] = request.IncludeShadowTrails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameList))
            {
                query["NameList"] = request.NameList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrails",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTrailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic shows you how to query the information about the single-account trails within an Alibaba Cloud account. In this example, the information about a trail named `test-4` is returned.
          *
          * @param request DescribeTrailsRequest
          * @return DescribeTrailsResponse
         */
        public DescribeTrailsResponse DescribeTrails(DescribeTrailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrailsWithOptions(request, runtime);
        }

        /**
          * This topic shows you how to query the information about the single-account trails within an Alibaba Cloud account. In this example, the information about a trail named `test-4` is returned.
          *
          * @param request DescribeTrailsRequest
          * @return DescribeTrailsResponse
         */
        public async Task<DescribeTrailsResponse> DescribeTrailsAsync(DescribeTrailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrailsWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to query only the information about the most recent events that are generated within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. For more information about supported events, see [Alibaba Cloud services and events that are supported by the AccessKey pair audit feature](~~419214~~). Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedEventsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAccessKeyLastUsedEventsResponse
         */
        public GetAccessKeyLastUsedEventsResponse GetAccessKeyLastUsedEventsWithOptions(GetAccessKeyLastUsedEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["AccessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyLastUsedEvents",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyLastUsedEventsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to query only the information about the most recent events that are generated within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. For more information about supported events, see [Alibaba Cloud services and events that are supported by the AccessKey pair audit feature](~~419214~~). Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedEventsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAccessKeyLastUsedEventsResponse
         */
        public async Task<GetAccessKeyLastUsedEventsResponse> GetAccessKeyLastUsedEventsWithOptionsAsync(GetAccessKeyLastUsedEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["AccessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyLastUsedEvents",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyLastUsedEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to query only the information about the most recent events that are generated within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. For more information about supported events, see [Alibaba Cloud services and events that are supported by the AccessKey pair audit feature](~~419214~~). Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedEventsRequest
          * @return GetAccessKeyLastUsedEventsResponse
         */
        public GetAccessKeyLastUsedEventsResponse GetAccessKeyLastUsedEvents(GetAccessKeyLastUsedEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessKeyLastUsedEventsWithOptions(request, runtime);
        }

        /**
          * You can call this operation to query only the information about the most recent events that are generated within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. For more information about supported events, see [Alibaba Cloud services and events that are supported by the AccessKey pair audit feature](~~419214~~). Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedEventsRequest
          * @return GetAccessKeyLastUsedEventsResponse
         */
        public async Task<GetAccessKeyLastUsedEventsResponse> GetAccessKeyLastUsedEventsAsync(GetAccessKeyLastUsedEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessKeyLastUsedEventsWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to query only the information about the most recent call of a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAccessKeyLastUsedInfoResponse
         */
        public GetAccessKeyLastUsedInfoResponse GetAccessKeyLastUsedInfoWithOptions(GetAccessKeyLastUsedInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["AccessKey"] = request.AccessKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyLastUsedInfo",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyLastUsedInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to query only the information about the most recent call of a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAccessKeyLastUsedInfoResponse
         */
        public async Task<GetAccessKeyLastUsedInfoResponse> GetAccessKeyLastUsedInfoWithOptionsAsync(GetAccessKeyLastUsedInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["AccessKey"] = request.AccessKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyLastUsedInfo",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyLastUsedInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to query only the information about the most recent call of a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedInfoRequest
          * @return GetAccessKeyLastUsedInfoResponse
         */
        public GetAccessKeyLastUsedInfoResponse GetAccessKeyLastUsedInfo(GetAccessKeyLastUsedInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessKeyLastUsedInfoWithOptions(request, runtime);
        }

        /**
          * You can call this operation to query only the information about the most recent call of a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedInfoRequest
          * @return GetAccessKeyLastUsedInfoResponse
         */
        public async Task<GetAccessKeyLastUsedInfoResponse> GetAccessKeyLastUsedInfoAsync(GetAccessKeyLastUsedInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessKeyLastUsedInfoWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to query only the information about the IP addresses that are most recently used within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedIpsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAccessKeyLastUsedIpsResponse
         */
        public GetAccessKeyLastUsedIpsResponse GetAccessKeyLastUsedIpsWithOptions(GetAccessKeyLastUsedIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["AccessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyLastUsedIps",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyLastUsedIpsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to query only the information about the IP addresses that are most recently used within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedIpsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAccessKeyLastUsedIpsResponse
         */
        public async Task<GetAccessKeyLastUsedIpsResponse> GetAccessKeyLastUsedIpsWithOptionsAsync(GetAccessKeyLastUsedIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["AccessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyLastUsedIps",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyLastUsedIpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to query only the information about the IP addresses that are most recently used within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedIpsRequest
          * @return GetAccessKeyLastUsedIpsResponse
         */
        public GetAccessKeyLastUsedIpsResponse GetAccessKeyLastUsedIps(GetAccessKeyLastUsedIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessKeyLastUsedIpsWithOptions(request, runtime);
        }

        /**
          * You can call this operation to query only the information about the IP addresses that are most recently used within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedIpsRequest
          * @return GetAccessKeyLastUsedIpsResponse
         */
        public async Task<GetAccessKeyLastUsedIpsResponse> GetAccessKeyLastUsedIpsAsync(GetAccessKeyLastUsedIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessKeyLastUsedIpsWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to query only the information about Alibaba Cloud services that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedProductsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAccessKeyLastUsedProductsResponse
         */
        public GetAccessKeyLastUsedProductsResponse GetAccessKeyLastUsedProductsWithOptions(GetAccessKeyLastUsedProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["AccessKey"] = request.AccessKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyLastUsedProducts",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyLastUsedProductsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to query only the information about Alibaba Cloud services that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedProductsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAccessKeyLastUsedProductsResponse
         */
        public async Task<GetAccessKeyLastUsedProductsResponse> GetAccessKeyLastUsedProductsWithOptionsAsync(GetAccessKeyLastUsedProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["AccessKey"] = request.AccessKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyLastUsedProducts",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyLastUsedProductsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to query only the information about Alibaba Cloud services that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedProductsRequest
          * @return GetAccessKeyLastUsedProductsResponse
         */
        public GetAccessKeyLastUsedProductsResponse GetAccessKeyLastUsedProducts(GetAccessKeyLastUsedProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessKeyLastUsedProductsWithOptions(request, runtime);
        }

        /**
          * You can call this operation to query only the information about Alibaba Cloud services that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedProductsRequest
          * @return GetAccessKeyLastUsedProductsResponse
         */
        public async Task<GetAccessKeyLastUsedProductsResponse> GetAccessKeyLastUsedProductsAsync(GetAccessKeyLastUsedProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessKeyLastUsedProductsWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to query only the information about resources that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAccessKeyLastUsedResourcesResponse
         */
        public GetAccessKeyLastUsedResourcesResponse GetAccessKeyLastUsedResourcesWithOptions(GetAccessKeyLastUsedResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["AccessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyLastUsedResources",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyLastUsedResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to query only the information about resources that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAccessKeyLastUsedResourcesResponse
         */
        public async Task<GetAccessKeyLastUsedResourcesResponse> GetAccessKeyLastUsedResourcesWithOptionsAsync(GetAccessKeyLastUsedResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["AccessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyLastUsedResources",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyLastUsedResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to query only the information about resources that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedResourcesRequest
          * @return GetAccessKeyLastUsedResourcesResponse
         */
        public GetAccessKeyLastUsedResourcesResponse GetAccessKeyLastUsedResources(GetAccessKeyLastUsedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessKeyLastUsedResourcesWithOptions(request, runtime);
        }

        /**
          * You can call this operation to query only the information about resources that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.
          *
          * @param request GetAccessKeyLastUsedResourcesRequest
          * @return GetAccessKeyLastUsedResourcesResponse
         */
        public async Task<GetAccessKeyLastUsedResourcesResponse> GetAccessKeyLastUsedResourcesAsync(GetAccessKeyLastUsedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessKeyLastUsedResourcesWithOptionsAsync(request, runtime);
        }

        /**
          * This topic describes how to query the details of a historical event delivery tasks created within your Alibaba Cloud account. In this example, the details of a historical event delivery task whose ID is `16602` are returned. The sample response shows that this task is used to deliver the historical events recorded by the trail named `trail-name` to Log Service and the task is complete.
          *
          * @param request GetDeliveryHistoryJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDeliveryHistoryJobResponse
         */
        public GetDeliveryHistoryJobResponse GetDeliveryHistoryJobWithOptions(GetDeliveryHistoryJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeliveryHistoryJob",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeliveryHistoryJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic describes how to query the details of a historical event delivery tasks created within your Alibaba Cloud account. In this example, the details of a historical event delivery task whose ID is `16602` are returned. The sample response shows that this task is used to deliver the historical events recorded by the trail named `trail-name` to Log Service and the task is complete.
          *
          * @param request GetDeliveryHistoryJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDeliveryHistoryJobResponse
         */
        public async Task<GetDeliveryHistoryJobResponse> GetDeliveryHistoryJobWithOptionsAsync(GetDeliveryHistoryJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeliveryHistoryJob",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeliveryHistoryJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic describes how to query the details of a historical event delivery tasks created within your Alibaba Cloud account. In this example, the details of a historical event delivery task whose ID is `16602` are returned. The sample response shows that this task is used to deliver the historical events recorded by the trail named `trail-name` to Log Service and the task is complete.
          *
          * @param request GetDeliveryHistoryJobRequest
          * @return GetDeliveryHistoryJobResponse
         */
        public GetDeliveryHistoryJobResponse GetDeliveryHistoryJob(GetDeliveryHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeliveryHistoryJobWithOptions(request, runtime);
        }

        /**
          * This topic describes how to query the details of a historical event delivery tasks created within your Alibaba Cloud account. In this example, the details of a historical event delivery task whose ID is `16602` are returned. The sample response shows that this task is used to deliver the historical events recorded by the trail named `trail-name` to Log Service and the task is complete.
          *
          * @param request GetDeliveryHistoryJobRequest
          * @return GetDeliveryHistoryJobResponse
         */
        public async Task<GetDeliveryHistoryJobResponse> GetDeliveryHistoryJobAsync(GetDeliveryHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeliveryHistoryJobWithOptionsAsync(request, runtime);
        }

        /**
          * By default, global events are stored in the Singapore region.
          * To obtain the permissions to call the API operation, you must submit a ticket.
          *
          * @param request GetGlobalEventsStorageRegionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetGlobalEventsStorageRegionResponse
         */
        public GetGlobalEventsStorageRegionResponse GetGlobalEventsStorageRegionWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGlobalEventsStorageRegion",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGlobalEventsStorageRegionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * By default, global events are stored in the Singapore region.
          * To obtain the permissions to call the API operation, you must submit a ticket.
          *
          * @param request GetGlobalEventsStorageRegionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetGlobalEventsStorageRegionResponse
         */
        public async Task<GetGlobalEventsStorageRegionResponse> GetGlobalEventsStorageRegionWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGlobalEventsStorageRegion",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGlobalEventsStorageRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * By default, global events are stored in the Singapore region.
          * To obtain the permissions to call the API operation, you must submit a ticket.
          *
          * @return GetGlobalEventsStorageRegionResponse
         */
        public GetGlobalEventsStorageRegionResponse GetGlobalEventsStorageRegion()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGlobalEventsStorageRegionWithOptions(runtime);
        }

        /**
          * By default, global events are stored in the Singapore region.
          * To obtain the permissions to call the API operation, you must submit a ticket.
          *
          * @return GetGlobalEventsStorageRegionResponse
         */
        public async Task<GetGlobalEventsStorageRegionResponse> GetGlobalEventsStorageRegionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGlobalEventsStorageRegionWithOptionsAsync(runtime);
        }

        /**
          * This topic describes how to query the status of a sample single-account trail named `trail-test`.
          *
          * @param request GetTrailStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTrailStatusResponse
         */
        public GetTrailStatusResponse GetTrailStatusWithOptions(GetTrailStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOrganizationTrail))
            {
                query["IsOrganizationTrail"] = request.IsOrganizationTrail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrailStatus",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrailStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic describes how to query the status of a sample single-account trail named `trail-test`.
          *
          * @param request GetTrailStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTrailStatusResponse
         */
        public async Task<GetTrailStatusResponse> GetTrailStatusWithOptionsAsync(GetTrailStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOrganizationTrail))
            {
                query["IsOrganizationTrail"] = request.IsOrganizationTrail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrailStatus",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrailStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic describes how to query the status of a sample single-account trail named `trail-test`.
          *
          * @param request GetTrailStatusRequest
          * @return GetTrailStatusResponse
         */
        public GetTrailStatusResponse GetTrailStatus(GetTrailStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTrailStatusWithOptions(request, runtime);
        }

        /**
          * This topic describes how to query the status of a sample single-account trail named `trail-test`.
          *
          * @param request GetTrailStatusRequest
          * @return GetTrailStatusResponse
         */
        public async Task<GetTrailStatusResponse> GetTrailStatusAsync(GetTrailStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTrailStatusWithOptionsAsync(request, runtime);
        }

        /**
          * This topic describes how to query the historical event delivery tasks created within your Alibaba Cloud account. In this example, a historical event delivery task whose ID is `16602` is returned. This task is used to deliver historical events for the trail named `trail-name` to Log Service.
          *
          * @param request ListDeliveryHistoryJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDeliveryHistoryJobsResponse
         */
        public ListDeliveryHistoryJobsResponse ListDeliveryHistoryJobsWithOptions(ListDeliveryHistoryJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Action = "ListDeliveryHistoryJobs",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeliveryHistoryJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic describes how to query the historical event delivery tasks created within your Alibaba Cloud account. In this example, a historical event delivery task whose ID is `16602` is returned. This task is used to deliver historical events for the trail named `trail-name` to Log Service.
          *
          * @param request ListDeliveryHistoryJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDeliveryHistoryJobsResponse
         */
        public async Task<ListDeliveryHistoryJobsResponse> ListDeliveryHistoryJobsWithOptionsAsync(ListDeliveryHistoryJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Action = "ListDeliveryHistoryJobs",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeliveryHistoryJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic describes how to query the historical event delivery tasks created within your Alibaba Cloud account. In this example, a historical event delivery task whose ID is `16602` is returned. This task is used to deliver historical events for the trail named `trail-name` to Log Service.
          *
          * @param request ListDeliveryHistoryJobsRequest
          * @return ListDeliveryHistoryJobsResponse
         */
        public ListDeliveryHistoryJobsResponse ListDeliveryHistoryJobs(ListDeliveryHistoryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeliveryHistoryJobsWithOptions(request, runtime);
        }

        /**
          * This topic describes how to query the historical event delivery tasks created within your Alibaba Cloud account. In this example, a historical event delivery task whose ID is `16602` is returned. This task is used to deliver historical events for the trail named `trail-name` to Log Service.
          *
          * @param request ListDeliveryHistoryJobsRequest
          * @return ListDeliveryHistoryJobsResponse
         */
        public async Task<ListDeliveryHistoryJobsResponse> ListDeliveryHistoryJobsAsync(ListDeliveryHistoryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeliveryHistoryJobsWithOptionsAsync(request, runtime);
        }

        /**
          * When you call this operation to query event details, you can query the event details at most twice per second.
          * > Do not frequently call this operation. You can create a trail to deliver events to Log Service. Then, you can query event details in near real time by using the real-time log consumption feature of Log Service. For more information, see [Create a single-account trail](~~28810~~), [Create a multi-account trail](~~160661~~), and [Overview](~~28997~~).
          *
          * @param request LookupEventsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return LookupEventsResponse
         */
        public LookupEventsResponse LookupEventsWithOptions(LookupEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LookupAttribute))
            {
                query["LookupAttribute"] = request.LookupAttribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "LookupEvents",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LookupEventsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * When you call this operation to query event details, you can query the event details at most twice per second.
          * > Do not frequently call this operation. You can create a trail to deliver events to Log Service. Then, you can query event details in near real time by using the real-time log consumption feature of Log Service. For more information, see [Create a single-account trail](~~28810~~), [Create a multi-account trail](~~160661~~), and [Overview](~~28997~~).
          *
          * @param request LookupEventsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return LookupEventsResponse
         */
        public async Task<LookupEventsResponse> LookupEventsWithOptionsAsync(LookupEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LookupAttribute))
            {
                query["LookupAttribute"] = request.LookupAttribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "LookupEvents",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LookupEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * When you call this operation to query event details, you can query the event details at most twice per second.
          * > Do not frequently call this operation. You can create a trail to deliver events to Log Service. Then, you can query event details in near real time by using the real-time log consumption feature of Log Service. For more information, see [Create a single-account trail](~~28810~~), [Create a multi-account trail](~~160661~~), and [Overview](~~28997~~).
          *
          * @param request LookupEventsRequest
          * @return LookupEventsResponse
         */
        public LookupEventsResponse LookupEvents(LookupEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LookupEventsWithOptions(request, runtime);
        }

        /**
          * When you call this operation to query event details, you can query the event details at most twice per second.
          * > Do not frequently call this operation. You can create a trail to deliver events to Log Service. Then, you can query event details in near real time by using the real-time log consumption feature of Log Service. For more information, see [Create a single-account trail](~~28810~~), [Create a multi-account trail](~~160661~~), and [Overview](~~28997~~).
          *
          * @param request LookupEventsRequest
          * @return LookupEventsResponse
         */
        public async Task<LookupEventsResponse> LookupEventsAsync(LookupEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LookupEventsWithOptionsAsync(request, runtime);
        }

        /**
          * This topic describes how to enable logging for a sample trail named `trail-test`.
          *
          * @param request StartLoggingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartLoggingResponse
         */
        public StartLoggingResponse StartLoggingWithOptions(StartLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartLogging",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartLoggingResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic describes how to enable logging for a sample trail named `trail-test`.
          *
          * @param request StartLoggingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartLoggingResponse
         */
        public async Task<StartLoggingResponse> StartLoggingWithOptionsAsync(StartLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartLogging",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartLoggingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic describes how to enable logging for a sample trail named `trail-test`.
          *
          * @param request StartLoggingRequest
          * @return StartLoggingResponse
         */
        public StartLoggingResponse StartLogging(StartLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartLoggingWithOptions(request, runtime);
        }

        /**
          * This topic describes how to enable logging for a sample trail named `trail-test`.
          *
          * @param request StartLoggingRequest
          * @return StartLoggingResponse
         */
        public async Task<StartLoggingResponse> StartLoggingAsync(StartLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartLoggingWithOptionsAsync(request, runtime);
        }

        /**
          * This topic describes how to disable logging for a sample trail named `trail-test`.
          *
          * @param request StopLoggingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopLoggingResponse
         */
        public StopLoggingResponse StopLoggingWithOptions(StopLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopLogging",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopLoggingResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic describes how to disable logging for a sample trail named `trail-test`.
          *
          * @param request StopLoggingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopLoggingResponse
         */
        public async Task<StopLoggingResponse> StopLoggingWithOptionsAsync(StopLoggingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopLogging",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopLoggingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic describes how to disable logging for a sample trail named `trail-test`.
          *
          * @param request StopLoggingRequest
          * @return StopLoggingResponse
         */
        public StopLoggingResponse StopLogging(StopLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopLoggingWithOptions(request, runtime);
        }

        /**
          * This topic describes how to disable logging for a sample trail named `trail-test`.
          *
          * @param request StopLoggingRequest
          * @return StopLoggingResponse
         */
        public async Task<StopLoggingResponse> StopLoggingAsync(StopLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopLoggingWithOptionsAsync(request, runtime);
        }

        /**
          * By default, global events are stored in the Singapore region.
          * *   To obtain the permissions to call the API operation, you must submit a ticket.
          * *   Only the China (Hangzhou) region (cn-hangzhou) and the Singapore region (ap-southeast-1) are supported.
          *
          * @param request UpdateGlobalEventsStorageRegionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateGlobalEventsStorageRegionResponse
         */
        public UpdateGlobalEventsStorageRegionResponse UpdateGlobalEventsStorageRegionWithOptions(UpdateGlobalEventsStorageRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageRegion))
            {
                query["StorageRegion"] = request.StorageRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGlobalEventsStorageRegion",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGlobalEventsStorageRegionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * By default, global events are stored in the Singapore region.
          * *   To obtain the permissions to call the API operation, you must submit a ticket.
          * *   Only the China (Hangzhou) region (cn-hangzhou) and the Singapore region (ap-southeast-1) are supported.
          *
          * @param request UpdateGlobalEventsStorageRegionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateGlobalEventsStorageRegionResponse
         */
        public async Task<UpdateGlobalEventsStorageRegionResponse> UpdateGlobalEventsStorageRegionWithOptionsAsync(UpdateGlobalEventsStorageRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageRegion))
            {
                query["StorageRegion"] = request.StorageRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGlobalEventsStorageRegion",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGlobalEventsStorageRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * By default, global events are stored in the Singapore region.
          * *   To obtain the permissions to call the API operation, you must submit a ticket.
          * *   Only the China (Hangzhou) region (cn-hangzhou) and the Singapore region (ap-southeast-1) are supported.
          *
          * @param request UpdateGlobalEventsStorageRegionRequest
          * @return UpdateGlobalEventsStorageRegionResponse
         */
        public UpdateGlobalEventsStorageRegionResponse UpdateGlobalEventsStorageRegion(UpdateGlobalEventsStorageRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGlobalEventsStorageRegionWithOptions(request, runtime);
        }

        /**
          * By default, global events are stored in the Singapore region.
          * *   To obtain the permissions to call the API operation, you must submit a ticket.
          * *   Only the China (Hangzhou) region (cn-hangzhou) and the Singapore region (ap-southeast-1) are supported.
          *
          * @param request UpdateGlobalEventsStorageRegionRequest
          * @return UpdateGlobalEventsStorageRegionResponse
         */
        public async Task<UpdateGlobalEventsStorageRegionResponse> UpdateGlobalEventsStorageRegionAsync(UpdateGlobalEventsStorageRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGlobalEventsStorageRegionWithOptionsAsync(request, runtime);
        }

        /**
          * This topic shows you how to change the destination Object Storage Service (OSS) bucket of a sample trail named `trail-test` to `audit-log`.
          *
          * @param request UpdateTrailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateTrailResponse
         */
        public UpdateTrailResponse UpdateTrailWithOptions(UpdateTrailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRW))
            {
                query["EventRW"] = request.EventRW;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKeyPrefix))
            {
                query["OssKeyPrefix"] = request.OssKeyPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssWriteRoleArn))
            {
                query["OssWriteRoleArn"] = request.OssWriteRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProjectArn))
            {
                query["SlsProjectArn"] = request.SlsProjectArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsWriteRoleArn))
            {
                query["SlsWriteRoleArn"] = request.SlsWriteRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrailRegion))
            {
                query["TrailRegion"] = request.TrailRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrail",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrailResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic shows you how to change the destination Object Storage Service (OSS) bucket of a sample trail named `trail-test` to `audit-log`.
          *
          * @param request UpdateTrailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateTrailResponse
         */
        public async Task<UpdateTrailResponse> UpdateTrailWithOptionsAsync(UpdateTrailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRW))
            {
                query["EventRW"] = request.EventRW;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKeyPrefix))
            {
                query["OssKeyPrefix"] = request.OssKeyPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssWriteRoleArn))
            {
                query["OssWriteRoleArn"] = request.OssWriteRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProjectArn))
            {
                query["SlsProjectArn"] = request.SlsProjectArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsWriteRoleArn))
            {
                query["SlsWriteRoleArn"] = request.SlsWriteRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrailRegion))
            {
                query["TrailRegion"] = request.TrailRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrail",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic shows you how to change the destination Object Storage Service (OSS) bucket of a sample trail named `trail-test` to `audit-log`.
          *
          * @param request UpdateTrailRequest
          * @return UpdateTrailResponse
         */
        public UpdateTrailResponse UpdateTrail(UpdateTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTrailWithOptions(request, runtime);
        }

        /**
          * This topic shows you how to change the destination Object Storage Service (OSS) bucket of a sample trail named `trail-test` to `audit-log`.
          *
          * @param request UpdateTrailRequest
          * @return UpdateTrailResponse
         */
        public async Task<UpdateTrailResponse> UpdateTrailAsync(UpdateTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTrailWithOptionsAsync(request, runtime);
        }

    }
}
