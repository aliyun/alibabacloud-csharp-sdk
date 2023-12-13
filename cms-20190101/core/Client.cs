// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cms20190101.Models;

namespace AlibabaCloud.SDK.Cms20190101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cms", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
          * This topic provides an example on how to add a tag to an application group whose ID is `7301****`. In this example, the key of the tag is `key1` and the value of the tag is `value1`.
          *
          * @param request AddTagsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddTagsResponse
         */
        public AddTagsResponse AddTagsWithOptions(AddTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTags",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTagsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to add a tag to an application group whose ID is `7301****`. In this example, the key of the tag is `key1` and the value of the tag is `value1`.
          *
          * @param request AddTagsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddTagsResponse
         */
        public async Task<AddTagsResponse> AddTagsWithOptionsAsync(AddTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTags",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to add a tag to an application group whose ID is `7301****`. In this example, the key of the tag is `key1` and the value of the tag is `value1`.
          *
          * @param request AddTagsRequest
          * @return AddTagsResponse
         */
        public AddTagsResponse AddTags(AddTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTagsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to add a tag to an application group whose ID is `7301****`. In this example, the key of the tag is `key1` and the value of the tag is `value1`.
          *
          * @param request AddTagsRequest
          * @return AddTagsResponse
         */
        public async Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTagsWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the `700****` alert template is applied to the `123456` application group. For the generated alert rule, the ID is `applyTemplate8ab74c6b-9f27-47ab-8841-de01dc08****`, and the name is `test123`.
          *
          * @param request ApplyMetricRuleTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ApplyMetricRuleTemplateResponse
         */
        public ApplyMetricRuleTemplateResponse ApplyMetricRuleTemplateWithOptions(ApplyMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyMode))
            {
                query["ApplyMode"] = request.ApplyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEndTime))
            {
                query["EnableEndTime"] = request.EnableEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStartTime))
            {
                query["EnableStartTime"] = request.EnableStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyLevel))
            {
                query["NotifyLevel"] = request.NotifyLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SilenceTime))
            {
                query["SilenceTime"] = request.SilenceTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["TemplateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Webhook))
            {
                query["Webhook"] = request.Webhook;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyMetricRuleTemplate",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyMetricRuleTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * In this example, the `700****` alert template is applied to the `123456` application group. For the generated alert rule, the ID is `applyTemplate8ab74c6b-9f27-47ab-8841-de01dc08****`, and the name is `test123`.
          *
          * @param request ApplyMetricRuleTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ApplyMetricRuleTemplateResponse
         */
        public async Task<ApplyMetricRuleTemplateResponse> ApplyMetricRuleTemplateWithOptionsAsync(ApplyMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyMode))
            {
                query["ApplyMode"] = request.ApplyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEndTime))
            {
                query["EnableEndTime"] = request.EnableEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStartTime))
            {
                query["EnableStartTime"] = request.EnableStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyLevel))
            {
                query["NotifyLevel"] = request.NotifyLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SilenceTime))
            {
                query["SilenceTime"] = request.SilenceTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["TemplateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Webhook))
            {
                query["Webhook"] = request.Webhook;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyMetricRuleTemplate",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyMetricRuleTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * In this example, the `700****` alert template is applied to the `123456` application group. For the generated alert rule, the ID is `applyTemplate8ab74c6b-9f27-47ab-8841-de01dc08****`, and the name is `test123`.
          *
          * @param request ApplyMetricRuleTemplateRequest
          * @return ApplyMetricRuleTemplateResponse
         */
        public ApplyMetricRuleTemplateResponse ApplyMetricRuleTemplate(ApplyMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyMetricRuleTemplateWithOptions(request, runtime);
        }

        /**
          * In this example, the `700****` alert template is applied to the `123456` application group. For the generated alert rule, the ID is `applyTemplate8ab74c6b-9f27-47ab-8841-de01dc08****`, and the name is `test123`.
          *
          * @param request ApplyMetricRuleTemplateRequest
          * @return ApplyMetricRuleTemplateResponse
         */
        public async Task<ApplyMetricRuleTemplateResponse> ApplyMetricRuleTemplateAsync(ApplyMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyMetricRuleTemplateWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to create a site monitoring task named `HangZhou_ECS1`. The URL that is monitored by the task is `https://www.aliyun.com` and the type of the task is `HTTP`. The returned result shows that the site monitoring task is created. The name of the site monitoring task is `HangZhou_ECS1` and the task ID is `679fbe4f-b80b-4706-91b2-5427b43e****`.
          *
          * @param request BatchCreateInstantSiteMonitorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchCreateInstantSiteMonitorResponse
         */
        public BatchCreateInstantSiteMonitorResponse BatchCreateInstantSiteMonitorWithOptions(BatchCreateInstantSiteMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskList))
            {
                query["TaskList"] = request.TaskList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateInstantSiteMonitor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateInstantSiteMonitorResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create a site monitoring task named `HangZhou_ECS1`. The URL that is monitored by the task is `https://www.aliyun.com` and the type of the task is `HTTP`. The returned result shows that the site monitoring task is created. The name of the site monitoring task is `HangZhou_ECS1` and the task ID is `679fbe4f-b80b-4706-91b2-5427b43e****`.
          *
          * @param request BatchCreateInstantSiteMonitorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchCreateInstantSiteMonitorResponse
         */
        public async Task<BatchCreateInstantSiteMonitorResponse> BatchCreateInstantSiteMonitorWithOptionsAsync(BatchCreateInstantSiteMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskList))
            {
                query["TaskList"] = request.TaskList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateInstantSiteMonitor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateInstantSiteMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create a site monitoring task named `HangZhou_ECS1`. The URL that is monitored by the task is `https://www.aliyun.com` and the type of the task is `HTTP`. The returned result shows that the site monitoring task is created. The name of the site monitoring task is `HangZhou_ECS1` and the task ID is `679fbe4f-b80b-4706-91b2-5427b43e****`.
          *
          * @param request BatchCreateInstantSiteMonitorRequest
          * @return BatchCreateInstantSiteMonitorResponse
         */
        public BatchCreateInstantSiteMonitorResponse BatchCreateInstantSiteMonitor(BatchCreateInstantSiteMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCreateInstantSiteMonitorWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to create a site monitoring task named `HangZhou_ECS1`. The URL that is monitored by the task is `https://www.aliyun.com` and the type of the task is `HTTP`. The returned result shows that the site monitoring task is created. The name of the site monitoring task is `HangZhou_ECS1` and the task ID is `679fbe4f-b80b-4706-91b2-5427b43e****`.
          *
          * @param request BatchCreateInstantSiteMonitorRequest
          * @return BatchCreateInstantSiteMonitorResponse
         */
        public async Task<BatchCreateInstantSiteMonitorResponse> BatchCreateInstantSiteMonitorAsync(BatchCreateInstantSiteMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCreateInstantSiteMonitorWithOptionsAsync(request, runtime);
        }

        /**
          * @deprecated : BatchCreateIntantSiteMonitor is deprecated, please use Cms::2019-01-01::BatchCreateInstantSiteMonitor instead.
          *
          * @param request BatchCreateIntantSiteMonitorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchCreateIntantSiteMonitorResponse
         */
        // Deprecated
        public BatchCreateIntantSiteMonitorResponse BatchCreateIntantSiteMonitorWithOptions(BatchCreateIntantSiteMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskList))
            {
                query["TaskList"] = request.TaskList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateIntantSiteMonitor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateIntantSiteMonitorResponse>(CallApi(params_, req, runtime));
        }

        /**
          * @deprecated : BatchCreateIntantSiteMonitor is deprecated, please use Cms::2019-01-01::BatchCreateInstantSiteMonitor instead.
          *
          * @param request BatchCreateIntantSiteMonitorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchCreateIntantSiteMonitorResponse
         */
        // Deprecated
        public async Task<BatchCreateIntantSiteMonitorResponse> BatchCreateIntantSiteMonitorWithOptionsAsync(BatchCreateIntantSiteMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskList))
            {
                query["TaskList"] = request.TaskList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateIntantSiteMonitor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateIntantSiteMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * @deprecated : BatchCreateIntantSiteMonitor is deprecated, please use Cms::2019-01-01::BatchCreateInstantSiteMonitor instead.
          *
          * @param request BatchCreateIntantSiteMonitorRequest
          * @return BatchCreateIntantSiteMonitorResponse
         */
        // Deprecated
        public BatchCreateIntantSiteMonitorResponse BatchCreateIntantSiteMonitor(BatchCreateIntantSiteMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCreateIntantSiteMonitorWithOptions(request, runtime);
        }

        /**
          * @deprecated : BatchCreateIntantSiteMonitor is deprecated, please use Cms::2019-01-01::BatchCreateInstantSiteMonitor instead.
          *
          * @param request BatchCreateIntantSiteMonitorRequest
          * @return BatchCreateIntantSiteMonitorResponse
         */
        // Deprecated
        public async Task<BatchCreateIntantSiteMonitorResponse> BatchCreateIntantSiteMonitorAsync(BatchCreateIntantSiteMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCreateIntantSiteMonitorWithOptionsAsync(request, runtime);
        }

        /**
          * ### [](#)Prerequisites
          * The `Cursor` information is returned by calling the [Cursor](~~2330730~~) operation.
          * ### [](#)Description
          * This topic provides an example on how to export the monitoring data of the `cpu_idle` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The `Cursor` information is specified. A maximum of 1,000 data entries can be returned in each response.
          *
          * @param tmpReq BatchExportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchExportResponse
         */
        public BatchExportResponse BatchExportWithOptions(BatchExportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchExportShrinkRequest request = new BatchExportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Measurements))
            {
                request.MeasurementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Measurements, "Measurements", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                body["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeasurementsShrink))
            {
                body["Measurements"] = request.MeasurementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                body["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchExport",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchExportResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### [](#)Prerequisites
          * The `Cursor` information is returned by calling the [Cursor](~~2330730~~) operation.
          * ### [](#)Description
          * This topic provides an example on how to export the monitoring data of the `cpu_idle` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The `Cursor` information is specified. A maximum of 1,000 data entries can be returned in each response.
          *
          * @param tmpReq BatchExportRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchExportResponse
         */
        public async Task<BatchExportResponse> BatchExportWithOptionsAsync(BatchExportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchExportShrinkRequest request = new BatchExportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Measurements))
            {
                request.MeasurementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Measurements, "Measurements", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                body["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeasurementsShrink))
            {
                body["Measurements"] = request.MeasurementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                body["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchExport",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchExportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### [](#)Prerequisites
          * The `Cursor` information is returned by calling the [Cursor](~~2330730~~) operation.
          * ### [](#)Description
          * This topic provides an example on how to export the monitoring data of the `cpu_idle` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The `Cursor` information is specified. A maximum of 1,000 data entries can be returned in each response.
          *
          * @param request BatchExportRequest
          * @return BatchExportResponse
         */
        public BatchExportResponse BatchExport(BatchExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchExportWithOptions(request, runtime);
        }

        /**
          * ### [](#)Prerequisites
          * The `Cursor` information is returned by calling the [Cursor](~~2330730~~) operation.
          * ### [](#)Description
          * This topic provides an example on how to export the monitoring data of the `cpu_idle` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The `Cursor` information is specified. A maximum of 1,000 data entries can be returned in each response.
          *
          * @param request BatchExportRequest
          * @return BatchExportResponse
         */
        public async Task<BatchExportResponse> BatchExportAsync(BatchExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchExportWithOptionsAsync(request, runtime);
        }

        public CreateCmsCallNumOrderResponse CreateCmsCallNumOrderWithOptions(CreateCmsCallNumOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUseCoupon))
            {
                query["AutoUseCoupon"] = request.AutoUseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneCount))
            {
                query["PhoneCount"] = request.PhoneCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCmsCallNumOrder",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCmsCallNumOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCmsCallNumOrderResponse> CreateCmsCallNumOrderWithOptionsAsync(CreateCmsCallNumOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUseCoupon))
            {
                query["AutoUseCoupon"] = request.AutoUseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneCount))
            {
                query["PhoneCount"] = request.PhoneCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCmsCallNumOrder",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCmsCallNumOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCmsCallNumOrderResponse CreateCmsCallNumOrder(CreateCmsCallNumOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCmsCallNumOrderWithOptions(request, runtime);
        }

        public async Task<CreateCmsCallNumOrderResponse> CreateCmsCallNumOrderAsync(CreateCmsCallNumOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCmsCallNumOrderWithOptionsAsync(request, runtime);
        }

        public CreateCmsOrderResponse CreateCmsOrderWithOptions(CreateCmsOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiCount))
            {
                query["ApiCount"] = request.ApiCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUseCoupon))
            {
                query["AutoUseCoupon"] = request.AutoUseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTimeSeries))
            {
                query["CustomTimeSeries"] = request.CustomTimeSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStoreNum))
            {
                query["EventStoreNum"] = request.EventStoreNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStoreTime))
            {
                query["EventStoreTime"] = request.EventStoreTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogMonitorStream))
            {
                query["LogMonitorStream"] = request.LogMonitorStream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneCount))
            {
                query["PhoneCount"] = request.PhoneCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteEcsNum))
            {
                query["SiteEcsNum"] = request.SiteEcsNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteOperatorNum))
            {
                query["SiteOperatorNum"] = request.SiteOperatorNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteTaskNum))
            {
                query["SiteTaskNum"] = request.SiteTaskNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsCount))
            {
                query["SmsCount"] = request.SmsCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuggestType))
            {
                query["SuggestType"] = request.SuggestType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCmsOrder",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCmsOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCmsOrderResponse> CreateCmsOrderWithOptionsAsync(CreateCmsOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiCount))
            {
                query["ApiCount"] = request.ApiCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUseCoupon))
            {
                query["AutoUseCoupon"] = request.AutoUseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTimeSeries))
            {
                query["CustomTimeSeries"] = request.CustomTimeSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStoreNum))
            {
                query["EventStoreNum"] = request.EventStoreNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStoreTime))
            {
                query["EventStoreTime"] = request.EventStoreTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogMonitorStream))
            {
                query["LogMonitorStream"] = request.LogMonitorStream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneCount))
            {
                query["PhoneCount"] = request.PhoneCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteEcsNum))
            {
                query["SiteEcsNum"] = request.SiteEcsNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteOperatorNum))
            {
                query["SiteOperatorNum"] = request.SiteOperatorNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteTaskNum))
            {
                query["SiteTaskNum"] = request.SiteTaskNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsCount))
            {
                query["SmsCount"] = request.SmsCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuggestType))
            {
                query["SuggestType"] = request.SuggestType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCmsOrder",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCmsOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCmsOrderResponse CreateCmsOrder(CreateCmsOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCmsOrderWithOptions(request, runtime);
        }

        public async Task<CreateCmsOrderResponse> CreateCmsOrderAsync(CreateCmsOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCmsOrderWithOptionsAsync(request, runtime);
        }

        public CreateCmsSmspackageOrderResponse CreateCmsSmspackageOrderWithOptions(CreateCmsSmspackageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUseCoupon))
            {
                query["AutoUseCoupon"] = request.AutoUseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsCount))
            {
                query["SmsCount"] = request.SmsCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCmsSmspackageOrder",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCmsSmspackageOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCmsSmspackageOrderResponse> CreateCmsSmspackageOrderWithOptionsAsync(CreateCmsSmspackageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUseCoupon))
            {
                query["AutoUseCoupon"] = request.AutoUseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsCount))
            {
                query["SmsCount"] = request.SmsCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCmsSmspackageOrder",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCmsSmspackageOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCmsSmspackageOrderResponse CreateCmsSmspackageOrder(CreateCmsSmspackageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCmsSmspackageOrderWithOptions(request, runtime);
        }

        public async Task<CreateCmsSmspackageOrderResponse> CreateCmsSmspackageOrderAsync(CreateCmsSmspackageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCmsSmspackageOrderWithOptionsAsync(request, runtime);
        }

        /**
          * This operation is available for Elastic Compute Service (ECS), ApsaraDB RDS, and Server Load Balancer (SLB).
          * This topic provides an example to show how to create an application group for resources whose tag key is `ecs_instance`. In this example, the alert contact group of the application group is `ECS_Group`.
          *
          * @param request CreateDynamicTagGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateDynamicTagGroupResponse
         */
        public CreateDynamicTagGroupResponse CreateDynamicTagGroupWithOptions(CreateDynamicTagGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupList))
            {
                query["ContactGroupList"] = request.ContactGroupList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInstallAgent))
            {
                query["EnableInstallAgent"] = request.EnableInstallAgent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSubscribeEvent))
            {
                query["EnableSubscribeEvent"] = request.EnableSubscribeEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchExpress))
            {
                query["MatchExpress"] = request.MatchExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchExpressFilterRelation))
            {
                query["MatchExpressFilterRelation"] = request.MatchExpressFilterRelation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRegionId))
            {
                query["TagRegionId"] = request.TagRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIdList))
            {
                query["TemplateIdList"] = request.TemplateIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDynamicTagGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDynamicTagGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This operation is available for Elastic Compute Service (ECS), ApsaraDB RDS, and Server Load Balancer (SLB).
          * This topic provides an example to show how to create an application group for resources whose tag key is `ecs_instance`. In this example, the alert contact group of the application group is `ECS_Group`.
          *
          * @param request CreateDynamicTagGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateDynamicTagGroupResponse
         */
        public async Task<CreateDynamicTagGroupResponse> CreateDynamicTagGroupWithOptionsAsync(CreateDynamicTagGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupList))
            {
                query["ContactGroupList"] = request.ContactGroupList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInstallAgent))
            {
                query["EnableInstallAgent"] = request.EnableInstallAgent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSubscribeEvent))
            {
                query["EnableSubscribeEvent"] = request.EnableSubscribeEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchExpress))
            {
                query["MatchExpress"] = request.MatchExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchExpressFilterRelation))
            {
                query["MatchExpressFilterRelation"] = request.MatchExpressFilterRelation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRegionId))
            {
                query["TagRegionId"] = request.TagRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIdList))
            {
                query["TemplateIdList"] = request.TemplateIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDynamicTagGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDynamicTagGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This operation is available for Elastic Compute Service (ECS), ApsaraDB RDS, and Server Load Balancer (SLB).
          * This topic provides an example to show how to create an application group for resources whose tag key is `ecs_instance`. In this example, the alert contact group of the application group is `ECS_Group`.
          *
          * @param request CreateDynamicTagGroupRequest
          * @return CreateDynamicTagGroupResponse
         */
        public CreateDynamicTagGroupResponse CreateDynamicTagGroup(CreateDynamicTagGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDynamicTagGroupWithOptions(request, runtime);
        }

        /**
          * This operation is available for Elastic Compute Service (ECS), ApsaraDB RDS, and Server Load Balancer (SLB).
          * This topic provides an example to show how to create an application group for resources whose tag key is `ecs_instance`. In this example, the alert contact group of the application group is `ECS_Group`.
          *
          * @param request CreateDynamicTagGroupRequest
          * @return CreateDynamicTagGroupResponse
         */
        public async Task<CreateDynamicTagGroupResponse> CreateDynamicTagGroupAsync(CreateDynamicTagGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDynamicTagGroupWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example to show how to create an alert rule for the `cpu_total` metric of Elastic Compute Service (ECS) in the `123456` application group. The ID of the alert rule is `456789`. The name of the alert rule is `ECS_Rule1`. The alert level is `Critical`. The statistical method is `Average`. The comparison operator is `GreaterThanOrEqualToThreshold`. The alert threshold is `90`. The number of alert retries is `3`. The response shows that the alert rule named `ECS_Rule1` is created.
          *
          * @param request CreateGroupMetricRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateGroupMetricRulesResponse
         */
        public CreateGroupMetricRulesResponse CreateGroupMetricRulesWithOptions(CreateGroupMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMetricRules))
            {
                query["GroupMetricRules"] = request.GroupMetricRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroupMetricRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupMetricRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to create an alert rule for the `cpu_total` metric of Elastic Compute Service (ECS) in the `123456` application group. The ID of the alert rule is `456789`. The name of the alert rule is `ECS_Rule1`. The alert level is `Critical`. The statistical method is `Average`. The comparison operator is `GreaterThanOrEqualToThreshold`. The alert threshold is `90`. The number of alert retries is `3`. The response shows that the alert rule named `ECS_Rule1` is created.
          *
          * @param request CreateGroupMetricRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateGroupMetricRulesResponse
         */
        public async Task<CreateGroupMetricRulesResponse> CreateGroupMetricRulesWithOptionsAsync(CreateGroupMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMetricRules))
            {
                query["GroupMetricRules"] = request.GroupMetricRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroupMetricRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupMetricRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to create an alert rule for the `cpu_total` metric of Elastic Compute Service (ECS) in the `123456` application group. The ID of the alert rule is `456789`. The name of the alert rule is `ECS_Rule1`. The alert level is `Critical`. The statistical method is `Average`. The comparison operator is `GreaterThanOrEqualToThreshold`. The alert threshold is `90`. The number of alert retries is `3`. The response shows that the alert rule named `ECS_Rule1` is created.
          *
          * @param request CreateGroupMetricRulesRequest
          * @return CreateGroupMetricRulesResponse
         */
        public CreateGroupMetricRulesResponse CreateGroupMetricRules(CreateGroupMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupMetricRulesWithOptions(request, runtime);
        }

        /**
          * This topic provides an example to show how to create an alert rule for the `cpu_total` metric of Elastic Compute Service (ECS) in the `123456` application group. The ID of the alert rule is `456789`. The name of the alert rule is `ECS_Rule1`. The alert level is `Critical`. The statistical method is `Average`. The comparison operator is `GreaterThanOrEqualToThreshold`. The alert threshold is `90`. The number of alert retries is `3`. The response shows that the alert rule named `ECS_Rule1` is created.
          *
          * @param request CreateGroupMetricRulesRequest
          * @return CreateGroupMetricRulesResponse
         */
        public async Task<CreateGroupMetricRulesResponse> CreateGroupMetricRulesAsync(CreateGroupMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupMetricRulesWithOptionsAsync(request, runtime);
        }

        public CreateGroupMonitoringAgentProcessResponse CreateGroupMonitoringAgentProcessWithOptions(CreateGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfig))
            {
                query["AlertConfig"] = request.AlertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchExpress))
            {
                query["MatchExpress"] = request.MatchExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchExpressFilterRelation))
            {
                query["MatchExpressFilterRelation"] = request.MatchExpressFilterRelation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                query["ProcessName"] = request.ProcessName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroupMonitoringAgentProcess",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupMonitoringAgentProcessResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGroupMonitoringAgentProcessResponse> CreateGroupMonitoringAgentProcessWithOptionsAsync(CreateGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfig))
            {
                query["AlertConfig"] = request.AlertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchExpress))
            {
                query["MatchExpress"] = request.MatchExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchExpressFilterRelation))
            {
                query["MatchExpressFilterRelation"] = request.MatchExpressFilterRelation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                query["ProcessName"] = request.ProcessName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroupMonitoringAgentProcess",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupMonitoringAgentProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGroupMonitoringAgentProcessResponse CreateGroupMonitoringAgentProcess(CreateGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupMonitoringAgentProcessWithOptions(request, runtime);
        }

        public async Task<CreateGroupMonitoringAgentProcessResponse> CreateGroupMonitoringAgentProcessAsync(CreateGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupMonitoringAgentProcessWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to create an availability monitoring task named `task1` in an application group named `123456`. The TaskType parameter of the task is set to `HTTP`. After you start the task, the system sends alerts by using the specified email address and DingTalk chatbot.
          *
          * @param request CreateHostAvailabilityRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateHostAvailabilityResponse
         */
        public CreateHostAvailabilityResponse CreateHostAvailabilityWithOptions(CreateHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfigEscalationList))
            {
                query["AlertConfigEscalationList"] = request.AlertConfigEscalationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfigTargetList))
            {
                query["AlertConfigTargetList"] = request.AlertConfigTargetList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskScope))
            {
                query["TaskScope"] = request.TaskScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfig))
            {
                query["AlertConfig"] = request.AlertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskOption))
            {
                query["TaskOption"] = request.TaskOption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHostAvailability",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHostAvailabilityResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create an availability monitoring task named `task1` in an application group named `123456`. The TaskType parameter of the task is set to `HTTP`. After you start the task, the system sends alerts by using the specified email address and DingTalk chatbot.
          *
          * @param request CreateHostAvailabilityRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateHostAvailabilityResponse
         */
        public async Task<CreateHostAvailabilityResponse> CreateHostAvailabilityWithOptionsAsync(CreateHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfigEscalationList))
            {
                query["AlertConfigEscalationList"] = request.AlertConfigEscalationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfigTargetList))
            {
                query["AlertConfigTargetList"] = request.AlertConfigTargetList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskScope))
            {
                query["TaskScope"] = request.TaskScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfig))
            {
                query["AlertConfig"] = request.AlertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskOption))
            {
                query["TaskOption"] = request.TaskOption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHostAvailability",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHostAvailabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create an availability monitoring task named `task1` in an application group named `123456`. The TaskType parameter of the task is set to `HTTP`. After you start the task, the system sends alerts by using the specified email address and DingTalk chatbot.
          *
          * @param request CreateHostAvailabilityRequest
          * @return CreateHostAvailabilityResponse
         */
        public CreateHostAvailabilityResponse CreateHostAvailability(CreateHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHostAvailabilityWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to create an availability monitoring task named `task1` in an application group named `123456`. The TaskType parameter of the task is set to `HTTP`. After you start the task, the system sends alerts by using the specified email address and DingTalk chatbot.
          *
          * @param request CreateHostAvailabilityRequest
          * @return CreateHostAvailabilityResponse
         */
        public async Task<CreateHostAvailabilityResponse> CreateHostAvailabilityAsync(CreateHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHostAvailabilityWithOptionsAsync(request, runtime);
        }

        /**
          * ## Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          *
          * @param request CreateHybridMonitorNamespaceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateHybridMonitorNamespaceResponse
         */
        public CreateHybridMonitorNamespaceResponse CreateHybridMonitorNamespaceWithOptions(CreateHybridMonitorNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceRegion))
            {
                query["NamespaceRegion"] = request.NamespaceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceType))
            {
                query["NamespaceType"] = request.NamespaceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                query["Spec"] = request.Spec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHybridMonitorNamespace",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHybridMonitorNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          *
          * @param request CreateHybridMonitorNamespaceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateHybridMonitorNamespaceResponse
         */
        public async Task<CreateHybridMonitorNamespaceResponse> CreateHybridMonitorNamespaceWithOptionsAsync(CreateHybridMonitorNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceRegion))
            {
                query["NamespaceRegion"] = request.NamespaceRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceType))
            {
                query["NamespaceType"] = request.NamespaceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                query["Spec"] = request.Spec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHybridMonitorNamespace",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHybridMonitorNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          *
          * @param request CreateHybridMonitorNamespaceRequest
          * @return CreateHybridMonitorNamespaceResponse
         */
        public CreateHybridMonitorNamespaceResponse CreateHybridMonitorNamespace(CreateHybridMonitorNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHybridMonitorNamespaceWithOptions(request, runtime);
        }

        /**
          * ## Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          *
          * @param request CreateHybridMonitorNamespaceRequest
          * @return CreateHybridMonitorNamespaceResponse
         */
        public async Task<CreateHybridMonitorNamespaceResponse> CreateHybridMonitorNamespaceAsync(CreateHybridMonitorNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHybridMonitorNamespaceWithOptionsAsync(request, runtime);
        }

        /**
          * # Prerequisites
          * Simple Log Service is activated. A project and a Logstore are created in Simple Log Service. For more information, see [Getting Started](~~54604~~).
          * # Description
          * In this example, a Logstore group named `Logstore_test` is created. The region ID is `cn-hangzhou`. The project is `aliyun-project`. The Logstore is `Logstore-ECS`. The response shows that the Logstore group is created.
          *
          * @param request CreateHybridMonitorSLSGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateHybridMonitorSLSGroupResponse
         */
        public CreateHybridMonitorSLSGroupResponse CreateHybridMonitorSLSGroupWithOptions(CreateHybridMonitorSLSGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupConfig))
            {
                query["SLSGroupConfig"] = request.SLSGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupDescription))
            {
                query["SLSGroupDescription"] = request.SLSGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupName))
            {
                query["SLSGroupName"] = request.SLSGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHybridMonitorSLSGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHybridMonitorSLSGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
          * # Prerequisites
          * Simple Log Service is activated. A project and a Logstore are created in Simple Log Service. For more information, see [Getting Started](~~54604~~).
          * # Description
          * In this example, a Logstore group named `Logstore_test` is created. The region ID is `cn-hangzhou`. The project is `aliyun-project`. The Logstore is `Logstore-ECS`. The response shows that the Logstore group is created.
          *
          * @param request CreateHybridMonitorSLSGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateHybridMonitorSLSGroupResponse
         */
        public async Task<CreateHybridMonitorSLSGroupResponse> CreateHybridMonitorSLSGroupWithOptionsAsync(CreateHybridMonitorSLSGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupConfig))
            {
                query["SLSGroupConfig"] = request.SLSGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupDescription))
            {
                query["SLSGroupDescription"] = request.SLSGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupName))
            {
                query["SLSGroupName"] = request.SLSGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHybridMonitorSLSGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHybridMonitorSLSGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * # Prerequisites
          * Simple Log Service is activated. A project and a Logstore are created in Simple Log Service. For more information, see [Getting Started](~~54604~~).
          * # Description
          * In this example, a Logstore group named `Logstore_test` is created. The region ID is `cn-hangzhou`. The project is `aliyun-project`. The Logstore is `Logstore-ECS`. The response shows that the Logstore group is created.
          *
          * @param request CreateHybridMonitorSLSGroupRequest
          * @return CreateHybridMonitorSLSGroupResponse
         */
        public CreateHybridMonitorSLSGroupResponse CreateHybridMonitorSLSGroup(CreateHybridMonitorSLSGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHybridMonitorSLSGroupWithOptions(request, runtime);
        }

        /**
          * # Prerequisites
          * Simple Log Service is activated. A project and a Logstore are created in Simple Log Service. For more information, see [Getting Started](~~54604~~).
          * # Description
          * In this example, a Logstore group named `Logstore_test` is created. The region ID is `cn-hangzhou`. The project is `aliyun-project`. The Logstore is `Logstore-ECS`. The response shows that the Logstore group is created.
          *
          * @param request CreateHybridMonitorSLSGroupRequest
          * @return CreateHybridMonitorSLSGroupResponse
         */
        public async Task<CreateHybridMonitorSLSGroupResponse> CreateHybridMonitorSLSGroupAsync(CreateHybridMonitorSLSGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHybridMonitorSLSGroupWithOptionsAsync(request, runtime);
        }

        /**
          * ## Prerequisites
          * *   Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          * *   If you want to create a metric for logs imported from Log Service, make sure that you have activated Log Service and created a project and a Logstore. For more information, see [Getting Started](~~54604~~).
          *
          * @param request CreateHybridMonitorTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateHybridMonitorTaskResponse
         */
        public CreateHybridMonitorTaskResponse CreateHybridMonitorTaskWithOptions(CreateHybridMonitorTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachLabels))
            {
                query["AttachLabels"] = request.AttachLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectInterval))
            {
                query["CollectInterval"] = request.CollectInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectTargetType))
            {
                query["CollectTargetType"] = request.CollectTargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSProcessConfig))
            {
                query["SLSProcessConfig"] = request.SLSProcessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserIdList))
            {
                query["TargetUserIdList"] = request.TargetUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YARMConfig))
            {
                query["YARMConfig"] = request.YARMConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHybridMonitorTask",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHybridMonitorTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Prerequisites
          * *   Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          * *   If you want to create a metric for logs imported from Log Service, make sure that you have activated Log Service and created a project and a Logstore. For more information, see [Getting Started](~~54604~~).
          *
          * @param request CreateHybridMonitorTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateHybridMonitorTaskResponse
         */
        public async Task<CreateHybridMonitorTaskResponse> CreateHybridMonitorTaskWithOptionsAsync(CreateHybridMonitorTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachLabels))
            {
                query["AttachLabels"] = request.AttachLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectInterval))
            {
                query["CollectInterval"] = request.CollectInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectTargetType))
            {
                query["CollectTargetType"] = request.CollectTargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSProcessConfig))
            {
                query["SLSProcessConfig"] = request.SLSProcessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserIdList))
            {
                query["TargetUserIdList"] = request.TargetUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YARMConfig))
            {
                query["YARMConfig"] = request.YARMConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHybridMonitorTask",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHybridMonitorTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Prerequisites
          * *   Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          * *   If you want to create a metric for logs imported from Log Service, make sure that you have activated Log Service and created a project and a Logstore. For more information, see [Getting Started](~~54604~~).
          *
          * @param request CreateHybridMonitorTaskRequest
          * @return CreateHybridMonitorTaskResponse
         */
        public CreateHybridMonitorTaskResponse CreateHybridMonitorTask(CreateHybridMonitorTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHybridMonitorTaskWithOptions(request, runtime);
        }

        /**
          * ## Prerequisites
          * *   Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          * *   If you want to create a metric for logs imported from Log Service, make sure that you have activated Log Service and created a project and a Logstore. For more information, see [Getting Started](~~54604~~).
          *
          * @param request CreateHybridMonitorTaskRequest
          * @return CreateHybridMonitorTaskResponse
         */
        public async Task<CreateHybridMonitorTaskResponse> CreateHybridMonitorTaskAsync(CreateHybridMonitorTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHybridMonitorTaskWithOptionsAsync(request, runtime);
        }

        /**
          * You can create an instant test task only by using the Alibaba Cloud account that you used to enable Network Analysis and Monitoring. 
          * This topic provides an example to show how to create an instant test task. The name of the task is `task1`. The tested address is `http://www.aliyun.com`. The test type is `HTTP`. The number of detection points is `1`.
          *
          * @param request CreateInstantSiteMonitorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateInstantSiteMonitorResponse
         */
        public CreateInstantSiteMonitorResponse CreateInstantSiteMonitorWithOptions(CreateInstantSiteMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCities))
            {
                query["IspCities"] = request.IspCities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsJson))
            {
                query["OptionsJson"] = request.OptionsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RandomIspCity))
            {
                query["RandomIspCity"] = request.RandomIspCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstantSiteMonitor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstantSiteMonitorResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can create an instant test task only by using the Alibaba Cloud account that you used to enable Network Analysis and Monitoring. 
          * This topic provides an example to show how to create an instant test task. The name of the task is `task1`. The tested address is `http://www.aliyun.com`. The test type is `HTTP`. The number of detection points is `1`.
          *
          * @param request CreateInstantSiteMonitorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateInstantSiteMonitorResponse
         */
        public async Task<CreateInstantSiteMonitorResponse> CreateInstantSiteMonitorWithOptionsAsync(CreateInstantSiteMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCities))
            {
                query["IspCities"] = request.IspCities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsJson))
            {
                query["OptionsJson"] = request.OptionsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RandomIspCity))
            {
                query["RandomIspCity"] = request.RandomIspCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstantSiteMonitor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstantSiteMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can create an instant test task only by using the Alibaba Cloud account that you used to enable Network Analysis and Monitoring. 
          * This topic provides an example to show how to create an instant test task. The name of the task is `task1`. The tested address is `http://www.aliyun.com`. The test type is `HTTP`. The number of detection points is `1`.
          *
          * @param request CreateInstantSiteMonitorRequest
          * @return CreateInstantSiteMonitorResponse
         */
        public CreateInstantSiteMonitorResponse CreateInstantSiteMonitor(CreateInstantSiteMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstantSiteMonitorWithOptions(request, runtime);
        }

        /**
          * You can create an instant test task only by using the Alibaba Cloud account that you used to enable Network Analysis and Monitoring. 
          * This topic provides an example to show how to create an instant test task. The name of the task is `task1`. The tested address is `http://www.aliyun.com`. The test type is `HTTP`. The number of detection points is `1`.
          *
          * @param request CreateInstantSiteMonitorRequest
          * @return CreateInstantSiteMonitorResponse
         */
        public async Task<CreateInstantSiteMonitorResponse> CreateInstantSiteMonitorAsync(CreateInstantSiteMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstantSiteMonitorWithOptionsAsync(request, runtime);
        }

        /**
          * ### Background information
          * *   CloudMonitor blocks alert notifications based on the blacklist policies that take effect. To block alert notifications when the value of a metric that belongs to a cloud service reaches the threshold that you specified, add the metric to a blacklist policy.
          * *   CloudMonitor allows you to create blacklist policies only based on threshold metrics. You cannot create blacklist policies based on system events. For more information about the cloud services and the thresholds of the metrics that are supported by CloudMonitor, see [Appendix 1: Metrics](~~163515~~).
          *
          * @param request CreateMetricRuleBlackListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateMetricRuleBlackListResponse
         */
        public CreateMetricRuleBlackListResponse CreateMetricRuleBlackListWithOptions(CreateMetricRuleBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                query["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEndTime))
            {
                query["EnableEndTime"] = request.EnableEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStartTime))
            {
                query["EnableStartTime"] = request.EnableStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["Instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                query["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                query["ScopeType"] = request.ScopeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeValue))
            {
                query["ScopeValue"] = request.ScopeValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMetricRuleBlackList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMetricRuleBlackListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Background information
          * *   CloudMonitor blocks alert notifications based on the blacklist policies that take effect. To block alert notifications when the value of a metric that belongs to a cloud service reaches the threshold that you specified, add the metric to a blacklist policy.
          * *   CloudMonitor allows you to create blacklist policies only based on threshold metrics. You cannot create blacklist policies based on system events. For more information about the cloud services and the thresholds of the metrics that are supported by CloudMonitor, see [Appendix 1: Metrics](~~163515~~).
          *
          * @param request CreateMetricRuleBlackListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateMetricRuleBlackListResponse
         */
        public async Task<CreateMetricRuleBlackListResponse> CreateMetricRuleBlackListWithOptionsAsync(CreateMetricRuleBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                query["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEndTime))
            {
                query["EnableEndTime"] = request.EnableEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStartTime))
            {
                query["EnableStartTime"] = request.EnableStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["Instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                query["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                query["ScopeType"] = request.ScopeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeValue))
            {
                query["ScopeValue"] = request.ScopeValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMetricRuleBlackList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMetricRuleBlackListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Background information
          * *   CloudMonitor blocks alert notifications based on the blacklist policies that take effect. To block alert notifications when the value of a metric that belongs to a cloud service reaches the threshold that you specified, add the metric to a blacklist policy.
          * *   CloudMonitor allows you to create blacklist policies only based on threshold metrics. You cannot create blacklist policies based on system events. For more information about the cloud services and the thresholds of the metrics that are supported by CloudMonitor, see [Appendix 1: Metrics](~~163515~~).
          *
          * @param request CreateMetricRuleBlackListRequest
          * @return CreateMetricRuleBlackListResponse
         */
        public CreateMetricRuleBlackListResponse CreateMetricRuleBlackList(CreateMetricRuleBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMetricRuleBlackListWithOptions(request, runtime);
        }

        /**
          * ### Background information
          * *   CloudMonitor blocks alert notifications based on the blacklist policies that take effect. To block alert notifications when the value of a metric that belongs to a cloud service reaches the threshold that you specified, add the metric to a blacklist policy.
          * *   CloudMonitor allows you to create blacklist policies only based on threshold metrics. You cannot create blacklist policies based on system events. For more information about the cloud services and the thresholds of the metrics that are supported by CloudMonitor, see [Appendix 1: Metrics](~~163515~~).
          *
          * @param request CreateMetricRuleBlackListRequest
          * @return CreateMetricRuleBlackListResponse
         */
        public async Task<CreateMetricRuleBlackListResponse> CreateMetricRuleBlackListAsync(CreateMetricRuleBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMetricRuleBlackListWithOptionsAsync(request, runtime);
        }

        public CreateMetricRuleResourcesResponse CreateMetricRuleResourcesWithOptions(CreateMetricRuleResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overwrite))
            {
                query["Overwrite"] = request.Overwrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMetricRuleResources",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMetricRuleResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMetricRuleResourcesResponse> CreateMetricRuleResourcesWithOptionsAsync(CreateMetricRuleResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overwrite))
            {
                query["Overwrite"] = request.Overwrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMetricRuleResources",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMetricRuleResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMetricRuleResourcesResponse CreateMetricRuleResources(CreateMetricRuleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMetricRuleResourcesWithOptions(request, runtime);
        }

        public async Task<CreateMetricRuleResourcesResponse> CreateMetricRuleResourcesAsync(CreateMetricRuleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMetricRuleResourcesWithOptionsAsync(request, runtime);
        }

        public CreateMetricRuleTemplateResponse CreateMetricRuleTemplateWithOptions(CreateMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTemplates))
            {
                query["AlertTemplates"] = request.AlertTemplates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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
                Action = "CreateMetricRuleTemplate",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMetricRuleTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMetricRuleTemplateResponse> CreateMetricRuleTemplateWithOptionsAsync(CreateMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTemplates))
            {
                query["AlertTemplates"] = request.AlertTemplates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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
                Action = "CreateMetricRuleTemplate",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMetricRuleTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMetricRuleTemplateResponse CreateMetricRuleTemplate(CreateMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMetricRuleTemplateWithOptions(request, runtime);
        }

        public async Task<CreateMetricRuleTemplateResponse> CreateMetricRuleTemplateAsync(CreateMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMetricRuleTemplateWithOptionsAsync(request, runtime);
        }

        public CreateMonitorAgentProcessResponse CreateMonitorAgentProcessWithOptions(CreateMonitorAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                query["ProcessName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessUser))
            {
                query["ProcessUser"] = request.ProcessUser;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMonitorAgentProcess",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMonitorAgentProcessResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMonitorAgentProcessResponse> CreateMonitorAgentProcessWithOptionsAsync(CreateMonitorAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                query["ProcessName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessUser))
            {
                query["ProcessUser"] = request.ProcessUser;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMonitorAgentProcess",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMonitorAgentProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMonitorAgentProcessResponse CreateMonitorAgentProcess(CreateMonitorAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMonitorAgentProcessWithOptions(request, runtime);
        }

        public async Task<CreateMonitorAgentProcessResponse> CreateMonitorAgentProcessAsync(CreateMonitorAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMonitorAgentProcessWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the application group named `ECS_Group` is created.
          *
          * @param request CreateMonitorGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateMonitorGroupResponse
         */
        public CreateMonitorGroupResponse CreateMonitorGroupWithOptions(CreateMonitorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroups))
            {
                query["ContactGroups"] = request.ContactGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMonitorGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMonitorGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
          * In this example, the application group named `ECS_Group` is created.
          *
          * @param request CreateMonitorGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateMonitorGroupResponse
         */
        public async Task<CreateMonitorGroupResponse> CreateMonitorGroupWithOptionsAsync(CreateMonitorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroups))
            {
                query["ContactGroups"] = request.ContactGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMonitorGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMonitorGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * In this example, the application group named `ECS_Group` is created.
          *
          * @param request CreateMonitorGroupRequest
          * @return CreateMonitorGroupResponse
         */
        public CreateMonitorGroupResponse CreateMonitorGroup(CreateMonitorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMonitorGroupWithOptions(request, runtime);
        }

        /**
          * In this example, the application group named `ECS_Group` is created.
          *
          * @param request CreateMonitorGroupRequest
          * @return CreateMonitorGroupResponse
         */
        public async Task<CreateMonitorGroupResponse> CreateMonitorGroupAsync(CreateMonitorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMonitorGroupWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to create an application group by using the resource group `CloudMonitor` and the alert contact group `ECS_Group`. The region ID of the resource group is `cn-hangzhou`.
          *
          * @param request CreateMonitorGroupByResourceGroupIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateMonitorGroupByResourceGroupIdResponse
         */
        public CreateMonitorGroupByResourceGroupIdResponse CreateMonitorGroupByResourceGroupIdWithOptions(CreateMonitorGroupByResourceGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupList))
            {
                query["ContactGroupList"] = request.ContactGroupList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInstallAgent))
            {
                query["EnableInstallAgent"] = request.EnableInstallAgent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSubscribeEvent))
            {
                query["EnableSubscribeEvent"] = request.EnableSubscribeEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["ResourceGroupName"] = request.ResourceGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMonitorGroupByResourceGroupId",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMonitorGroupByResourceGroupIdResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create an application group by using the resource group `CloudMonitor` and the alert contact group `ECS_Group`. The region ID of the resource group is `cn-hangzhou`.
          *
          * @param request CreateMonitorGroupByResourceGroupIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateMonitorGroupByResourceGroupIdResponse
         */
        public async Task<CreateMonitorGroupByResourceGroupIdResponse> CreateMonitorGroupByResourceGroupIdWithOptionsAsync(CreateMonitorGroupByResourceGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupList))
            {
                query["ContactGroupList"] = request.ContactGroupList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInstallAgent))
            {
                query["EnableInstallAgent"] = request.EnableInstallAgent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSubscribeEvent))
            {
                query["EnableSubscribeEvent"] = request.EnableSubscribeEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["ResourceGroupName"] = request.ResourceGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMonitorGroupByResourceGroupId",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMonitorGroupByResourceGroupIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create an application group by using the resource group `CloudMonitor` and the alert contact group `ECS_Group`. The region ID of the resource group is `cn-hangzhou`.
          *
          * @param request CreateMonitorGroupByResourceGroupIdRequest
          * @return CreateMonitorGroupByResourceGroupIdResponse
         */
        public CreateMonitorGroupByResourceGroupIdResponse CreateMonitorGroupByResourceGroupId(CreateMonitorGroupByResourceGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMonitorGroupByResourceGroupIdWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to create an application group by using the resource group `CloudMonitor` and the alert contact group `ECS_Group`. The region ID of the resource group is `cn-hangzhou`.
          *
          * @param request CreateMonitorGroupByResourceGroupIdRequest
          * @return CreateMonitorGroupByResourceGroupIdResponse
         */
        public async Task<CreateMonitorGroupByResourceGroupIdResponse> CreateMonitorGroupByResourceGroupIdAsync(CreateMonitorGroupByResourceGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMonitorGroupByResourceGroupIdWithOptionsAsync(request, runtime);
        }

        /**
          * You can add a maximum of 1,000 instances to an application group at a time. You can add a maximum of 3,000 instances of an Alibaba Cloud service to an application group. The total number of instances that you can add to an application group is unlimited.
          * In this example, an Elastic Compute Service (ECS) instance in the `China (Hangzhou)` region is added to the `3607****` application group. The instance ID is `i-2ze26xj5wwy12****` and the instance name is `test-instance-ecs`.
          *
          * @param request CreateMonitorGroupInstancesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateMonitorGroupInstancesResponse
         */
        public CreateMonitorGroupInstancesResponse CreateMonitorGroupInstancesWithOptions(CreateMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["Instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMonitorGroupInstances",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMonitorGroupInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can add a maximum of 1,000 instances to an application group at a time. You can add a maximum of 3,000 instances of an Alibaba Cloud service to an application group. The total number of instances that you can add to an application group is unlimited.
          * In this example, an Elastic Compute Service (ECS) instance in the `China (Hangzhou)` region is added to the `3607****` application group. The instance ID is `i-2ze26xj5wwy12****` and the instance name is `test-instance-ecs`.
          *
          * @param request CreateMonitorGroupInstancesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateMonitorGroupInstancesResponse
         */
        public async Task<CreateMonitorGroupInstancesResponse> CreateMonitorGroupInstancesWithOptionsAsync(CreateMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["Instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMonitorGroupInstances",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMonitorGroupInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can add a maximum of 1,000 instances to an application group at a time. You can add a maximum of 3,000 instances of an Alibaba Cloud service to an application group. The total number of instances that you can add to an application group is unlimited.
          * In this example, an Elastic Compute Service (ECS) instance in the `China (Hangzhou)` region is added to the `3607****` application group. The instance ID is `i-2ze26xj5wwy12****` and the instance name is `test-instance-ecs`.
          *
          * @param request CreateMonitorGroupInstancesRequest
          * @return CreateMonitorGroupInstancesResponse
         */
        public CreateMonitorGroupInstancesResponse CreateMonitorGroupInstances(CreateMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMonitorGroupInstancesWithOptions(request, runtime);
        }

        /**
          * You can add a maximum of 1,000 instances to an application group at a time. You can add a maximum of 3,000 instances of an Alibaba Cloud service to an application group. The total number of instances that you can add to an application group is unlimited.
          * In this example, an Elastic Compute Service (ECS) instance in the `China (Hangzhou)` region is added to the `3607****` application group. The instance ID is `i-2ze26xj5wwy12****` and the instance name is `test-instance-ecs`.
          *
          * @param request CreateMonitorGroupInstancesRequest
          * @return CreateMonitorGroupInstancesResponse
         */
        public async Task<CreateMonitorGroupInstancesResponse> CreateMonitorGroupInstancesAsync(CreateMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMonitorGroupInstancesWithOptionsAsync(request, runtime);
        }

        /**
          * If the policy is valid, no alert notifications are sent for the application group.
          * This topic describes how to create the `PauseNotify` policy to pause alert notifications for the `7301****` application group. The StartTime parameter is set to `1622949300000` and the EndTime parameter is set to `1623208500000`. This indicates that the policy is valid from `2021-06-06 11:15:00 UTC+8` to `2021-06-09 11:15:00 UTC+8`.
          *
          * @param request CreateMonitorGroupNotifyPolicyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateMonitorGroupNotifyPolicyResponse
         */
        public CreateMonitorGroupNotifyPolicyResponse CreateMonitorGroupNotifyPolicyWithOptions(CreateMonitorGroupNotifyPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
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
                Action = "CreateMonitorGroupNotifyPolicy",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMonitorGroupNotifyPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If the policy is valid, no alert notifications are sent for the application group.
          * This topic describes how to create the `PauseNotify` policy to pause alert notifications for the `7301****` application group. The StartTime parameter is set to `1622949300000` and the EndTime parameter is set to `1623208500000`. This indicates that the policy is valid from `2021-06-06 11:15:00 UTC+8` to `2021-06-09 11:15:00 UTC+8`.
          *
          * @param request CreateMonitorGroupNotifyPolicyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateMonitorGroupNotifyPolicyResponse
         */
        public async Task<CreateMonitorGroupNotifyPolicyResponse> CreateMonitorGroupNotifyPolicyWithOptionsAsync(CreateMonitorGroupNotifyPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
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
                Action = "CreateMonitorGroupNotifyPolicy",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMonitorGroupNotifyPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If the policy is valid, no alert notifications are sent for the application group.
          * This topic describes how to create the `PauseNotify` policy to pause alert notifications for the `7301****` application group. The StartTime parameter is set to `1622949300000` and the EndTime parameter is set to `1623208500000`. This indicates that the policy is valid from `2021-06-06 11:15:00 UTC+8` to `2021-06-09 11:15:00 UTC+8`.
          *
          * @param request CreateMonitorGroupNotifyPolicyRequest
          * @return CreateMonitorGroupNotifyPolicyResponse
         */
        public CreateMonitorGroupNotifyPolicyResponse CreateMonitorGroupNotifyPolicy(CreateMonitorGroupNotifyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMonitorGroupNotifyPolicyWithOptions(request, runtime);
        }

        /**
          * If the policy is valid, no alert notifications are sent for the application group.
          * This topic describes how to create the `PauseNotify` policy to pause alert notifications for the `7301****` application group. The StartTime parameter is set to `1622949300000` and the EndTime parameter is set to `1623208500000`. This indicates that the policy is valid from `2021-06-06 11:15:00 UTC+8` to `2021-06-09 11:15:00 UTC+8`.
          *
          * @param request CreateMonitorGroupNotifyPolicyRequest
          * @return CreateMonitorGroupNotifyPolicyResponse
         */
        public async Task<CreateMonitorGroupNotifyPolicyResponse> CreateMonitorGroupNotifyPolicyAsync(CreateMonitorGroupNotifyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMonitorGroupNotifyPolicyWithOptionsAsync(request, runtime);
        }

        public CreateMonitoringAgentProcessResponse CreateMonitoringAgentProcessWithOptions(CreateMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                query["ProcessName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessUser))
            {
                query["ProcessUser"] = request.ProcessUser;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMonitoringAgentProcess",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMonitoringAgentProcessResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMonitoringAgentProcessResponse> CreateMonitoringAgentProcessWithOptionsAsync(CreateMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                query["ProcessName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessUser))
            {
                query["ProcessUser"] = request.ProcessUser;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMonitoringAgentProcess",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMonitoringAgentProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMonitoringAgentProcessResponse CreateMonitoringAgentProcess(CreateMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMonitoringAgentProcessWithOptions(request, runtime);
        }

        public async Task<CreateMonitoringAgentProcessResponse> CreateMonitoringAgentProcessAsync(CreateMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMonitoringAgentProcessWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to create a site monitoring task named `HanZhou_ECS1`. The URL that is monitored by the task is `https://www.aliyun.com` and the type of the task is `HTTPS`.
          *
          * @param request CreateSiteMonitorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateSiteMonitorResponse
         */
        public CreateSiteMonitorResponse CreateSiteMonitorWithOptions(CreateSiteMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertIds))
            {
                query["AlertIds"] = request.AlertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSchedule))
            {
                query["CustomSchedule"] = request.CustomSchedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCities))
            {
                query["IspCities"] = request.IspCities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsJson))
            {
                query["OptionsJson"] = request.OptionsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSiteMonitor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSiteMonitorResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create a site monitoring task named `HanZhou_ECS1`. The URL that is monitored by the task is `https://www.aliyun.com` and the type of the task is `HTTPS`.
          *
          * @param request CreateSiteMonitorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateSiteMonitorResponse
         */
        public async Task<CreateSiteMonitorResponse> CreateSiteMonitorWithOptionsAsync(CreateSiteMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertIds))
            {
                query["AlertIds"] = request.AlertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSchedule))
            {
                query["CustomSchedule"] = request.CustomSchedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCities))
            {
                query["IspCities"] = request.IspCities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsJson))
            {
                query["OptionsJson"] = request.OptionsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSiteMonitor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSiteMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create a site monitoring task named `HanZhou_ECS1`. The URL that is monitored by the task is `https://www.aliyun.com` and the type of the task is `HTTPS`.
          *
          * @param request CreateSiteMonitorRequest
          * @return CreateSiteMonitorResponse
         */
        public CreateSiteMonitorResponse CreateSiteMonitor(CreateSiteMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSiteMonitorWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to create a site monitoring task named `HanZhou_ECS1`. The URL that is monitored by the task is `https://www.aliyun.com` and the type of the task is `HTTPS`.
          *
          * @param request CreateSiteMonitorRequest
          * @return CreateSiteMonitorResponse
         */
        public async Task<CreateSiteMonitorResponse> CreateSiteMonitorAsync(CreateSiteMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSiteMonitorWithOptionsAsync(request, runtime);
        }

        /**
          * ### [](#)Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          * ### [](#)Background information
          * You can call this operation to obtain the Cursor information and then call the [BatchExport](~~2329847~~) operation to export the monitoring data.
          * ### [](#)Description
          * This topic provides an example on how to define the monitoring data of a specified metric for a specified cloud service. In this example, the namespace of the cloud service is set to `acs_ecs_dashboard`, the metric is set to `cpu_idle`, the start time is set to `1641627000000`, and the end time is set to `1641645000000`. The number of idle CPU cores on your Elastic Compute Service (ECS) instances is measured every 60 seconds from 15:30:00, January 8, 2022 to 20:30:00, January 8, 2022. The `Cursor` information is returned.
          *
          * @param tmpReq CursorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CursorResponse
         */
        public CursorResponse CursorWithOptions(CursorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CursorShrinkRequest request = new CursorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Matchers))
            {
                request.MatchersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Matchers, "Matchers", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchersShrink))
            {
                body["Matchers"] = request.MatchersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                body["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
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
                Action = "Cursor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CursorResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### [](#)Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          * ### [](#)Background information
          * You can call this operation to obtain the Cursor information and then call the [BatchExport](~~2329847~~) operation to export the monitoring data.
          * ### [](#)Description
          * This topic provides an example on how to define the monitoring data of a specified metric for a specified cloud service. In this example, the namespace of the cloud service is set to `acs_ecs_dashboard`, the metric is set to `cpu_idle`, the start time is set to `1641627000000`, and the end time is set to `1641645000000`. The number of idle CPU cores on your Elastic Compute Service (ECS) instances is measured every 60 seconds from 15:30:00, January 8, 2022 to 20:30:00, January 8, 2022. The `Cursor` information is returned.
          *
          * @param tmpReq CursorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CursorResponse
         */
        public async Task<CursorResponse> CursorWithOptionsAsync(CursorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CursorShrinkRequest request = new CursorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Matchers))
            {
                request.MatchersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Matchers, "Matchers", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchersShrink))
            {
                body["Matchers"] = request.MatchersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                body["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
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
                Action = "Cursor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CursorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### [](#)Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          * ### [](#)Background information
          * You can call this operation to obtain the Cursor information and then call the [BatchExport](~~2329847~~) operation to export the monitoring data.
          * ### [](#)Description
          * This topic provides an example on how to define the monitoring data of a specified metric for a specified cloud service. In this example, the namespace of the cloud service is set to `acs_ecs_dashboard`, the metric is set to `cpu_idle`, the start time is set to `1641627000000`, and the end time is set to `1641645000000`. The number of idle CPU cores on your Elastic Compute Service (ECS) instances is measured every 60 seconds from 15:30:00, January 8, 2022 to 20:30:00, January 8, 2022. The `Cursor` information is returned.
          *
          * @param request CursorRequest
          * @return CursorResponse
         */
        public CursorResponse Cursor(CursorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CursorWithOptions(request, runtime);
        }

        /**
          * ### [](#)Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          * ### [](#)Background information
          * You can call this operation to obtain the Cursor information and then call the [BatchExport](~~2329847~~) operation to export the monitoring data.
          * ### [](#)Description
          * This topic provides an example on how to define the monitoring data of a specified metric for a specified cloud service. In this example, the namespace of the cloud service is set to `acs_ecs_dashboard`, the metric is set to `cpu_idle`, the start time is set to `1641627000000`, and the end time is set to `1641645000000`. The number of idle CPU cores on your Elastic Compute Service (ECS) instances is measured every 60 seconds from 15:30:00, January 8, 2022 to 20:30:00, January 8, 2022. The `Cursor` information is returned.
          *
          * @param request CursorRequest
          * @return CursorResponse
         */
        public async Task<CursorResponse> CursorAsync(CursorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CursorWithOptionsAsync(request, runtime);
        }

        public DeleteContactResponse DeleteContactWithOptions(DeleteContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContact",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteContactResponse> DeleteContactWithOptionsAsync(DeleteContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContact",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteContactResponse DeleteContact(DeleteContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContactWithOptions(request, runtime);
        }

        public async Task<DeleteContactResponse> DeleteContactAsync(DeleteContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContactWithOptionsAsync(request, runtime);
        }

        public DeleteContactGroupResponse DeleteContactGroupWithOptions(DeleteContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupName))
            {
                query["ContactGroupName"] = request.ContactGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContactGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteContactGroupResponse> DeleteContactGroupWithOptionsAsync(DeleteContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupName))
            {
                query["ContactGroupName"] = request.ContactGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContactGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteContactGroupResponse DeleteContactGroup(DeleteContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContactGroupWithOptions(request, runtime);
        }

        public async Task<DeleteContactGroupResponse> DeleteContactGroupAsync(DeleteContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContactGroupWithOptionsAsync(request, runtime);
        }

        public DeleteCustomMetricResponse DeleteCustomMetricWithOptions(DeleteCustomMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                query["Md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UUID))
            {
                query["UUID"] = request.UUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomMetric",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomMetricResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCustomMetricResponse> DeleteCustomMetricWithOptionsAsync(DeleteCustomMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                query["Md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UUID))
            {
                query["UUID"] = request.UUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomMetric",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCustomMetricResponse DeleteCustomMetric(DeleteCustomMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomMetricWithOptions(request, runtime);
        }

        public async Task<DeleteCustomMetricResponse> DeleteCustomMetricAsync(DeleteCustomMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomMetricWithOptionsAsync(request, runtime);
        }

        public DeleteDynamicTagGroupResponse DeleteDynamicTagGroupWithOptions(DeleteDynamicTagGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicTagRuleId))
            {
                query["DynamicTagRuleId"] = request.DynamicTagRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDynamicTagGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDynamicTagGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDynamicTagGroupResponse> DeleteDynamicTagGroupWithOptionsAsync(DeleteDynamicTagGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicTagRuleId))
            {
                query["DynamicTagRuleId"] = request.DynamicTagRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDynamicTagGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDynamicTagGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDynamicTagGroupResponse DeleteDynamicTagGroup(DeleteDynamicTagGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDynamicTagGroupWithOptions(request, runtime);
        }

        public async Task<DeleteDynamicTagGroupResponse> DeleteDynamicTagGroupAsync(DeleteDynamicTagGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDynamicTagGroupWithOptionsAsync(request, runtime);
        }

        public DeleteEventRuleTargetsResponse DeleteEventRuleTargetsWithOptions(DeleteEventRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventRuleTargets",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventRuleTargetsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEventRuleTargetsResponse> DeleteEventRuleTargetsWithOptionsAsync(DeleteEventRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventRuleTargets",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventRuleTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEventRuleTargetsResponse DeleteEventRuleTargets(DeleteEventRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventRuleTargetsWithOptions(request, runtime);
        }

        public async Task<DeleteEventRuleTargetsResponse> DeleteEventRuleTargetsAsync(DeleteEventRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventRuleTargetsWithOptionsAsync(request, runtime);
        }

        public DeleteEventRulesResponse DeleteEventRulesWithOptions(DeleteEventRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleNames))
            {
                query["RuleNames"] = request.RuleNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEventRulesResponse> DeleteEventRulesWithOptionsAsync(DeleteEventRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleNames))
            {
                query["RuleNames"] = request.RuleNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEventRulesResponse DeleteEventRules(DeleteEventRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventRulesWithOptions(request, runtime);
        }

        public async Task<DeleteEventRulesResponse> DeleteEventRulesAsync(DeleteEventRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventRulesWithOptionsAsync(request, runtime);
        }

        public DeleteExporterOutputResponse DeleteExporterOutputWithOptions(DeleteExporterOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestName))
            {
                query["DestName"] = request.DestName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExporterOutput",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExporterOutputResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteExporterOutputResponse> DeleteExporterOutputWithOptionsAsync(DeleteExporterOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestName))
            {
                query["DestName"] = request.DestName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExporterOutput",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExporterOutputResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteExporterOutputResponse DeleteExporterOutput(DeleteExporterOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExporterOutputWithOptions(request, runtime);
        }

        public async Task<DeleteExporterOutputResponse> DeleteExporterOutputAsync(DeleteExporterOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExporterOutputWithOptionsAsync(request, runtime);
        }

        public DeleteExporterRuleResponse DeleteExporterRuleWithOptions(DeleteExporterRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExporterRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExporterRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteExporterRuleResponse> DeleteExporterRuleWithOptionsAsync(DeleteExporterRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExporterRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExporterRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteExporterRuleResponse DeleteExporterRule(DeleteExporterRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExporterRuleWithOptions(request, runtime);
        }

        public async Task<DeleteExporterRuleResponse> DeleteExporterRuleAsync(DeleteExporterRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExporterRuleWithOptionsAsync(request, runtime);
        }

        public DeleteGroupMonitoringAgentProcessResponse DeleteGroupMonitoringAgentProcessWithOptions(DeleteGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroupMonitoringAgentProcess",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupMonitoringAgentProcessResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteGroupMonitoringAgentProcessResponse> DeleteGroupMonitoringAgentProcessWithOptionsAsync(DeleteGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroupMonitoringAgentProcess",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupMonitoringAgentProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteGroupMonitoringAgentProcessResponse DeleteGroupMonitoringAgentProcess(DeleteGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGroupMonitoringAgentProcessWithOptions(request, runtime);
        }

        public async Task<DeleteGroupMonitoringAgentProcessResponse> DeleteGroupMonitoringAgentProcessAsync(DeleteGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGroupMonitoringAgentProcessWithOptionsAsync(request, runtime);
        }

        public DeleteHostAvailabilityResponse DeleteHostAvailabilityWithOptions(DeleteHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHostAvailability",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHostAvailabilityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteHostAvailabilityResponse> DeleteHostAvailabilityWithOptionsAsync(DeleteHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHostAvailability",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHostAvailabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteHostAvailabilityResponse DeleteHostAvailability(DeleteHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHostAvailabilityWithOptions(request, runtime);
        }

        public async Task<DeleteHostAvailabilityResponse> DeleteHostAvailabilityAsync(DeleteHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHostAvailabilityWithOptionsAsync(request, runtime);
        }

        /**
          * > If a metric import task is created for metrics in a namespace, you cannot delete the namespace unless you delete the task first.
          * This topic provides an example on how to delete a namespace named `aliyun`. The response shows that the namespace is deleted.
          *
          * @param request DeleteHybridMonitorNamespaceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteHybridMonitorNamespaceResponse
         */
        public DeleteHybridMonitorNamespaceResponse DeleteHybridMonitorNamespaceWithOptions(DeleteHybridMonitorNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHybridMonitorNamespace",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHybridMonitorNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > If a metric import task is created for metrics in a namespace, you cannot delete the namespace unless you delete the task first.
          * This topic provides an example on how to delete a namespace named `aliyun`. The response shows that the namespace is deleted.
          *
          * @param request DeleteHybridMonitorNamespaceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteHybridMonitorNamespaceResponse
         */
        public async Task<DeleteHybridMonitorNamespaceResponse> DeleteHybridMonitorNamespaceWithOptionsAsync(DeleteHybridMonitorNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHybridMonitorNamespace",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHybridMonitorNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > If a metric import task is created for metrics in a namespace, you cannot delete the namespace unless you delete the task first.
          * This topic provides an example on how to delete a namespace named `aliyun`. The response shows that the namespace is deleted.
          *
          * @param request DeleteHybridMonitorNamespaceRequest
          * @return DeleteHybridMonitorNamespaceResponse
         */
        public DeleteHybridMonitorNamespaceResponse DeleteHybridMonitorNamespace(DeleteHybridMonitorNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHybridMonitorNamespaceWithOptions(request, runtime);
        }

        /**
          * > If a metric import task is created for metrics in a namespace, you cannot delete the namespace unless you delete the task first.
          * This topic provides an example on how to delete a namespace named `aliyun`. The response shows that the namespace is deleted.
          *
          * @param request DeleteHybridMonitorNamespaceRequest
          * @return DeleteHybridMonitorNamespaceResponse
         */
        public async Task<DeleteHybridMonitorNamespaceResponse> DeleteHybridMonitorNamespaceAsync(DeleteHybridMonitorNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHybridMonitorNamespaceWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to delete a Logstore group named `Logstore_test`. The response shows that the Logstore group is deleted.
          *
          * @param request DeleteHybridMonitorSLSGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteHybridMonitorSLSGroupResponse
         */
        public DeleteHybridMonitorSLSGroupResponse DeleteHybridMonitorSLSGroupWithOptions(DeleteHybridMonitorSLSGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupName))
            {
                query["SLSGroupName"] = request.SLSGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHybridMonitorSLSGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHybridMonitorSLSGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to delete a Logstore group named `Logstore_test`. The response shows that the Logstore group is deleted.
          *
          * @param request DeleteHybridMonitorSLSGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteHybridMonitorSLSGroupResponse
         */
        public async Task<DeleteHybridMonitorSLSGroupResponse> DeleteHybridMonitorSLSGroupWithOptionsAsync(DeleteHybridMonitorSLSGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupName))
            {
                query["SLSGroupName"] = request.SLSGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHybridMonitorSLSGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHybridMonitorSLSGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to delete a Logstore group named `Logstore_test`. The response shows that the Logstore group is deleted.
          *
          * @param request DeleteHybridMonitorSLSGroupRequest
          * @return DeleteHybridMonitorSLSGroupResponse
         */
        public DeleteHybridMonitorSLSGroupResponse DeleteHybridMonitorSLSGroup(DeleteHybridMonitorSLSGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHybridMonitorSLSGroupWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to delete a Logstore group named `Logstore_test`. The response shows that the Logstore group is deleted.
          *
          * @param request DeleteHybridMonitorSLSGroupRequest
          * @return DeleteHybridMonitorSLSGroupResponse
         */
        public async Task<DeleteHybridMonitorSLSGroupResponse> DeleteHybridMonitorSLSGroupAsync(DeleteHybridMonitorSLSGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHybridMonitorSLSGroupWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to delete a metric import task whose ID is `36****`. The returned result indicates that the metric import task is deleted.
          *
          * @param request DeleteHybridMonitorTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteHybridMonitorTaskResponse
         */
        public DeleteHybridMonitorTaskResponse DeleteHybridMonitorTaskWithOptions(DeleteHybridMonitorTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHybridMonitorTask",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHybridMonitorTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to delete a metric import task whose ID is `36****`. The returned result indicates that the metric import task is deleted.
          *
          * @param request DeleteHybridMonitorTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteHybridMonitorTaskResponse
         */
        public async Task<DeleteHybridMonitorTaskResponse> DeleteHybridMonitorTaskWithOptionsAsync(DeleteHybridMonitorTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHybridMonitorTask",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHybridMonitorTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to delete a metric import task whose ID is `36****`. The returned result indicates that the metric import task is deleted.
          *
          * @param request DeleteHybridMonitorTaskRequest
          * @return DeleteHybridMonitorTaskResponse
         */
        public DeleteHybridMonitorTaskResponse DeleteHybridMonitorTask(DeleteHybridMonitorTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHybridMonitorTaskWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to delete a metric import task whose ID is `36****`. The returned result indicates that the metric import task is deleted.
          *
          * @param request DeleteHybridMonitorTaskRequest
          * @return DeleteHybridMonitorTaskResponse
         */
        public async Task<DeleteHybridMonitorTaskResponse> DeleteHybridMonitorTaskAsync(DeleteHybridMonitorTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHybridMonitorTaskWithOptionsAsync(request, runtime);
        }

        public DeleteLogMonitorResponse DeleteLogMonitorWithOptions(DeleteLogMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogId))
            {
                query["LogId"] = request.LogId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLogMonitor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLogMonitorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteLogMonitorResponse> DeleteLogMonitorWithOptionsAsync(DeleteLogMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogId))
            {
                query["LogId"] = request.LogId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLogMonitor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLogMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteLogMonitorResponse DeleteLogMonitor(DeleteLogMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLogMonitorWithOptions(request, runtime);
        }

        public async Task<DeleteLogMonitorResponse> DeleteLogMonitorAsync(DeleteLogMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLogMonitorWithOptionsAsync(request, runtime);
        }

        public DeleteMetricRuleBlackListResponse DeleteMetricRuleBlackListWithOptions(DeleteMetricRuleBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMetricRuleBlackList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMetricRuleBlackListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteMetricRuleBlackListResponse> DeleteMetricRuleBlackListWithOptionsAsync(DeleteMetricRuleBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMetricRuleBlackList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMetricRuleBlackListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteMetricRuleBlackListResponse DeleteMetricRuleBlackList(DeleteMetricRuleBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMetricRuleBlackListWithOptions(request, runtime);
        }

        public async Task<DeleteMetricRuleBlackListResponse> DeleteMetricRuleBlackListAsync(DeleteMetricRuleBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMetricRuleBlackListWithOptionsAsync(request, runtime);
        }

        public DeleteMetricRuleResourcesResponse DeleteMetricRuleResourcesWithOptions(DeleteMetricRuleResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMetricRuleResources",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMetricRuleResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteMetricRuleResourcesResponse> DeleteMetricRuleResourcesWithOptionsAsync(DeleteMetricRuleResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMetricRuleResources",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMetricRuleResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteMetricRuleResourcesResponse DeleteMetricRuleResources(DeleteMetricRuleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMetricRuleResourcesWithOptions(request, runtime);
        }

        public async Task<DeleteMetricRuleResourcesResponse> DeleteMetricRuleResourcesAsync(DeleteMetricRuleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMetricRuleResourcesWithOptionsAsync(request, runtime);
        }

        public DeleteMetricRuleTargetsResponse DeleteMetricRuleTargetsWithOptions(DeleteMetricRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetIds))
            {
                query["TargetIds"] = request.TargetIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMetricRuleTargets",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMetricRuleTargetsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteMetricRuleTargetsResponse> DeleteMetricRuleTargetsWithOptionsAsync(DeleteMetricRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetIds))
            {
                query["TargetIds"] = request.TargetIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMetricRuleTargets",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMetricRuleTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteMetricRuleTargetsResponse DeleteMetricRuleTargets(DeleteMetricRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMetricRuleTargetsWithOptions(request, runtime);
        }

        public async Task<DeleteMetricRuleTargetsResponse> DeleteMetricRuleTargetsAsync(DeleteMetricRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMetricRuleTargetsWithOptionsAsync(request, runtime);
        }

        public DeleteMetricRuleTemplateResponse DeleteMetricRuleTemplateWithOptions(DeleteMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteMetricRuleTemplate",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMetricRuleTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteMetricRuleTemplateResponse> DeleteMetricRuleTemplateWithOptionsAsync(DeleteMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteMetricRuleTemplate",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMetricRuleTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteMetricRuleTemplateResponse DeleteMetricRuleTemplate(DeleteMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMetricRuleTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteMetricRuleTemplateResponse> DeleteMetricRuleTemplateAsync(DeleteMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMetricRuleTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteMetricRulesResponse DeleteMetricRulesWithOptions(DeleteMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMetricRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMetricRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteMetricRulesResponse> DeleteMetricRulesWithOptionsAsync(DeleteMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMetricRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMetricRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteMetricRulesResponse DeleteMetricRules(DeleteMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMetricRulesWithOptions(request, runtime);
        }

        public async Task<DeleteMetricRulesResponse> DeleteMetricRulesAsync(DeleteMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMetricRulesWithOptionsAsync(request, runtime);
        }

        public DeleteMonitorGroupResponse DeleteMonitorGroupWithOptions(DeleteMonitorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMonitorGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMonitorGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteMonitorGroupResponse> DeleteMonitorGroupWithOptionsAsync(DeleteMonitorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMonitorGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMonitorGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteMonitorGroupResponse DeleteMonitorGroup(DeleteMonitorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMonitorGroupWithOptions(request, runtime);
        }

        public async Task<DeleteMonitorGroupResponse> DeleteMonitorGroupAsync(DeleteMonitorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMonitorGroupWithOptionsAsync(request, runtime);
        }

        public DeleteMonitorGroupDynamicRuleResponse DeleteMonitorGroupDynamicRuleWithOptions(DeleteMonitorGroupDynamicRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMonitorGroupDynamicRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMonitorGroupDynamicRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteMonitorGroupDynamicRuleResponse> DeleteMonitorGroupDynamicRuleWithOptionsAsync(DeleteMonitorGroupDynamicRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMonitorGroupDynamicRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMonitorGroupDynamicRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteMonitorGroupDynamicRuleResponse DeleteMonitorGroupDynamicRule(DeleteMonitorGroupDynamicRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMonitorGroupDynamicRuleWithOptions(request, runtime);
        }

        public async Task<DeleteMonitorGroupDynamicRuleResponse> DeleteMonitorGroupDynamicRuleAsync(DeleteMonitorGroupDynamicRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMonitorGroupDynamicRuleWithOptionsAsync(request, runtime);
        }

        public DeleteMonitorGroupInstancesResponse DeleteMonitorGroupInstancesWithOptions(DeleteMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMonitorGroupInstances",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMonitorGroupInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteMonitorGroupInstancesResponse> DeleteMonitorGroupInstancesWithOptionsAsync(DeleteMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMonitorGroupInstances",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMonitorGroupInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteMonitorGroupInstancesResponse DeleteMonitorGroupInstances(DeleteMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMonitorGroupInstancesWithOptions(request, runtime);
        }

        public async Task<DeleteMonitorGroupInstancesResponse> DeleteMonitorGroupInstancesAsync(DeleteMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMonitorGroupInstancesWithOptionsAsync(request, runtime);
        }

        public DeleteMonitorGroupNotifyPolicyResponse DeleteMonitorGroupNotifyPolicyWithOptions(DeleteMonitorGroupNotifyPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMonitorGroupNotifyPolicy",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMonitorGroupNotifyPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteMonitorGroupNotifyPolicyResponse> DeleteMonitorGroupNotifyPolicyWithOptionsAsync(DeleteMonitorGroupNotifyPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMonitorGroupNotifyPolicy",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMonitorGroupNotifyPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteMonitorGroupNotifyPolicyResponse DeleteMonitorGroupNotifyPolicy(DeleteMonitorGroupNotifyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMonitorGroupNotifyPolicyWithOptions(request, runtime);
        }

        public async Task<DeleteMonitorGroupNotifyPolicyResponse> DeleteMonitorGroupNotifyPolicyAsync(DeleteMonitorGroupNotifyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMonitorGroupNotifyPolicyWithOptionsAsync(request, runtime);
        }

        public DeleteMonitoringAgentProcessResponse DeleteMonitoringAgentProcessWithOptions(DeleteMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                query["ProcessId"] = request.ProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                query["ProcessName"] = request.ProcessName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMonitoringAgentProcess",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMonitoringAgentProcessResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteMonitoringAgentProcessResponse> DeleteMonitoringAgentProcessWithOptionsAsync(DeleteMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                query["ProcessId"] = request.ProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                query["ProcessName"] = request.ProcessName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMonitoringAgentProcess",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMonitoringAgentProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteMonitoringAgentProcessResponse DeleteMonitoringAgentProcess(DeleteMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMonitoringAgentProcessWithOptions(request, runtime);
        }

        public async Task<DeleteMonitoringAgentProcessResponse> DeleteMonitoringAgentProcessAsync(DeleteMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMonitoringAgentProcessWithOptionsAsync(request, runtime);
        }

        public DeleteSiteMonitorsResponse DeleteSiteMonitorsWithOptions(DeleteSiteMonitorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDeleteAlarms))
            {
                query["IsDeleteAlarms"] = request.IsDeleteAlarms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["TaskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSiteMonitors",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSiteMonitorsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteSiteMonitorsResponse> DeleteSiteMonitorsWithOptionsAsync(DeleteSiteMonitorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDeleteAlarms))
            {
                query["IsDeleteAlarms"] = request.IsDeleteAlarms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["TaskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSiteMonitors",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSiteMonitorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteSiteMonitorsResponse DeleteSiteMonitors(DeleteSiteMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSiteMonitorsWithOptions(request, runtime);
        }

        public async Task<DeleteSiteMonitorsResponse> DeleteSiteMonitorsAsync(DeleteSiteMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSiteMonitorsWithOptionsAsync(request, runtime);
        }

        public DescribeActiveMetricRuleListResponse DescribeActiveMetricRuleListWithOptions(DescribeActiveMetricRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeActiveMetricRuleList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeActiveMetricRuleListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeActiveMetricRuleListResponse> DescribeActiveMetricRuleListWithOptionsAsync(DescribeActiveMetricRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeActiveMetricRuleList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeActiveMetricRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeActiveMetricRuleListResponse DescribeActiveMetricRuleList(DescribeActiveMetricRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeActiveMetricRuleListWithOptions(request, runtime);
        }

        public async Task<DescribeActiveMetricRuleListResponse> DescribeActiveMetricRuleListAsync(DescribeActiveMetricRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeActiveMetricRuleListWithOptionsAsync(request, runtime);
        }

        /**
          * @deprecated : DescribeAlertHistoryList is deprecated, please use Cms::2019-01-01::DescribeAlertLogList instead.
          * This API operation is no longer maintained. We recommend that you call the [DescribeAlertLogList](~~201087~~) operation.
          *
          * @param request DescribeAlertHistoryListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeAlertHistoryListResponse
         */
        // Deprecated
        public DescribeAlertHistoryListResponse DescribeAlertHistoryListWithOptions(DescribeAlertHistoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ascending))
            {
                query["Ascending"] = request.Ascending;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
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
                Action = "DescribeAlertHistoryList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertHistoryListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * @deprecated : DescribeAlertHistoryList is deprecated, please use Cms::2019-01-01::DescribeAlertLogList instead.
          * This API operation is no longer maintained. We recommend that you call the [DescribeAlertLogList](~~201087~~) operation.
          *
          * @param request DescribeAlertHistoryListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeAlertHistoryListResponse
         */
        // Deprecated
        public async Task<DescribeAlertHistoryListResponse> DescribeAlertHistoryListWithOptionsAsync(DescribeAlertHistoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ascending))
            {
                query["Ascending"] = request.Ascending;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
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
                Action = "DescribeAlertHistoryList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertHistoryListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * @deprecated : DescribeAlertHistoryList is deprecated, please use Cms::2019-01-01::DescribeAlertLogList instead.
          * This API operation is no longer maintained. We recommend that you call the [DescribeAlertLogList](~~201087~~) operation.
          *
          * @param request DescribeAlertHistoryListRequest
          * @return DescribeAlertHistoryListResponse
         */
        // Deprecated
        public DescribeAlertHistoryListResponse DescribeAlertHistoryList(DescribeAlertHistoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertHistoryListWithOptions(request, runtime);
        }

        /**
          * @deprecated : DescribeAlertHistoryList is deprecated, please use Cms::2019-01-01::DescribeAlertLogList instead.
          * This API operation is no longer maintained. We recommend that you call the [DescribeAlertLogList](~~201087~~) operation.
          *
          * @param request DescribeAlertHistoryListRequest
          * @return DescribeAlertHistoryListResponse
         */
        // Deprecated
        public async Task<DescribeAlertHistoryListResponse> DescribeAlertHistoryListAsync(DescribeAlertHistoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertHistoryListWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example to show how to query the statistics of alert logs for Elastic Compute Service (ECS) based on the `product` dimension.
          *
          * @param request DescribeAlertLogCountRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeAlertLogCountResponse
         */
        public DescribeAlertLogCountResponse DescribeAlertLogCountWithOptions(DescribeAlertLogCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroup))
            {
                query["ContactGroup"] = request.ContactGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastMin))
            {
                query["LastMin"] = request.LastMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendStatus))
            {
                query["SendStatus"] = request.SendStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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
                Action = "DescribeAlertLogCount",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertLogCountResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query the statistics of alert logs for Elastic Compute Service (ECS) based on the `product` dimension.
          *
          * @param request DescribeAlertLogCountRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeAlertLogCountResponse
         */
        public async Task<DescribeAlertLogCountResponse> DescribeAlertLogCountWithOptionsAsync(DescribeAlertLogCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroup))
            {
                query["ContactGroup"] = request.ContactGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastMin))
            {
                query["LastMin"] = request.LastMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendStatus))
            {
                query["SendStatus"] = request.SendStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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
                Action = "DescribeAlertLogCount",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertLogCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query the statistics of alert logs for Elastic Compute Service (ECS) based on the `product` dimension.
          *
          * @param request DescribeAlertLogCountRequest
          * @return DescribeAlertLogCountResponse
         */
        public DescribeAlertLogCountResponse DescribeAlertLogCount(DescribeAlertLogCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertLogCountWithOptions(request, runtime);
        }

        /**
          * This topic provides an example to show how to query the statistics of alert logs for Elastic Compute Service (ECS) based on the `product` dimension.
          *
          * @param request DescribeAlertLogCountRequest
          * @return DescribeAlertLogCountResponse
         */
        public async Task<DescribeAlertLogCountResponse> DescribeAlertLogCountAsync(DescribeAlertLogCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertLogCountWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the number of alert logs for Elastic Compute Service (ECS) based on the `product` dimension.
          *
          * @param request DescribeAlertLogHistogramRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeAlertLogHistogramResponse
         */
        public DescribeAlertLogHistogramResponse DescribeAlertLogHistogramWithOptions(DescribeAlertLogHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroup))
            {
                query["ContactGroup"] = request.ContactGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastMin))
            {
                query["LastMin"] = request.LastMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendStatus))
            {
                query["SendStatus"] = request.SendStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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
                Action = "DescribeAlertLogHistogram",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertLogHistogramResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the number of alert logs for Elastic Compute Service (ECS) based on the `product` dimension.
          *
          * @param request DescribeAlertLogHistogramRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeAlertLogHistogramResponse
         */
        public async Task<DescribeAlertLogHistogramResponse> DescribeAlertLogHistogramWithOptionsAsync(DescribeAlertLogHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroup))
            {
                query["ContactGroup"] = request.ContactGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastMin))
            {
                query["LastMin"] = request.LastMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendStatus))
            {
                query["SendStatus"] = request.SendStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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
                Action = "DescribeAlertLogHistogram",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertLogHistogramResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the number of alert logs for Elastic Compute Service (ECS) based on the `product` dimension.
          *
          * @param request DescribeAlertLogHistogramRequest
          * @return DescribeAlertLogHistogramResponse
         */
        public DescribeAlertLogHistogramResponse DescribeAlertLogHistogram(DescribeAlertLogHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertLogHistogramWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the number of alert logs for Elastic Compute Service (ECS) based on the `product` dimension.
          *
          * @param request DescribeAlertLogHistogramRequest
          * @return DescribeAlertLogHistogramResponse
         */
        public async Task<DescribeAlertLogHistogramResponse> DescribeAlertLogHistogramAsync(DescribeAlertLogHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertLogHistogramWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example to show how to query the alert logs of Elastic Compute Service (ECS) based on the `product` dimension.
          *
          * @param request DescribeAlertLogListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeAlertLogListResponse
         */
        public DescribeAlertLogListResponse DescribeAlertLogListWithOptions(DescribeAlertLogListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroup))
            {
                query["ContactGroup"] = request.ContactGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastMin))
            {
                query["LastMin"] = request.LastMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendStatus))
            {
                query["SendStatus"] = request.SendStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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
                Action = "DescribeAlertLogList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertLogListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query the alert logs of Elastic Compute Service (ECS) based on the `product` dimension.
          *
          * @param request DescribeAlertLogListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeAlertLogListResponse
         */
        public async Task<DescribeAlertLogListResponse> DescribeAlertLogListWithOptionsAsync(DescribeAlertLogListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroup))
            {
                query["ContactGroup"] = request.ContactGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastMin))
            {
                query["LastMin"] = request.LastMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendStatus))
            {
                query["SendStatus"] = request.SendStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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
                Action = "DescribeAlertLogList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertLogListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query the alert logs of Elastic Compute Service (ECS) based on the `product` dimension.
          *
          * @param request DescribeAlertLogListRequest
          * @return DescribeAlertLogListResponse
         */
        public DescribeAlertLogListResponse DescribeAlertLogList(DescribeAlertLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertLogListWithOptions(request, runtime);
        }

        /**
          * This topic provides an example to show how to query the alert logs of Elastic Compute Service (ECS) based on the `product` dimension.
          *
          * @param request DescribeAlertLogListRequest
          * @return DescribeAlertLogListResponse
         */
        public async Task<DescribeAlertLogListResponse> DescribeAlertLogListAsync(DescribeAlertLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertLogListWithOptionsAsync(request, runtime);
        }

        public DescribeAlertingMetricRuleResourcesResponse DescribeAlertingMetricRuleResourcesWithOptions(DescribeAlertingMetricRuleResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertingMetricRuleResources",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertingMetricRuleResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAlertingMetricRuleResourcesResponse> DescribeAlertingMetricRuleResourcesWithOptionsAsync(DescribeAlertingMetricRuleResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertingMetricRuleResources",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertingMetricRuleResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAlertingMetricRuleResourcesResponse DescribeAlertingMetricRuleResources(DescribeAlertingMetricRuleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertingMetricRuleResourcesWithOptions(request, runtime);
        }

        public async Task<DescribeAlertingMetricRuleResourcesResponse> DescribeAlertingMetricRuleResourcesAsync(DescribeAlertingMetricRuleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertingMetricRuleResourcesWithOptionsAsync(request, runtime);
        }

        public DescribeContactGroupListResponse DescribeContactGroupListWithOptions(DescribeContactGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeContactGroupList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContactGroupListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeContactGroupListResponse> DescribeContactGroupListWithOptionsAsync(DescribeContactGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeContactGroupList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContactGroupListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeContactGroupListResponse DescribeContactGroupList(DescribeContactGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContactGroupListWithOptions(request, runtime);
        }

        public async Task<DescribeContactGroupListResponse> DescribeContactGroupListAsync(DescribeContactGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContactGroupListWithOptionsAsync(request, runtime);
        }

        public DescribeContactListResponse DescribeContactListWithOptions(DescribeContactListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChanelType))
            {
                query["ChanelType"] = request.ChanelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChanelValue))
            {
                query["ChanelValue"] = request.ChanelValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
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
                Action = "DescribeContactList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContactListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeContactListResponse> DescribeContactListWithOptionsAsync(DescribeContactListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChanelType))
            {
                query["ChanelType"] = request.ChanelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChanelValue))
            {
                query["ChanelValue"] = request.ChanelValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
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
                Action = "DescribeContactList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContactListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeContactListResponse DescribeContactList(DescribeContactListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContactListWithOptions(request, runtime);
        }

        public async Task<DescribeContactListResponse> DescribeContactListAsync(DescribeContactListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContactListWithOptionsAsync(request, runtime);
        }

        public DescribeContactListByContactGroupResponse DescribeContactListByContactGroupWithOptions(DescribeContactListByContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupName))
            {
                query["ContactGroupName"] = request.ContactGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeContactListByContactGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContactListByContactGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeContactListByContactGroupResponse> DescribeContactListByContactGroupWithOptionsAsync(DescribeContactListByContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupName))
            {
                query["ContactGroupName"] = request.ContactGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeContactListByContactGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContactListByContactGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeContactListByContactGroupResponse DescribeContactListByContactGroup(DescribeContactListByContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContactListByContactGroupWithOptions(request, runtime);
        }

        public async Task<DescribeContactListByContactGroupResponse> DescribeContactListByContactGroupAsync(DescribeContactListByContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContactListByContactGroupWithOptionsAsync(request, runtime);
        }

        public DescribeCustomEventAttributeResponse DescribeCustomEventAttributeWithOptions(DescribeCustomEventAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeywords))
            {
                query["SearchKeywords"] = request.SearchKeywords;
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
                Action = "DescribeCustomEventAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomEventAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCustomEventAttributeResponse> DescribeCustomEventAttributeWithOptionsAsync(DescribeCustomEventAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeywords))
            {
                query["SearchKeywords"] = request.SearchKeywords;
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
                Action = "DescribeCustomEventAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomEventAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCustomEventAttributeResponse DescribeCustomEventAttribute(DescribeCustomEventAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomEventAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeCustomEventAttributeResponse> DescribeCustomEventAttributeAsync(DescribeCustomEventAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomEventAttributeWithOptionsAsync(request, runtime);
        }

        /**
          * >  This operation counts the number of times that a custom event occurred for each service.
          *
          * @param request DescribeCustomEventCountRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCustomEventCountResponse
         */
        public DescribeCustomEventCountResponse DescribeCustomEventCountWithOptions(DescribeCustomEventCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeywords))
            {
                query["SearchKeywords"] = request.SearchKeywords;
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
                Action = "DescribeCustomEventCount",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomEventCountResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  This operation counts the number of times that a custom event occurred for each service.
          *
          * @param request DescribeCustomEventCountRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCustomEventCountResponse
         */
        public async Task<DescribeCustomEventCountResponse> DescribeCustomEventCountWithOptionsAsync(DescribeCustomEventCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeywords))
            {
                query["SearchKeywords"] = request.SearchKeywords;
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
                Action = "DescribeCustomEventCount",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomEventCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  This operation counts the number of times that a custom event occurred for each service.
          *
          * @param request DescribeCustomEventCountRequest
          * @return DescribeCustomEventCountResponse
         */
        public DescribeCustomEventCountResponse DescribeCustomEventCount(DescribeCustomEventCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomEventCountWithOptions(request, runtime);
        }

        /**
          * >  This operation counts the number of times that a custom event occurred for each service.
          *
          * @param request DescribeCustomEventCountRequest
          * @return DescribeCustomEventCountResponse
         */
        public async Task<DescribeCustomEventCountResponse> DescribeCustomEventCountAsync(DescribeCustomEventCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomEventCountWithOptionsAsync(request, runtime);
        }

        public DescribeCustomEventHistogramResponse DescribeCustomEventHistogramWithOptions(DescribeCustomEventHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeywords))
            {
                query["SearchKeywords"] = request.SearchKeywords;
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
                Action = "DescribeCustomEventHistogram",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomEventHistogramResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCustomEventHistogramResponse> DescribeCustomEventHistogramWithOptionsAsync(DescribeCustomEventHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeywords))
            {
                query["SearchKeywords"] = request.SearchKeywords;
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
                Action = "DescribeCustomEventHistogram",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomEventHistogramResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCustomEventHistogramResponse DescribeCustomEventHistogram(DescribeCustomEventHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomEventHistogramWithOptions(request, runtime);
        }

        public async Task<DescribeCustomEventHistogramResponse> DescribeCustomEventHistogramAsync(DescribeCustomEventHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomEventHistogramWithOptionsAsync(request, runtime);
        }

        /**
          * >  You can call the DescribeMetricList operation to query the metrics of a cloud service. For more information, see [DescribeMetricList](~~51936~~).
          *
          * @param request DescribeCustomMetricListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCustomMetricListResponse
         */
        public DescribeCustomMetricListResponse DescribeCustomMetricListWithOptions(DescribeCustomMetricListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                query["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                query["Md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
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
                Action = "DescribeCustomMetricList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomMetricListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  You can call the DescribeMetricList operation to query the metrics of a cloud service. For more information, see [DescribeMetricList](~~51936~~).
          *
          * @param request DescribeCustomMetricListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCustomMetricListResponse
         */
        public async Task<DescribeCustomMetricListResponse> DescribeCustomMetricListWithOptionsAsync(DescribeCustomMetricListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                query["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                query["Md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
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
                Action = "DescribeCustomMetricList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomMetricListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  You can call the DescribeMetricList operation to query the metrics of a cloud service. For more information, see [DescribeMetricList](~~51936~~).
          *
          * @param request DescribeCustomMetricListRequest
          * @return DescribeCustomMetricListResponse
         */
        public DescribeCustomMetricListResponse DescribeCustomMetricList(DescribeCustomMetricListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomMetricListWithOptions(request, runtime);
        }

        /**
          * >  You can call the DescribeMetricList operation to query the metrics of a cloud service. For more information, see [DescribeMetricList](~~51936~~).
          *
          * @param request DescribeCustomMetricListRequest
          * @return DescribeCustomMetricListResponse
         */
        public async Task<DescribeCustomMetricListResponse> DescribeCustomMetricListAsync(DescribeCustomMetricListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomMetricListWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example to show how to query tag rules that are related to `tagkey1`. The sample responses indicate that two tag rules are found. The rule IDs are `1536df65-a719-429d-8813-73cc40d7****` and `56e8cebb-b3d7-4a91-9880-78a8c84f****`.
          *
          * @param request DescribeDynamicTagRuleListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDynamicTagRuleListResponse
         */
        public DescribeDynamicTagRuleListResponse DescribeDynamicTagRuleListWithOptions(DescribeDynamicTagRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicTagRuleId))
            {
                query["DynamicTagRuleId"] = request.DynamicTagRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRegionId))
            {
                query["TagRegionId"] = request.TagRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValue))
            {
                query["TagValue"] = request.TagValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDynamicTagRuleList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDynamicTagRuleListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query tag rules that are related to `tagkey1`. The sample responses indicate that two tag rules are found. The rule IDs are `1536df65-a719-429d-8813-73cc40d7****` and `56e8cebb-b3d7-4a91-9880-78a8c84f****`.
          *
          * @param request DescribeDynamicTagRuleListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeDynamicTagRuleListResponse
         */
        public async Task<DescribeDynamicTagRuleListResponse> DescribeDynamicTagRuleListWithOptionsAsync(DescribeDynamicTagRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicTagRuleId))
            {
                query["DynamicTagRuleId"] = request.DynamicTagRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRegionId))
            {
                query["TagRegionId"] = request.TagRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValue))
            {
                query["TagValue"] = request.TagValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDynamicTagRuleList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDynamicTagRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query tag rules that are related to `tagkey1`. The sample responses indicate that two tag rules are found. The rule IDs are `1536df65-a719-429d-8813-73cc40d7****` and `56e8cebb-b3d7-4a91-9880-78a8c84f****`.
          *
          * @param request DescribeDynamicTagRuleListRequest
          * @return DescribeDynamicTagRuleListResponse
         */
        public DescribeDynamicTagRuleListResponse DescribeDynamicTagRuleList(DescribeDynamicTagRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDynamicTagRuleListWithOptions(request, runtime);
        }

        /**
          * This topic provides an example to show how to query tag rules that are related to `tagkey1`. The sample responses indicate that two tag rules are found. The rule IDs are `1536df65-a719-429d-8813-73cc40d7****` and `56e8cebb-b3d7-4a91-9880-78a8c84f****`.
          *
          * @param request DescribeDynamicTagRuleListRequest
          * @return DescribeDynamicTagRuleListResponse
         */
        public async Task<DescribeDynamicTagRuleListResponse> DescribeDynamicTagRuleListAsync(DescribeDynamicTagRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDynamicTagRuleListWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example to show how to query the details of an event-triggered alert rule named `testRule`.
          *
          * @param request DescribeEventRuleAttributeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeEventRuleAttributeResponse
         */
        public DescribeEventRuleAttributeResponse DescribeEventRuleAttributeWithOptions(DescribeEventRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SilenceTime))
            {
                query["SilenceTime"] = request.SilenceTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEventRuleAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventRuleAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query the details of an event-triggered alert rule named `testRule`.
          *
          * @param request DescribeEventRuleAttributeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeEventRuleAttributeResponse
         */
        public async Task<DescribeEventRuleAttributeResponse> DescribeEventRuleAttributeWithOptionsAsync(DescribeEventRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SilenceTime))
            {
                query["SilenceTime"] = request.SilenceTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEventRuleAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventRuleAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query the details of an event-triggered alert rule named `testRule`.
          *
          * @param request DescribeEventRuleAttributeRequest
          * @return DescribeEventRuleAttributeResponse
         */
        public DescribeEventRuleAttributeResponse DescribeEventRuleAttribute(DescribeEventRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventRuleAttributeWithOptions(request, runtime);
        }

        /**
          * This topic provides an example to show how to query the details of an event-triggered alert rule named `testRule`.
          *
          * @param request DescribeEventRuleAttributeRequest
          * @return DescribeEventRuleAttributeResponse
         */
        public async Task<DescribeEventRuleAttributeResponse> DescribeEventRuleAttributeAsync(DescribeEventRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventRuleAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeEventRuleListResponse DescribeEventRuleListWithOptions(DescribeEventRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnable))
            {
                query["IsEnable"] = request.IsEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePrefix))
            {
                query["NamePrefix"] = request.NamePrefix;
            }
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
                Action = "DescribeEventRuleList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventRuleListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEventRuleListResponse> DescribeEventRuleListWithOptionsAsync(DescribeEventRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnable))
            {
                query["IsEnable"] = request.IsEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePrefix))
            {
                query["NamePrefix"] = request.NamePrefix;
            }
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
                Action = "DescribeEventRuleList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEventRuleListResponse DescribeEventRuleList(DescribeEventRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventRuleListWithOptions(request, runtime);
        }

        public async Task<DescribeEventRuleListResponse> DescribeEventRuleListAsync(DescribeEventRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventRuleListWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example to show how to query the details of an event-triggered alert rule named `testRule`.
          *
          * @param request DescribeEventRuleTargetListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeEventRuleTargetListResponse
         */
        public DescribeEventRuleTargetListResponse DescribeEventRuleTargetListWithOptions(DescribeEventRuleTargetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEventRuleTargetList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventRuleTargetListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query the details of an event-triggered alert rule named `testRule`.
          *
          * @param request DescribeEventRuleTargetListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeEventRuleTargetListResponse
         */
        public async Task<DescribeEventRuleTargetListResponse> DescribeEventRuleTargetListWithOptionsAsync(DescribeEventRuleTargetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEventRuleTargetList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventRuleTargetListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query the details of an event-triggered alert rule named `testRule`.
          *
          * @param request DescribeEventRuleTargetListRequest
          * @return DescribeEventRuleTargetListResponse
         */
        public DescribeEventRuleTargetListResponse DescribeEventRuleTargetList(DescribeEventRuleTargetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventRuleTargetListWithOptions(request, runtime);
        }

        /**
          * This topic provides an example to show how to query the details of an event-triggered alert rule named `testRule`.
          *
          * @param request DescribeEventRuleTargetListRequest
          * @return DescribeEventRuleTargetListResponse
         */
        public async Task<DescribeEventRuleTargetListResponse> DescribeEventRuleTargetListAsync(DescribeEventRuleTargetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventRuleTargetListWithOptionsAsync(request, runtime);
        }

        public DescribeExporterOutputListResponse DescribeExporterOutputListWithOptions(DescribeExporterOutputListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeExporterOutputList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExporterOutputListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeExporterOutputListResponse> DescribeExporterOutputListWithOptionsAsync(DescribeExporterOutputListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeExporterOutputList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExporterOutputListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeExporterOutputListResponse DescribeExporterOutputList(DescribeExporterOutputListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExporterOutputListWithOptions(request, runtime);
        }

        public async Task<DescribeExporterOutputListResponse> DescribeExporterOutputListAsync(DescribeExporterOutputListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExporterOutputListWithOptionsAsync(request, runtime);
        }

        public DescribeExporterRuleListResponse DescribeExporterRuleListWithOptions(DescribeExporterRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeExporterRuleList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExporterRuleListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeExporterRuleListResponse> DescribeExporterRuleListWithOptionsAsync(DescribeExporterRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeExporterRuleList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExporterRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeExporterRuleListResponse DescribeExporterRuleList(DescribeExporterRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExporterRuleListWithOptions(request, runtime);
        }

        public async Task<DescribeExporterRuleListResponse> DescribeExporterRuleListAsync(DescribeExporterRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExporterRuleListWithOptionsAsync(request, runtime);
        }

        /**
          * You can create a process monitoring task to monitor all or the specified Elastic Compute Service (ECS) instances in an application group and configure alert rules for the process monitoring task.
          *
          * @param request DescribeGroupMonitoringAgentProcessRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeGroupMonitoringAgentProcessResponse
         */
        public DescribeGroupMonitoringAgentProcessResponse DescribeGroupMonitoringAgentProcessWithOptions(DescribeGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                query["ProcessName"] = request.ProcessName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGroupMonitoringAgentProcess",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGroupMonitoringAgentProcessResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can create a process monitoring task to monitor all or the specified Elastic Compute Service (ECS) instances in an application group and configure alert rules for the process monitoring task.
          *
          * @param request DescribeGroupMonitoringAgentProcessRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeGroupMonitoringAgentProcessResponse
         */
        public async Task<DescribeGroupMonitoringAgentProcessResponse> DescribeGroupMonitoringAgentProcessWithOptionsAsync(DescribeGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                query["ProcessName"] = request.ProcessName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGroupMonitoringAgentProcess",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGroupMonitoringAgentProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can create a process monitoring task to monitor all or the specified Elastic Compute Service (ECS) instances in an application group and configure alert rules for the process monitoring task.
          *
          * @param request DescribeGroupMonitoringAgentProcessRequest
          * @return DescribeGroupMonitoringAgentProcessResponse
         */
        public DescribeGroupMonitoringAgentProcessResponse DescribeGroupMonitoringAgentProcess(DescribeGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupMonitoringAgentProcessWithOptions(request, runtime);
        }

        /**
          * You can create a process monitoring task to monitor all or the specified Elastic Compute Service (ECS) instances in an application group and configure alert rules for the process monitoring task.
          *
          * @param request DescribeGroupMonitoringAgentProcessRequest
          * @return DescribeGroupMonitoringAgentProcessResponse
         */
        public async Task<DescribeGroupMonitoringAgentProcessResponse> DescribeGroupMonitoringAgentProcessAsync(DescribeGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupMonitoringAgentProcessWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example to show how to query all the availability monitoring tasks of your Alibaba Cloud account. The sample responses indicate that the account has one availability monitoring task named `ecs_instance`.
          *
          * @param request DescribeHostAvailabilityListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHostAvailabilityListResponse
         */
        public DescribeHostAvailabilityListResponse DescribeHostAvailabilityListWithOptions(DescribeHostAvailabilityListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHostAvailabilityList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHostAvailabilityListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query all the availability monitoring tasks of your Alibaba Cloud account. The sample responses indicate that the account has one availability monitoring task named `ecs_instance`.
          *
          * @param request DescribeHostAvailabilityListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHostAvailabilityListResponse
         */
        public async Task<DescribeHostAvailabilityListResponse> DescribeHostAvailabilityListWithOptionsAsync(DescribeHostAvailabilityListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHostAvailabilityList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHostAvailabilityListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query all the availability monitoring tasks of your Alibaba Cloud account. The sample responses indicate that the account has one availability monitoring task named `ecs_instance`.
          *
          * @param request DescribeHostAvailabilityListRequest
          * @return DescribeHostAvailabilityListResponse
         */
        public DescribeHostAvailabilityListResponse DescribeHostAvailabilityList(DescribeHostAvailabilityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHostAvailabilityListWithOptions(request, runtime);
        }

        /**
          * This topic provides an example to show how to query all the availability monitoring tasks of your Alibaba Cloud account. The sample responses indicate that the account has one availability monitoring task named `ecs_instance`.
          *
          * @param request DescribeHostAvailabilityListRequest
          * @return DescribeHostAvailabilityListResponse
         */
        public async Task<DescribeHostAvailabilityListResponse> DescribeHostAvailabilityListAsync(DescribeHostAvailabilityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHostAvailabilityListWithOptionsAsync(request, runtime);
        }

        /**
          * ## Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          *
          * @param request DescribeHybridMonitorDataListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHybridMonitorDataListResponse
         */
        public DescribeHybridMonitorDataListResponse DescribeHybridMonitorDataListWithOptions(DescribeHybridMonitorDataListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromSQL))
            {
                query["PromSQL"] = request.PromSQL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHybridMonitorDataList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHybridMonitorDataListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          *
          * @param request DescribeHybridMonitorDataListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHybridMonitorDataListResponse
         */
        public async Task<DescribeHybridMonitorDataListResponse> DescribeHybridMonitorDataListWithOptionsAsync(DescribeHybridMonitorDataListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromSQL))
            {
                query["PromSQL"] = request.PromSQL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHybridMonitorDataList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHybridMonitorDataListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          *
          * @param request DescribeHybridMonitorDataListRequest
          * @return DescribeHybridMonitorDataListResponse
         */
        public DescribeHybridMonitorDataListResponse DescribeHybridMonitorDataList(DescribeHybridMonitorDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHybridMonitorDataListWithOptions(request, runtime);
        }

        /**
          * ## Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          *
          * @param request DescribeHybridMonitorDataListRequest
          * @return DescribeHybridMonitorDataListResponse
         */
        public async Task<DescribeHybridMonitorDataListResponse> DescribeHybridMonitorDataListAsync(DescribeHybridMonitorDataListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHybridMonitorDataListWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, all namespaces within the current account are queried. The response shows that the current account has only one namespace named `aliyun-test`.
          *
          * @param request DescribeHybridMonitorNamespaceListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHybridMonitorNamespaceListResponse
         */
        public DescribeHybridMonitorNamespaceListResponse DescribeHybridMonitorNamespaceListWithOptions(DescribeHybridMonitorNamespaceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowTaskStatistic))
            {
                query["ShowTaskStatistic"] = request.ShowTaskStatistic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHybridMonitorNamespaceList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHybridMonitorNamespaceListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * In this example, all namespaces within the current account are queried. The response shows that the current account has only one namespace named `aliyun-test`.
          *
          * @param request DescribeHybridMonitorNamespaceListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHybridMonitorNamespaceListResponse
         */
        public async Task<DescribeHybridMonitorNamespaceListResponse> DescribeHybridMonitorNamespaceListWithOptionsAsync(DescribeHybridMonitorNamespaceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowTaskStatistic))
            {
                query["ShowTaskStatistic"] = request.ShowTaskStatistic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHybridMonitorNamespaceList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHybridMonitorNamespaceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * In this example, all namespaces within the current account are queried. The response shows that the current account has only one namespace named `aliyun-test`.
          *
          * @param request DescribeHybridMonitorNamespaceListRequest
          * @return DescribeHybridMonitorNamespaceListResponse
         */
        public DescribeHybridMonitorNamespaceListResponse DescribeHybridMonitorNamespaceList(DescribeHybridMonitorNamespaceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHybridMonitorNamespaceListWithOptions(request, runtime);
        }

        /**
          * In this example, all namespaces within the current account are queried. The response shows that the current account has only one namespace named `aliyun-test`.
          *
          * @param request DescribeHybridMonitorNamespaceListRequest
          * @return DescribeHybridMonitorNamespaceListResponse
         */
        public async Task<DescribeHybridMonitorNamespaceListResponse> DescribeHybridMonitorNamespaceListAsync(DescribeHybridMonitorNamespaceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHybridMonitorNamespaceListWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, all Logstore groups within the current account are queried. The response shows that the current account has two Logstore groups: `Logstore_test` and `Logstore_aliyun`.
          *
          * @param request DescribeHybridMonitorSLSGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHybridMonitorSLSGroupResponse
         */
        public DescribeHybridMonitorSLSGroupResponse DescribeHybridMonitorSLSGroupWithOptions(DescribeHybridMonitorSLSGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupName))
            {
                query["SLSGroupName"] = request.SLSGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHybridMonitorSLSGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHybridMonitorSLSGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
          * In this example, all Logstore groups within the current account are queried. The response shows that the current account has two Logstore groups: `Logstore_test` and `Logstore_aliyun`.
          *
          * @param request DescribeHybridMonitorSLSGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHybridMonitorSLSGroupResponse
         */
        public async Task<DescribeHybridMonitorSLSGroupResponse> DescribeHybridMonitorSLSGroupWithOptionsAsync(DescribeHybridMonitorSLSGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupName))
            {
                query["SLSGroupName"] = request.SLSGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHybridMonitorSLSGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHybridMonitorSLSGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * In this example, all Logstore groups within the current account are queried. The response shows that the current account has two Logstore groups: `Logstore_test` and `Logstore_aliyun`.
          *
          * @param request DescribeHybridMonitorSLSGroupRequest
          * @return DescribeHybridMonitorSLSGroupResponse
         */
        public DescribeHybridMonitorSLSGroupResponse DescribeHybridMonitorSLSGroup(DescribeHybridMonitorSLSGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHybridMonitorSLSGroupWithOptions(request, runtime);
        }

        /**
          * In this example, all Logstore groups within the current account are queried. The response shows that the current account has two Logstore groups: `Logstore_test` and `Logstore_aliyun`.
          *
          * @param request DescribeHybridMonitorSLSGroupRequest
          * @return DescribeHybridMonitorSLSGroupResponse
         */
        public async Task<DescribeHybridMonitorSLSGroupResponse> DescribeHybridMonitorSLSGroupAsync(DescribeHybridMonitorSLSGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHybridMonitorSLSGroupWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query all metric import tasks that belong to the current Alibaba Cloud account. The returned result indicates that the current account has only one metric import task. The metric import task is named `aliyun_task`.
          *
          * @param request DescribeHybridMonitorTaskListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHybridMonitorTaskListResponse
         */
        public DescribeHybridMonitorTaskListResponse DescribeHybridMonitorTaskListWithOptions(DescribeHybridMonitorTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeAliyunTask))
            {
                query["IncludeAliyunTask"] = request.IncludeAliyunTask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHybridMonitorTaskList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHybridMonitorTaskListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query all metric import tasks that belong to the current Alibaba Cloud account. The returned result indicates that the current account has only one metric import task. The metric import task is named `aliyun_task`.
          *
          * @param request DescribeHybridMonitorTaskListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHybridMonitorTaskListResponse
         */
        public async Task<DescribeHybridMonitorTaskListResponse> DescribeHybridMonitorTaskListWithOptionsAsync(DescribeHybridMonitorTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeAliyunTask))
            {
                query["IncludeAliyunTask"] = request.IncludeAliyunTask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHybridMonitorTaskList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHybridMonitorTaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query all metric import tasks that belong to the current Alibaba Cloud account. The returned result indicates that the current account has only one metric import task. The metric import task is named `aliyun_task`.
          *
          * @param request DescribeHybridMonitorTaskListRequest
          * @return DescribeHybridMonitorTaskListResponse
         */
        public DescribeHybridMonitorTaskListResponse DescribeHybridMonitorTaskList(DescribeHybridMonitorTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHybridMonitorTaskListWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query all metric import tasks that belong to the current Alibaba Cloud account. The returned result indicates that the current account has only one metric import task. The metric import task is named `aliyun_task`.
          *
          * @param request DescribeHybridMonitorTaskListRequest
          * @return DescribeHybridMonitorTaskListResponse
         */
        public async Task<DescribeHybridMonitorTaskListResponse> DescribeHybridMonitorTaskListAsync(DescribeHybridMonitorTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHybridMonitorTaskListWithOptionsAsync(request, runtime);
        }

        public DescribeLogMonitorAttributeResponse DescribeLogMonitorAttributeWithOptions(DescribeLogMonitorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogMonitorAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogMonitorAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeLogMonitorAttributeResponse> DescribeLogMonitorAttributeWithOptionsAsync(DescribeLogMonitorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogMonitorAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogMonitorAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeLogMonitorAttributeResponse DescribeLogMonitorAttribute(DescribeLogMonitorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogMonitorAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeLogMonitorAttributeResponse> DescribeLogMonitorAttributeAsync(DescribeLogMonitorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogMonitorAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeLogMonitorListResponse DescribeLogMonitorListWithOptions(DescribeLogMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                query["SearchValue"] = request.SearchValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogMonitorList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogMonitorListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeLogMonitorListResponse> DescribeLogMonitorListWithOptionsAsync(DescribeLogMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                query["SearchValue"] = request.SearchValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogMonitorList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogMonitorListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeLogMonitorListResponse DescribeLogMonitorList(DescribeLogMonitorListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogMonitorListWithOptions(request, runtime);
        }

        public async Task<DescribeLogMonitorListResponse> DescribeLogMonitorListAsync(DescribeLogMonitorListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogMonitorListWithOptionsAsync(request, runtime);
        }

        /**
          * ## Limits
          * Each API operation can be called up to 10 times per second. An Alibaba Cloud account and the RAM users within the account share the quota. 
          * >  Different from [DescribeMetricList](~~51936~~), the DescribeMetricData operation provides statistical features. You can set the `Dimension` parameter to {"instanceId": "i-abcdefgh12****"} to aggregate all data of your Alibaba Cloud account. This topic provides an example to show how to query the monitoring data of the `cpu_idle` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`.
          *
          * @param request DescribeMetricDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricDataResponse
         */
        public DescribeMetricDataResponse DescribeMetricDataWithOptions(DescribeMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Express))
            {
                query["Express"] = request.Express;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "DescribeMetricData",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Limits
          * Each API operation can be called up to 10 times per second. An Alibaba Cloud account and the RAM users within the account share the quota. 
          * >  Different from [DescribeMetricList](~~51936~~), the DescribeMetricData operation provides statistical features. You can set the `Dimension` parameter to {"instanceId": "i-abcdefgh12****"} to aggregate all data of your Alibaba Cloud account. This topic provides an example to show how to query the monitoring data of the `cpu_idle` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`.
          *
          * @param request DescribeMetricDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricDataResponse
         */
        public async Task<DescribeMetricDataResponse> DescribeMetricDataWithOptionsAsync(DescribeMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Express))
            {
                query["Express"] = request.Express;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "DescribeMetricData",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Limits
          * Each API operation can be called up to 10 times per second. An Alibaba Cloud account and the RAM users within the account share the quota. 
          * >  Different from [DescribeMetricList](~~51936~~), the DescribeMetricData operation provides statistical features. You can set the `Dimension` parameter to {"instanceId": "i-abcdefgh12****"} to aggregate all data of your Alibaba Cloud account. This topic provides an example to show how to query the monitoring data of the `cpu_idle` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`.
          *
          * @param request DescribeMetricDataRequest
          * @return DescribeMetricDataResponse
         */
        public DescribeMetricDataResponse DescribeMetricData(DescribeMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricDataWithOptions(request, runtime);
        }

        /**
          * ## Limits
          * Each API operation can be called up to 10 times per second. An Alibaba Cloud account and the RAM users within the account share the quota. 
          * >  Different from [DescribeMetricList](~~51936~~), the DescribeMetricData operation provides statistical features. You can set the `Dimension` parameter to {"instanceId": "i-abcdefgh12****"} to aggregate all data of your Alibaba Cloud account. This topic provides an example to show how to query the monitoring data of the `cpu_idle` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`.
          *
          * @param request DescribeMetricDataRequest
          * @return DescribeMetricDataResponse
         */
        public async Task<DescribeMetricDataResponse> DescribeMetricDataAsync(DescribeMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricDataWithOptionsAsync(request, runtime);
        }

        /**
          * ### [](#)Limits
          * Each API operation can be called up to 50 times per second. An Alibaba Cloud account and the RAM users within the account share the quota.
          * ### [](#)Precautions
          * The storage duration of the monitoring data of each cloud service is related to the `Period` parameter (statistical period). A larger value of the `Period` parameter indicates that the monitoring data is distributed in a larger time range and the storage duration of the monitoring data is longer. The following list describes the specific relationships:
          * *   If the value of the `Period` parameter is less than 60 seconds, the storage duration is seven days.
          * *   If the value of the `Period` parameter is 60 seconds, the storage duration is 31 days.
          * *   If the value of the `Period` parameter is 300 seconds, the storage duration is 91 days.
          * ### [](#)Description
          * This topic provides an example on how to query the latest monitoring data of the `CPUUtilization` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The returned result indicates that the monitoring data for the instance `i-abcdefgh12****` of the account `123456789876****` is queried at an interval of 60 seconds. The maximum, minimum, and average values of the metric are 100, 93.1, and 99.52.
          *
          * @param request DescribeMetricLastRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricLastResponse
         */
        public DescribeMetricLastResponse DescribeMetricLastWithOptions(DescribeMetricLastRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Express))
            {
                query["Express"] = request.Express;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "DescribeMetricLast",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricLastResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### [](#)Limits
          * Each API operation can be called up to 50 times per second. An Alibaba Cloud account and the RAM users within the account share the quota.
          * ### [](#)Precautions
          * The storage duration of the monitoring data of each cloud service is related to the `Period` parameter (statistical period). A larger value of the `Period` parameter indicates that the monitoring data is distributed in a larger time range and the storage duration of the monitoring data is longer. The following list describes the specific relationships:
          * *   If the value of the `Period` parameter is less than 60 seconds, the storage duration is seven days.
          * *   If the value of the `Period` parameter is 60 seconds, the storage duration is 31 days.
          * *   If the value of the `Period` parameter is 300 seconds, the storage duration is 91 days.
          * ### [](#)Description
          * This topic provides an example on how to query the latest monitoring data of the `CPUUtilization` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The returned result indicates that the monitoring data for the instance `i-abcdefgh12****` of the account `123456789876****` is queried at an interval of 60 seconds. The maximum, minimum, and average values of the metric are 100, 93.1, and 99.52.
          *
          * @param request DescribeMetricLastRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricLastResponse
         */
        public async Task<DescribeMetricLastResponse> DescribeMetricLastWithOptionsAsync(DescribeMetricLastRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Express))
            {
                query["Express"] = request.Express;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "DescribeMetricLast",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricLastResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### [](#)Limits
          * Each API operation can be called up to 50 times per second. An Alibaba Cloud account and the RAM users within the account share the quota.
          * ### [](#)Precautions
          * The storage duration of the monitoring data of each cloud service is related to the `Period` parameter (statistical period). A larger value of the `Period` parameter indicates that the monitoring data is distributed in a larger time range and the storage duration of the monitoring data is longer. The following list describes the specific relationships:
          * *   If the value of the `Period` parameter is less than 60 seconds, the storage duration is seven days.
          * *   If the value of the `Period` parameter is 60 seconds, the storage duration is 31 days.
          * *   If the value of the `Period` parameter is 300 seconds, the storage duration is 91 days.
          * ### [](#)Description
          * This topic provides an example on how to query the latest monitoring data of the `CPUUtilization` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The returned result indicates that the monitoring data for the instance `i-abcdefgh12****` of the account `123456789876****` is queried at an interval of 60 seconds. The maximum, minimum, and average values of the metric are 100, 93.1, and 99.52.
          *
          * @param request DescribeMetricLastRequest
          * @return DescribeMetricLastResponse
         */
        public DescribeMetricLastResponse DescribeMetricLast(DescribeMetricLastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricLastWithOptions(request, runtime);
        }

        /**
          * ### [](#)Limits
          * Each API operation can be called up to 50 times per second. An Alibaba Cloud account and the RAM users within the account share the quota.
          * ### [](#)Precautions
          * The storage duration of the monitoring data of each cloud service is related to the `Period` parameter (statistical period). A larger value of the `Period` parameter indicates that the monitoring data is distributed in a larger time range and the storage duration of the monitoring data is longer. The following list describes the specific relationships:
          * *   If the value of the `Period` parameter is less than 60 seconds, the storage duration is seven days.
          * *   If the value of the `Period` parameter is 60 seconds, the storage duration is 31 days.
          * *   If the value of the `Period` parameter is 300 seconds, the storage duration is 91 days.
          * ### [](#)Description
          * This topic provides an example on how to query the latest monitoring data of the `CPUUtilization` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The returned result indicates that the monitoring data for the instance `i-abcdefgh12****` of the account `123456789876****` is queried at an interval of 60 seconds. The maximum, minimum, and average values of the metric are 100, 93.1, and 99.52.
          *
          * @param request DescribeMetricLastRequest
          * @return DescribeMetricLastResponse
         */
        public async Task<DescribeMetricLastResponse> DescribeMetricLastAsync(DescribeMetricLastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricLastWithOptionsAsync(request, runtime);
        }

        /**
          * ## Limits
          * Each API operation can be called up to 50 times per second. An Alibaba Cloud account and the RAM users within the account share the quota. 
          * >This topic provides an example to show how to query the monitoring data of the `cpu_idle` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The returned result indicates that the monitoring data for the instance `i-abcdefgh12****` of the account `120886317861****` is queried at an interval of 60 seconds. The maximum, minimum, and average values of the metric are 100, 93.1, and 99.52.
          *
          * @param request DescribeMetricListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricListResponse
         */
        public DescribeMetricListResponse DescribeMetricListWithOptions(DescribeMetricListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Express))
            {
                query["Express"] = request.Express;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "DescribeMetricList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Limits
          * Each API operation can be called up to 50 times per second. An Alibaba Cloud account and the RAM users within the account share the quota. 
          * >This topic provides an example to show how to query the monitoring data of the `cpu_idle` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The returned result indicates that the monitoring data for the instance `i-abcdefgh12****` of the account `120886317861****` is queried at an interval of 60 seconds. The maximum, minimum, and average values of the metric are 100, 93.1, and 99.52.
          *
          * @param request DescribeMetricListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricListResponse
         */
        public async Task<DescribeMetricListResponse> DescribeMetricListWithOptionsAsync(DescribeMetricListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Express))
            {
                query["Express"] = request.Express;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "DescribeMetricList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Limits
          * Each API operation can be called up to 50 times per second. An Alibaba Cloud account and the RAM users within the account share the quota. 
          * >This topic provides an example to show how to query the monitoring data of the `cpu_idle` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The returned result indicates that the monitoring data for the instance `i-abcdefgh12****` of the account `120886317861****` is queried at an interval of 60 seconds. The maximum, minimum, and average values of the metric are 100, 93.1, and 99.52.
          *
          * @param request DescribeMetricListRequest
          * @return DescribeMetricListResponse
         */
        public DescribeMetricListResponse DescribeMetricList(DescribeMetricListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricListWithOptions(request, runtime);
        }

        /**
          * ## Limits
          * Each API operation can be called up to 50 times per second. An Alibaba Cloud account and the RAM users within the account share the quota. 
          * >This topic provides an example to show how to query the monitoring data of the `cpu_idle` metric for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The returned result indicates that the monitoring data for the instance `i-abcdefgh12****` of the account `120886317861****` is queried at an interval of 60 seconds. The maximum, minimum, and average values of the metric are 100, 93.1, and 99.52.
          *
          * @param request DescribeMetricListRequest
          * @return DescribeMetricListResponse
         */
        public async Task<DescribeMetricListResponse> DescribeMetricListAsync(DescribeMetricListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricListWithOptionsAsync(request, runtime);
        }

        /**
          * This operation is usually used with DescribeMetricList and DescribeMetricLast. For more information, see [DescribeMetricList](~~51936~~) and [DescribeMetricLast](~~51939~~).
          *
          * @param request DescribeMetricMetaListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricMetaListResponse
         */
        public DescribeMetricMetaListResponse DescribeMetricMetaListWithOptions(DescribeMetricMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
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
                Action = "DescribeMetricMetaList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricMetaListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This operation is usually used with DescribeMetricList and DescribeMetricLast. For more information, see [DescribeMetricList](~~51936~~) and [DescribeMetricLast](~~51939~~).
          *
          * @param request DescribeMetricMetaListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricMetaListResponse
         */
        public async Task<DescribeMetricMetaListResponse> DescribeMetricMetaListWithOptionsAsync(DescribeMetricMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
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
                Action = "DescribeMetricMetaList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricMetaListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This operation is usually used with DescribeMetricList and DescribeMetricLast. For more information, see [DescribeMetricList](~~51936~~) and [DescribeMetricLast](~~51939~~).
          *
          * @param request DescribeMetricMetaListRequest
          * @return DescribeMetricMetaListResponse
         */
        public DescribeMetricMetaListResponse DescribeMetricMetaList(DescribeMetricMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricMetaListWithOptions(request, runtime);
        }

        /**
          * This operation is usually used with DescribeMetricList and DescribeMetricLast. For more information, see [DescribeMetricList](~~51936~~) and [DescribeMetricLast](~~51939~~).
          *
          * @param request DescribeMetricMetaListRequest
          * @return DescribeMetricMetaListResponse
         */
        public async Task<DescribeMetricMetaListResponse> DescribeMetricMetaListAsync(DescribeMetricMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricMetaListWithOptionsAsync(request, runtime);
        }

        public DescribeMetricRuleBlackListResponse DescribeMetricRuleBlackListWithOptions(DescribeMetricRuleBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnable))
            {
                query["IsEnable"] = request.IsEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                query["ScopeType"] = request.ScopeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricRuleBlackList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricRuleBlackListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMetricRuleBlackListResponse> DescribeMetricRuleBlackListWithOptionsAsync(DescribeMetricRuleBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnable))
            {
                query["IsEnable"] = request.IsEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                query["ScopeType"] = request.ScopeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricRuleBlackList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricRuleBlackListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMetricRuleBlackListResponse DescribeMetricRuleBlackList(DescribeMetricRuleBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricRuleBlackListWithOptions(request, runtime);
        }

        public async Task<DescribeMetricRuleBlackListResponse> DescribeMetricRuleBlackListAsync(DescribeMetricRuleBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricRuleBlackListWithOptionsAsync(request, runtime);
        }

        public DescribeMetricRuleCountResponse DescribeMetricRuleCountWithOptions(DescribeMetricRuleCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricRuleCount",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricRuleCountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMetricRuleCountResponse> DescribeMetricRuleCountWithOptionsAsync(DescribeMetricRuleCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricRuleCount",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricRuleCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMetricRuleCountResponse DescribeMetricRuleCount(DescribeMetricRuleCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricRuleCountWithOptions(request, runtime);
        }

        public async Task<DescribeMetricRuleCountResponse> DescribeMetricRuleCountAsync(DescribeMetricRuleCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricRuleCountWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query all alert rules within your Alibaba Cloud account. The returned result shows that only one alert rule is found. The name of the alert rule is `Rule_01` and the ID is `applyTemplate344cfd42-0f32-4fd6-805a-88d7908a****`.
          *
          * @param request DescribeMetricRuleListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricRuleListResponse
         */
        public DescribeMetricRuleListResponse DescribeMetricRuleListWithOptions(DescribeMetricRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertState))
            {
                query["AlertState"] = request.AlertState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableState))
            {
                query["EnableState"] = request.EnableState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIds))
            {
                query["RuleIds"] = request.RuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricRuleList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricRuleListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query all alert rules within your Alibaba Cloud account. The returned result shows that only one alert rule is found. The name of the alert rule is `Rule_01` and the ID is `applyTemplate344cfd42-0f32-4fd6-805a-88d7908a****`.
          *
          * @param request DescribeMetricRuleListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricRuleListResponse
         */
        public async Task<DescribeMetricRuleListResponse> DescribeMetricRuleListWithOptionsAsync(DescribeMetricRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertState))
            {
                query["AlertState"] = request.AlertState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableState))
            {
                query["EnableState"] = request.EnableState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIds))
            {
                query["RuleIds"] = request.RuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricRuleList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query all alert rules within your Alibaba Cloud account. The returned result shows that only one alert rule is found. The name of the alert rule is `Rule_01` and the ID is `applyTemplate344cfd42-0f32-4fd6-805a-88d7908a****`.
          *
          * @param request DescribeMetricRuleListRequest
          * @return DescribeMetricRuleListResponse
         */
        public DescribeMetricRuleListResponse DescribeMetricRuleList(DescribeMetricRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricRuleListWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query all alert rules within your Alibaba Cloud account. The returned result shows that only one alert rule is found. The name of the alert rule is `Rule_01` and the ID is `applyTemplate344cfd42-0f32-4fd6-805a-88d7908a****`.
          *
          * @param request DescribeMetricRuleListRequest
          * @return DescribeMetricRuleListResponse
         */
        public async Task<DescribeMetricRuleListResponse> DescribeMetricRuleListAsync(DescribeMetricRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricRuleListWithOptionsAsync(request, runtime);
        }

        /**
          * ## Limit
          * This operation supports only Message Service (MNS) resources. 
          * >This topic provides an example on how to query the resources that are associated with an alert rule whose ID is `ae06917_75a8c43178ab66****`.
          *
          * @param request DescribeMetricRuleTargetsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricRuleTargetsResponse
         */
        public DescribeMetricRuleTargetsResponse DescribeMetricRuleTargetsWithOptions(DescribeMetricRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricRuleTargets",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricRuleTargetsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Limit
          * This operation supports only Message Service (MNS) resources. 
          * >This topic provides an example on how to query the resources that are associated with an alert rule whose ID is `ae06917_75a8c43178ab66****`.
          *
          * @param request DescribeMetricRuleTargetsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricRuleTargetsResponse
         */
        public async Task<DescribeMetricRuleTargetsResponse> DescribeMetricRuleTargetsWithOptionsAsync(DescribeMetricRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricRuleTargets",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricRuleTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Limit
          * This operation supports only Message Service (MNS) resources. 
          * >This topic provides an example on how to query the resources that are associated with an alert rule whose ID is `ae06917_75a8c43178ab66****`.
          *
          * @param request DescribeMetricRuleTargetsRequest
          * @return DescribeMetricRuleTargetsResponse
         */
        public DescribeMetricRuleTargetsResponse DescribeMetricRuleTargets(DescribeMetricRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricRuleTargetsWithOptions(request, runtime);
        }

        /**
          * ## Limit
          * This operation supports only Message Service (MNS) resources. 
          * >This topic provides an example on how to query the resources that are associated with an alert rule whose ID is `ae06917_75a8c43178ab66****`.
          *
          * @param request DescribeMetricRuleTargetsRequest
          * @return DescribeMetricRuleTargetsResponse
         */
        public async Task<DescribeMetricRuleTargetsResponse> DescribeMetricRuleTargetsAsync(DescribeMetricRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricRuleTargetsWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the details of an alert template whose ID is `70****`.
          *
          * @param request DescribeMetricRuleTemplateAttributeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricRuleTemplateAttributeResponse
         */
        public DescribeMetricRuleTemplateAttributeResponse DescribeMetricRuleTemplateAttributeWithOptions(DescribeMetricRuleTemplateAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
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
                Action = "DescribeMetricRuleTemplateAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricRuleTemplateAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the details of an alert template whose ID is `70****`.
          *
          * @param request DescribeMetricRuleTemplateAttributeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricRuleTemplateAttributeResponse
         */
        public async Task<DescribeMetricRuleTemplateAttributeResponse> DescribeMetricRuleTemplateAttributeWithOptionsAsync(DescribeMetricRuleTemplateAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
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
                Action = "DescribeMetricRuleTemplateAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricRuleTemplateAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the details of an alert template whose ID is `70****`.
          *
          * @param request DescribeMetricRuleTemplateAttributeRequest
          * @return DescribeMetricRuleTemplateAttributeResponse
         */
        public DescribeMetricRuleTemplateAttributeResponse DescribeMetricRuleTemplateAttribute(DescribeMetricRuleTemplateAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricRuleTemplateAttributeWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the details of an alert template whose ID is `70****`.
          *
          * @param request DescribeMetricRuleTemplateAttributeRequest
          * @return DescribeMetricRuleTemplateAttributeResponse
         */
        public async Task<DescribeMetricRuleTemplateAttributeResponse> DescribeMetricRuleTemplateAttributeAsync(DescribeMetricRuleTemplateAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricRuleTemplateAttributeWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query alert templates. In this example, the following alert templates are returned in the response: `ECS_Template1` and `ECS_Template2`.
          *
          * @param request DescribeMetricRuleTemplateListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricRuleTemplateListResponse
         */
        public DescribeMetricRuleTemplateListResponse DescribeMetricRuleTemplateListWithOptions(DescribeMetricRuleTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.History))
            {
                query["History"] = request.History;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
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
                Action = "DescribeMetricRuleTemplateList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricRuleTemplateListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query alert templates. In this example, the following alert templates are returned in the response: `ECS_Template1` and `ECS_Template2`.
          *
          * @param request DescribeMetricRuleTemplateListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricRuleTemplateListResponse
         */
        public async Task<DescribeMetricRuleTemplateListResponse> DescribeMetricRuleTemplateListWithOptionsAsync(DescribeMetricRuleTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.History))
            {
                query["History"] = request.History;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
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
                Action = "DescribeMetricRuleTemplateList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricRuleTemplateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query alert templates. In this example, the following alert templates are returned in the response: `ECS_Template1` and `ECS_Template2`.
          *
          * @param request DescribeMetricRuleTemplateListRequest
          * @return DescribeMetricRuleTemplateListResponse
         */
        public DescribeMetricRuleTemplateListResponse DescribeMetricRuleTemplateList(DescribeMetricRuleTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricRuleTemplateListWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query alert templates. In this example, the following alert templates are returned in the response: `ECS_Template1` and `ECS_Template2`.
          *
          * @param request DescribeMetricRuleTemplateListRequest
          * @return DescribeMetricRuleTemplateListResponse
         */
        public async Task<DescribeMetricRuleTemplateListResponse> DescribeMetricRuleTemplateListAsync(DescribeMetricRuleTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricRuleTemplateListWithOptionsAsync(request, runtime);
        }

        /**
          * ### [](#)Limits
          * Each API operation can be called up to 10 times per second. An Alibaba Cloud account and the RAM users within the account share the quota.
          * ### [](#)Precautions
          * The storage duration of the monitoring data of each cloud service is related to the `Period` parameter (statistical period). A larger value of the `Period` parameter indicates that the monitoring data is distributed in a larger time range and the storage duration of the monitoring data is longer. The following list describes the specific relationships:
          * *   If the value of the `Period` parameter is less than 60 seconds, the storage duration is seven days.
          * *   If the value of the `Period` parameter is 60 seconds, the storage duration is 31 days.
          * *   If the value of the `Period` parameter is 300 seconds, the storage duration is 91 days.
          * ### [](#)Description
          * This topic provides an example to show how to query the monitoring data of the `cpu_idle` metric in the last 60 seconds for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The monitoring data is sorted in the descending order based on the `Average` field.
          *
          * @param request DescribeMetricTopRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricTopResponse
         */
        public DescribeMetricTopResponse DescribeMetricTopWithOptions(DescribeMetricTopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Express))
            {
                query["Express"] = request.Express;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDesc))
            {
                query["OrderDesc"] = request.OrderDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Orderby))
            {
                query["Orderby"] = request.Orderby;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "DescribeMetricTop",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricTopResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### [](#)Limits
          * Each API operation can be called up to 10 times per second. An Alibaba Cloud account and the RAM users within the account share the quota.
          * ### [](#)Precautions
          * The storage duration of the monitoring data of each cloud service is related to the `Period` parameter (statistical period). A larger value of the `Period` parameter indicates that the monitoring data is distributed in a larger time range and the storage duration of the monitoring data is longer. The following list describes the specific relationships:
          * *   If the value of the `Period` parameter is less than 60 seconds, the storage duration is seven days.
          * *   If the value of the `Period` parameter is 60 seconds, the storage duration is 31 days.
          * *   If the value of the `Period` parameter is 300 seconds, the storage duration is 91 days.
          * ### [](#)Description
          * This topic provides an example to show how to query the monitoring data of the `cpu_idle` metric in the last 60 seconds for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The monitoring data is sorted in the descending order based on the `Average` field.
          *
          * @param request DescribeMetricTopRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMetricTopResponse
         */
        public async Task<DescribeMetricTopResponse> DescribeMetricTopWithOptionsAsync(DescribeMetricTopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Express))
            {
                query["Express"] = request.Express;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDesc))
            {
                query["OrderDesc"] = request.OrderDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Orderby))
            {
                query["Orderby"] = request.Orderby;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "DescribeMetricTop",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricTopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### [](#)Limits
          * Each API operation can be called up to 10 times per second. An Alibaba Cloud account and the RAM users within the account share the quota.
          * ### [](#)Precautions
          * The storage duration of the monitoring data of each cloud service is related to the `Period` parameter (statistical period). A larger value of the `Period` parameter indicates that the monitoring data is distributed in a larger time range and the storage duration of the monitoring data is longer. The following list describes the specific relationships:
          * *   If the value of the `Period` parameter is less than 60 seconds, the storage duration is seven days.
          * *   If the value of the `Period` parameter is 60 seconds, the storage duration is 31 days.
          * *   If the value of the `Period` parameter is 300 seconds, the storage duration is 91 days.
          * ### [](#)Description
          * This topic provides an example to show how to query the monitoring data of the `cpu_idle` metric in the last 60 seconds for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The monitoring data is sorted in the descending order based on the `Average` field.
          *
          * @param request DescribeMetricTopRequest
          * @return DescribeMetricTopResponse
         */
        public DescribeMetricTopResponse DescribeMetricTop(DescribeMetricTopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricTopWithOptions(request, runtime);
        }

        /**
          * ### [](#)Limits
          * Each API operation can be called up to 10 times per second. An Alibaba Cloud account and the RAM users within the account share the quota.
          * ### [](#)Precautions
          * The storage duration of the monitoring data of each cloud service is related to the `Period` parameter (statistical period). A larger value of the `Period` parameter indicates that the monitoring data is distributed in a larger time range and the storage duration of the monitoring data is longer. The following list describes the specific relationships:
          * *   If the value of the `Period` parameter is less than 60 seconds, the storage duration is seven days.
          * *   If the value of the `Period` parameter is 60 seconds, the storage duration is 31 days.
          * *   If the value of the `Period` parameter is 300 seconds, the storage duration is 91 days.
          * ### [](#)Description
          * This topic provides an example to show how to query the monitoring data of the `cpu_idle` metric in the last 60 seconds for Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. The monitoring data is sorted in the descending order based on the `Average` field.
          *
          * @param request DescribeMetricTopRequest
          * @return DescribeMetricTopResponse
         */
        public async Task<DescribeMetricTopResponse> DescribeMetricTopAsync(DescribeMetricTopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricTopWithOptionsAsync(request, runtime);
        }

        public DescribeMonitorGroupCategoriesResponse DescribeMonitorGroupCategoriesWithOptions(DescribeMonitorGroupCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitorGroupCategories",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorGroupCategoriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMonitorGroupCategoriesResponse> DescribeMonitorGroupCategoriesWithOptionsAsync(DescribeMonitorGroupCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitorGroupCategories",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorGroupCategoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMonitorGroupCategoriesResponse DescribeMonitorGroupCategories(DescribeMonitorGroupCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorGroupCategoriesWithOptions(request, runtime);
        }

        public async Task<DescribeMonitorGroupCategoriesResponse> DescribeMonitorGroupCategoriesAsync(DescribeMonitorGroupCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorGroupCategoriesWithOptionsAsync(request, runtime);
        }

        public DescribeMonitorGroupDynamicRulesResponse DescribeMonitorGroupDynamicRulesWithOptions(DescribeMonitorGroupDynamicRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitorGroupDynamicRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorGroupDynamicRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMonitorGroupDynamicRulesResponse> DescribeMonitorGroupDynamicRulesWithOptionsAsync(DescribeMonitorGroupDynamicRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitorGroupDynamicRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorGroupDynamicRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMonitorGroupDynamicRulesResponse DescribeMonitorGroupDynamicRules(DescribeMonitorGroupDynamicRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorGroupDynamicRulesWithOptions(request, runtime);
        }

        public async Task<DescribeMonitorGroupDynamicRulesResponse> DescribeMonitorGroupDynamicRulesAsync(DescribeMonitorGroupDynamicRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorGroupDynamicRulesWithOptionsAsync(request, runtime);
        }

        public DescribeMonitorGroupInstanceAttributeResponse DescribeMonitorGroupInstanceAttributeWithOptions(DescribeMonitorGroupInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Total))
            {
                query["Total"] = request.Total;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitorGroupInstanceAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorGroupInstanceAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMonitorGroupInstanceAttributeResponse> DescribeMonitorGroupInstanceAttributeWithOptionsAsync(DescribeMonitorGroupInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Total))
            {
                query["Total"] = request.Total;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitorGroupInstanceAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorGroupInstanceAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMonitorGroupInstanceAttributeResponse DescribeMonitorGroupInstanceAttribute(DescribeMonitorGroupInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorGroupInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeMonitorGroupInstanceAttributeResponse> DescribeMonitorGroupInstanceAttributeAsync(DescribeMonitorGroupInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorGroupInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeMonitorGroupInstancesResponse DescribeMonitorGroupInstancesWithOptions(DescribeMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
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
                Action = "DescribeMonitorGroupInstances",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorGroupInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMonitorGroupInstancesResponse> DescribeMonitorGroupInstancesWithOptionsAsync(DescribeMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
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
                Action = "DescribeMonitorGroupInstances",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorGroupInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMonitorGroupInstancesResponse DescribeMonitorGroupInstances(DescribeMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorGroupInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeMonitorGroupInstancesResponse> DescribeMonitorGroupInstancesAsync(DescribeMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorGroupInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeMonitorGroupNotifyPolicyListResponse DescribeMonitorGroupNotifyPolicyListWithOptions(DescribeMonitorGroupNotifyPolicyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitorGroupNotifyPolicyList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorGroupNotifyPolicyListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMonitorGroupNotifyPolicyListResponse> DescribeMonitorGroupNotifyPolicyListWithOptionsAsync(DescribeMonitorGroupNotifyPolicyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitorGroupNotifyPolicyList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorGroupNotifyPolicyListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMonitorGroupNotifyPolicyListResponse DescribeMonitorGroupNotifyPolicyList(DescribeMonitorGroupNotifyPolicyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorGroupNotifyPolicyListWithOptions(request, runtime);
        }

        public async Task<DescribeMonitorGroupNotifyPolicyListResponse> DescribeMonitorGroupNotifyPolicyListAsync(DescribeMonitorGroupNotifyPolicyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorGroupNotifyPolicyListWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example of how to query the application groups of the current account. The response shows that the current account has two application groups: `testGroup124` and `test123`.
          *
          * @param request DescribeMonitorGroupsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMonitorGroupsResponse
         */
        public DescribeMonitorGroupsResponse DescribeMonitorGroupsWithOptions(DescribeMonitorGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicTagRuleId))
            {
                query["DynamicTagRuleId"] = request.DynamicTagRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupFounderTagKey))
            {
                query["GroupFounderTagKey"] = request.GroupFounderTagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupFounderTagValue))
            {
                query["GroupFounderTagValue"] = request.GroupFounderTagValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTemplateHistory))
            {
                query["IncludeTemplateHistory"] = request.IncludeTemplateHistory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectContactGroups))
            {
                query["SelectContactGroups"] = request.SelectContactGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitorGroups",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example of how to query the application groups of the current account. The response shows that the current account has two application groups: `testGroup124` and `test123`.
          *
          * @param request DescribeMonitorGroupsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMonitorGroupsResponse
         */
        public async Task<DescribeMonitorGroupsResponse> DescribeMonitorGroupsWithOptionsAsync(DescribeMonitorGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicTagRuleId))
            {
                query["DynamicTagRuleId"] = request.DynamicTagRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupFounderTagKey))
            {
                query["GroupFounderTagKey"] = request.GroupFounderTagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupFounderTagValue))
            {
                query["GroupFounderTagValue"] = request.GroupFounderTagValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTemplateHistory))
            {
                query["IncludeTemplateHistory"] = request.IncludeTemplateHistory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectContactGroups))
            {
                query["SelectContactGroups"] = request.SelectContactGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitorGroups",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example of how to query the application groups of the current account. The response shows that the current account has two application groups: `testGroup124` and `test123`.
          *
          * @param request DescribeMonitorGroupsRequest
          * @return DescribeMonitorGroupsResponse
         */
        public DescribeMonitorGroupsResponse DescribeMonitorGroups(DescribeMonitorGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorGroupsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example of how to query the application groups of the current account. The response shows that the current account has two application groups: `testGroup124` and `test123`.
          *
          * @param request DescribeMonitorGroupsRequest
          * @return DescribeMonitorGroupsResponse
         */
        public async Task<DescribeMonitorGroupsResponse> DescribeMonitorGroupsAsync(DescribeMonitorGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeMonitorResourceQuotaAttributeResponse DescribeMonitorResourceQuotaAttributeWithOptions(DescribeMonitorResourceQuotaAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowUsed))
            {
                query["ShowUsed"] = request.ShowUsed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitorResourceQuotaAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorResourceQuotaAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMonitorResourceQuotaAttributeResponse> DescribeMonitorResourceQuotaAttributeWithOptionsAsync(DescribeMonitorResourceQuotaAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowUsed))
            {
                query["ShowUsed"] = request.ShowUsed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitorResourceQuotaAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorResourceQuotaAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMonitorResourceQuotaAttributeResponse DescribeMonitorResourceQuotaAttribute(DescribeMonitorResourceQuotaAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorResourceQuotaAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeMonitorResourceQuotaAttributeResponse> DescribeMonitorResourceQuotaAttributeAsync(DescribeMonitorResourceQuotaAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorResourceQuotaAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeMonitoringAgentAccessKeyResponse DescribeMonitoringAgentAccessKeyWithOptions(DescribeMonitoringAgentAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitoringAgentAccessKey",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitoringAgentAccessKeyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMonitoringAgentAccessKeyResponse> DescribeMonitoringAgentAccessKeyWithOptionsAsync(DescribeMonitoringAgentAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitoringAgentAccessKey",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitoringAgentAccessKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMonitoringAgentAccessKeyResponse DescribeMonitoringAgentAccessKey(DescribeMonitoringAgentAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitoringAgentAccessKeyWithOptions(request, runtime);
        }

        public async Task<DescribeMonitoringAgentAccessKeyResponse> DescribeMonitoringAgentAccessKeyAsync(DescribeMonitoringAgentAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitoringAgentAccessKeyWithOptionsAsync(request, runtime);
        }

        public DescribeMonitoringAgentConfigResponse DescribeMonitoringAgentConfigWithOptions(DescribeMonitoringAgentConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitoringAgentConfig",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitoringAgentConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMonitoringAgentConfigResponse> DescribeMonitoringAgentConfigWithOptionsAsync(DescribeMonitoringAgentConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitoringAgentConfig",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitoringAgentConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMonitoringAgentConfigResponse DescribeMonitoringAgentConfig(DescribeMonitoringAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitoringAgentConfigWithOptions(request, runtime);
        }

        public async Task<DescribeMonitoringAgentConfigResponse> DescribeMonitoringAgentConfigAsync(DescribeMonitoringAgentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitoringAgentConfigWithOptionsAsync(request, runtime);
        }

        public DescribeMonitoringAgentHostsResponse DescribeMonitoringAgentHostsWithOptions(DescribeMonitoringAgentHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunHost))
            {
                query["AliyunHost"] = request.AliyunHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceRegionId))
            {
                query["InstanceRegionId"] = request.InstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumbers))
            {
                query["SerialNumbers"] = request.SerialNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SysomStatus))
            {
                query["SysomStatus"] = request.SysomStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitoringAgentHosts",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitoringAgentHostsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMonitoringAgentHostsResponse> DescribeMonitoringAgentHostsWithOptionsAsync(DescribeMonitoringAgentHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunHost))
            {
                query["AliyunHost"] = request.AliyunHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceRegionId))
            {
                query["InstanceRegionId"] = request.InstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumbers))
            {
                query["SerialNumbers"] = request.SerialNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SysomStatus))
            {
                query["SysomStatus"] = request.SysomStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitoringAgentHosts",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitoringAgentHostsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMonitoringAgentHostsResponse DescribeMonitoringAgentHosts(DescribeMonitoringAgentHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitoringAgentHostsWithOptions(request, runtime);
        }

        public async Task<DescribeMonitoringAgentHostsResponse> DescribeMonitoringAgentHostsAsync(DescribeMonitoringAgentHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitoringAgentHostsWithOptionsAsync(request, runtime);
        }

        /**
          * >  Before you call this operation, call the CreateMonitoringAgentProcess operation to create processes. For more information, see [CreateMonitoringAgentProcess](~~114951~~~).
          * This topic provides an example of how to query the processes of the `i-hp3hl3cx1pbahzy8****` instance. The response indicates the details of the `NGINX` and `HTTP` processes.
          *
          * @param request DescribeMonitoringAgentProcessesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMonitoringAgentProcessesResponse
         */
        public DescribeMonitoringAgentProcessesResponse DescribeMonitoringAgentProcessesWithOptions(DescribeMonitoringAgentProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitoringAgentProcesses",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitoringAgentProcessesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  Before you call this operation, call the CreateMonitoringAgentProcess operation to create processes. For more information, see [CreateMonitoringAgentProcess](~~114951~~~).
          * This topic provides an example of how to query the processes of the `i-hp3hl3cx1pbahzy8****` instance. The response indicates the details of the `NGINX` and `HTTP` processes.
          *
          * @param request DescribeMonitoringAgentProcessesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMonitoringAgentProcessesResponse
         */
        public async Task<DescribeMonitoringAgentProcessesResponse> DescribeMonitoringAgentProcessesWithOptionsAsync(DescribeMonitoringAgentProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitoringAgentProcesses",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitoringAgentProcessesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  Before you call this operation, call the CreateMonitoringAgentProcess operation to create processes. For more information, see [CreateMonitoringAgentProcess](~~114951~~~).
          * This topic provides an example of how to query the processes of the `i-hp3hl3cx1pbahzy8****` instance. The response indicates the details of the `NGINX` and `HTTP` processes.
          *
          * @param request DescribeMonitoringAgentProcessesRequest
          * @return DescribeMonitoringAgentProcessesResponse
         */
        public DescribeMonitoringAgentProcessesResponse DescribeMonitoringAgentProcesses(DescribeMonitoringAgentProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitoringAgentProcessesWithOptions(request, runtime);
        }

        /**
          * >  Before you call this operation, call the CreateMonitoringAgentProcess operation to create processes. For more information, see [CreateMonitoringAgentProcess](~~114951~~~).
          * This topic provides an example of how to query the processes of the `i-hp3hl3cx1pbahzy8****` instance. The response indicates the details of the `NGINX` and `HTTP` processes.
          *
          * @param request DescribeMonitoringAgentProcessesRequest
          * @return DescribeMonitoringAgentProcessesResponse
         */
        public async Task<DescribeMonitoringAgentProcessesResponse> DescribeMonitoringAgentProcessesAsync(DescribeMonitoringAgentProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitoringAgentProcessesWithOptionsAsync(request, runtime);
        }

        /**
          * This topic describes how to query the status of the CloudMonitor agent that is installed on the `i-hp3dunahluwajv6f****` instance. The result indicates that the CloudMonitor agent is in the `running` state.
          *
          * @param request DescribeMonitoringAgentStatusesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMonitoringAgentStatusesResponse
         */
        public DescribeMonitoringAgentStatusesResponse DescribeMonitoringAgentStatusesWithOptions(DescribeMonitoringAgentStatusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAvailabilityTaskId))
            {
                query["HostAvailabilityTaskId"] = request.HostAvailabilityTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitoringAgentStatuses",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitoringAgentStatusesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic describes how to query the status of the CloudMonitor agent that is installed on the `i-hp3dunahluwajv6f****` instance. The result indicates that the CloudMonitor agent is in the `running` state.
          *
          * @param request DescribeMonitoringAgentStatusesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeMonitoringAgentStatusesResponse
         */
        public async Task<DescribeMonitoringAgentStatusesResponse> DescribeMonitoringAgentStatusesWithOptionsAsync(DescribeMonitoringAgentStatusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAvailabilityTaskId))
            {
                query["HostAvailabilityTaskId"] = request.HostAvailabilityTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitoringAgentStatuses",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitoringAgentStatusesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic describes how to query the status of the CloudMonitor agent that is installed on the `i-hp3dunahluwajv6f****` instance. The result indicates that the CloudMonitor agent is in the `running` state.
          *
          * @param request DescribeMonitoringAgentStatusesRequest
          * @return DescribeMonitoringAgentStatusesResponse
         */
        public DescribeMonitoringAgentStatusesResponse DescribeMonitoringAgentStatuses(DescribeMonitoringAgentStatusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitoringAgentStatusesWithOptions(request, runtime);
        }

        /**
          * This topic describes how to query the status of the CloudMonitor agent that is installed on the `i-hp3dunahluwajv6f****` instance. The result indicates that the CloudMonitor agent is in the `running` state.
          *
          * @param request DescribeMonitoringAgentStatusesRequest
          * @return DescribeMonitoringAgentStatusesResponse
         */
        public async Task<DescribeMonitoringAgentStatusesResponse> DescribeMonitoringAgentStatusesAsync(DescribeMonitoringAgentStatusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitoringAgentStatusesWithOptionsAsync(request, runtime);
        }

        public DescribeMonitoringConfigResponse DescribeMonitoringConfigWithOptions(DescribeMonitoringConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitoringConfig",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitoringConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMonitoringConfigResponse> DescribeMonitoringConfigWithOptionsAsync(DescribeMonitoringConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitoringConfig",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitoringConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMonitoringConfigResponse DescribeMonitoringConfig(DescribeMonitoringConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitoringConfigWithOptions(request, runtime);
        }

        public async Task<DescribeMonitoringConfigResponse> DescribeMonitoringConfigAsync(DescribeMonitoringConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitoringConfigWithOptionsAsync(request, runtime);
        }

        /**
          * >  If a tag is attached to multiple cloud resources in the region, the key of the tag is returned only once.
          *
          * @param request DescribeProductResourceTagKeyListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeProductResourceTagKeyListResponse
         */
        public DescribeProductResourceTagKeyListResponse DescribeProductResourceTagKeyListWithOptions(DescribeProductResourceTagKeyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeProductResourceTagKeyList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProductResourceTagKeyListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  If a tag is attached to multiple cloud resources in the region, the key of the tag is returned only once.
          *
          * @param request DescribeProductResourceTagKeyListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeProductResourceTagKeyListResponse
         */
        public async Task<DescribeProductResourceTagKeyListResponse> DescribeProductResourceTagKeyListWithOptionsAsync(DescribeProductResourceTagKeyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeProductResourceTagKeyList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProductResourceTagKeyListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  If a tag is attached to multiple cloud resources in the region, the key of the tag is returned only once.
          *
          * @param request DescribeProductResourceTagKeyListRequest
          * @return DescribeProductResourceTagKeyListResponse
         */
        public DescribeProductResourceTagKeyListResponse DescribeProductResourceTagKeyList(DescribeProductResourceTagKeyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProductResourceTagKeyListWithOptions(request, runtime);
        }

        /**
          * >  If a tag is attached to multiple cloud resources in the region, the key of the tag is returned only once.
          *
          * @param request DescribeProductResourceTagKeyListRequest
          * @return DescribeProductResourceTagKeyListResponse
         */
        public async Task<DescribeProductResourceTagKeyListResponse> DescribeProductResourceTagKeyListAsync(DescribeProductResourceTagKeyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProductResourceTagKeyListWithOptionsAsync(request, runtime);
        }

        public DescribeProductsOfActiveMetricRuleResponse DescribeProductsOfActiveMetricRuleWithOptions(DescribeProductsOfActiveMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProductsOfActiveMetricRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProductsOfActiveMetricRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeProductsOfActiveMetricRuleResponse> DescribeProductsOfActiveMetricRuleWithOptionsAsync(DescribeProductsOfActiveMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProductsOfActiveMetricRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProductsOfActiveMetricRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeProductsOfActiveMetricRuleResponse DescribeProductsOfActiveMetricRule(DescribeProductsOfActiveMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProductsOfActiveMetricRuleWithOptions(request, runtime);
        }

        public async Task<DescribeProductsOfActiveMetricRuleResponse> DescribeProductsOfActiveMetricRuleAsync(DescribeProductsOfActiveMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProductsOfActiveMetricRuleWithOptionsAsync(request, runtime);
        }

        /**
          * The information obtained by this operation includes the service description, namespace, and tags.
          *
          * @param request DescribeProjectMetaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeProjectMetaResponse
         */
        public DescribeProjectMetaResponse DescribeProjectMetaWithOptions(DescribeProjectMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
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
                Action = "DescribeProjectMeta",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectMetaResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The information obtained by this operation includes the service description, namespace, and tags.
          *
          * @param request DescribeProjectMetaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeProjectMetaResponse
         */
        public async Task<DescribeProjectMetaResponse> DescribeProjectMetaWithOptionsAsync(DescribeProjectMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
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
                Action = "DescribeProjectMeta",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The information obtained by this operation includes the service description, namespace, and tags.
          *
          * @param request DescribeProjectMetaRequest
          * @return DescribeProjectMetaResponse
         */
        public DescribeProjectMetaResponse DescribeProjectMeta(DescribeProjectMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProjectMetaWithOptions(request, runtime);
        }

        /**
          * The information obtained by this operation includes the service description, namespace, and tags.
          *
          * @param request DescribeProjectMetaRequest
          * @return DescribeProjectMetaResponse
         */
        public async Task<DescribeProjectMetaResponse> DescribeProjectMetaAsync(DescribeProjectMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProjectMetaWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the details of a site monitoring task whose ID is `cc641dff-c19d-45f3-ad0a-818a0c4f****`. The returned result indicates that the task name is `test123`, the URL that is monitored by the task is `https://aliyun.com`, and the name of the carrier is `Alibaba`.
          *
          * @param request DescribeSiteMonitorAttributeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSiteMonitorAttributeResponse
         */
        public DescribeSiteMonitorAttributeResponse DescribeSiteMonitorAttributeWithOptions(DescribeSiteMonitorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeAlert))
            {
                query["IncludeAlert"] = request.IncludeAlert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSiteMonitorAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteMonitorAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the details of a site monitoring task whose ID is `cc641dff-c19d-45f3-ad0a-818a0c4f****`. The returned result indicates that the task name is `test123`, the URL that is monitored by the task is `https://aliyun.com`, and the name of the carrier is `Alibaba`.
          *
          * @param request DescribeSiteMonitorAttributeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSiteMonitorAttributeResponse
         */
        public async Task<DescribeSiteMonitorAttributeResponse> DescribeSiteMonitorAttributeWithOptionsAsync(DescribeSiteMonitorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeAlert))
            {
                query["IncludeAlert"] = request.IncludeAlert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSiteMonitorAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteMonitorAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the details of a site monitoring task whose ID is `cc641dff-c19d-45f3-ad0a-818a0c4f****`. The returned result indicates that the task name is `test123`, the URL that is monitored by the task is `https://aliyun.com`, and the name of the carrier is `Alibaba`.
          *
          * @param request DescribeSiteMonitorAttributeRequest
          * @return DescribeSiteMonitorAttributeResponse
         */
        public DescribeSiteMonitorAttributeResponse DescribeSiteMonitorAttribute(DescribeSiteMonitorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSiteMonitorAttributeWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the details of a site monitoring task whose ID is `cc641dff-c19d-45f3-ad0a-818a0c4f****`. The returned result indicates that the task name is `test123`, the URL that is monitored by the task is `https://aliyun.com`, and the name of the carrier is `Alibaba`.
          *
          * @param request DescribeSiteMonitorAttributeRequest
          * @return DescribeSiteMonitorAttributeResponse
         */
        public async Task<DescribeSiteMonitorAttributeResponse> DescribeSiteMonitorAttributeAsync(DescribeSiteMonitorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSiteMonitorAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeSiteMonitorDataResponse DescribeSiteMonitorDataWithOptions(DescribeSiteMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSiteMonitorData",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteMonitorDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSiteMonitorDataResponse> DescribeSiteMonitorDataWithOptionsAsync(DescribeSiteMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSiteMonitorData",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteMonitorDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSiteMonitorDataResponse DescribeSiteMonitorData(DescribeSiteMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSiteMonitorDataWithOptions(request, runtime);
        }

        public async Task<DescribeSiteMonitorDataResponse> DescribeSiteMonitorDataAsync(DescribeSiteMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSiteMonitorDataWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the detection points that are provided by China Unicom in Guiyang.
          *
          * @param request DescribeSiteMonitorISPCityListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSiteMonitorISPCityListResponse
         */
        public DescribeSiteMonitorISPCityListResponse DescribeSiteMonitorISPCityListWithOptions(DescribeSiteMonitorISPCityListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IPV4))
            {
                query["IPV4"] = request.IPV4;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IPV6))
            {
                query["IPV6"] = request.IPV6;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                query["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewAll))
            {
                query["ViewAll"] = request.ViewAll;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSiteMonitorISPCityList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteMonitorISPCityListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the detection points that are provided by China Unicom in Guiyang.
          *
          * @param request DescribeSiteMonitorISPCityListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSiteMonitorISPCityListResponse
         */
        public async Task<DescribeSiteMonitorISPCityListResponse> DescribeSiteMonitorISPCityListWithOptionsAsync(DescribeSiteMonitorISPCityListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IPV4))
            {
                query["IPV4"] = request.IPV4;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IPV6))
            {
                query["IPV6"] = request.IPV6;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                query["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewAll))
            {
                query["ViewAll"] = request.ViewAll;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSiteMonitorISPCityList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteMonitorISPCityListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the detection points that are provided by China Unicom in Guiyang.
          *
          * @param request DescribeSiteMonitorISPCityListRequest
          * @return DescribeSiteMonitorISPCityListResponse
         */
        public DescribeSiteMonitorISPCityListResponse DescribeSiteMonitorISPCityList(DescribeSiteMonitorISPCityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSiteMonitorISPCityListWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the detection points that are provided by China Unicom in Guiyang.
          *
          * @param request DescribeSiteMonitorISPCityListRequest
          * @return DescribeSiteMonitorISPCityListResponse
         */
        public async Task<DescribeSiteMonitorISPCityListResponse> DescribeSiteMonitorISPCityListAsync(DescribeSiteMonitorISPCityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSiteMonitorISPCityListWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query all the site monitoring tasks of your Alibaba Cloud account. In this example, the returned result indicates that the Alibaba Cloud account has one site monitoring task named `HanZhou_ECS2`.
          *
          * @param request DescribeSiteMonitorListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSiteMonitorListResponse
         */
        public DescribeSiteMonitorListResponse DescribeSiteMonitorListWithOptions(DescribeSiteMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskState))
            {
                query["TaskState"] = request.TaskState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSiteMonitorList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteMonitorListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query all the site monitoring tasks of your Alibaba Cloud account. In this example, the returned result indicates that the Alibaba Cloud account has one site monitoring task named `HanZhou_ECS2`.
          *
          * @param request DescribeSiteMonitorListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSiteMonitorListResponse
         */
        public async Task<DescribeSiteMonitorListResponse> DescribeSiteMonitorListWithOptionsAsync(DescribeSiteMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskState))
            {
                query["TaskState"] = request.TaskState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSiteMonitorList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteMonitorListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query all the site monitoring tasks of your Alibaba Cloud account. In this example, the returned result indicates that the Alibaba Cloud account has one site monitoring task named `HanZhou_ECS2`.
          *
          * @param request DescribeSiteMonitorListRequest
          * @return DescribeSiteMonitorListResponse
         */
        public DescribeSiteMonitorListResponse DescribeSiteMonitorList(DescribeSiteMonitorListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSiteMonitorListWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query all the site monitoring tasks of your Alibaba Cloud account. In this example, the returned result indicates that the Alibaba Cloud account has one site monitoring task named `HanZhou_ECS2`.
          *
          * @param request DescribeSiteMonitorListRequest
          * @return DescribeSiteMonitorListResponse
         */
        public async Task<DescribeSiteMonitorListResponse> DescribeSiteMonitorListAsync(DescribeSiteMonitorListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSiteMonitorListWithOptionsAsync(request, runtime);
        }

        /**
          * You can create an instant test task only by using the Alibaba Cloud account that you used to enable Network Analysis and Monitoring.
          * This topic provides an example to show how to query the logs of an instant test task whose ID is `afa5c3ce-f944-4363-9edb-ce919a29****`.
          *
          * @param request DescribeSiteMonitorLogRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSiteMonitorLogResponse
         */
        public DescribeSiteMonitorLogResponse DescribeSiteMonitorLogWithOptions(DescribeSiteMonitorLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Browser))
            {
                query["Browser"] = request.Browser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserInfo))
            {
                query["BrowserInfo"] = request.BrowserInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Device))
            {
                query["Device"] = request.Device;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                query["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["TaskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSiteMonitorLog",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteMonitorLogResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can create an instant test task only by using the Alibaba Cloud account that you used to enable Network Analysis and Monitoring.
          * This topic provides an example to show how to query the logs of an instant test task whose ID is `afa5c3ce-f944-4363-9edb-ce919a29****`.
          *
          * @param request DescribeSiteMonitorLogRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSiteMonitorLogResponse
         */
        public async Task<DescribeSiteMonitorLogResponse> DescribeSiteMonitorLogWithOptionsAsync(DescribeSiteMonitorLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Browser))
            {
                query["Browser"] = request.Browser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserInfo))
            {
                query["BrowserInfo"] = request.BrowserInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Device))
            {
                query["Device"] = request.Device;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                query["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["TaskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSiteMonitorLog",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteMonitorLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can create an instant test task only by using the Alibaba Cloud account that you used to enable Network Analysis and Monitoring.
          * This topic provides an example to show how to query the logs of an instant test task whose ID is `afa5c3ce-f944-4363-9edb-ce919a29****`.
          *
          * @param request DescribeSiteMonitorLogRequest
          * @return DescribeSiteMonitorLogResponse
         */
        public DescribeSiteMonitorLogResponse DescribeSiteMonitorLog(DescribeSiteMonitorLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSiteMonitorLogWithOptions(request, runtime);
        }

        /**
          * You can create an instant test task only by using the Alibaba Cloud account that you used to enable Network Analysis and Monitoring.
          * This topic provides an example to show how to query the logs of an instant test task whose ID is `afa5c3ce-f944-4363-9edb-ce919a29****`.
          *
          * @param request DescribeSiteMonitorLogRequest
          * @return DescribeSiteMonitorLogResponse
         */
        public async Task<DescribeSiteMonitorLogResponse> DescribeSiteMonitorLogAsync(DescribeSiteMonitorLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSiteMonitorLogWithOptionsAsync(request, runtime);
        }

        public DescribeSiteMonitorQuotaResponse DescribeSiteMonitorQuotaWithOptions(DescribeSiteMonitorQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSiteMonitorQuota",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteMonitorQuotaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSiteMonitorQuotaResponse> DescribeSiteMonitorQuotaWithOptionsAsync(DescribeSiteMonitorQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSiteMonitorQuota",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteMonitorQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSiteMonitorQuotaResponse DescribeSiteMonitorQuota(DescribeSiteMonitorQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSiteMonitorQuotaWithOptions(request, runtime);
        }

        public async Task<DescribeSiteMonitorQuotaResponse> DescribeSiteMonitorQuotaAsync(DescribeSiteMonitorQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSiteMonitorQuotaWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example to show how to query the statistics of the `Availability` metric for a site monitoring task whose ID is `ef4cdc8b-9dc7-43e7-810e-f950e56c****`. The result indicates that the availability rate of the site is `100%`.
          *
          * @param request DescribeSiteMonitorStatisticsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSiteMonitorStatisticsResponse
         */
        public DescribeSiteMonitorStatisticsResponse DescribeSiteMonitorStatisticsWithOptions(DescribeSiteMonitorStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["TimeRange"] = request.TimeRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSiteMonitorStatistics",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteMonitorStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query the statistics of the `Availability` metric for a site monitoring task whose ID is `ef4cdc8b-9dc7-43e7-810e-f950e56c****`. The result indicates that the availability rate of the site is `100%`.
          *
          * @param request DescribeSiteMonitorStatisticsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSiteMonitorStatisticsResponse
         */
        public async Task<DescribeSiteMonitorStatisticsResponse> DescribeSiteMonitorStatisticsWithOptionsAsync(DescribeSiteMonitorStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["TimeRange"] = request.TimeRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSiteMonitorStatistics",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteMonitorStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to query the statistics of the `Availability` metric for a site monitoring task whose ID is `ef4cdc8b-9dc7-43e7-810e-f950e56c****`. The result indicates that the availability rate of the site is `100%`.
          *
          * @param request DescribeSiteMonitorStatisticsRequest
          * @return DescribeSiteMonitorStatisticsResponse
         */
        public DescribeSiteMonitorStatisticsResponse DescribeSiteMonitorStatistics(DescribeSiteMonitorStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSiteMonitorStatisticsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example to show how to query the statistics of the `Availability` metric for a site monitoring task whose ID is `ef4cdc8b-9dc7-43e7-810e-f950e56c****`. The result indicates that the availability rate of the site is `100%`.
          *
          * @param request DescribeSiteMonitorStatisticsRequest
          * @return DescribeSiteMonitorStatisticsResponse
         */
        public async Task<DescribeSiteMonitorStatisticsResponse> DescribeSiteMonitorStatisticsAsync(DescribeSiteMonitorStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSiteMonitorStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeSystemEventAttributeResponse DescribeSystemEventAttributeWithOptions(DescribeSystemEventAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeywords))
            {
                query["SearchKeywords"] = request.SearchKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeSystemEventAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSystemEventAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSystemEventAttributeResponse> DescribeSystemEventAttributeWithOptionsAsync(DescribeSystemEventAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeywords))
            {
                query["SearchKeywords"] = request.SearchKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeSystemEventAttribute",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSystemEventAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSystemEventAttributeResponse DescribeSystemEventAttribute(DescribeSystemEventAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSystemEventAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeSystemEventAttributeResponse> DescribeSystemEventAttributeAsync(DescribeSystemEventAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSystemEventAttributeWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the number of times that a system event occurred for Elastic Compute Service (`ECS`). The returned result indicates that the number of times that the specified system event occurred is 3.
          *
          * @param request DescribeSystemEventCountRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSystemEventCountResponse
         */
        public DescribeSystemEventCountResponse DescribeSystemEventCountWithOptions(DescribeSystemEventCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeywords))
            {
                query["SearchKeywords"] = request.SearchKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeSystemEventCount",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSystemEventCountResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the number of times that a system event occurred for Elastic Compute Service (`ECS`). The returned result indicates that the number of times that the specified system event occurred is 3.
          *
          * @param request DescribeSystemEventCountRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeSystemEventCountResponse
         */
        public async Task<DescribeSystemEventCountResponse> DescribeSystemEventCountWithOptionsAsync(DescribeSystemEventCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeywords))
            {
                query["SearchKeywords"] = request.SearchKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeSystemEventCount",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSystemEventCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to query the number of times that a system event occurred for Elastic Compute Service (`ECS`). The returned result indicates that the number of times that the specified system event occurred is 3.
          *
          * @param request DescribeSystemEventCountRequest
          * @return DescribeSystemEventCountResponse
         */
        public DescribeSystemEventCountResponse DescribeSystemEventCount(DescribeSystemEventCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSystemEventCountWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the number of times that a system event occurred for Elastic Compute Service (`ECS`). The returned result indicates that the number of times that the specified system event occurred is 3.
          *
          * @param request DescribeSystemEventCountRequest
          * @return DescribeSystemEventCountResponse
         */
        public async Task<DescribeSystemEventCountResponse> DescribeSystemEventCountAsync(DescribeSystemEventCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSystemEventCountWithOptionsAsync(request, runtime);
        }

        public DescribeSystemEventHistogramResponse DescribeSystemEventHistogramWithOptions(DescribeSystemEventHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeywords))
            {
                query["SearchKeywords"] = request.SearchKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeSystemEventHistogram",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSystemEventHistogramResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSystemEventHistogramResponse> DescribeSystemEventHistogramWithOptionsAsync(DescribeSystemEventHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeywords))
            {
                query["SearchKeywords"] = request.SearchKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeSystemEventHistogram",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSystemEventHistogramResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSystemEventHistogramResponse DescribeSystemEventHistogram(DescribeSystemEventHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSystemEventHistogramWithOptions(request, runtime);
        }

        public async Task<DescribeSystemEventHistogramResponse> DescribeSystemEventHistogramAsync(DescribeSystemEventHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSystemEventHistogramWithOptionsAsync(request, runtime);
        }

        public DescribeSystemEventMetaListResponse DescribeSystemEventMetaListWithOptions(DescribeSystemEventMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSystemEventMetaList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSystemEventMetaListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSystemEventMetaListResponse> DescribeSystemEventMetaListWithOptionsAsync(DescribeSystemEventMetaListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSystemEventMetaList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSystemEventMetaListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSystemEventMetaListResponse DescribeSystemEventMetaList(DescribeSystemEventMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSystemEventMetaListWithOptions(request, runtime);
        }

        public async Task<DescribeSystemEventMetaListResponse> DescribeSystemEventMetaListAsync(DescribeSystemEventMetaListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSystemEventMetaListWithOptionsAsync(request, runtime);
        }

        public DescribeTagKeyListResponse DescribeTagKeyListWithOptions(DescribeTagKeyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeTagKeyList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagKeyListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTagKeyListResponse> DescribeTagKeyListWithOptionsAsync(DescribeTagKeyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeTagKeyList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagKeyListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTagKeyListResponse DescribeTagKeyList(DescribeTagKeyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagKeyListWithOptions(request, runtime);
        }

        public async Task<DescribeTagKeyListResponse> DescribeTagKeyListAsync(DescribeTagKeyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagKeyListWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example of how to query the tag values corresponding to `tagKey1`. The return results are `tagValue1` and `tagValue2`.
          *
          * @param request DescribeTagValueListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeTagValueListResponse
         */
        public DescribeTagValueListResponse DescribeTagValueListWithOptions(DescribeTagValueListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTagValueList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagValueListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example of how to query the tag values corresponding to `tagKey1`. The return results are `tagValue1` and `tagValue2`.
          *
          * @param request DescribeTagValueListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeTagValueListResponse
         */
        public async Task<DescribeTagValueListResponse> DescribeTagValueListWithOptionsAsync(DescribeTagValueListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTagValueList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagValueListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example of how to query the tag values corresponding to `tagKey1`. The return results are `tagValue1` and `tagValue2`.
          *
          * @param request DescribeTagValueListRequest
          * @return DescribeTagValueListResponse
         */
        public DescribeTagValueListResponse DescribeTagValueList(DescribeTagValueListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagValueListWithOptions(request, runtime);
        }

        /**
          * This topic provides an example of how to query the tag values corresponding to `tagKey1`. The return results are `tagValue1` and `tagValue2`.
          *
          * @param request DescribeTagValueListRequest
          * @return DescribeTagValueListResponse
         */
        public async Task<DescribeTagValueListResponse> DescribeTagValueListAsync(DescribeTagValueListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagValueListWithOptionsAsync(request, runtime);
        }

        public DescribeUnhealthyHostAvailabilityResponse DescribeUnhealthyHostAvailabilityWithOptions(DescribeUnhealthyHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUnhealthyHostAvailability",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUnhealthyHostAvailabilityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUnhealthyHostAvailabilityResponse> DescribeUnhealthyHostAvailabilityWithOptionsAsync(DescribeUnhealthyHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUnhealthyHostAvailability",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUnhealthyHostAvailabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUnhealthyHostAvailabilityResponse DescribeUnhealthyHostAvailability(DescribeUnhealthyHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUnhealthyHostAvailabilityWithOptions(request, runtime);
        }

        public async Task<DescribeUnhealthyHostAvailabilityResponse> DescribeUnhealthyHostAvailabilityAsync(DescribeUnhealthyHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUnhealthyHostAvailabilityWithOptionsAsync(request, runtime);
        }

        public DisableActiveMetricRuleResponse DisableActiveMetricRuleWithOptions(DisableActiveMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableActiveMetricRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableActiveMetricRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableActiveMetricRuleResponse> DisableActiveMetricRuleWithOptionsAsync(DisableActiveMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableActiveMetricRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableActiveMetricRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableActiveMetricRuleResponse DisableActiveMetricRule(DisableActiveMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableActiveMetricRuleWithOptions(request, runtime);
        }

        public async Task<DisableActiveMetricRuleResponse> DisableActiveMetricRuleAsync(DisableActiveMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableActiveMetricRuleWithOptionsAsync(request, runtime);
        }

        public DisableEventRulesResponse DisableEventRulesWithOptions(DisableEventRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleNames))
            {
                query["RuleNames"] = request.RuleNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableEventRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableEventRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableEventRulesResponse> DisableEventRulesWithOptionsAsync(DisableEventRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleNames))
            {
                query["RuleNames"] = request.RuleNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableEventRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableEventRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableEventRulesResponse DisableEventRules(DisableEventRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableEventRulesWithOptions(request, runtime);
        }

        public async Task<DisableEventRulesResponse> DisableEventRulesAsync(DisableEventRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableEventRulesWithOptionsAsync(request, runtime);
        }

        public DisableHostAvailabilityResponse DisableHostAvailabilityWithOptions(DisableHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableHostAvailability",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableHostAvailabilityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableHostAvailabilityResponse> DisableHostAvailabilityWithOptionsAsync(DisableHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableHostAvailability",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableHostAvailabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableHostAvailabilityResponse DisableHostAvailability(DisableHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableHostAvailabilityWithOptions(request, runtime);
        }

        public async Task<DisableHostAvailabilityResponse> DisableHostAvailabilityAsync(DisableHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableHostAvailabilityWithOptionsAsync(request, runtime);
        }

        public DisableMetricRulesResponse DisableMetricRulesWithOptions(DisableMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableMetricRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableMetricRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableMetricRulesResponse> DisableMetricRulesWithOptionsAsync(DisableMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableMetricRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableMetricRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableMetricRulesResponse DisableMetricRules(DisableMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableMetricRulesWithOptions(request, runtime);
        }

        public async Task<DisableMetricRulesResponse> DisableMetricRulesAsync(DisableMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableMetricRulesWithOptionsAsync(request, runtime);
        }

        public DisableSiteMonitorsResponse DisableSiteMonitorsWithOptions(DisableSiteMonitorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["TaskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableSiteMonitors",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSiteMonitorsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableSiteMonitorsResponse> DisableSiteMonitorsWithOptionsAsync(DisableSiteMonitorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["TaskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableSiteMonitors",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSiteMonitorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableSiteMonitorsResponse DisableSiteMonitors(DisableSiteMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableSiteMonitorsWithOptions(request, runtime);
        }

        public async Task<DisableSiteMonitorsResponse> DisableSiteMonitorsAsync(DisableSiteMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableSiteMonitorsWithOptionsAsync(request, runtime);
        }

        public EnableActiveMetricRuleResponse EnableActiveMetricRuleWithOptions(EnableActiveMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableActiveMetricRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableActiveMetricRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableActiveMetricRuleResponse> EnableActiveMetricRuleWithOptionsAsync(EnableActiveMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableActiveMetricRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableActiveMetricRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableActiveMetricRuleResponse EnableActiveMetricRule(EnableActiveMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableActiveMetricRuleWithOptions(request, runtime);
        }

        public async Task<EnableActiveMetricRuleResponse> EnableActiveMetricRuleAsync(EnableActiveMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableActiveMetricRuleWithOptionsAsync(request, runtime);
        }

        public EnableEventRulesResponse EnableEventRulesWithOptions(EnableEventRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleNames))
            {
                query["RuleNames"] = request.RuleNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableEventRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableEventRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableEventRulesResponse> EnableEventRulesWithOptionsAsync(EnableEventRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleNames))
            {
                query["RuleNames"] = request.RuleNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableEventRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableEventRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableEventRulesResponse EnableEventRules(EnableEventRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableEventRulesWithOptions(request, runtime);
        }

        public async Task<EnableEventRulesResponse> EnableEventRulesAsync(EnableEventRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableEventRulesWithOptionsAsync(request, runtime);
        }

        public EnableHostAvailabilityResponse EnableHostAvailabilityWithOptions(EnableHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableHostAvailability",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableHostAvailabilityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableHostAvailabilityResponse> EnableHostAvailabilityWithOptionsAsync(EnableHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableHostAvailability",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableHostAvailabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableHostAvailabilityResponse EnableHostAvailability(EnableHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableHostAvailabilityWithOptions(request, runtime);
        }

        public async Task<EnableHostAvailabilityResponse> EnableHostAvailabilityAsync(EnableHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableHostAvailabilityWithOptionsAsync(request, runtime);
        }

        public EnableMetricRuleBlackListResponse EnableMetricRuleBlackListWithOptions(EnableMetricRuleBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnable))
            {
                query["IsEnable"] = request.IsEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableMetricRuleBlackList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableMetricRuleBlackListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableMetricRuleBlackListResponse> EnableMetricRuleBlackListWithOptionsAsync(EnableMetricRuleBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnable))
            {
                query["IsEnable"] = request.IsEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableMetricRuleBlackList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableMetricRuleBlackListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableMetricRuleBlackListResponse EnableMetricRuleBlackList(EnableMetricRuleBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableMetricRuleBlackListWithOptions(request, runtime);
        }

        public async Task<EnableMetricRuleBlackListResponse> EnableMetricRuleBlackListAsync(EnableMetricRuleBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableMetricRuleBlackListWithOptionsAsync(request, runtime);
        }

        public EnableMetricRulesResponse EnableMetricRulesWithOptions(EnableMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableMetricRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableMetricRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableMetricRulesResponse> EnableMetricRulesWithOptionsAsync(EnableMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableMetricRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableMetricRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableMetricRulesResponse EnableMetricRules(EnableMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableMetricRulesWithOptions(request, runtime);
        }

        public async Task<EnableMetricRulesResponse> EnableMetricRulesAsync(EnableMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableMetricRulesWithOptionsAsync(request, runtime);
        }

        public EnableSiteMonitorsResponse EnableSiteMonitorsWithOptions(EnableSiteMonitorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["TaskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSiteMonitors",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSiteMonitorsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableSiteMonitorsResponse> EnableSiteMonitorsWithOptionsAsync(EnableSiteMonitorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["TaskIds"] = request.TaskIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSiteMonitors",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSiteMonitorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableSiteMonitorsResponse EnableSiteMonitors(EnableSiteMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSiteMonitorsWithOptions(request, runtime);
        }

        public async Task<EnableSiteMonitorsResponse> EnableSiteMonitorsAsync(EnableSiteMonitorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSiteMonitorsWithOptionsAsync(request, runtime);
        }

        /**
          * ## Prerequisites
          * The Cloud Assistant client is installed on an ECS instance. For more information about how to install the Cloud Assistant client, see [Overview](~~64601~~).
          *
          * @param request InstallMonitoringAgentRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return InstallMonitoringAgentResponse
         */
        public InstallMonitoringAgentResponse InstallMonitoringAgentWithOptions(InstallMonitoringAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallCommand))
            {
                query["InstallCommand"] = request.InstallCommand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallMonitoringAgent",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallMonitoringAgentResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Prerequisites
          * The Cloud Assistant client is installed on an ECS instance. For more information about how to install the Cloud Assistant client, see [Overview](~~64601~~).
          *
          * @param request InstallMonitoringAgentRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return InstallMonitoringAgentResponse
         */
        public async Task<InstallMonitoringAgentResponse> InstallMonitoringAgentWithOptionsAsync(InstallMonitoringAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallCommand))
            {
                query["InstallCommand"] = request.InstallCommand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallMonitoringAgent",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallMonitoringAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Prerequisites
          * The Cloud Assistant client is installed on an ECS instance. For more information about how to install the Cloud Assistant client, see [Overview](~~64601~~).
          *
          * @param request InstallMonitoringAgentRequest
          * @return InstallMonitoringAgentResponse
         */
        public InstallMonitoringAgentResponse InstallMonitoringAgent(InstallMonitoringAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallMonitoringAgentWithOptions(request, runtime);
        }

        /**
          * ## Prerequisites
          * The Cloud Assistant client is installed on an ECS instance. For more information about how to install the Cloud Assistant client, see [Overview](~~64601~~).
          *
          * @param request InstallMonitoringAgentRequest
          * @return InstallMonitoringAgentResponse
         */
        public async Task<InstallMonitoringAgentResponse> InstallMonitoringAgentAsync(InstallMonitoringAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallMonitoringAgentWithOptionsAsync(request, runtime);
        }

        public ModifyGroupMonitoringAgentProcessResponse ModifyGroupMonitoringAgentProcessWithOptions(ModifyGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfig))
            {
                query["AlertConfig"] = request.AlertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchExpressFilterRelation))
            {
                query["MatchExpressFilterRelation"] = request.MatchExpressFilterRelation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGroupMonitoringAgentProcess",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGroupMonitoringAgentProcessResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyGroupMonitoringAgentProcessResponse> ModifyGroupMonitoringAgentProcessWithOptionsAsync(ModifyGroupMonitoringAgentProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfig))
            {
                query["AlertConfig"] = request.AlertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchExpressFilterRelation))
            {
                query["MatchExpressFilterRelation"] = request.MatchExpressFilterRelation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGroupMonitoringAgentProcess",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGroupMonitoringAgentProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyGroupMonitoringAgentProcessResponse ModifyGroupMonitoringAgentProcess(ModifyGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGroupMonitoringAgentProcessWithOptions(request, runtime);
        }

        public async Task<ModifyGroupMonitoringAgentProcessResponse> ModifyGroupMonitoringAgentProcessAsync(ModifyGroupMonitoringAgentProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGroupMonitoringAgentProcessWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to change the name of an availability monitoring task named `12345` in an application group named `123456` to `task2`.
          *
          * @param request ModifyHostAvailabilityRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyHostAvailabilityResponse
         */
        public ModifyHostAvailabilityResponse ModifyHostAvailabilityWithOptions(ModifyHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfigEscalationList))
            {
                query["AlertConfigEscalationList"] = request.AlertConfigEscalationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfigTargetList))
            {
                query["AlertConfigTargetList"] = request.AlertConfigTargetList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskScope))
            {
                query["TaskScope"] = request.TaskScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfig))
            {
                query["AlertConfig"] = request.AlertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskOption))
            {
                query["TaskOption"] = request.TaskOption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHostAvailability",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHostAvailabilityResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to change the name of an availability monitoring task named `12345` in an application group named `123456` to `task2`.
          *
          * @param request ModifyHostAvailabilityRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyHostAvailabilityResponse
         */
        public async Task<ModifyHostAvailabilityResponse> ModifyHostAvailabilityWithOptionsAsync(ModifyHostAvailabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfigEscalationList))
            {
                query["AlertConfigEscalationList"] = request.AlertConfigEscalationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfigTargetList))
            {
                query["AlertConfigTargetList"] = request.AlertConfigTargetList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskScope))
            {
                query["TaskScope"] = request.TaskScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfig))
            {
                query["AlertConfig"] = request.AlertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskOption))
            {
                query["TaskOption"] = request.TaskOption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHostAvailability",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHostAvailabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to change the name of an availability monitoring task named `12345` in an application group named `123456` to `task2`.
          *
          * @param request ModifyHostAvailabilityRequest
          * @return ModifyHostAvailabilityResponse
         */
        public ModifyHostAvailabilityResponse ModifyHostAvailability(ModifyHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHostAvailabilityWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to change the name of an availability monitoring task named `12345` in an application group named `123456` to `task2`.
          *
          * @param request ModifyHostAvailabilityRequest
          * @return ModifyHostAvailabilityResponse
         */
        public async Task<ModifyHostAvailabilityResponse> ModifyHostAvailabilityAsync(ModifyHostAvailabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHostAvailabilityWithOptionsAsync(request, runtime);
        }

        /**
          * ****
          *
          * @param request ModifyHostInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyHostInfoResponse
         */
        public ModifyHostInfoResponse ModifyHostInfoWithOptions(ModifyHostInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHostInfo",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHostInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ****
          *
          * @param request ModifyHostInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyHostInfoResponse
         */
        public async Task<ModifyHostInfoResponse> ModifyHostInfoWithOptionsAsync(ModifyHostInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHostInfo",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHostInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ****
          *
          * @param request ModifyHostInfoRequest
          * @return ModifyHostInfoResponse
         */
        public ModifyHostInfoResponse ModifyHostInfo(ModifyHostInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHostInfoWithOptions(request, runtime);
        }

        /**
          * ****
          *
          * @param request ModifyHostInfoRequest
          * @return ModifyHostInfoResponse
         */
        public async Task<ModifyHostInfoResponse> ModifyHostInfoAsync(ModifyHostInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHostInfoWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to change the data retention period of the `aliyun` namespace to `cms.s1.2xlarge`. The response shows that the namespace is modified.
          *
          * @param request ModifyHybridMonitorNamespaceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyHybridMonitorNamespaceResponse
         */
        public ModifyHybridMonitorNamespaceResponse ModifyHybridMonitorNamespaceWithOptions(ModifyHybridMonitorNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                query["Spec"] = request.Spec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHybridMonitorNamespace",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHybridMonitorNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to change the data retention period of the `aliyun` namespace to `cms.s1.2xlarge`. The response shows that the namespace is modified.
          *
          * @param request ModifyHybridMonitorNamespaceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyHybridMonitorNamespaceResponse
         */
        public async Task<ModifyHybridMonitorNamespaceResponse> ModifyHybridMonitorNamespaceWithOptionsAsync(ModifyHybridMonitorNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                query["Spec"] = request.Spec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHybridMonitorNamespace",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHybridMonitorNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to change the data retention period of the `aliyun` namespace to `cms.s1.2xlarge`. The response shows that the namespace is modified.
          *
          * @param request ModifyHybridMonitorNamespaceRequest
          * @return ModifyHybridMonitorNamespaceResponse
         */
        public ModifyHybridMonitorNamespaceResponse ModifyHybridMonitorNamespace(ModifyHybridMonitorNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHybridMonitorNamespaceWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to change the data retention period of the `aliyun` namespace to `cms.s1.2xlarge`. The response shows that the namespace is modified.
          *
          * @param request ModifyHybridMonitorNamespaceRequest
          * @return ModifyHybridMonitorNamespaceResponse
         */
        public async Task<ModifyHybridMonitorNamespaceResponse> ModifyHybridMonitorNamespaceAsync(ModifyHybridMonitorNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHybridMonitorNamespaceWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, a Logstore group named `Logstore_test` is modified. The Logstore of the `aliyun-project` project in the `cn-hangzhou` region is changed to `Logstore-aliyun-all`. The response shows that the Logstore group is modified.
          *
          * @param request ModifyHybridMonitorSLSGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyHybridMonitorSLSGroupResponse
         */
        public ModifyHybridMonitorSLSGroupResponse ModifyHybridMonitorSLSGroupWithOptions(ModifyHybridMonitorSLSGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupConfig))
            {
                query["SLSGroupConfig"] = request.SLSGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupDescription))
            {
                query["SLSGroupDescription"] = request.SLSGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupName))
            {
                query["SLSGroupName"] = request.SLSGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHybridMonitorSLSGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHybridMonitorSLSGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
          * In this example, a Logstore group named `Logstore_test` is modified. The Logstore of the `aliyun-project` project in the `cn-hangzhou` region is changed to `Logstore-aliyun-all`. The response shows that the Logstore group is modified.
          *
          * @param request ModifyHybridMonitorSLSGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyHybridMonitorSLSGroupResponse
         */
        public async Task<ModifyHybridMonitorSLSGroupResponse> ModifyHybridMonitorSLSGroupWithOptionsAsync(ModifyHybridMonitorSLSGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupConfig))
            {
                query["SLSGroupConfig"] = request.SLSGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupDescription))
            {
                query["SLSGroupDescription"] = request.SLSGroupDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSGroupName))
            {
                query["SLSGroupName"] = request.SLSGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHybridMonitorSLSGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHybridMonitorSLSGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * In this example, a Logstore group named `Logstore_test` is modified. The Logstore of the `aliyun-project` project in the `cn-hangzhou` region is changed to `Logstore-aliyun-all`. The response shows that the Logstore group is modified.
          *
          * @param request ModifyHybridMonitorSLSGroupRequest
          * @return ModifyHybridMonitorSLSGroupResponse
         */
        public ModifyHybridMonitorSLSGroupResponse ModifyHybridMonitorSLSGroup(ModifyHybridMonitorSLSGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHybridMonitorSLSGroupWithOptions(request, runtime);
        }

        /**
          * In this example, a Logstore group named `Logstore_test` is modified. The Logstore of the `aliyun-project` project in the `cn-hangzhou` region is changed to `Logstore-aliyun-all`. The response shows that the Logstore group is modified.
          *
          * @param request ModifyHybridMonitorSLSGroupRequest
          * @return ModifyHybridMonitorSLSGroupResponse
         */
        public async Task<ModifyHybridMonitorSLSGroupResponse> ModifyHybridMonitorSLSGroupAsync(ModifyHybridMonitorSLSGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHybridMonitorSLSGroupWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to change the collection period of a metric import task whose ID is `36****` to `15` seconds. The task is used to monitor the logs that are imported from Log Service. The returned result indicates that the metric is modified.
          *
          * @param request ModifyHybridMonitorTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyHybridMonitorTaskResponse
         */
        public ModifyHybridMonitorTaskResponse ModifyHybridMonitorTaskWithOptions(ModifyHybridMonitorTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachLabels))
            {
                query["AttachLabels"] = request.AttachLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectInterval))
            {
                query["CollectInterval"] = request.CollectInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSProcessConfig))
            {
                query["SLSProcessConfig"] = request.SLSProcessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHybridMonitorTask",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHybridMonitorTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to change the collection period of a metric import task whose ID is `36****` to `15` seconds. The task is used to monitor the logs that are imported from Log Service. The returned result indicates that the metric is modified.
          *
          * @param request ModifyHybridMonitorTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyHybridMonitorTaskResponse
         */
        public async Task<ModifyHybridMonitorTaskResponse> ModifyHybridMonitorTaskWithOptionsAsync(ModifyHybridMonitorTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachLabels))
            {
                query["AttachLabels"] = request.AttachLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectInterval))
            {
                query["CollectInterval"] = request.CollectInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SLSProcessConfig))
            {
                query["SLSProcessConfig"] = request.SLSProcessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHybridMonitorTask",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHybridMonitorTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to change the collection period of a metric import task whose ID is `36****` to `15` seconds. The task is used to monitor the logs that are imported from Log Service. The returned result indicates that the metric is modified.
          *
          * @param request ModifyHybridMonitorTaskRequest
          * @return ModifyHybridMonitorTaskResponse
         */
        public ModifyHybridMonitorTaskResponse ModifyHybridMonitorTask(ModifyHybridMonitorTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHybridMonitorTaskWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to change the collection period of a metric import task whose ID is `36****` to `15` seconds. The task is used to monitor the logs that are imported from Log Service. The returned result indicates that the metric is modified.
          *
          * @param request ModifyHybridMonitorTaskRequest
          * @return ModifyHybridMonitorTaskResponse
         */
        public async Task<ModifyHybridMonitorTaskResponse> ModifyHybridMonitorTaskAsync(ModifyHybridMonitorTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHybridMonitorTaskWithOptionsAsync(request, runtime);
        }

        public ModifyMetricRuleBlackListResponse ModifyMetricRuleBlackListWithOptions(ModifyMetricRuleBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                query["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEndTime))
            {
                query["EnableEndTime"] = request.EnableEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStartTime))
            {
                query["EnableStartTime"] = request.EnableStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["Instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                query["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                query["ScopeType"] = request.ScopeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeValue))
            {
                query["ScopeValue"] = request.ScopeValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMetricRuleBlackList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMetricRuleBlackListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyMetricRuleBlackListResponse> ModifyMetricRuleBlackListWithOptionsAsync(ModifyMetricRuleBlackListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                query["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEndTime))
            {
                query["EnableEndTime"] = request.EnableEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStartTime))
            {
                query["EnableStartTime"] = request.EnableStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["Instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                query["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                query["ScopeType"] = request.ScopeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeValue))
            {
                query["ScopeValue"] = request.ScopeValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMetricRuleBlackList",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMetricRuleBlackListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyMetricRuleBlackListResponse ModifyMetricRuleBlackList(ModifyMetricRuleBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMetricRuleBlackListWithOptions(request, runtime);
        }

        public async Task<ModifyMetricRuleBlackListResponse> ModifyMetricRuleBlackListAsync(ModifyMetricRuleBlackListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMetricRuleBlackListWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to modify an alert template whose version is `1` and ID is `123456`. The alert level is changed to `Critical`. The statistical method is changed to `Average`. The alert threshold comparator is changed to `GreaterThanOrEqualToThreshold`. The alert threshold is changed to `90`. The number of alert retries is changed to `3`. The response shows that the alert template is modified.
          *
          * @param request ModifyMetricRuleTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyMetricRuleTemplateResponse
         */
        public ModifyMetricRuleTemplateResponse ModifyMetricRuleTemplateWithOptions(ModifyMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTemplates))
            {
                query["AlertTemplates"] = request.AlertTemplates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestVersion))
            {
                query["RestVersion"] = request.RestVersion;
            }
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
                Action = "ModifyMetricRuleTemplate",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMetricRuleTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to modify an alert template whose version is `1` and ID is `123456`. The alert level is changed to `Critical`. The statistical method is changed to `Average`. The alert threshold comparator is changed to `GreaterThanOrEqualToThreshold`. The alert threshold is changed to `90`. The number of alert retries is changed to `3`. The response shows that the alert template is modified.
          *
          * @param request ModifyMetricRuleTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyMetricRuleTemplateResponse
         */
        public async Task<ModifyMetricRuleTemplateResponse> ModifyMetricRuleTemplateWithOptionsAsync(ModifyMetricRuleTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTemplates))
            {
                query["AlertTemplates"] = request.AlertTemplates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestVersion))
            {
                query["RestVersion"] = request.RestVersion;
            }
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
                Action = "ModifyMetricRuleTemplate",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMetricRuleTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to modify an alert template whose version is `1` and ID is `123456`. The alert level is changed to `Critical`. The statistical method is changed to `Average`. The alert threshold comparator is changed to `GreaterThanOrEqualToThreshold`. The alert threshold is changed to `90`. The number of alert retries is changed to `3`. The response shows that the alert template is modified.
          *
          * @param request ModifyMetricRuleTemplateRequest
          * @return ModifyMetricRuleTemplateResponse
         */
        public ModifyMetricRuleTemplateResponse ModifyMetricRuleTemplate(ModifyMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMetricRuleTemplateWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to modify an alert template whose version is `1` and ID is `123456`. The alert level is changed to `Critical`. The statistical method is changed to `Average`. The alert threshold comparator is changed to `GreaterThanOrEqualToThreshold`. The alert threshold is changed to `90`. The number of alert retries is changed to `3`. The response shows that the alert template is modified.
          *
          * @param request ModifyMetricRuleTemplateRequest
          * @return ModifyMetricRuleTemplateResponse
         */
        public async Task<ModifyMetricRuleTemplateResponse> ModifyMetricRuleTemplateAsync(ModifyMetricRuleTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMetricRuleTemplateWithOptionsAsync(request, runtime);
        }

        public ModifyMonitorGroupResponse ModifyMonitorGroupWithOptions(ModifyMonitorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroups))
            {
                query["ContactGroups"] = request.ContactGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMonitorGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMonitorGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyMonitorGroupResponse> ModifyMonitorGroupWithOptionsAsync(ModifyMonitorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroups))
            {
                query["ContactGroups"] = request.ContactGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMonitorGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMonitorGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyMonitorGroupResponse ModifyMonitorGroup(ModifyMonitorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMonitorGroupWithOptions(request, runtime);
        }

        public async Task<ModifyMonitorGroupResponse> ModifyMonitorGroupAsync(ModifyMonitorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMonitorGroupWithOptionsAsync(request, runtime);
        }

        public ModifyMonitorGroupInstancesResponse ModifyMonitorGroupInstancesWithOptions(ModifyMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["Instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMonitorGroupInstances",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMonitorGroupInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyMonitorGroupInstancesResponse> ModifyMonitorGroupInstancesWithOptionsAsync(ModifyMonitorGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["Instances"] = request.Instances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMonitorGroupInstances",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMonitorGroupInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyMonitorGroupInstancesResponse ModifyMonitorGroupInstances(ModifyMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMonitorGroupInstancesWithOptions(request, runtime);
        }

        public async Task<ModifyMonitorGroupInstancesResponse> ModifyMonitorGroupInstancesAsync(ModifyMonitorGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMonitorGroupInstancesWithOptionsAsync(request, runtime);
        }

        /**
          * The number of site monitoring tasks.
          *
          * @param request ModifySiteMonitorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifySiteMonitorResponse
         */
        public ModifySiteMonitorResponse ModifySiteMonitorWithOptions(ModifySiteMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertIds))
            {
                query["AlertIds"] = request.AlertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSchedule))
            {
                query["CustomSchedule"] = request.CustomSchedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntervalUnit))
            {
                query["IntervalUnit"] = request.IntervalUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCities))
            {
                query["IspCities"] = request.IspCities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsJson))
            {
                query["OptionsJson"] = request.OptionsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySiteMonitor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySiteMonitorResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The number of site monitoring tasks.
          *
          * @param request ModifySiteMonitorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifySiteMonitorResponse
         */
        public async Task<ModifySiteMonitorResponse> ModifySiteMonitorWithOptionsAsync(ModifySiteMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertIds))
            {
                query["AlertIds"] = request.AlertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSchedule))
            {
                query["CustomSchedule"] = request.CustomSchedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntervalUnit))
            {
                query["IntervalUnit"] = request.IntervalUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCities))
            {
                query["IspCities"] = request.IspCities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsJson))
            {
                query["OptionsJson"] = request.OptionsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySiteMonitor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySiteMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The number of site monitoring tasks.
          *
          * @param request ModifySiteMonitorRequest
          * @return ModifySiteMonitorResponse
         */
        public ModifySiteMonitorResponse ModifySiteMonitor(ModifySiteMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySiteMonitorWithOptions(request, runtime);
        }

        /**
          * The number of site monitoring tasks.
          *
          * @param request ModifySiteMonitorRequest
          * @return ModifySiteMonitorResponse
         */
        public async Task<ModifySiteMonitorResponse> ModifySiteMonitorAsync(ModifySiteMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySiteMonitorWithOptionsAsync(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request OpenCmsServiceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OpenCmsServiceResponse
         */
        // Deprecated
        public OpenCmsServiceResponse OpenCmsServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenCmsService",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenCmsServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @param request OpenCmsServiceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OpenCmsServiceResponse
         */
        // Deprecated
        public async Task<OpenCmsServiceResponse> OpenCmsServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenCmsService",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenCmsServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @return OpenCmsServiceResponse
         */
        // Deprecated
        public OpenCmsServiceResponse OpenCmsService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenCmsServiceWithOptions(runtime);
        }

        /**
          * @deprecated
          *
          * @return OpenCmsServiceResponse
         */
        // Deprecated
        public async Task<OpenCmsServiceResponse> OpenCmsServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenCmsServiceWithOptionsAsync(runtime);
        }

        public PutContactResponse PutContactWithOptions(PutContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Describe))
            {
                query["Describe"] = request.Describe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channels))
            {
                query["Channels"] = request.Channels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutContact",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutContactResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutContactResponse> PutContactWithOptionsAsync(PutContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Describe))
            {
                query["Describe"] = request.Describe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channels))
            {
                query["Channels"] = request.Channels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutContact",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutContactResponse PutContact(PutContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutContactWithOptions(request, runtime);
        }

        public async Task<PutContactResponse> PutContactAsync(PutContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutContactWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to create an alert contact group named `ECS_Group`.
          *
          * @param request PutContactGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutContactGroupResponse
         */
        public PutContactGroupResponse PutContactGroupWithOptions(PutContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupName))
            {
                query["ContactGroupName"] = request.ContactGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNames))
            {
                query["ContactNames"] = request.ContactNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Describe))
            {
                query["Describe"] = request.Describe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSubscribed))
            {
                query["EnableSubscribed"] = request.EnableSubscribed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutContactGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutContactGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create an alert contact group named `ECS_Group`.
          *
          * @param request PutContactGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutContactGroupResponse
         */
        public async Task<PutContactGroupResponse> PutContactGroupWithOptionsAsync(PutContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupName))
            {
                query["ContactGroupName"] = request.ContactGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactNames))
            {
                query["ContactNames"] = request.ContactNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Describe))
            {
                query["Describe"] = request.Describe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSubscribed))
            {
                query["EnableSubscribed"] = request.EnableSubscribed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutContactGroup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutContactGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create an alert contact group named `ECS_Group`.
          *
          * @param request PutContactGroupRequest
          * @return PutContactGroupResponse
         */
        public PutContactGroupResponse PutContactGroup(PutContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutContactGroupWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to create an alert contact group named `ECS_Group`.
          *
          * @param request PutContactGroupRequest
          * @return PutContactGroupResponse
         */
        public async Task<PutContactGroupResponse> PutContactGroupAsync(PutContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutContactGroupWithOptionsAsync(request, runtime);
        }

        public PutCustomEventResponse PutCustomEventWithOptions(PutCustomEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventInfo))
            {
                query["EventInfo"] = request.EventInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutCustomEvent",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutCustomEventResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutCustomEventResponse> PutCustomEventWithOptionsAsync(PutCustomEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventInfo))
            {
                query["EventInfo"] = request.EventInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutCustomEvent",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutCustomEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutCustomEventResponse PutCustomEvent(PutCustomEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutCustomEventWithOptions(request, runtime);
        }

        public async Task<PutCustomEventResponse> PutCustomEventAsync(PutCustomEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutCustomEventWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, call the PutCustomEvent operation to report the monitoring data of the custom event. For more information, see [PutCustomEvent](~~115012~~).
          *
          * @param request PutCustomEventRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutCustomEventRuleResponse
         */
        public PutCustomEventRuleResponse PutCustomEventRuleWithOptions(PutCustomEventRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroups))
            {
                query["ContactGroups"] = request.ContactGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveInterval))
            {
                query["EffectiveInterval"] = request.EffectiveInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailSubject))
            {
                query["EmailSubject"] = request.EmailSubject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Webhook))
            {
                query["Webhook"] = request.Webhook;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutCustomEventRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutCustomEventRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, call the PutCustomEvent operation to report the monitoring data of the custom event. For more information, see [PutCustomEvent](~~115012~~).
          *
          * @param request PutCustomEventRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutCustomEventRuleResponse
         */
        public async Task<PutCustomEventRuleResponse> PutCustomEventRuleWithOptionsAsync(PutCustomEventRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroups))
            {
                query["ContactGroups"] = request.ContactGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveInterval))
            {
                query["EffectiveInterval"] = request.EffectiveInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailSubject))
            {
                query["EmailSubject"] = request.EmailSubject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Webhook))
            {
                query["Webhook"] = request.Webhook;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutCustomEventRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutCustomEventRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, call the PutCustomEvent operation to report the monitoring data of the custom event. For more information, see [PutCustomEvent](~~115012~~).
          *
          * @param request PutCustomEventRuleRequest
          * @return PutCustomEventRuleResponse
         */
        public PutCustomEventRuleResponse PutCustomEventRule(PutCustomEventRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutCustomEventRuleWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, call the PutCustomEvent operation to report the monitoring data of the custom event. For more information, see [PutCustomEvent](~~115012~~).
          *
          * @param request PutCustomEventRuleRequest
          * @return PutCustomEventRuleResponse
         */
        public async Task<PutCustomEventRuleResponse> PutCustomEventRuleAsync(PutCustomEventRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutCustomEventRuleWithOptionsAsync(request, runtime);
        }

        /**
          * >  We recommend that you call the [PutHybridMonitorMetricData](~~383455~~) operation of Hybrid Cloud Monitoring to report monitoring data.
          *
          * @param request PutCustomMetricRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutCustomMetricResponse
         */
        public PutCustomMetricResponse PutCustomMetricWithOptions(PutCustomMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricList))
            {
                query["MetricList"] = request.MetricList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutCustomMetric",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutCustomMetricResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  We recommend that you call the [PutHybridMonitorMetricData](~~383455~~) operation of Hybrid Cloud Monitoring to report monitoring data.
          *
          * @param request PutCustomMetricRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutCustomMetricResponse
         */
        public async Task<PutCustomMetricResponse> PutCustomMetricWithOptionsAsync(PutCustomMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricList))
            {
                query["MetricList"] = request.MetricList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutCustomMetric",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutCustomMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  We recommend that you call the [PutHybridMonitorMetricData](~~383455~~) operation of Hybrid Cloud Monitoring to report monitoring data.
          *
          * @param request PutCustomMetricRequest
          * @return PutCustomMetricResponse
         */
        public PutCustomMetricResponse PutCustomMetric(PutCustomMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutCustomMetricWithOptions(request, runtime);
        }

        /**
          * >  We recommend that you call the [PutHybridMonitorMetricData](~~383455~~) operation of Hybrid Cloud Monitoring to report monitoring data.
          *
          * @param request PutCustomMetricRequest
          * @return PutCustomMetricResponse
         */
        public async Task<PutCustomMetricResponse> PutCustomMetricAsync(PutCustomMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutCustomMetricWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, call the PutCustomMetric operation to report custom monitoring data. For more information, see [PutCustomMetric](~~115004~~).
          *
          * @param request PutCustomMetricRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutCustomMetricRuleResponse
         */
        public PutCustomMetricRuleResponse PutCustomMetricRuleWithOptions(PutCustomMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparisonOperator))
            {
                query["ComparisonOperator"] = request.ComparisonOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroups))
            {
                query["ContactGroups"] = request.ContactGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveInterval))
            {
                query["EffectiveInterval"] = request.EffectiveInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailSubject))
            {
                query["EmailSubject"] = request.EmailSubject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SilenceTime))
            {
                query["SilenceTime"] = request.SilenceTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statistics))
            {
                query["Statistics"] = request.Statistics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Webhook))
            {
                query["Webhook"] = request.Webhook;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutCustomMetricRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutCustomMetricRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, call the PutCustomMetric operation to report custom monitoring data. For more information, see [PutCustomMetric](~~115004~~).
          *
          * @param request PutCustomMetricRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutCustomMetricRuleResponse
         */
        public async Task<PutCustomMetricRuleResponse> PutCustomMetricRuleWithOptionsAsync(PutCustomMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparisonOperator))
            {
                query["ComparisonOperator"] = request.ComparisonOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroups))
            {
                query["ContactGroups"] = request.ContactGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveInterval))
            {
                query["EffectiveInterval"] = request.EffectiveInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailSubject))
            {
                query["EmailSubject"] = request.EmailSubject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SilenceTime))
            {
                query["SilenceTime"] = request.SilenceTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statistics))
            {
                query["Statistics"] = request.Statistics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Webhook))
            {
                query["Webhook"] = request.Webhook;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutCustomMetricRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutCustomMetricRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, call the PutCustomMetric operation to report custom monitoring data. For more information, see [PutCustomMetric](~~115004~~).
          *
          * @param request PutCustomMetricRuleRequest
          * @return PutCustomMetricRuleResponse
         */
        public PutCustomMetricRuleResponse PutCustomMetricRule(PutCustomMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutCustomMetricRuleWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, call the PutCustomMetric operation to report custom monitoring data. For more information, see [PutCustomMetric](~~115004~~).
          *
          * @param request PutCustomMetricRuleRequest
          * @return PutCustomMetricRuleResponse
         */
        public async Task<PutCustomMetricRuleResponse> PutCustomMetricRuleAsync(PutCustomMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutCustomMetricRuleWithOptionsAsync(request, runtime);
        }

        /**
          * If the specified rule name does not exist, an event-triggered alert rule is created. If the specified rule name exists, the specified event-triggered alert rule is modified.
          * In this example, the `myRuleName` alert rule is created for the `ecs` cloud service.
          *
          * @param request PutEventRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutEventRuleResponse
         */
        public PutEventRuleResponse PutEventRuleWithOptions(PutEventRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventPattern))
            {
                query["EventPattern"] = request.EventPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SilenceTime))
            {
                query["SilenceTime"] = request.SilenceTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEventRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEventRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If the specified rule name does not exist, an event-triggered alert rule is created. If the specified rule name exists, the specified event-triggered alert rule is modified.
          * In this example, the `myRuleName` alert rule is created for the `ecs` cloud service.
          *
          * @param request PutEventRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutEventRuleResponse
         */
        public async Task<PutEventRuleResponse> PutEventRuleWithOptionsAsync(PutEventRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventPattern))
            {
                query["EventPattern"] = request.EventPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SilenceTime))
            {
                query["SilenceTime"] = request.SilenceTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEventRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEventRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If the specified rule name does not exist, an event-triggered alert rule is created. If the specified rule name exists, the specified event-triggered alert rule is modified.
          * In this example, the `myRuleName` alert rule is created for the `ecs` cloud service.
          *
          * @param request PutEventRuleRequest
          * @return PutEventRuleResponse
         */
        public PutEventRuleResponse PutEventRule(PutEventRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutEventRuleWithOptions(request, runtime);
        }

        /**
          * If the specified rule name does not exist, an event-triggered alert rule is created. If the specified rule name exists, the specified event-triggered alert rule is modified.
          * In this example, the `myRuleName` alert rule is created for the `ecs` cloud service.
          *
          * @param request PutEventRuleRequest
          * @return PutEventRuleResponse
         */
        public async Task<PutEventRuleResponse> PutEventRuleAsync(PutEventRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutEventRuleWithOptionsAsync(request, runtime);
        }

        public PutEventRuleTargetsResponse PutEventRuleTargetsWithOptions(PutEventRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactParameters))
            {
                query["ContactParameters"] = request.ContactParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FcParameters))
            {
                query["FcParameters"] = request.FcParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MnsParameters))
            {
                query["MnsParameters"] = request.MnsParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenApiParameters))
            {
                query["OpenApiParameters"] = request.OpenApiParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsParameters))
            {
                query["SlsParameters"] = request.SlsParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookParameters))
            {
                query["WebhookParameters"] = request.WebhookParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEventRuleTargets",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEventRuleTargetsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutEventRuleTargetsResponse> PutEventRuleTargetsWithOptionsAsync(PutEventRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactParameters))
            {
                query["ContactParameters"] = request.ContactParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FcParameters))
            {
                query["FcParameters"] = request.FcParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MnsParameters))
            {
                query["MnsParameters"] = request.MnsParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenApiParameters))
            {
                query["OpenApiParameters"] = request.OpenApiParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsParameters))
            {
                query["SlsParameters"] = request.SlsParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebhookParameters))
            {
                query["WebhookParameters"] = request.WebhookParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEventRuleTargets",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEventRuleTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutEventRuleTargetsResponse PutEventRuleTargets(PutEventRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutEventRuleTargetsWithOptions(request, runtime);
        }

        public async Task<PutEventRuleTargetsResponse> PutEventRuleTargetsAsync(PutEventRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutEventRuleTargetsWithOptionsAsync(request, runtime);
        }

        /**
          * > The monitoring data can be exported only to Log Service. More services will be supported in the future.
          *
          * @param request PutExporterOutputRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutExporterOutputResponse
         */
        public PutExporterOutputResponse PutExporterOutputWithOptions(PutExporterOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigJson))
            {
                query["ConfigJson"] = request.ConfigJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                query["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestName))
            {
                query["DestName"] = request.DestName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestType))
            {
                query["DestType"] = request.DestType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutExporterOutput",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutExporterOutputResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > The monitoring data can be exported only to Log Service. More services will be supported in the future.
          *
          * @param request PutExporterOutputRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutExporterOutputResponse
         */
        public async Task<PutExporterOutputResponse> PutExporterOutputWithOptionsAsync(PutExporterOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigJson))
            {
                query["ConfigJson"] = request.ConfigJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                query["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestName))
            {
                query["DestName"] = request.DestName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestType))
            {
                query["DestType"] = request.DestType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutExporterOutput",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutExporterOutputResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > The monitoring data can be exported only to Log Service. More services will be supported in the future.
          *
          * @param request PutExporterOutputRequest
          * @return PutExporterOutputResponse
         */
        public PutExporterOutputResponse PutExporterOutput(PutExporterOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutExporterOutputWithOptions(request, runtime);
        }

        /**
          * > The monitoring data can be exported only to Log Service. More services will be supported in the future.
          *
          * @param request PutExporterOutputRequest
          * @return PutExporterOutputResponse
         */
        public async Task<PutExporterOutputResponse> PutExporterOutputAsync(PutExporterOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutExporterOutputWithOptionsAsync(request, runtime);
        }

        public PutExporterRuleResponse PutExporterRuleWithOptions(PutExporterRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Describe))
            {
                query["Describe"] = request.Describe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstNames))
            {
                query["DstNames"] = request.DstNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetWindows))
            {
                query["TargetWindows"] = request.TargetWindows;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutExporterRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutExporterRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutExporterRuleResponse> PutExporterRuleWithOptionsAsync(PutExporterRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Describe))
            {
                query["Describe"] = request.Describe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstNames))
            {
                query["DstNames"] = request.DstNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetWindows))
            {
                query["TargetWindows"] = request.TargetWindows;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutExporterRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutExporterRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutExporterRuleResponse PutExporterRule(PutExporterRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutExporterRuleWithOptions(request, runtime);
        }

        public async Task<PutExporterRuleResponse> PutExporterRuleAsync(PutExporterRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutExporterRuleWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to create an alert rule for the `cpu_total` metric of Elastic Compute Service (ECS) in the `17285****` application group. The ID of the alert rule is `123456`. The name of the alert rule is `Rule_test`. The alert level is `Critical`. The statistical method is `Average`. The alert threshold comparator is `GreaterThanOrEqualToThreshold`. The alert threshold is `90`. The number of alert retries is `3`. The returned result shows that the alert rule is created and the alert rule ID is `123456`.
          *
          * @param request PutGroupMetricRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutGroupMetricRuleResponse
         */
        public PutGroupMetricRuleResponse PutGroupMetricRuleWithOptions(PutGroupMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroups))
            {
                query["ContactGroups"] = request.ContactGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveInterval))
            {
                query["EffectiveInterval"] = request.EffectiveInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailSubject))
            {
                query["EmailSubject"] = request.EmailSubject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraDimensionJson))
            {
                query["ExtraDimensionJson"] = request.ExtraDimensionJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoDataPolicy))
            {
                query["NoDataPolicy"] = request.NoDataPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoEffectiveInterval))
            {
                query["NoEffectiveInterval"] = request.NoEffectiveInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                query["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SilenceTime))
            {
                query["SilenceTime"] = request.SilenceTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Webhook))
            {
                query["Webhook"] = request.Webhook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Escalations))
            {
                query["Escalations"] = request.Escalations;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutGroupMetricRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutGroupMetricRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create an alert rule for the `cpu_total` metric of Elastic Compute Service (ECS) in the `17285****` application group. The ID of the alert rule is `123456`. The name of the alert rule is `Rule_test`. The alert level is `Critical`. The statistical method is `Average`. The alert threshold comparator is `GreaterThanOrEqualToThreshold`. The alert threshold is `90`. The number of alert retries is `3`. The returned result shows that the alert rule is created and the alert rule ID is `123456`.
          *
          * @param request PutGroupMetricRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutGroupMetricRuleResponse
         */
        public async Task<PutGroupMetricRuleResponse> PutGroupMetricRuleWithOptionsAsync(PutGroupMetricRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroups))
            {
                query["ContactGroups"] = request.ContactGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveInterval))
            {
                query["EffectiveInterval"] = request.EffectiveInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailSubject))
            {
                query["EmailSubject"] = request.EmailSubject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraDimensionJson))
            {
                query["ExtraDimensionJson"] = request.ExtraDimensionJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoDataPolicy))
            {
                query["NoDataPolicy"] = request.NoDataPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoEffectiveInterval))
            {
                query["NoEffectiveInterval"] = request.NoEffectiveInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                query["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SilenceTime))
            {
                query["SilenceTime"] = request.SilenceTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Webhook))
            {
                query["Webhook"] = request.Webhook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Escalations))
            {
                query["Escalations"] = request.Escalations;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutGroupMetricRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutGroupMetricRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create an alert rule for the `cpu_total` metric of Elastic Compute Service (ECS) in the `17285****` application group. The ID of the alert rule is `123456`. The name of the alert rule is `Rule_test`. The alert level is `Critical`. The statistical method is `Average`. The alert threshold comparator is `GreaterThanOrEqualToThreshold`. The alert threshold is `90`. The number of alert retries is `3`. The returned result shows that the alert rule is created and the alert rule ID is `123456`.
          *
          * @param request PutGroupMetricRuleRequest
          * @return PutGroupMetricRuleResponse
         */
        public PutGroupMetricRuleResponse PutGroupMetricRule(PutGroupMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutGroupMetricRuleWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to create an alert rule for the `cpu_total` metric of Elastic Compute Service (ECS) in the `17285****` application group. The ID of the alert rule is `123456`. The name of the alert rule is `Rule_test`. The alert level is `Critical`. The statistical method is `Average`. The alert threshold comparator is `GreaterThanOrEqualToThreshold`. The alert threshold is `90`. The number of alert retries is `3`. The returned result shows that the alert rule is created and the alert rule ID is `123456`.
          *
          * @param request PutGroupMetricRuleRequest
          * @return PutGroupMetricRuleResponse
         */
        public async Task<PutGroupMetricRuleResponse> PutGroupMetricRuleAsync(PutGroupMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutGroupMetricRuleWithOptionsAsync(request, runtime);
        }

        /**
          * # [](#)Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          * # [](#)Limits
          * The size of the monitoring data that you import at a time must be less than or equal to 1 MB.
          * # [](#)Description
          * This topic provides an example on how to import the monitoring data of the `CPU_Usage` metric to the `default-aliyun` namespace of Hybrid Cloud Monitoring.
          *
          * @param request PutHybridMonitorMetricDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutHybridMonitorMetricDataResponse
         */
        public PutHybridMonitorMetricDataResponse PutHybridMonitorMetricDataWithOptions(PutHybridMonitorMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricList))
            {
                query["MetricList"] = request.MetricList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutHybridMonitorMetricData",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutHybridMonitorMetricDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * # [](#)Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          * # [](#)Limits
          * The size of the monitoring data that you import at a time must be less than or equal to 1 MB.
          * # [](#)Description
          * This topic provides an example on how to import the monitoring data of the `CPU_Usage` metric to the `default-aliyun` namespace of Hybrid Cloud Monitoring.
          *
          * @param request PutHybridMonitorMetricDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutHybridMonitorMetricDataResponse
         */
        public async Task<PutHybridMonitorMetricDataResponse> PutHybridMonitorMetricDataWithOptionsAsync(PutHybridMonitorMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricList))
            {
                query["MetricList"] = request.MetricList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutHybridMonitorMetricData",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutHybridMonitorMetricDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * # [](#)Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          * # [](#)Limits
          * The size of the monitoring data that you import at a time must be less than or equal to 1 MB.
          * # [](#)Description
          * This topic provides an example on how to import the monitoring data of the `CPU_Usage` metric to the `default-aliyun` namespace of Hybrid Cloud Monitoring.
          *
          * @param request PutHybridMonitorMetricDataRequest
          * @return PutHybridMonitorMetricDataResponse
         */
        public PutHybridMonitorMetricDataResponse PutHybridMonitorMetricData(PutHybridMonitorMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutHybridMonitorMetricDataWithOptions(request, runtime);
        }

        /**
          * # [](#)Prerequisites
          * Hybrid Cloud Monitoring is activated. For more information, see [Activate Hybrid Cloud Monitoring](~~250773~~).
          * # [](#)Limits
          * The size of the monitoring data that you import at a time must be less than or equal to 1 MB.
          * # [](#)Description
          * This topic provides an example on how to import the monitoring data of the `CPU_Usage` metric to the `default-aliyun` namespace of Hybrid Cloud Monitoring.
          *
          * @param request PutHybridMonitorMetricDataRequest
          * @return PutHybridMonitorMetricDataResponse
         */
        public async Task<PutHybridMonitorMetricDataResponse> PutHybridMonitorMetricDataAsync(PutHybridMonitorMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutHybridMonitorMetricDataWithOptionsAsync(request, runtime);
        }

        /**
          * In the example of this topic, the `cpu_total` log monitoring metric is created. The response shows that the log monitoring metric is created and the metric ID is `16****`.
          *
          * @param request PutLogMonitorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutLogMonitorResponse
         */
        public PutLogMonitorResponse PutLogMonitorWithOptions(PutLogMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aggregates))
            {
                query["Aggregates"] = request.Aggregates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Groupbys))
            {
                query["Groupbys"] = request.Groupbys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogId))
            {
                query["LogId"] = request.LogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricExpress))
            {
                query["MetricExpress"] = request.MetricExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsLogstore))
            {
                query["SlsLogstore"] = request.SlsLogstore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProject))
            {
                query["SlsProject"] = request.SlsProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsRegionId))
            {
                query["SlsRegionId"] = request.SlsRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tumblingwindows))
            {
                query["Tumblingwindows"] = request.Tumblingwindows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unit))
            {
                query["Unit"] = request.Unit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueFilter))
            {
                query["ValueFilter"] = request.ValueFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueFilterRelation))
            {
                query["ValueFilterRelation"] = request.ValueFilterRelation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutLogMonitor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutLogMonitorResponse>(CallApi(params_, req, runtime));
        }

        /**
          * In the example of this topic, the `cpu_total` log monitoring metric is created. The response shows that the log monitoring metric is created and the metric ID is `16****`.
          *
          * @param request PutLogMonitorRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutLogMonitorResponse
         */
        public async Task<PutLogMonitorResponse> PutLogMonitorWithOptionsAsync(PutLogMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aggregates))
            {
                query["Aggregates"] = request.Aggregates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Groupbys))
            {
                query["Groupbys"] = request.Groupbys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogId))
            {
                query["LogId"] = request.LogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricExpress))
            {
                query["MetricExpress"] = request.MetricExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsLogstore))
            {
                query["SlsLogstore"] = request.SlsLogstore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProject))
            {
                query["SlsProject"] = request.SlsProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsRegionId))
            {
                query["SlsRegionId"] = request.SlsRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tumblingwindows))
            {
                query["Tumblingwindows"] = request.Tumblingwindows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unit))
            {
                query["Unit"] = request.Unit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueFilter))
            {
                query["ValueFilter"] = request.ValueFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueFilterRelation))
            {
                query["ValueFilterRelation"] = request.ValueFilterRelation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutLogMonitor",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutLogMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * In the example of this topic, the `cpu_total` log monitoring metric is created. The response shows that the log monitoring metric is created and the metric ID is `16****`.
          *
          * @param request PutLogMonitorRequest
          * @return PutLogMonitorResponse
         */
        public PutLogMonitorResponse PutLogMonitor(PutLogMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutLogMonitorWithOptions(request, runtime);
        }

        /**
          * In the example of this topic, the `cpu_total` log monitoring metric is created. The response shows that the log monitoring metric is created and the metric ID is `16****`.
          *
          * @param request PutLogMonitorRequest
          * @return PutLogMonitorResponse
         */
        public async Task<PutLogMonitorResponse> PutLogMonitorAsync(PutLogMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutLogMonitorWithOptionsAsync(request, runtime);
        }

        /**
          * ## Limit
          * This operation supports only Message Service (MNS) resources.
          *
          * @param request PutMetricRuleTargetsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutMetricRuleTargetsResponse
         */
        public PutMetricRuleTargetsResponse PutMetricRuleTargetsWithOptions(PutMetricRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Targets))
            {
                query["Targets"] = request.Targets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutMetricRuleTargets",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMetricRuleTargetsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Limit
          * This operation supports only Message Service (MNS) resources.
          *
          * @param request PutMetricRuleTargetsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutMetricRuleTargetsResponse
         */
        public async Task<PutMetricRuleTargetsResponse> PutMetricRuleTargetsWithOptionsAsync(PutMetricRuleTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Targets))
            {
                query["Targets"] = request.Targets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutMetricRuleTargets",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMetricRuleTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Limit
          * This operation supports only Message Service (MNS) resources.
          *
          * @param request PutMetricRuleTargetsRequest
          * @return PutMetricRuleTargetsResponse
         */
        public PutMetricRuleTargetsResponse PutMetricRuleTargets(PutMetricRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutMetricRuleTargetsWithOptions(request, runtime);
        }

        /**
          * ## Limit
          * This operation supports only Message Service (MNS) resources.
          *
          * @param request PutMetricRuleTargetsRequest
          * @return PutMetricRuleTargetsResponse
         */
        public async Task<PutMetricRuleTargetsResponse> PutMetricRuleTargetsAsync(PutMetricRuleTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutMetricRuleTargetsWithOptionsAsync(request, runtime);
        }

        public PutMonitorGroupDynamicRuleResponse PutMonitorGroupDynamicRuleWithOptions(PutMonitorGroupDynamicRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupRules))
            {
                query["GroupRules"] = request.GroupRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsync))
            {
                query["IsAsync"] = request.IsAsync;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutMonitorGroupDynamicRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMonitorGroupDynamicRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutMonitorGroupDynamicRuleResponse> PutMonitorGroupDynamicRuleWithOptionsAsync(PutMonitorGroupDynamicRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupRules))
            {
                query["GroupRules"] = request.GroupRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsync))
            {
                query["IsAsync"] = request.IsAsync;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutMonitorGroupDynamicRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMonitorGroupDynamicRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutMonitorGroupDynamicRuleResponse PutMonitorGroupDynamicRule(PutMonitorGroupDynamicRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutMonitorGroupDynamicRuleWithOptions(request, runtime);
        }

        public async Task<PutMonitorGroupDynamicRuleResponse> PutMonitorGroupDynamicRuleAsync(PutMonitorGroupDynamicRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutMonitorGroupDynamicRuleWithOptionsAsync(request, runtime);
        }

        public PutMonitoringConfigResponse PutMonitoringConfigWithOptions(PutMonitoringConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoInstall))
            {
                query["AutoInstall"] = request.AutoInstall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInstallAgentNewECS))
            {
                query["EnableInstallAgentNewECS"] = request.EnableInstallAgentNewECS;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutMonitoringConfig",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMonitoringConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutMonitoringConfigResponse> PutMonitoringConfigWithOptionsAsync(PutMonitoringConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoInstall))
            {
                query["AutoInstall"] = request.AutoInstall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInstallAgentNewECS))
            {
                query["EnableInstallAgentNewECS"] = request.EnableInstallAgentNewECS;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutMonitoringConfig",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMonitoringConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutMonitoringConfigResponse PutMonitoringConfig(PutMonitoringConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutMonitoringConfigWithOptions(request, runtime);
        }

        public async Task<PutMonitoringConfigResponse> PutMonitoringConfigAsync(PutMonitoringConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutMonitoringConfigWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example to show how to create a threshold-triggered alert rule for the `cpu_total` metric of an Elastic Compute Service (ECS) instance whose ID is `i-uf6j91r34rnwawoo****`. The namespace of ECS is `acs_ecs_dashboard`. The alert contact group of the alert rule is `ECS_Group`. The name of the alert rule is `test123`. The ID of the alert rule is `a151cd6023eacee2f0978e03863cc1697c89508****`. The statistical method for Critical-level alerts is `Average`. The comparison operator for Critical-level alerts is `GreaterThanOrEqualToThreshold`. The threshold for Critical-level alerts is `90`. The consecutive number of times for which the metric value meets the trigger condition before a Critical-level alert is triggered is `3`.
          *
          * @param tmpReq PutResourceMetricRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutResourceMetricRuleResponse
         */
        public PutResourceMetricRuleResponse PutResourceMetricRuleWithOptions(PutResourceMetricRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PutResourceMetricRuleShrinkRequest request = new PutResourceMetricRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CompositeExpression))
            {
                request.CompositeExpressionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CompositeExpression, "CompositeExpression", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Prometheus))
            {
                request.PrometheusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Prometheus, "Prometheus", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompositeExpressionShrink))
            {
                query["CompositeExpression"] = request.CompositeExpressionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroups))
            {
                query["ContactGroups"] = request.ContactGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveInterval))
            {
                query["EffectiveInterval"] = request.EffectiveInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailSubject))
            {
                query["EmailSubject"] = request.EmailSubject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoDataPolicy))
            {
                query["NoDataPolicy"] = request.NoDataPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoEffectiveInterval))
            {
                query["NoEffectiveInterval"] = request.NoEffectiveInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusShrink))
            {
                query["Prometheus"] = request.PrometheusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SilenceTime))
            {
                query["SilenceTime"] = request.SilenceTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Webhook))
            {
                query["Webhook"] = request.Webhook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Escalations))
            {
                query["Escalations"] = request.Escalations;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutResourceMetricRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutResourceMetricRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to create a threshold-triggered alert rule for the `cpu_total` metric of an Elastic Compute Service (ECS) instance whose ID is `i-uf6j91r34rnwawoo****`. The namespace of ECS is `acs_ecs_dashboard`. The alert contact group of the alert rule is `ECS_Group`. The name of the alert rule is `test123`. The ID of the alert rule is `a151cd6023eacee2f0978e03863cc1697c89508****`. The statistical method for Critical-level alerts is `Average`. The comparison operator for Critical-level alerts is `GreaterThanOrEqualToThreshold`. The threshold for Critical-level alerts is `90`. The consecutive number of times for which the metric value meets the trigger condition before a Critical-level alert is triggered is `3`.
          *
          * @param tmpReq PutResourceMetricRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutResourceMetricRuleResponse
         */
        public async Task<PutResourceMetricRuleResponse> PutResourceMetricRuleWithOptionsAsync(PutResourceMetricRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PutResourceMetricRuleShrinkRequest request = new PutResourceMetricRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CompositeExpression))
            {
                request.CompositeExpressionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CompositeExpression, "CompositeExpression", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Prometheus))
            {
                request.PrometheusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Prometheus, "Prometheus", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompositeExpressionShrink))
            {
                query["CompositeExpression"] = request.CompositeExpressionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroups))
            {
                query["ContactGroups"] = request.ContactGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveInterval))
            {
                query["EffectiveInterval"] = request.EffectiveInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailSubject))
            {
                query["EmailSubject"] = request.EmailSubject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoDataPolicy))
            {
                query["NoDataPolicy"] = request.NoDataPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoEffectiveInterval))
            {
                query["NoEffectiveInterval"] = request.NoEffectiveInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusShrink))
            {
                query["Prometheus"] = request.PrometheusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SilenceTime))
            {
                query["SilenceTime"] = request.SilenceTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Webhook))
            {
                query["Webhook"] = request.Webhook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Escalations))
            {
                query["Escalations"] = request.Escalations;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutResourceMetricRule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutResourceMetricRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example to show how to create a threshold-triggered alert rule for the `cpu_total` metric of an Elastic Compute Service (ECS) instance whose ID is `i-uf6j91r34rnwawoo****`. The namespace of ECS is `acs_ecs_dashboard`. The alert contact group of the alert rule is `ECS_Group`. The name of the alert rule is `test123`. The ID of the alert rule is `a151cd6023eacee2f0978e03863cc1697c89508****`. The statistical method for Critical-level alerts is `Average`. The comparison operator for Critical-level alerts is `GreaterThanOrEqualToThreshold`. The threshold for Critical-level alerts is `90`. The consecutive number of times for which the metric value meets the trigger condition before a Critical-level alert is triggered is `3`.
          *
          * @param request PutResourceMetricRuleRequest
          * @return PutResourceMetricRuleResponse
         */
        public PutResourceMetricRuleResponse PutResourceMetricRule(PutResourceMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutResourceMetricRuleWithOptions(request, runtime);
        }

        /**
          * This topic provides an example to show how to create a threshold-triggered alert rule for the `cpu_total` metric of an Elastic Compute Service (ECS) instance whose ID is `i-uf6j91r34rnwawoo****`. The namespace of ECS is `acs_ecs_dashboard`. The alert contact group of the alert rule is `ECS_Group`. The name of the alert rule is `test123`. The ID of the alert rule is `a151cd6023eacee2f0978e03863cc1697c89508****`. The statistical method for Critical-level alerts is `Average`. The comparison operator for Critical-level alerts is `GreaterThanOrEqualToThreshold`. The threshold for Critical-level alerts is `90`. The consecutive number of times for which the metric value meets the trigger condition before a Critical-level alert is triggered is `3`.
          *
          * @param request PutResourceMetricRuleRequest
          * @return PutResourceMetricRuleResponse
         */
        public async Task<PutResourceMetricRuleResponse> PutResourceMetricRuleAsync(PutResourceMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutResourceMetricRuleWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to create a threshold-triggered alert rule for the `cpu_total` metric of the `i-uf6j91r34rnwawoo****` instance that belongs to Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. In this example, the alert contact group of the alert rule is `ECS_Group`, the name of the alert rule is `test123`, and the ID of the alert rule is `a151cd6023eacee2f0978e03863cc1697c89508****`. The statistical method for Critical-level alerts is `Average`, the comparison operator for Critical-level alerts is `GreaterThanOrEqualToThreshold`, the threshold for Critical-level alerts is `90`, and the consecutive number of times for which the metric value is measured before a Critical-level alert is triggered is `3`.
          *
          * @param request PutResourceMetricRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutResourceMetricRulesResponse
         */
        public PutResourceMetricRulesResponse PutResourceMetricRulesWithOptions(PutResourceMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutResourceMetricRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutResourceMetricRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create a threshold-triggered alert rule for the `cpu_total` metric of the `i-uf6j91r34rnwawoo****` instance that belongs to Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. In this example, the alert contact group of the alert rule is `ECS_Group`, the name of the alert rule is `test123`, and the ID of the alert rule is `a151cd6023eacee2f0978e03863cc1697c89508****`. The statistical method for Critical-level alerts is `Average`, the comparison operator for Critical-level alerts is `GreaterThanOrEqualToThreshold`, the threshold for Critical-level alerts is `90`, and the consecutive number of times for which the metric value is measured before a Critical-level alert is triggered is `3`.
          *
          * @param request PutResourceMetricRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutResourceMetricRulesResponse
         */
        public async Task<PutResourceMetricRulesResponse> PutResourceMetricRulesWithOptionsAsync(PutResourceMetricRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutResourceMetricRules",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutResourceMetricRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This topic provides an example on how to create a threshold-triggered alert rule for the `cpu_total` metric of the `i-uf6j91r34rnwawoo****` instance that belongs to Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. In this example, the alert contact group of the alert rule is `ECS_Group`, the name of the alert rule is `test123`, and the ID of the alert rule is `a151cd6023eacee2f0978e03863cc1697c89508****`. The statistical method for Critical-level alerts is `Average`, the comparison operator for Critical-level alerts is `GreaterThanOrEqualToThreshold`, the threshold for Critical-level alerts is `90`, and the consecutive number of times for which the metric value is measured before a Critical-level alert is triggered is `3`.
          *
          * @param request PutResourceMetricRulesRequest
          * @return PutResourceMetricRulesResponse
         */
        public PutResourceMetricRulesResponse PutResourceMetricRules(PutResourceMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutResourceMetricRulesWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to create a threshold-triggered alert rule for the `cpu_total` metric of the `i-uf6j91r34rnwawoo****` instance that belongs to Elastic Compute Service (ECS). The namespace of ECS is `acs_ecs_dashboard`. In this example, the alert contact group of the alert rule is `ECS_Group`, the name of the alert rule is `test123`, and the ID of the alert rule is `a151cd6023eacee2f0978e03863cc1697c89508****`. The statistical method for Critical-level alerts is `Average`, the comparison operator for Critical-level alerts is `GreaterThanOrEqualToThreshold`, the threshold for Critical-level alerts is `90`, and the consecutive number of times for which the metric value is measured before a Critical-level alert is triggered is `3`.
          *
          * @param request PutResourceMetricRulesRequest
          * @return PutResourceMetricRulesResponse
         */
        public async Task<PutResourceMetricRulesResponse> PutResourceMetricRulesAsync(PutResourceMetricRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutResourceMetricRulesWithOptionsAsync(request, runtime);
        }

        public RemoveTagsResponse RemoveTagsWithOptions(RemoveTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTags",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTagsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveTagsResponse> RemoveTagsWithOptionsAsync(RemoveTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTags",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTagsWithOptions(request, runtime);
        }

        public async Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTagsWithOptionsAsync(request, runtime);
        }

        /**
          * This operation is used to test whether a system event can be triggered as expected. You can call this operation to simulate a system event and check whether an expected response is returned after an alert is triggered by the system event.
          *
          * @param request SendDryRunSystemEventRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SendDryRunSystemEventResponse
         */
        public SendDryRunSystemEventResponse SendDryRunSystemEventWithOptions(SendDryRunSystemEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventContent))
            {
                query["EventContent"] = request.EventContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendDryRunSystemEvent",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendDryRunSystemEventResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This operation is used to test whether a system event can be triggered as expected. You can call this operation to simulate a system event and check whether an expected response is returned after an alert is triggered by the system event.
          *
          * @param request SendDryRunSystemEventRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SendDryRunSystemEventResponse
         */
        public async Task<SendDryRunSystemEventResponse> SendDryRunSystemEventWithOptionsAsync(SendDryRunSystemEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventContent))
            {
                query["EventContent"] = request.EventContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendDryRunSystemEvent",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendDryRunSystemEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This operation is used to test whether a system event can be triggered as expected. You can call this operation to simulate a system event and check whether an expected response is returned after an alert is triggered by the system event.
          *
          * @param request SendDryRunSystemEventRequest
          * @return SendDryRunSystemEventResponse
         */
        public SendDryRunSystemEventResponse SendDryRunSystemEvent(SendDryRunSystemEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendDryRunSystemEventWithOptions(request, runtime);
        }

        /**
          * This operation is used to test whether a system event can be triggered as expected. You can call this operation to simulate a system event and check whether an expected response is returned after an alert is triggered by the system event.
          *
          * @param request SendDryRunSystemEventRequest
          * @return SendDryRunSystemEventResponse
         */
        public async Task<SendDryRunSystemEventResponse> SendDryRunSystemEventAsync(SendDryRunSystemEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendDryRunSystemEventWithOptionsAsync(request, runtime);
        }

        /**
          * >  This API operation is not applicable to ECS instances. To uninstall the agent from an ECS instance, see [Install and uninstall the Cloud Monitor agent](~~183482~~).
          *
          * @param request UninstallMonitoringAgentRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UninstallMonitoringAgentResponse
         */
        public UninstallMonitoringAgentResponse UninstallMonitoringAgentWithOptions(UninstallMonitoringAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallMonitoringAgent",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallMonitoringAgentResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  This API operation is not applicable to ECS instances. To uninstall the agent from an ECS instance, see [Install and uninstall the Cloud Monitor agent](~~183482~~).
          *
          * @param request UninstallMonitoringAgentRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UninstallMonitoringAgentResponse
         */
        public async Task<UninstallMonitoringAgentResponse> UninstallMonitoringAgentWithOptionsAsync(UninstallMonitoringAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallMonitoringAgent",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallMonitoringAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  This API operation is not applicable to ECS instances. To uninstall the agent from an ECS instance, see [Install and uninstall the Cloud Monitor agent](~~183482~~).
          *
          * @param request UninstallMonitoringAgentRequest
          * @return UninstallMonitoringAgentResponse
         */
        public UninstallMonitoringAgentResponse UninstallMonitoringAgent(UninstallMonitoringAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UninstallMonitoringAgentWithOptions(request, runtime);
        }

        /**
          * >  This API operation is not applicable to ECS instances. To uninstall the agent from an ECS instance, see [Install and uninstall the Cloud Monitor agent](~~183482~~).
          *
          * @param request UninstallMonitoringAgentRequest
          * @return UninstallMonitoringAgentResponse
         */
        public async Task<UninstallMonitoringAgentResponse> UninstallMonitoringAgentAsync(UninstallMonitoringAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UninstallMonitoringAgentWithOptionsAsync(request, runtime);
        }

    }
}
