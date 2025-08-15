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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建高级查询历史记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAdvancedQueryHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAdvancedQueryHistoryResponse
        /// </returns>
        public CreateAdvancedQueryHistoryResponse CreateAdvancedQueryHistoryWithOptions(CreateAdvancedQueryHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuerySql))
            {
                query["QuerySql"] = request.QuerySql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimpleQuery))
            {
                query["SimpleQuery"] = request.SimpleQuery;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAdvancedQueryHistory",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAdvancedQueryHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建高级查询历史记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAdvancedQueryHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAdvancedQueryHistoryResponse
        /// </returns>
        public async Task<CreateAdvancedQueryHistoryResponse> CreateAdvancedQueryHistoryWithOptionsAsync(CreateAdvancedQueryHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuerySql))
            {
                query["QuerySql"] = request.QuerySql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimpleQuery))
            {
                query["SimpleQuery"] = request.SimpleQuery;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAdvancedQueryHistory",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAdvancedQueryHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建高级查询历史记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAdvancedQueryHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAdvancedQueryHistoryResponse
        /// </returns>
        public CreateAdvancedQueryHistoryResponse CreateAdvancedQueryHistory(CreateAdvancedQueryHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAdvancedQueryHistoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建高级查询历史记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAdvancedQueryHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAdvancedQueryHistoryResponse
        /// </returns>
        public async Task<CreateAdvancedQueryHistoryResponse> CreateAdvancedQueryHistoryAsync(CreateAdvancedQueryHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAdvancedQueryHistoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAdvancedQueryTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAdvancedQueryTemplateResponse
        /// </returns>
        public CreateAdvancedQueryTemplateResponse CreateAdvancedQueryTemplateWithOptions(CreateAdvancedQueryTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimpleQuery))
            {
                query["SimpleQuery"] = request.SimpleQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateSql))
            {
                query["TemplateSql"] = request.TemplateSql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAdvancedQueryTemplate",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAdvancedQueryTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAdvancedQueryTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAdvancedQueryTemplateResponse
        /// </returns>
        public async Task<CreateAdvancedQueryTemplateResponse> CreateAdvancedQueryTemplateWithOptionsAsync(CreateAdvancedQueryTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimpleQuery))
            {
                query["SimpleQuery"] = request.SimpleQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateSql))
            {
                query["TemplateSql"] = request.TemplateSql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAdvancedQueryTemplate",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAdvancedQueryTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAdvancedQueryTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAdvancedQueryTemplateResponse
        /// </returns>
        public CreateAdvancedQueryTemplateResponse CreateAdvancedQueryTemplate(CreateAdvancedQueryTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAdvancedQueryTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAdvancedQueryTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAdvancedQueryTemplateResponse
        /// </returns>
        public async Task<CreateAdvancedQueryTemplateResponse> CreateAdvancedQueryTemplateAsync(CreateAdvancedQueryTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAdvancedQueryTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data backfill task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have created a single-account trail to deliver events to Simple Log Service by calling the <a href="https://help.aliyun.com/document_detail/212313.html">CreateTrail</a> operation.</description></item>
        /// <item><description>Only one data backfill task can run at a time within an Alibaba Cloud account.
        /// This topic provides an example on how to create a data backfill task for a trail named <c>trail-name</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDeliveryHistoryJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeliveryHistoryJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data backfill task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have created a single-account trail to deliver events to Simple Log Service by calling the <a href="https://help.aliyun.com/document_detail/212313.html">CreateTrail</a> operation.</description></item>
        /// <item><description>Only one data backfill task can run at a time within an Alibaba Cloud account.
        /// This topic provides an example on how to create a data backfill task for a trail named <c>trail-name</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDeliveryHistoryJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeliveryHistoryJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data backfill task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have created a single-account trail to deliver events to Simple Log Service by calling the <a href="https://help.aliyun.com/document_detail/212313.html">CreateTrail</a> operation.</description></item>
        /// <item><description>Only one data backfill task can run at a time within an Alibaba Cloud account.
        /// This topic provides an example on how to create a data backfill task for a trail named <c>trail-name</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDeliveryHistoryJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeliveryHistoryJobResponse
        /// </returns>
        public CreateDeliveryHistoryJobResponse CreateDeliveryHistoryJob(CreateDeliveryHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeliveryHistoryJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data backfill task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits</para>
        /// <list type="bullet">
        /// <item><description>Make sure that you have created a single-account trail to deliver events to Simple Log Service by calling the <a href="https://help.aliyun.com/document_detail/212313.html">CreateTrail</a> operation.</description></item>
        /// <item><description>Only one data backfill task can run at a time within an Alibaba Cloud account.
        /// This topic provides an example on how to create a data backfill task for a trail named <c>trail-name</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDeliveryHistoryJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeliveryHistoryJobResponse
        /// </returns>
        public async Task<CreateDeliveryHistoryJobResponse> CreateDeliveryHistoryJobAsync(CreateDeliveryHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeliveryHistoryJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a trail. By default, ActionTrail allows you to query events generated within your Alibaba Cloud account in the last 90 days. To query and analyze events generated more than 90 days ago, create a trail to deliver events to Object Storage Service (OSS), Simple Log Service, or MaxCompute.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Operation description</em>*</para>
        /// <remarks>
        /// <para>By default, a trail that is created by calling an operation is in the Disabled state. You must call the StartLogging operation to enable the trail. This way, ActionTrail can deliver events to the destination cloud service.
        /// <b>Prerequisites</b>
        /// Before you create a trail, make sure that at least one of the following storage configurations is complete:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Deliver events to OSS</para>
        /// <list type="bullet">
        /// <item><description>OSS is activated and a bucket is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Deliver events to Simple Log Service</para>
        /// <list type="bullet">
        /// <item><description>Simple Log Service is activated and a project is created.<remarks>
        /// <para>When a trail is created, ActionTrail automatically creates a Logstore named <c>actiontrail_&lt;Trail name&gt;</c> in the project. You cannot write data other than the audit data to the Logstore. This ensures the accuracy of the audit data.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Deliver events to MaxCompute</para>
        /// <list type="bullet">
        /// <item><description>MaxCompute is activated.<remarks>
        /// <para>When a trail is created, ActionTrail automatically creates a project named <c>actiontrail_&lt;Account ID&gt;</c> on the Projects page. You cannot write data other than the audit data to the project. This ensures the accuracy of the audit data.
        /// <b>Usage Notes</b>
        /// This topic provides an example on how to create a single-account trail named <c>trail-test</c> to deliver events to an OSS bucket named <c>audit-log</c>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTrailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrailResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxComputeProjectArn))
            {
                query["MaxComputeProjectArn"] = request.MaxComputeProjectArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxComputeWriteRoleArn))
            {
                query["MaxComputeWriteRoleArn"] = request.MaxComputeWriteRoleArn;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a trail. By default, ActionTrail allows you to query events generated within your Alibaba Cloud account in the last 90 days. To query and analyze events generated more than 90 days ago, create a trail to deliver events to Object Storage Service (OSS), Simple Log Service, or MaxCompute.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Operation description</em>*</para>
        /// <remarks>
        /// <para>By default, a trail that is created by calling an operation is in the Disabled state. You must call the StartLogging operation to enable the trail. This way, ActionTrail can deliver events to the destination cloud service.
        /// <b>Prerequisites</b>
        /// Before you create a trail, make sure that at least one of the following storage configurations is complete:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Deliver events to OSS</para>
        /// <list type="bullet">
        /// <item><description>OSS is activated and a bucket is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Deliver events to Simple Log Service</para>
        /// <list type="bullet">
        /// <item><description>Simple Log Service is activated and a project is created.<remarks>
        /// <para>When a trail is created, ActionTrail automatically creates a Logstore named <c>actiontrail_&lt;Trail name&gt;</c> in the project. You cannot write data other than the audit data to the Logstore. This ensures the accuracy of the audit data.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Deliver events to MaxCompute</para>
        /// <list type="bullet">
        /// <item><description>MaxCompute is activated.<remarks>
        /// <para>When a trail is created, ActionTrail automatically creates a project named <c>actiontrail_&lt;Account ID&gt;</c> on the Projects page. You cannot write data other than the audit data to the project. This ensures the accuracy of the audit data.
        /// <b>Usage Notes</b>
        /// This topic provides an example on how to create a single-account trail named <c>trail-test</c> to deliver events to an OSS bucket named <c>audit-log</c>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTrailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrailResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxComputeProjectArn))
            {
                query["MaxComputeProjectArn"] = request.MaxComputeProjectArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxComputeWriteRoleArn))
            {
                query["MaxComputeWriteRoleArn"] = request.MaxComputeWriteRoleArn;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a trail. By default, ActionTrail allows you to query events generated within your Alibaba Cloud account in the last 90 days. To query and analyze events generated more than 90 days ago, create a trail to deliver events to Object Storage Service (OSS), Simple Log Service, or MaxCompute.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Operation description</em>*</para>
        /// <remarks>
        /// <para>By default, a trail that is created by calling an operation is in the Disabled state. You must call the StartLogging operation to enable the trail. This way, ActionTrail can deliver events to the destination cloud service.
        /// <b>Prerequisites</b>
        /// Before you create a trail, make sure that at least one of the following storage configurations is complete:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Deliver events to OSS</para>
        /// <list type="bullet">
        /// <item><description>OSS is activated and a bucket is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Deliver events to Simple Log Service</para>
        /// <list type="bullet">
        /// <item><description>Simple Log Service is activated and a project is created.<remarks>
        /// <para>When a trail is created, ActionTrail automatically creates a Logstore named <c>actiontrail_&lt;Trail name&gt;</c> in the project. You cannot write data other than the audit data to the Logstore. This ensures the accuracy of the audit data.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Deliver events to MaxCompute</para>
        /// <list type="bullet">
        /// <item><description>MaxCompute is activated.<remarks>
        /// <para>When a trail is created, ActionTrail automatically creates a project named <c>actiontrail_&lt;Account ID&gt;</c> on the Projects page. You cannot write data other than the audit data to the project. This ensures the accuracy of the audit data.
        /// <b>Usage Notes</b>
        /// This topic provides an example on how to create a single-account trail named <c>trail-test</c> to deliver events to an OSS bucket named <c>audit-log</c>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTrailRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrailResponse
        /// </returns>
        public CreateTrailResponse CreateTrail(CreateTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTrailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a trail. By default, ActionTrail allows you to query events generated within your Alibaba Cloud account in the last 90 days. To query and analyze events generated more than 90 days ago, create a trail to deliver events to Object Storage Service (OSS), Simple Log Service, or MaxCompute.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Operation description</em>*</para>
        /// <remarks>
        /// <para>By default, a trail that is created by calling an operation is in the Disabled state. You must call the StartLogging operation to enable the trail. This way, ActionTrail can deliver events to the destination cloud service.
        /// <b>Prerequisites</b>
        /// Before you create a trail, make sure that at least one of the following storage configurations is complete:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Deliver events to OSS</para>
        /// <list type="bullet">
        /// <item><description>OSS is activated and a bucket is created.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Deliver events to Simple Log Service</para>
        /// <list type="bullet">
        /// <item><description>Simple Log Service is activated and a project is created.<remarks>
        /// <para>When a trail is created, ActionTrail automatically creates a Logstore named <c>actiontrail_&lt;Trail name&gt;</c> in the project. You cannot write data other than the audit data to the Logstore. This ensures the accuracy of the audit data.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Deliver events to MaxCompute</para>
        /// <list type="bullet">
        /// <item><description>MaxCompute is activated.<remarks>
        /// <para>When a trail is created, ActionTrail automatically creates a project named <c>actiontrail_&lt;Account ID&gt;</c> on the Projects page. You cannot write data other than the audit data to the project. This ensures the accuracy of the audit data.
        /// <b>Usage Notes</b>
        /// This topic provides an example on how to create a single-account trail named <c>trail-test</c> to deliver events to an OSS bucket named <c>audit-log</c>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTrailRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrailResponse
        /// </returns>
        public async Task<CreateTrailResponse> CreateTrailAsync(CreateTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTrailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除高级查询历史记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAdvancedQueryHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAdvancedQueryHistoryResponse
        /// </returns>
        public DeleteAdvancedQueryHistoryResponse DeleteAdvancedQueryHistoryWithOptions(DeleteAdvancedQueryHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAdvancedQueryHistory",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAdvancedQueryHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除高级查询历史记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAdvancedQueryHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAdvancedQueryHistoryResponse
        /// </returns>
        public async Task<DeleteAdvancedQueryHistoryResponse> DeleteAdvancedQueryHistoryWithOptionsAsync(DeleteAdvancedQueryHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAdvancedQueryHistory",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAdvancedQueryHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除高级查询历史记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAdvancedQueryHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAdvancedQueryHistoryResponse
        /// </returns>
        public DeleteAdvancedQueryHistoryResponse DeleteAdvancedQueryHistory(DeleteAdvancedQueryHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAdvancedQueryHistoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除高级查询历史记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAdvancedQueryHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAdvancedQueryHistoryResponse
        /// </returns>
        public async Task<DeleteAdvancedQueryHistoryResponse> DeleteAdvancedQueryHistoryAsync(DeleteAdvancedQueryHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAdvancedQueryHistoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAdvancedQueryTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAdvancedQueryTemplateResponse
        /// </returns>
        public DeleteAdvancedQueryTemplateResponse DeleteAdvancedQueryTemplateWithOptions(DeleteAdvancedQueryTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAdvancedQueryTemplate",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAdvancedQueryTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAdvancedQueryTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAdvancedQueryTemplateResponse
        /// </returns>
        public async Task<DeleteAdvancedQueryTemplateResponse> DeleteAdvancedQueryTemplateWithOptionsAsync(DeleteAdvancedQueryTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAdvancedQueryTemplate",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAdvancedQueryTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAdvancedQueryTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAdvancedQueryTemplateResponse
        /// </returns>
        public DeleteAdvancedQueryTemplateResponse DeleteAdvancedQueryTemplate(DeleteAdvancedQueryTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAdvancedQueryTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAdvancedQueryTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAdvancedQueryTemplateResponse
        /// </returns>
        public async Task<DeleteAdvancedQueryTemplateResponse> DeleteAdvancedQueryTemplateAsync(DeleteAdvancedQueryTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAdvancedQueryTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data backfill task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to delete a data backfill task whose ID is <c>16602</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDeliveryHistoryJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeliveryHistoryJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data backfill task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to delete a data backfill task whose ID is <c>16602</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDeliveryHistoryJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeliveryHistoryJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data backfill task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to delete a data backfill task whose ID is <c>16602</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDeliveryHistoryJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeliveryHistoryJobResponse
        /// </returns>
        public DeleteDeliveryHistoryJobResponse DeleteDeliveryHistoryJob(DeleteDeliveryHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeliveryHistoryJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data backfill task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to delete a data backfill task whose ID is <c>16602</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDeliveryHistoryJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeliveryHistoryJobResponse
        /// </returns>
        public async Task<DeleteDeliveryHistoryJobResponse> DeleteDeliveryHistoryJobAsync(DeleteDeliveryHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeliveryHistoryJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a trail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to delete a sample trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTrailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a trail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to delete a sample trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTrailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a trail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to delete a sample trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTrailRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrailResponse
        /// </returns>
        public DeleteTrailResponse DeleteTrail(DeleteTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTrailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a trail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to delete a sample trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTrailRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrailResponse
        /// </returns>
        public async Task<DeleteTrailResponse> DeleteTrailAsync(DeleteTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTrailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询高级查询历史记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvancedQueryHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvancedQueryHistoryResponse
        /// </returns>
        public DescribeAdvancedQueryHistoryResponse DescribeAdvancedQueryHistoryWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvancedQueryHistory",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAdvancedQueryHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询高级查询历史记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvancedQueryHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvancedQueryHistoryResponse
        /// </returns>
        public async Task<DescribeAdvancedQueryHistoryResponse> DescribeAdvancedQueryHistoryWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvancedQueryHistory",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAdvancedQueryHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询高级查询历史记录</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeAdvancedQueryHistoryResponse
        /// </returns>
        public DescribeAdvancedQueryHistoryResponse DescribeAdvancedQueryHistory()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAdvancedQueryHistoryWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询高级查询历史记录</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeAdvancedQueryHistoryResponse
        /// </returns>
        public async Task<DescribeAdvancedQueryHistoryResponse> DescribeAdvancedQueryHistoryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAdvancedQueryHistoryWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvancedQueryTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvancedQueryTemplateResponse
        /// </returns>
        public DescribeAdvancedQueryTemplateResponse DescribeAdvancedQueryTemplateWithOptions(DescribeAdvancedQueryTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvancedQueryTemplate",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAdvancedQueryTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvancedQueryTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvancedQueryTemplateResponse
        /// </returns>
        public async Task<DescribeAdvancedQueryTemplateResponse> DescribeAdvancedQueryTemplateWithOptionsAsync(DescribeAdvancedQueryTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvancedQueryTemplate",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAdvancedQueryTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvancedQueryTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvancedQueryTemplateResponse
        /// </returns>
        public DescribeAdvancedQueryTemplateResponse DescribeAdvancedQueryTemplate(DescribeAdvancedQueryTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAdvancedQueryTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvancedQueryTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvancedQueryTemplateResponse
        /// </returns>
        public async Task<DescribeAdvancedQueryTemplateResponse> DescribeAdvancedQueryTemplateAsync(DescribeAdvancedQueryTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAdvancedQueryTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Alibaba Cloud regions that are supported by ActionTrail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Alibaba Cloud regions that are supported by ActionTrail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Alibaba Cloud regions that are supported by ActionTrail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Alibaba Cloud regions that are supported by ActionTrail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举资源生命周期事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceLifeCycleEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceLifeCycleEventsResponse
        /// </returns>
        public DescribeResourceLifeCycleEventsResponse DescribeResourceLifeCycleEventsWithOptions(DescribeResourceLifeCycleEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
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
                Action = "DescribeResourceLifeCycleEvents",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceLifeCycleEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举资源生命周期事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceLifeCycleEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceLifeCycleEventsResponse
        /// </returns>
        public async Task<DescribeResourceLifeCycleEventsResponse> DescribeResourceLifeCycleEventsWithOptionsAsync(DescribeResourceLifeCycleEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
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
                Action = "DescribeResourceLifeCycleEvents",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceLifeCycleEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举资源生命周期事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceLifeCycleEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceLifeCycleEventsResponse
        /// </returns>
        public DescribeResourceLifeCycleEventsResponse DescribeResourceLifeCycleEvents(DescribeResourceLifeCycleEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceLifeCycleEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举资源生命周期事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceLifeCycleEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceLifeCycleEventsResponse
        /// </returns>
        public async Task<DescribeResourceLifeCycleEventsResponse> DescribeResourceLifeCycleEventsAsync(DescribeResourceLifeCycleEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceLifeCycleEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScenesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScenesResponse
        /// </returns>
        public DescribeScenesResponse DescribeScenesWithOptions(DescribeScenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchCode))
            {
                query["SearchCode"] = request.SearchCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScenes",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScenesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScenesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScenesResponse
        /// </returns>
        public async Task<DescribeScenesResponse> DescribeScenesWithOptionsAsync(DescribeScenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchCode))
            {
                query["SearchCode"] = request.SearchCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScenes",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScenesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScenesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScenesResponse
        /// </returns>
        public DescribeScenesResponse DescribeScenes(DescribeScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScenesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScenesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScenesResponse
        /// </returns>
        public async Task<DescribeScenesResponse> DescribeScenesAsync(DescribeScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScenesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举所有模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSearchTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSearchTemplatesResponse
        /// </returns>
        public DescribeSearchTemplatesResponse DescribeSearchTemplatesWithOptions(DescribeSearchTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSearchTemplates",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSearchTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举所有模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSearchTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSearchTemplatesResponse
        /// </returns>
        public async Task<DescribeSearchTemplatesResponse> DescribeSearchTemplatesWithOptionsAsync(DescribeSearchTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSearchTemplates",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSearchTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举所有模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSearchTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSearchTemplatesResponse
        /// </returns>
        public DescribeSearchTemplatesResponse DescribeSearchTemplates(DescribeSearchTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSearchTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举所有模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSearchTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSearchTemplatesResponse
        /// </returns>
        public async Task<DescribeSearchTemplatesResponse> DescribeSearchTemplatesAsync(DescribeSearchTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSearchTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries created trails.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic shows you how to query the information about the single-account trails within an Alibaba Cloud account. In this example, the information about a trail named <c>test-4</c> is returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTrailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrailsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries created trails.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic shows you how to query the information about the single-account trails within an Alibaba Cloud account. In this example, the information about a trail named <c>test-4</c> is returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTrailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrailsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries created trails.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic shows you how to query the information about the single-account trails within an Alibaba Cloud account. In this example, the information about a trail named <c>test-4</c> is returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTrailsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrailsResponse
        /// </returns>
        public DescribeTrailsResponse DescribeTrails(DescribeTrailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrailsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries created trails.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic shows you how to query the information about the single-account trails within an Alibaba Cloud account. In this example, the information about a trail named <c>test-4</c> is returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTrailsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTrailsResponse
        /// </returns>
        public async Task<DescribeTrailsResponse> DescribeTrailsAsync(DescribeTrailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrailsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户告警量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserAlertCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserAlertCountResponse
        /// </returns>
        public DescribeUserAlertCountResponse DescribeUserAlertCountWithOptions(DescribeUserAlertCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserAlertCount",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserAlertCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户告警量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserAlertCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserAlertCountResponse
        /// </returns>
        public async Task<DescribeUserAlertCountResponse> DescribeUserAlertCountWithOptionsAsync(DescribeUserAlertCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserAlertCount",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserAlertCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户告警量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserAlertCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserAlertCountResponse
        /// </returns>
        public DescribeUserAlertCountResponse DescribeUserAlertCount(DescribeUserAlertCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserAlertCountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户告警量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserAlertCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserAlertCountResponse
        /// </returns>
        public async Task<DescribeUserAlertCountResponse> DescribeUserAlertCountAsync(DescribeUserAlertCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserAlertCountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户日志量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserLogCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserLogCountResponse
        /// </returns>
        public DescribeUserLogCountResponse DescribeUserLogCountWithOptions(DescribeUserLogCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserLogCount",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserLogCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户日志量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserLogCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserLogCountResponse
        /// </returns>
        public async Task<DescribeUserLogCountResponse> DescribeUserLogCountWithOptionsAsync(DescribeUserLogCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserLogCount",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserLogCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户日志量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserLogCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserLogCountResponse
        /// </returns>
        public DescribeUserLogCountResponse DescribeUserLogCount(DescribeUserLogCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserLogCountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户日志量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserLogCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserLogCountResponse
        /// </returns>
        public async Task<DescribeUserLogCountResponse> DescribeUserLogCountAsync(DescribeUserLogCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserLogCountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the Insights feature</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableInsightRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableInsightResponse
        /// </returns>
        public EnableInsightResponse EnableInsightWithOptions(EnableInsightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsightType))
            {
                query["InsightType"] = request.InsightType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableInsight",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableInsightResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the Insights feature</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableInsightRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableInsightResponse
        /// </returns>
        public async Task<EnableInsightResponse> EnableInsightWithOptionsAsync(EnableInsightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsightType))
            {
                query["InsightType"] = request.InsightType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableInsight",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableInsightResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the Insights feature</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableInsightRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableInsightResponse
        /// </returns>
        public EnableInsightResponse EnableInsight(EnableInsightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableInsightWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the Insights feature</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableInsightRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableInsightResponse
        /// </returns>
        public async Task<EnableInsightResponse> EnableInsightAsync(EnableInsightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableInsightWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the most recent events that are generated when a specified AccessKey pair is called to access Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about the most recent events that are generated within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. For more information about supported events, see <a href="https://help.aliyun.com/document_detail/419214.html">Alibaba Cloud services and events that are supported by the AccessKey pair audit feature</a>. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedEventsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the most recent events that are generated when a specified AccessKey pair is called to access Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about the most recent events that are generated within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. For more information about supported events, see <a href="https://help.aliyun.com/document_detail/419214.html">Alibaba Cloud services and events that are supported by the AccessKey pair audit feature</a>. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedEventsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the most recent events that are generated when a specified AccessKey pair is called to access Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about the most recent events that are generated within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. For more information about supported events, see <a href="https://help.aliyun.com/document_detail/419214.html">Alibaba Cloud services and events that are supported by the AccessKey pair audit feature</a>. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedEventsResponse
        /// </returns>
        public GetAccessKeyLastUsedEventsResponse GetAccessKeyLastUsedEvents(GetAccessKeyLastUsedEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessKeyLastUsedEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the most recent events that are generated when a specified AccessKey pair is called to access Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about the most recent events that are generated within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. For more information about supported events, see <a href="https://help.aliyun.com/document_detail/419214.html">Alibaba Cloud services and events that are supported by the AccessKey pair audit feature</a>. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedEventsResponse
        /// </returns>
        public async Task<GetAccessKeyLastUsedEventsResponse> GetAccessKeyLastUsedEventsAsync(GetAccessKeyLastUsedEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessKeyLastUsedEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the most recent call of a specified AccessKey pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about the most recent call of a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the most recent call of a specified AccessKey pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about the most recent call of a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the most recent call of a specified AccessKey pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about the most recent call of a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedInfoResponse
        /// </returns>
        public GetAccessKeyLastUsedInfoResponse GetAccessKeyLastUsedInfo(GetAccessKeyLastUsedInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessKeyLastUsedInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the most recent call of a specified AccessKey pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about the most recent call of a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedInfoResponse
        /// </returns>
        public async Task<GetAccessKeyLastUsedInfoResponse> GetAccessKeyLastUsedInfoAsync(GetAccessKeyLastUsedInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessKeyLastUsedInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the IP addresses that are most recently used when an AccessKey pair is called to access Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about the IP addresses that are most recently used within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedIpsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedIpsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the IP addresses that are most recently used when an AccessKey pair is called to access Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about the IP addresses that are most recently used within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedIpsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedIpsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the IP addresses that are most recently used when an AccessKey pair is called to access Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about the IP addresses that are most recently used within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedIpsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedIpsResponse
        /// </returns>
        public GetAccessKeyLastUsedIpsResponse GetAccessKeyLastUsedIps(GetAccessKeyLastUsedIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessKeyLastUsedIpsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the IP addresses that are most recently used when an AccessKey pair is called to access Alibaba Cloud services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about the IP addresses that are most recently used within 400 days after February 1, 2022 when a specified AccessKey pair is called to access Alibaba Cloud services. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedIpsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedIpsResponse
        /// </returns>
        public async Task<GetAccessKeyLastUsedIpsResponse> GetAccessKeyLastUsedIpsAsync(GetAccessKeyLastUsedIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessKeyLastUsedIpsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the Alibaba Cloud services that are most recently accessed by using a specified AccessKey pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about Alibaba Cloud services that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedProductsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedProductsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the Alibaba Cloud services that are most recently accessed by using a specified AccessKey pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about Alibaba Cloud services that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedProductsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedProductsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the Alibaba Cloud services that are most recently accessed by using a specified AccessKey pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about Alibaba Cloud services that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedProductsResponse
        /// </returns>
        public GetAccessKeyLastUsedProductsResponse GetAccessKeyLastUsedProducts(GetAccessKeyLastUsedProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessKeyLastUsedProductsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the Alibaba Cloud services that are most recently accessed by using a specified AccessKey pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about Alibaba Cloud services that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedProductsResponse
        /// </returns>
        public async Task<GetAccessKeyLastUsedProductsResponse> GetAccessKeyLastUsedProductsAsync(GetAccessKeyLastUsedProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessKeyLastUsedProductsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the resources that are most recently accessed by using a specified AccessKey pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about resources that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the resources that are most recently accessed by using a specified AccessKey pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about resources that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the resources that are most recently accessed by using a specified AccessKey pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about resources that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedResourcesResponse
        /// </returns>
        public GetAccessKeyLastUsedResourcesResponse GetAccessKeyLastUsedResources(GetAccessKeyLastUsedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessKeyLastUsedResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the resources that are most recently accessed by using a specified AccessKey pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only the information about resources that are most recently accessed by using a specified AccessKey pair within 400 days after February 1, 2022. Data is updated at 1-hour intervals, which can cause query latency. We recommend that you do not change an AccessKey pair unless required.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedResourcesResponse
        /// </returns>
        public async Task<GetAccessKeyLastUsedResourcesResponse> GetAccessKeyLastUsedResourcesAsync(GetAccessKeyLastUsedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessKeyLastUsedResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdvancedQueryTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdvancedQueryTemplateResponse
        /// </returns>
        public GetAdvancedQueryTemplateResponse GetAdvancedQueryTemplateWithOptions(GetAdvancedQueryTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdvancedQueryTemplate",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdvancedQueryTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdvancedQueryTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdvancedQueryTemplateResponse
        /// </returns>
        public async Task<GetAdvancedQueryTemplateResponse> GetAdvancedQueryTemplateWithOptionsAsync(GetAdvancedQueryTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdvancedQueryTemplate",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdvancedQueryTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdvancedQueryTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdvancedQueryTemplateResponse
        /// </returns>
        public GetAdvancedQueryTemplateResponse GetAdvancedQueryTemplate(GetAdvancedQueryTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAdvancedQueryTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAdvancedQueryTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdvancedQueryTemplateResponse
        /// </returns>
        public async Task<GetAdvancedQueryTemplateResponse> GetAdvancedQueryTemplateAsync(GetAdvancedQueryTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAdvancedQueryTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a data backfill task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the details of a data backfill task whose ID is <c>16602</c>. The return result shows that historical events for a trail named <c>trail-name</c> are delivered to Simple Log Service and the task is complete.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeliveryHistoryJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeliveryHistoryJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a data backfill task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the details of a data backfill task whose ID is <c>16602</c>. The return result shows that historical events for a trail named <c>trail-name</c> are delivered to Simple Log Service and the task is complete.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeliveryHistoryJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeliveryHistoryJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a data backfill task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the details of a data backfill task whose ID is <c>16602</c>. The return result shows that historical events for a trail named <c>trail-name</c> are delivered to Simple Log Service and the task is complete.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeliveryHistoryJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeliveryHistoryJobResponse
        /// </returns>
        public GetDeliveryHistoryJobResponse GetDeliveryHistoryJob(GetDeliveryHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeliveryHistoryJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a data backfill task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the details of a data backfill task whose ID is <c>16602</c>. The return result shows that historical events for a trail named <c>trail-name</c> are delivered to Simple Log Service and the task is complete.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeliveryHistoryJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeliveryHistoryJobResponse
        /// </returns>
        public async Task<GetDeliveryHistoryJobResponse> GetDeliveryHistoryJobAsync(GetDeliveryHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeliveryHistoryJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the region where global events are stored.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, global events are stored in the Singapore region.
        /// To obtain the permissions to call the API operation, you must submit a ticket.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGlobalEventsStorageRegionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGlobalEventsStorageRegionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the region where global events are stored.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, global events are stored in the Singapore region.
        /// To obtain the permissions to call the API operation, you must submit a ticket.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGlobalEventsStorageRegionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGlobalEventsStorageRegionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the region where global events are stored.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, global events are stored in the Singapore region.
        /// To obtain the permissions to call the API operation, you must submit a ticket.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetGlobalEventsStorageRegionResponse
        /// </returns>
        public GetGlobalEventsStorageRegionResponse GetGlobalEventsStorageRegion()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGlobalEventsStorageRegionWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the region where global events are stored.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, global events are stored in the Singapore region.
        /// To obtain the permissions to call the API operation, you must submit a ticket.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetGlobalEventsStorageRegionResponse
        /// </returns>
        public async Task<GetGlobalEventsStorageRegionResponse> GetGlobalEventsStorageRegionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGlobalEventsStorageRegionWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作审计成熟度查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGovernanceMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGovernanceMetricsResponse
        /// </returns>
        public GetGovernanceMetricsResponse GetGovernanceMetricsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGovernanceMetrics",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGovernanceMetricsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作审计成熟度查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGovernanceMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGovernanceMetricsResponse
        /// </returns>
        public async Task<GetGovernanceMetricsResponse> GetGovernanceMetricsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGovernanceMetrics",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGovernanceMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作审计成熟度查询接口</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetGovernanceMetricsResponse
        /// </returns>
        public GetGovernanceMetricsResponse GetGovernanceMetrics()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGovernanceMetricsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作审计成熟度查询接口</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetGovernanceMetricsResponse
        /// </returns>
        public async Task<GetGovernanceMetricsResponse> GetGovernanceMetricsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGovernanceMetricsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a trail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to query the status of a sample single-account trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTrailStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrailStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a trail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to query the status of a sample single-account trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTrailStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrailStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a trail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to query the status of a sample single-account trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTrailStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrailStatusResponse
        /// </returns>
        public GetTrailStatusResponse GetTrailStatus(GetTrailStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTrailStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a trail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to query the status of a sample single-account trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTrailStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrailStatusResponse
        /// </returns>
        public async Task<GetTrailStatusResponse> GetTrailStatusAsync(GetTrailStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTrailStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据事件支持的服务与事件名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataEventServicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataEventServicesResponse
        /// </returns>
        public ListDataEventServicesResponse ListDataEventServicesWithOptions(ListDataEventServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataEventServices",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataEventServicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据事件支持的服务与事件名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataEventServicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataEventServicesResponse
        /// </returns>
        public async Task<ListDataEventServicesResponse> ListDataEventServicesWithOptionsAsync(ListDataEventServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataEventServices",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataEventServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据事件支持的服务与事件名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataEventServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataEventServicesResponse
        /// </returns>
        public ListDataEventServicesResponse ListDataEventServices(ListDataEventServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataEventServicesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据事件支持的服务与事件名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataEventServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataEventServicesResponse
        /// </returns>
        public async Task<ListDataEventServicesResponse> ListDataEventServicesAsync(ListDataEventServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataEventServicesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data backfill tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query a list of data backfill tasks. The returned result shows that a data backfill task with the ID <c>16602</c> is used to deliver historical events for a trail named <c>trail-name</c> to Simple Log Service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDeliveryHistoryJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeliveryHistoryJobsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data backfill tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query a list of data backfill tasks. The returned result shows that a data backfill task with the ID <c>16602</c> is used to deliver historical events for a trail named <c>trail-name</c> to Simple Log Service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDeliveryHistoryJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeliveryHistoryJobsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data backfill tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query a list of data backfill tasks. The returned result shows that a data backfill task with the ID <c>16602</c> is used to deliver historical events for a trail named <c>trail-name</c> to Simple Log Service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDeliveryHistoryJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeliveryHistoryJobsResponse
        /// </returns>
        public ListDeliveryHistoryJobsResponse ListDeliveryHistoryJobs(ListDeliveryHistoryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeliveryHistoryJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of data backfill tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query a list of data backfill tasks. The returned result shows that a data backfill task with the ID <c>16602</c> is used to deliver historical events for a trail named <c>trail-name</c> to Simple Log Service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDeliveryHistoryJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeliveryHistoryJobsResponse
        /// </returns>
        public async Task<ListDeliveryHistoryJobsResponse> ListDeliveryHistoryJobsAsync(ListDeliveryHistoryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeliveryHistoryJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to query event details, you can query the event details at most twice per second.</para>
        /// <remarks>
        /// <para>Do not frequently call this operation. You can create a trail to deliver events to Log Service. Then, you can query event details in near real time by using the real-time log consumption feature of Log Service. For more information, see <a href="https://help.aliyun.com/document_detail/28810.html">Create a single-account trail</a>, <a href="https://help.aliyun.com/document_detail/160661.html">Create a multi-account trail</a>, and <a href="https://help.aliyun.com/document_detail/28997.html">Overview</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// LookupEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LookupEventsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to query event details, you can query the event details at most twice per second.</para>
        /// <remarks>
        /// <para>Do not frequently call this operation. You can create a trail to deliver events to Log Service. Then, you can query event details in near real time by using the real-time log consumption feature of Log Service. For more information, see <a href="https://help.aliyun.com/document_detail/28810.html">Create a single-account trail</a>, <a href="https://help.aliyun.com/document_detail/160661.html">Create a multi-account trail</a>, and <a href="https://help.aliyun.com/document_detail/28997.html">Overview</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// LookupEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LookupEventsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to query event details, you can query the event details at most twice per second.</para>
        /// <remarks>
        /// <para>Do not frequently call this operation. You can create a trail to deliver events to Log Service. Then, you can query event details in near real time by using the real-time log consumption feature of Log Service. For more information, see <a href="https://help.aliyun.com/document_detail/28810.html">Create a single-account trail</a>, <a href="https://help.aliyun.com/document_detail/160661.html">Create a multi-account trail</a>, and <a href="https://help.aliyun.com/document_detail/28997.html">Overview</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// LookupEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// LookupEventsResponse
        /// </returns>
        public LookupEventsResponse LookupEvents(LookupEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LookupEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation to query event details, you can query the event details at most twice per second.</para>
        /// <remarks>
        /// <para>Do not frequently call this operation. You can create a trail to deliver events to Log Service. Then, you can query event details in near real time by using the real-time log consumption feature of Log Service. For more information, see <a href="https://help.aliyun.com/document_detail/28810.html">Create a single-account trail</a>, <a href="https://help.aliyun.com/document_detail/160661.html">Create a multi-account trail</a>, and <a href="https://help.aliyun.com/document_detail/28997.html">Overview</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// LookupEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// LookupEventsResponse
        /// </returns>
        public async Task<LookupEventsResponse> LookupEventsAsync(LookupEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LookupEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a trail to deliver events to an Object Storage Service (OSS) bucket or a Simple Log Service Logstore.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to enable logging for a sample trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartLoggingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartLoggingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a trail to deliver events to an Object Storage Service (OSS) bucket or a Simple Log Service Logstore.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to enable logging for a sample trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartLoggingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartLoggingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a trail to deliver events to an Object Storage Service (OSS) bucket or a Simple Log Service Logstore.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to enable logging for a sample trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartLoggingRequest
        /// </param>
        /// 
        /// <returns>
        /// StartLoggingResponse
        /// </returns>
        public StartLoggingResponse StartLogging(StartLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartLoggingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a trail to deliver events to an Object Storage Service (OSS) bucket or a Simple Log Service Logstore.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to enable logging for a sample trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartLoggingRequest
        /// </param>
        /// 
        /// <returns>
        /// StartLoggingResponse
        /// </returns>
        public async Task<StartLoggingResponse> StartLoggingAsync(StartLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartLoggingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a trail to stop the delivery of events to an Object Storage Service (OSS) bucket or a  Simple Log Service Logstore.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to disable logging for a sample trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopLoggingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopLoggingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a trail to stop the delivery of events to an Object Storage Service (OSS) bucket or a  Simple Log Service Logstore.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to disable logging for a sample trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopLoggingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopLoggingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a trail to stop the delivery of events to an Object Storage Service (OSS) bucket or a  Simple Log Service Logstore.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to disable logging for a sample trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopLoggingRequest
        /// </param>
        /// 
        /// <returns>
        /// StopLoggingResponse
        /// </returns>
        public StopLoggingResponse StopLogging(StopLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopLoggingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a trail to stop the delivery of events to an Object Storage Service (OSS) bucket or a  Simple Log Service Logstore.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to disable logging for a sample trail named <c>trail-test</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopLoggingRequest
        /// </param>
        /// 
        /// <returns>
        /// StopLoggingResponse
        /// </returns>
        public async Task<StopLoggingResponse> StopLoggingAsync(StopLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopLoggingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAdvancedQueryTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAdvancedQueryTemplateResponse
        /// </returns>
        public UpdateAdvancedQueryTemplateResponse UpdateAdvancedQueryTemplateWithOptions(UpdateAdvancedQueryTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimpleQuery))
            {
                query["SimpleQuery"] = request.SimpleQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateSql))
            {
                query["TemplateSql"] = request.TemplateSql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAdvancedQueryTemplate",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAdvancedQueryTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAdvancedQueryTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAdvancedQueryTemplateResponse
        /// </returns>
        public async Task<UpdateAdvancedQueryTemplateResponse> UpdateAdvancedQueryTemplateWithOptionsAsync(UpdateAdvancedQueryTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimpleQuery))
            {
                query["SimpleQuery"] = request.SimpleQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateSql))
            {
                query["TemplateSql"] = request.TemplateSql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAdvancedQueryTemplate",
                Version = "2020-07-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAdvancedQueryTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAdvancedQueryTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAdvancedQueryTemplateResponse
        /// </returns>
        public UpdateAdvancedQueryTemplateResponse UpdateAdvancedQueryTemplate(UpdateAdvancedQueryTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAdvancedQueryTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新高级查询模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAdvancedQueryTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAdvancedQueryTemplateResponse
        /// </returns>
        public async Task<UpdateAdvancedQueryTemplateResponse> UpdateAdvancedQueryTemplateAsync(UpdateAdvancedQueryTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAdvancedQueryTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies the region where you want to store global events.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, global events are stored in the Singapore region.</para>
        /// <list type="bullet">
        /// <item><description>To obtain the permissions to call the API operation, you must submit a ticket.</description></item>
        /// <item><description>Only the China (Hangzhou) region (cn-hangzhou) and the Singapore region (ap-southeast-1) are supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateGlobalEventsStorageRegionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGlobalEventsStorageRegionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies the region where you want to store global events.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, global events are stored in the Singapore region.</para>
        /// <list type="bullet">
        /// <item><description>To obtain the permissions to call the API operation, you must submit a ticket.</description></item>
        /// <item><description>Only the China (Hangzhou) region (cn-hangzhou) and the Singapore region (ap-southeast-1) are supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateGlobalEventsStorageRegionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGlobalEventsStorageRegionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies the region where you want to store global events.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, global events are stored in the Singapore region.</para>
        /// <list type="bullet">
        /// <item><description>To obtain the permissions to call the API operation, you must submit a ticket.</description></item>
        /// <item><description>Only the China (Hangzhou) region (cn-hangzhou) and the Singapore region (ap-southeast-1) are supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateGlobalEventsStorageRegionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGlobalEventsStorageRegionResponse
        /// </returns>
        public UpdateGlobalEventsStorageRegionResponse UpdateGlobalEventsStorageRegion(UpdateGlobalEventsStorageRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGlobalEventsStorageRegionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies the region where you want to store global events.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, global events are stored in the Singapore region.</para>
        /// <list type="bullet">
        /// <item><description>To obtain the permissions to call the API operation, you must submit a ticket.</description></item>
        /// <item><description>Only the China (Hangzhou) region (cn-hangzhou) and the Singapore region (ap-southeast-1) are supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateGlobalEventsStorageRegionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGlobalEventsStorageRegionResponse
        /// </returns>
        public async Task<UpdateGlobalEventsStorageRegionResponse> UpdateGlobalEventsStorageRegionAsync(UpdateGlobalEventsStorageRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGlobalEventsStorageRegionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of a trail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic shows you how to change the destination Object Storage Service (OSS) bucket of a sample trail named <c>trail-test</c> to <c>audit-log</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTrailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrailResponse
        /// </returns>
        public UpdateTrailResponse UpdateTrailWithOptions(UpdateTrailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRW))
            {
                query["EventRW"] = request.EventRW;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxComputeProjectArn))
            {
                query["MaxComputeProjectArn"] = request.MaxComputeProjectArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxComputeWriteRoleArn))
            {
                query["MaxComputeWriteRoleArn"] = request.MaxComputeWriteRoleArn;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of a trail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic shows you how to change the destination Object Storage Service (OSS) bucket of a sample trail named <c>trail-test</c> to <c>audit-log</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTrailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrailResponse
        /// </returns>
        public async Task<UpdateTrailResponse> UpdateTrailWithOptionsAsync(UpdateTrailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRW))
            {
                query["EventRW"] = request.EventRW;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxComputeProjectArn))
            {
                query["MaxComputeProjectArn"] = request.MaxComputeProjectArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxComputeWriteRoleArn))
            {
                query["MaxComputeWriteRoleArn"] = request.MaxComputeWriteRoleArn;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of a trail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic shows you how to change the destination Object Storage Service (OSS) bucket of a sample trail named <c>trail-test</c> to <c>audit-log</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTrailRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrailResponse
        /// </returns>
        public UpdateTrailResponse UpdateTrail(UpdateTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTrailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of a trail.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic shows you how to change the destination Object Storage Service (OSS) bucket of a sample trail named <c>trail-test</c> to <c>audit-log</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTrailRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrailResponse
        /// </returns>
        public async Task<UpdateTrailResponse> UpdateTrailAsync(UpdateTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTrailWithOptionsAsync(request, runtime);
        }

    }
}
