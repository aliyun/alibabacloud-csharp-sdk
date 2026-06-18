// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Bailian20231229.Models;

namespace AlibabaCloud.SDK.Bailian20231229
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "bailian.cn-beijing.aliyuncs.com"},
                {"ap-southeast-1", "bailian.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("bailian", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Creates a category in a specified workspace to classify and manage files. Each workspace supports a maximum of 500 categories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You cannot use an API to add data tables. To add data tables, go to the <a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> page in the console.</description></item>
        /// <item><description>A RAM user must obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. The <c>AliyunBailianDataFullAccess</c> permission, which includes the <c>sfm:AddCategory</c> permission, is required. An Alibaba Cloud account can call this operation directly without requiring authorization. To call this operation, use the latest version of the <a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Rate limiting:</b> Frequent calls to this operation are subject to rate limiting. Do not exceed a frequency of 5 calls per second. If rate limiting is triggered, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddCategoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCategoryResponse
        /// </returns>
        public AddCategoryResponse AddCategoryWithOptions(string WorkspaceId, AddCategoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                body["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCategoryId))
            {
                body["ParentCategoryId"] = request.ParentCategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCategory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/category/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a category in a specified workspace to classify and manage files. Each workspace supports a maximum of 500 categories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You cannot use an API to add data tables. To add data tables, go to the <a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> page in the console.</description></item>
        /// <item><description>A RAM user must obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. The <c>AliyunBailianDataFullAccess</c> permission, which includes the <c>sfm:AddCategory</c> permission, is required. An Alibaba Cloud account can call this operation directly without requiring authorization. To call this operation, use the latest version of the <a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Rate limiting:</b> Frequent calls to this operation are subject to rate limiting. Do not exceed a frequency of 5 calls per second. If rate limiting is triggered, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddCategoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCategoryResponse
        /// </returns>
        public async Task<AddCategoryResponse> AddCategoryWithOptionsAsync(string WorkspaceId, AddCategoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                body["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCategoryId))
            {
                body["ParentCategoryId"] = request.ParentCategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCategory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/category/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a category in a specified workspace to classify and manage files. Each workspace supports a maximum of 500 categories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You cannot use an API to add data tables. To add data tables, go to the <a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> page in the console.</description></item>
        /// <item><description>A RAM user must obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. The <c>AliyunBailianDataFullAccess</c> permission, which includes the <c>sfm:AddCategory</c> permission, is required. An Alibaba Cloud account can call this operation directly without requiring authorization. To call this operation, use the latest version of the <a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Rate limiting:</b> Frequent calls to this operation are subject to rate limiting. Do not exceed a frequency of 5 calls per second. If rate limiting is triggered, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCategoryResponse
        /// </returns>
        public AddCategoryResponse AddCategory(string WorkspaceId, AddCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddCategoryWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a category in a specified workspace to classify and manage files. Each workspace supports a maximum of 500 categories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You cannot use an API to add data tables. To add data tables, go to the <a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> page in the console.</description></item>
        /// <item><description>A RAM user must obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. The <c>AliyunBailianDataFullAccess</c> permission, which includes the <c>sfm:AddCategory</c> permission, is required. An Alibaba Cloud account can call this operation directly without requiring authorization. To call this operation, use the latest version of the <a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Rate limiting:</b> Frequent calls to this operation are subject to rate limiting. Do not exceed a frequency of 5 calls per second. If rate limiting is triggered, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCategoryResponse
        /// </returns>
        public async Task<AddCategoryResponse> AddCategoryAsync(string WorkspaceId, AddCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddCategoryWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a connector. This API currently supports only file connectors.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this operation, a RAM user (sub-account) must first have the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio and be a member of a <a href="https://help.aliyun.com/document_detail/2851098.html">business space</a>. This requires the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:AddCategory permission. A primary account can call this operation directly without authorization. We recommend using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Throttling:</b>
        /// Do not call this operation more than 5 times per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AddConnectorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddConnectorResponse
        /// </returns>
        public AddConnectorResponse AddConnectorWithOptions(string WorkspaceId, AddConnectorRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddConnectorShrinkRequest request = new AddConnectorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileConnectorConfig))
            {
                request.FileConnectorConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileConnectorConfig, "FileConnectorConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorName))
            {
                body["ConnectorName"] = request.ConnectorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorType))
            {
                body["ConnectorType"] = request.ConnectorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileConnectorConfigShrink))
            {
                body["FileConnectorConfig"] = request.FileConnectorConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddConnector",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/connector",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddConnectorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a connector. This API currently supports only file connectors.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this operation, a RAM user (sub-account) must first have the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio and be a member of a <a href="https://help.aliyun.com/document_detail/2851098.html">business space</a>. This requires the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:AddCategory permission. A primary account can call this operation directly without authorization. We recommend using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Throttling:</b>
        /// Do not call this operation more than 5 times per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AddConnectorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddConnectorResponse
        /// </returns>
        public async Task<AddConnectorResponse> AddConnectorWithOptionsAsync(string WorkspaceId, AddConnectorRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddConnectorShrinkRequest request = new AddConnectorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileConnectorConfig))
            {
                request.FileConnectorConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileConnectorConfig, "FileConnectorConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorName))
            {
                body["ConnectorName"] = request.ConnectorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorType))
            {
                body["ConnectorType"] = request.ConnectorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileConnectorConfigShrink))
            {
                body["FileConnectorConfig"] = request.FileConnectorConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddConnector",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/connector",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a connector. This API currently supports only file connectors.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this operation, a RAM user (sub-account) must first have the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio and be a member of a <a href="https://help.aliyun.com/document_detail/2851098.html">business space</a>. This requires the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:AddCategory permission. A primary account can call this operation directly without authorization. We recommend using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Throttling:</b>
        /// Do not call this operation more than 5 times per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddConnectorRequest
        /// </param>
        /// 
        /// <returns>
        /// AddConnectorResponse
        /// </returns>
        public AddConnectorResponse AddConnector(string WorkspaceId, AddConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddConnectorWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a connector. This API currently supports only file connectors.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this operation, a RAM user (sub-account) must first have the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio and be a member of a <a href="https://help.aliyun.com/document_detail/2851098.html">business space</a>. This requires the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:AddCategory permission. A primary account can call this operation directly without authorization. We recommend using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Throttling:</b>
        /// Do not call this operation more than 5 times per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddConnectorRequest
        /// </param>
        /// 
        /// <returns>
        /// AddConnectorResponse
        /// </returns>
        public async Task<AddConnectorResponse> AddConnectorAsync(string WorkspaceId, AddConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddConnectorWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports a file from the temporary storage space of Alibaba Cloud Model Studio into a data connection (formerly known as application data).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this API, a RAM user (sub-account) must have the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and be <a href="https://help.aliyun.com/document_detail/2851098.html">added to a workspace</a>. The required policy is <c>AliyunBailianDataFullAccess</c>, which includes the <c>sfm:AddFile</c> permission. An Alibaba Cloud account (primary account) can call this API directly without authorization. We recommend using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this API.</description></item>
        /// <item><description>This API is not idempotent.
        /// <b>Throttling:</b> Frequent calls to this API are subject to throttling. Do not exceed a rate of 10 calls per second. If your request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AddFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddFileResponse
        /// </returns>
        public AddFileResponse AddFileWithOptions(string WorkspaceId, AddFileRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddFileShrinkRequest request = new AddFileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParserConfig))
            {
                request.ParserConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParserConfig, "ParserConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaseId))
            {
                body["LeaseId"] = request.LeaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalFileUrl))
            {
                body["OriginalFileUrl"] = request.OriginalFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parser))
            {
                body["Parser"] = request.Parser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParserConfigShrink))
            {
                body["ParserConfig"] = request.ParserConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports a file from the temporary storage space of Alibaba Cloud Model Studio into a data connection (formerly known as application data).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this API, a RAM user (sub-account) must have the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and be <a href="https://help.aliyun.com/document_detail/2851098.html">added to a workspace</a>. The required policy is <c>AliyunBailianDataFullAccess</c>, which includes the <c>sfm:AddFile</c> permission. An Alibaba Cloud account (primary account) can call this API directly without authorization. We recommend using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this API.</description></item>
        /// <item><description>This API is not idempotent.
        /// <b>Throttling:</b> Frequent calls to this API are subject to throttling. Do not exceed a rate of 10 calls per second. If your request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AddFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddFileResponse
        /// </returns>
        public async Task<AddFileResponse> AddFileWithOptionsAsync(string WorkspaceId, AddFileRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddFileShrinkRequest request = new AddFileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParserConfig))
            {
                request.ParserConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParserConfig, "ParserConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaseId))
            {
                body["LeaseId"] = request.LeaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalFileUrl))
            {
                body["OriginalFileUrl"] = request.OriginalFileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parser))
            {
                body["Parser"] = request.Parser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParserConfigShrink))
            {
                body["ParserConfig"] = request.ParserConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports a file from the temporary storage space of Alibaba Cloud Model Studio into a data connection (formerly known as application data).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this API, a RAM user (sub-account) must have the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and be <a href="https://help.aliyun.com/document_detail/2851098.html">added to a workspace</a>. The required policy is <c>AliyunBailianDataFullAccess</c>, which includes the <c>sfm:AddFile</c> permission. An Alibaba Cloud account (primary account) can call this API directly without authorization. We recommend using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this API.</description></item>
        /// <item><description>This API is not idempotent.
        /// <b>Throttling:</b> Frequent calls to this API are subject to throttling. Do not exceed a rate of 10 calls per second. If your request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddFileRequest
        /// </param>
        /// 
        /// <returns>
        /// AddFileResponse
        /// </returns>
        public AddFileResponse AddFile(string WorkspaceId, AddFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddFileWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports a file from the temporary storage space of Alibaba Cloud Model Studio into a data connection (formerly known as application data).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this API, a RAM user (sub-account) must have the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and be <a href="https://help.aliyun.com/document_detail/2851098.html">added to a workspace</a>. The required policy is <c>AliyunBailianDataFullAccess</c>, which includes the <c>sfm:AddFile</c> permission. An Alibaba Cloud account (primary account) can call this API directly without authorization. We recommend using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this API.</description></item>
        /// <item><description>This API is not idempotent.
        /// <b>Throttling:</b> Frequent calls to this API are subject to throttling. Do not exceed a rate of 10 calls per second. If your request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddFileRequest
        /// </param>
        /// 
        /// <returns>
        /// AddFileResponse
        /// </returns>
        public async Task<AddFileResponse> AddFileAsync(string WorkspaceId, AddFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddFileWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports files from an authorized OSS Bucket into Alibaba Cloud Model Studio (Bailian) application data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><para>Please ensure that the OSS Bucket and Alibaba Cloud Model Studio belong to the same Alibaba Cloud account (main account) and that authorization has been completed according to the <a href="https://help.aliyun.com/document_detail/2782155.html">Configuration instructions for importing data from OSS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Supported Bucket storage types do not include Archive, Cold Archive, or Deep Cold Archive. Buckets with content encryption are supported. Public read/write, public read, and private Buckets are supported.</description></item>
        /// <item><description>If you want to use a Bucket with <a href="https://help.aliyun.com/document_detail/2636937.html">Referer hotlink protection</a> enabled, refer to <a href="https://help.aliyun.com/document_detail/2636937.html">Allow access only from trusted websites</a> to add the domain <c>*.console.aliyun.com</c> to the Referer allowlist.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>A RAM user (sub-account) must first obtain the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:AddFilesFromAuthorizedOss permission point) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. The Alibaba Cloud account (main account) can call this directly without authorization. We recommend that you call this operation through the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</para>
        /// </description></item>
        /// <item><description><para>This operation is not idempotent.
        /// <b>Throttling description:</b>
        /// Frequent calls to this operation will be throttled. The frequency should not exceed 5 calls per second. If throttled, please try again later.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AddFilesFromAuthorizedOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddFilesFromAuthorizedOssResponse
        /// </returns>
        public AddFilesFromAuthorizedOssResponse AddFilesFromAuthorizedOssWithOptions(string WorkspaceId, AddFilesFromAuthorizedOssRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddFilesFromAuthorizedOssShrinkRequest request = new AddFilesFromAuthorizedOssShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileDetails))
            {
                request.FileDetailsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileDetails, "FileDetails", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileDetailsShrink))
            {
                body["FileDetails"] = request.FileDetailsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                body["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssRegionId))
            {
                body["OssRegionId"] = request.OssRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverWriteFileByOssKey))
            {
                body["OverWriteFileByOssKey"] = request.OverWriteFileByOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFilesFromAuthorizedOss",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file/fromoss",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFilesFromAuthorizedOssResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports files from an authorized OSS Bucket into Alibaba Cloud Model Studio (Bailian) application data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><para>Please ensure that the OSS Bucket and Alibaba Cloud Model Studio belong to the same Alibaba Cloud account (main account) and that authorization has been completed according to the <a href="https://help.aliyun.com/document_detail/2782155.html">Configuration instructions for importing data from OSS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Supported Bucket storage types do not include Archive, Cold Archive, or Deep Cold Archive. Buckets with content encryption are supported. Public read/write, public read, and private Buckets are supported.</description></item>
        /// <item><description>If you want to use a Bucket with <a href="https://help.aliyun.com/document_detail/2636937.html">Referer hotlink protection</a> enabled, refer to <a href="https://help.aliyun.com/document_detail/2636937.html">Allow access only from trusted websites</a> to add the domain <c>*.console.aliyun.com</c> to the Referer allowlist.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>A RAM user (sub-account) must first obtain the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:AddFilesFromAuthorizedOss permission point) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. The Alibaba Cloud account (main account) can call this directly without authorization. We recommend that you call this operation through the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</para>
        /// </description></item>
        /// <item><description><para>This operation is not idempotent.
        /// <b>Throttling description:</b>
        /// Frequent calls to this operation will be throttled. The frequency should not exceed 5 calls per second. If throttled, please try again later.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AddFilesFromAuthorizedOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddFilesFromAuthorizedOssResponse
        /// </returns>
        public async Task<AddFilesFromAuthorizedOssResponse> AddFilesFromAuthorizedOssWithOptionsAsync(string WorkspaceId, AddFilesFromAuthorizedOssRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddFilesFromAuthorizedOssShrinkRequest request = new AddFilesFromAuthorizedOssShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileDetails))
            {
                request.FileDetailsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileDetails, "FileDetails", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileDetailsShrink))
            {
                body["FileDetails"] = request.FileDetailsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                body["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssRegionId))
            {
                body["OssRegionId"] = request.OssRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverWriteFileByOssKey))
            {
                body["OverWriteFileByOssKey"] = request.OverWriteFileByOssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFilesFromAuthorizedOss",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file/fromoss",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFilesFromAuthorizedOssResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports files from an authorized OSS Bucket into Alibaba Cloud Model Studio (Bailian) application data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><para>Please ensure that the OSS Bucket and Alibaba Cloud Model Studio belong to the same Alibaba Cloud account (main account) and that authorization has been completed according to the <a href="https://help.aliyun.com/document_detail/2782155.html">Configuration instructions for importing data from OSS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Supported Bucket storage types do not include Archive, Cold Archive, or Deep Cold Archive. Buckets with content encryption are supported. Public read/write, public read, and private Buckets are supported.</description></item>
        /// <item><description>If you want to use a Bucket with <a href="https://help.aliyun.com/document_detail/2636937.html">Referer hotlink protection</a> enabled, refer to <a href="https://help.aliyun.com/document_detail/2636937.html">Allow access only from trusted websites</a> to add the domain <c>*.console.aliyun.com</c> to the Referer allowlist.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>A RAM user (sub-account) must first obtain the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:AddFilesFromAuthorizedOss permission point) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. The Alibaba Cloud account (main account) can call this directly without authorization. We recommend that you call this operation through the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</para>
        /// </description></item>
        /// <item><description><para>This operation is not idempotent.
        /// <b>Throttling description:</b>
        /// Frequent calls to this operation will be throttled. The frequency should not exceed 5 calls per second. If throttled, please try again later.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddFilesFromAuthorizedOssRequest
        /// </param>
        /// 
        /// <returns>
        /// AddFilesFromAuthorizedOssResponse
        /// </returns>
        public AddFilesFromAuthorizedOssResponse AddFilesFromAuthorizedOss(string WorkspaceId, AddFilesFromAuthorizedOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddFilesFromAuthorizedOssWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports files from an authorized OSS Bucket into Alibaba Cloud Model Studio (Bailian) application data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><para>Please ensure that the OSS Bucket and Alibaba Cloud Model Studio belong to the same Alibaba Cloud account (main account) and that authorization has been completed according to the <a href="https://help.aliyun.com/document_detail/2782155.html">Configuration instructions for importing data from OSS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Supported Bucket storage types do not include Archive, Cold Archive, or Deep Cold Archive. Buckets with content encryption are supported. Public read/write, public read, and private Buckets are supported.</description></item>
        /// <item><description>If you want to use a Bucket with <a href="https://help.aliyun.com/document_detail/2636937.html">Referer hotlink protection</a> enabled, refer to <a href="https://help.aliyun.com/document_detail/2636937.html">Allow access only from trusted websites</a> to add the domain <c>*.console.aliyun.com</c> to the Referer allowlist.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>A RAM user (sub-account) must first obtain the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:AddFilesFromAuthorizedOss permission point) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. The Alibaba Cloud account (main account) can call this directly without authorization. We recommend that you call this operation through the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</para>
        /// </description></item>
        /// <item><description><para>This operation is not idempotent.
        /// <b>Throttling description:</b>
        /// Frequent calls to this operation will be throttled. The frequency should not exceed 5 calls per second. If throttled, please try again later.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddFilesFromAuthorizedOssRequest
        /// </param>
        /// 
        /// <returns>
        /// AddFilesFromAuthorizedOssResponse
        /// </returns>
        public async Task<AddFilesFromAuthorizedOssResponse> AddFilesFromAuthorizedOssAsync(string WorkspaceId, AddFilesFromAuthorizedOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddFilesFromAuthorizedOssWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a table to a tabular data connector.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:AddTable permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AddTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTableResponse
        /// </returns>
        public AddTableResponse AddTableWithOptions(string WorkspaceId, AddTableRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddTableShrinkRequest request = new AddTableShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TableColumns))
            {
                request.TableColumnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TableColumns, "TableColumns", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                body["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableColumnsShrink))
            {
                body["TableColumns"] = request.TableColumnsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableDesc))
            {
                body["TableDesc"] = request.TableDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTable",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/table",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a table to a tabular data connector.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:AddTable permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AddTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTableResponse
        /// </returns>
        public async Task<AddTableResponse> AddTableWithOptionsAsync(string WorkspaceId, AddTableRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddTableShrinkRequest request = new AddTableShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TableColumns))
            {
                request.TableColumnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TableColumns, "TableColumns", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                body["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableColumnsShrink))
            {
                body["TableColumns"] = request.TableColumnsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableDesc))
            {
                body["TableDesc"] = request.TableDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTable",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/table",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a table to a tabular data connector.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:AddTable permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddTableRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTableResponse
        /// </returns>
        public AddTableResponse AddTable(string WorkspaceId, AddTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddTableWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a table to a tabular data connector.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:AddTable permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddTableRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTableResponse
        /// </returns>
        public async Task<AddTableResponse> AddTableAsync(string WorkspaceId, AddTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddTableWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Request an upload lease for uploading knowledge base files or files for agent application conversational interactions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM users (sub-accounts) must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ApplyFileUploadLease permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this API. Alibaba Cloud accounts (primary accounts) can directly call this API without authorization. We recommend that you call this API by using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>This API is not idempotent.
        /// <b>Throttling:</b>
        /// This API is subject to throttling if called too frequently. The frequency must not exceed 10 calls per second. If throttled, please retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyFileUploadLeaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyFileUploadLeaseResponse
        /// </returns>
        public ApplyFileUploadLeaseResponse ApplyFileUploadLeaseWithOptions(string CategoryId, string WorkspaceId, ApplyFileUploadLeaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                body["Md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeInBytes))
            {
                body["SizeInBytes"] = request.SizeInBytes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseInternalEndpoint))
            {
                body["UseInternalEndpoint"] = request.UseInternalEndpoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyFileUploadLease",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/category/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CategoryId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyFileUploadLeaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Request an upload lease for uploading knowledge base files or files for agent application conversational interactions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM users (sub-accounts) must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ApplyFileUploadLease permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this API. Alibaba Cloud accounts (primary accounts) can directly call this API without authorization. We recommend that you call this API by using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>This API is not idempotent.
        /// <b>Throttling:</b>
        /// This API is subject to throttling if called too frequently. The frequency must not exceed 10 calls per second. If throttled, please retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyFileUploadLeaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyFileUploadLeaseResponse
        /// </returns>
        public async Task<ApplyFileUploadLeaseResponse> ApplyFileUploadLeaseWithOptionsAsync(string CategoryId, string WorkspaceId, ApplyFileUploadLeaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                body["Md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeInBytes))
            {
                body["SizeInBytes"] = request.SizeInBytes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseInternalEndpoint))
            {
                body["UseInternalEndpoint"] = request.UseInternalEndpoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyFileUploadLease",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/category/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CategoryId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyFileUploadLeaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Request an upload lease for uploading knowledge base files or files for agent application conversational interactions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM users (sub-accounts) must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ApplyFileUploadLease permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this API. Alibaba Cloud accounts (primary accounts) can directly call this API without authorization. We recommend that you call this API by using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>This API is not idempotent.
        /// <b>Throttling:</b>
        /// This API is subject to throttling if called too frequently. The frequency must not exceed 10 calls per second. If throttled, please retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyFileUploadLeaseRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyFileUploadLeaseResponse
        /// </returns>
        public ApplyFileUploadLeaseResponse ApplyFileUploadLease(string CategoryId, string WorkspaceId, ApplyFileUploadLeaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ApplyFileUploadLeaseWithOptions(CategoryId, WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Request an upload lease for uploading knowledge base files or files for agent application conversational interactions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM users (sub-accounts) must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ApplyFileUploadLease permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this API. Alibaba Cloud accounts (primary accounts) can directly call this API without authorization. We recommend that you call this API by using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>This API is not idempotent.
        /// <b>Throttling:</b>
        /// This API is subject to throttling if called too frequently. The frequency must not exceed 10 calls per second. If throttled, please retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyFileUploadLeaseRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyFileUploadLeaseResponse
        /// </returns>
        public async Task<ApplyFileUploadLeaseResponse> ApplyFileUploadLeaseAsync(string CategoryId, string WorkspaceId, ApplyFileUploadLeaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ApplyFileUploadLeaseWithOptionsAsync(CategoryId, WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This interface is intended for pro-code deployment only; other scenarios are currently not supported. It is used to apply for a temporary file upload lease. After obtaining the lease, you must upload the file manually.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>1\. This interface is intended for pro-code deployment only; other scenarios are currently not supported. 2. After obtaining the temporary file upload lease via this interface, upload the file manually.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyTempStorageLeaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyTempStorageLeaseResponse
        /// </returns>
        public ApplyTempStorageLeaseResponse ApplyTempStorageLeaseWithOptions(string WorkspaceId, ApplyTempStorageLeaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeInBytes))
            {
                body["SizeInBytes"] = request.SizeInBytes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyTempStorageLease",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyTempStorageLeaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This interface is intended for pro-code deployment only; other scenarios are currently not supported. It is used to apply for a temporary file upload lease. After obtaining the lease, you must upload the file manually.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>1\. This interface is intended for pro-code deployment only; other scenarios are currently not supported. 2. After obtaining the temporary file upload lease via this interface, upload the file manually.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyTempStorageLeaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyTempStorageLeaseResponse
        /// </returns>
        public async Task<ApplyTempStorageLeaseResponse> ApplyTempStorageLeaseWithOptionsAsync(string WorkspaceId, ApplyTempStorageLeaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeInBytes))
            {
                body["SizeInBytes"] = request.SizeInBytes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyTempStorageLease",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyTempStorageLeaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This interface is intended for pro-code deployment only; other scenarios are currently not supported. It is used to apply for a temporary file upload lease. After obtaining the lease, you must upload the file manually.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>1\. This interface is intended for pro-code deployment only; other scenarios are currently not supported. 2. After obtaining the temporary file upload lease via this interface, upload the file manually.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyTempStorageLeaseRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyTempStorageLeaseResponse
        /// </returns>
        public ApplyTempStorageLeaseResponse ApplyTempStorageLease(string WorkspaceId, ApplyTempStorageLeaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ApplyTempStorageLeaseWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This interface is intended for pro-code deployment only; other scenarios are currently not supported. It is used to apply for a temporary file upload lease. After obtaining the lease, you must upload the file manually.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>1\. This interface is intended for pro-code deployment only; other scenarios are currently not supported. 2. After obtaining the temporary file upload lease via this interface, upload the file manually.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyTempStorageLeaseRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyTempStorageLeaseResponse
        /// </returns>
        public async Task<ApplyTempStorageLeaseResponse> ApplyTempStorageLeaseAsync(string WorkspaceId, ApplyTempStorageLeaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ApplyTempStorageLeaseWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation updates document tags in a data connection in batches.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchUpdateFileTagRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFileTagResponse
        /// </returns>
        public BatchUpdateFileTagResponse BatchUpdateFileTagWithOptions(string WorkspaceId, BatchUpdateFileTagRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUpdateFileTagShrinkRequest request = new BatchUpdateFileTagShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileInfos))
            {
                request.FileInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileInfos, "FileInfos", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileInfosShrink))
            {
                body["FileInfos"] = request.FileInfosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateMode))
            {
                body["UpdateMode"] = request.UpdateMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUpdateFileTag",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/batchupdatetag",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateFileTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation updates document tags in a data connection in batches.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchUpdateFileTagRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFileTagResponse
        /// </returns>
        public async Task<BatchUpdateFileTagResponse> BatchUpdateFileTagWithOptionsAsync(string WorkspaceId, BatchUpdateFileTagRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUpdateFileTagShrinkRequest request = new BatchUpdateFileTagShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileInfos))
            {
                request.FileInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileInfos, "FileInfos", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileInfosShrink))
            {
                body["FileInfos"] = request.FileInfosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateMode))
            {
                body["UpdateMode"] = request.UpdateMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUpdateFileTag",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/batchupdatetag",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateFileTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation updates document tags in a data connection in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateFileTagRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFileTagResponse
        /// </returns>
        public BatchUpdateFileTagResponse BatchUpdateFileTag(string WorkspaceId, BatchUpdateFileTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchUpdateFileTagWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation updates document tags in a data connection in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateFileTagRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateFileTagResponse
        /// </returns>
        public async Task<BatchUpdateFileTagResponse> BatchUpdateFileTagAsync(string WorkspaceId, BatchUpdateFileTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchUpdateFileTagWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the parsing method for a specific file type. For example, you can specify LLM-based document parsing for .pdf files and the Qwen VL Parser for .jpg files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM user (sub-account) must first obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (the <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:ChangeParseSetting</c> permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. An Alibaba Cloud account (primary account) can call this operation directly without authorization. We recommend using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Throttling</b>
        /// The system throttles frequent calls to this operation. Do not exceed a frequency of 10 requests per second. If your request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ChangeParseSettingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeParseSettingResponse
        /// </returns>
        public ChangeParseSettingResponse ChangeParseSettingWithOptions(string WorkspaceId, ChangeParseSettingRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ChangeParseSettingShrinkRequest request = new ChangeParseSettingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParserConfig))
            {
                request.ParserConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParserConfig, "ParserConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parser))
            {
                body["Parser"] = request.Parser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParserConfigShrink))
            {
                body["ParserConfig"] = request.ParserConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeParseSetting",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/parser/settings",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeParseSettingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the parsing method for a specific file type. For example, you can specify LLM-based document parsing for .pdf files and the Qwen VL Parser for .jpg files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM user (sub-account) must first obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (the <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:ChangeParseSetting</c> permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. An Alibaba Cloud account (primary account) can call this operation directly without authorization. We recommend using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Throttling</b>
        /// The system throttles frequent calls to this operation. Do not exceed a frequency of 10 requests per second. If your request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ChangeParseSettingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeParseSettingResponse
        /// </returns>
        public async Task<ChangeParseSettingResponse> ChangeParseSettingWithOptionsAsync(string WorkspaceId, ChangeParseSettingRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ChangeParseSettingShrinkRequest request = new ChangeParseSettingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParserConfig))
            {
                request.ParserConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParserConfig, "ParserConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parser))
            {
                body["Parser"] = request.Parser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParserConfigShrink))
            {
                body["ParserConfig"] = request.ParserConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeParseSetting",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/parser/settings",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeParseSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the parsing method for a specific file type. For example, you can specify LLM-based document parsing for .pdf files and the Qwen VL Parser for .jpg files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM user (sub-account) must first obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (the <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:ChangeParseSetting</c> permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. An Alibaba Cloud account (primary account) can call this operation directly without authorization. We recommend using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Throttling</b>
        /// The system throttles frequent calls to this operation. Do not exceed a frequency of 10 requests per second. If your request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ChangeParseSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeParseSettingResponse
        /// </returns>
        public ChangeParseSettingResponse ChangeParseSetting(string WorkspaceId, ChangeParseSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ChangeParseSettingWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the parsing method for a specific file type. For example, you can specify LLM-based document parsing for .pdf files and the Qwen VL Parser for .jpg files.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM user (sub-account) must first obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (the <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:ChangeParseSetting</c> permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. An Alibaba Cloud account (primary account) can call this operation directly without authorization. We recommend using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Throttling</b>
        /// The system throttles frequent calls to this operation. Do not exceed a frequency of 10 requests per second. If your request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ChangeParseSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeParseSettingResponse
        /// </returns>
        public async Task<ChangeParseSettingResponse> ChangeParseSettingAsync(string WorkspaceId, ChangeParseSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ChangeParseSettingWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并发布智能体应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAndPulishAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndPulishAgentResponse
        /// </returns>
        public CreateAndPulishAgentResponse CreateAndPulishAgentWithOptions(string workspaceId, CreateAndPulishAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAndPulishAgentShrinkRequest request = new CreateAndPulishAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApplicationConfig))
            {
                request.ApplicationConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApplicationConfig, "applicationConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SampleLibrary))
            {
                request.SampleLibraryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SampleLibrary, "sampleLibrary", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigShrink))
            {
                body["applicationConfig"] = request.ApplicationConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleLibraryShrink))
            {
                body["sampleLibrary"] = request.SampleLibraryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAndPulishAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndPulishAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并发布智能体应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAndPulishAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndPulishAgentResponse
        /// </returns>
        public async Task<CreateAndPulishAgentResponse> CreateAndPulishAgentWithOptionsAsync(string workspaceId, CreateAndPulishAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAndPulishAgentShrinkRequest request = new CreateAndPulishAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApplicationConfig))
            {
                request.ApplicationConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApplicationConfig, "applicationConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SampleLibrary))
            {
                request.SampleLibraryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SampleLibrary, "sampleLibrary", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigShrink))
            {
                body["applicationConfig"] = request.ApplicationConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleLibraryShrink))
            {
                body["sampleLibrary"] = request.SampleLibraryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAndPulishAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndPulishAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并发布智能体应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndPulishAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndPulishAgentResponse
        /// </returns>
        public CreateAndPulishAgentResponse CreateAndPulishAgent(string workspaceId, CreateAndPulishAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAndPulishAgentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并发布智能体应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndPulishAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndPulishAgentResponse
        /// </returns>
        public async Task<CreateAndPulishAgentResponse> CreateAndPulishAgentAsync(string workspaceId, CreateAndPulishAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAndPulishAgentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Use this API to create two types of knowledge bases: unstructured knowledge bases for documents, audio, or video, and structured knowledge bases for data queries or image Q&amp;A.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Permissions</b>:<list type="bullet">
        /// <item><description><b>RAM user</b>: A RAM user must obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. You can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the \<c>sfm:CreateIndex\\</c> permission required for this operation.</description></item>
        /// <item><description><b>Alibaba Cloud account</b>: By default, Alibaba Cloud accounts have the required permissions and can call this operation directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>How to call</b>: Use the latest version of the &lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation. The SDK handles the complex signature calculation logic to simplify the process.</description></item>
        /// <item><description><b>What to do next</b>: This operation only initializes a knowledge base creation job. After calling this operation, you must call the <b>SubmitIndexJob</b> operation to complete the creation. Otherwise, an empty knowledge base is created. For related code examples, see <a href="https://help.aliyun.com/document_detail/2852772.html">Knowledge base API guide</a>.</description></item>
        /// <item><description><b>Idempotence</b>: This operation is not idempotent. Repeated calls may create multiple knowledge bases with the same name. To ensure idempotence, query for the knowledge base before you create it.
        /// <b>Rate limiting:</b>
        /// Frequent calls to this operation are subject to rate limiting. Do not exceed a frequency of 10 calls per second. If you encounter rate limiting, retry the call later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIndexResponse
        /// </returns>
        public CreateIndexResponse CreateIndexWithOptions(string WorkspaceId, CreateIndexRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateIndexShrinkRequest request = new CreateIndexShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CategoryIds))
            {
                request.CategoryIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CategoryIds, "CategoryIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Columns))
            {
                request.ColumnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Columns, "Columns", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentIds))
            {
                request.DocumentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentIds, "DocumentIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TableIds))
            {
                request.TableIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TableIds, "TableIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MetaExtractColumns))
            {
                request.MetaExtractColumnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MetaExtractColumns, "metaExtractColumns", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryIdsShrink))
            {
                query["CategoryIds"] = request.CategoryIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkSize))
            {
                query["ChunkSize"] = request.ChunkSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnsShrink))
            {
                query["Columns"] = request.ColumnsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateIndexType))
            {
                query["CreateIndexType"] = request.CreateIndexType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIdsShrink))
            {
                query["DocumentIds"] = request.DocumentIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmbeddingModelName))
            {
                query["EmbeddingModelName"] = request.EmbeddingModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRewrite))
            {
                query["EnableRewrite"] = request.EnableRewrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverlapSize))
            {
                query["OverlapSize"] = request.OverlapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankInstruct))
            {
                query["RerankInstruct"] = request.RerankInstruct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankMinScore))
            {
                query["RerankMinScore"] = request.RerankMinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankMode))
            {
                query["RerankMode"] = request.RerankMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankModelName))
            {
                query["RerankModelName"] = request.RerankModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Separator))
            {
                query["Separator"] = request.Separator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkInstanceId))
            {
                query["SinkInstanceId"] = request.SinkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkRegion))
            {
                query["SinkRegion"] = request.SinkRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkType))
            {
                query["SinkType"] = request.SinkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructureType))
            {
                query["StructureType"] = request.StructureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdsShrink))
            {
                query["TableIds"] = request.TableIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["channelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkMode))
            {
                query["chunkMode"] = request.ChunkMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectId))
            {
                query["connectId"] = request.ConnectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceCode))
            {
                query["datasourceCode"] = request.DatasourceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableHeaders))
            {
                query["enableHeaders"] = request.EnableHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeScene))
            {
                query["knowledgeScene"] = request.KnowledgeScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeType))
            {
                query["knowledgeType"] = request.KnowledgeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaExtractColumnsShrink))
            {
                query["metaExtractColumns"] = request.MetaExtractColumnsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineCommercialCu))
            {
                query["pipelineCommercialCu"] = request.PipelineCommercialCu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineCommercialType))
            {
                query["pipelineCommercialType"] = request.PipelineCommercialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineRetrieveRateLimitStrategy))
            {
                query["pipelineRetrieveRateLimitStrategy"] = request.PipelineRetrieveRateLimitStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                query["table"] = request.Table;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIndex",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIndexResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Use this API to create two types of knowledge bases: unstructured knowledge bases for documents, audio, or video, and structured knowledge bases for data queries or image Q&amp;A.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Permissions</b>:<list type="bullet">
        /// <item><description><b>RAM user</b>: A RAM user must obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. You can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the \<c>sfm:CreateIndex\\</c> permission required for this operation.</description></item>
        /// <item><description><b>Alibaba Cloud account</b>: By default, Alibaba Cloud accounts have the required permissions and can call this operation directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>How to call</b>: Use the latest version of the &lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation. The SDK handles the complex signature calculation logic to simplify the process.</description></item>
        /// <item><description><b>What to do next</b>: This operation only initializes a knowledge base creation job. After calling this operation, you must call the <b>SubmitIndexJob</b> operation to complete the creation. Otherwise, an empty knowledge base is created. For related code examples, see <a href="https://help.aliyun.com/document_detail/2852772.html">Knowledge base API guide</a>.</description></item>
        /// <item><description><b>Idempotence</b>: This operation is not idempotent. Repeated calls may create multiple knowledge bases with the same name. To ensure idempotence, query for the knowledge base before you create it.
        /// <b>Rate limiting:</b>
        /// Frequent calls to this operation are subject to rate limiting. Do not exceed a frequency of 10 calls per second. If you encounter rate limiting, retry the call later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIndexResponse
        /// </returns>
        public async Task<CreateIndexResponse> CreateIndexWithOptionsAsync(string WorkspaceId, CreateIndexRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateIndexShrinkRequest request = new CreateIndexShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CategoryIds))
            {
                request.CategoryIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CategoryIds, "CategoryIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Columns))
            {
                request.ColumnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Columns, "Columns", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentIds))
            {
                request.DocumentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentIds, "DocumentIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TableIds))
            {
                request.TableIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TableIds, "TableIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MetaExtractColumns))
            {
                request.MetaExtractColumnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MetaExtractColumns, "metaExtractColumns", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryIdsShrink))
            {
                query["CategoryIds"] = request.CategoryIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkSize))
            {
                query["ChunkSize"] = request.ChunkSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnsShrink))
            {
                query["Columns"] = request.ColumnsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateIndexType))
            {
                query["CreateIndexType"] = request.CreateIndexType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIdsShrink))
            {
                query["DocumentIds"] = request.DocumentIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmbeddingModelName))
            {
                query["EmbeddingModelName"] = request.EmbeddingModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRewrite))
            {
                query["EnableRewrite"] = request.EnableRewrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverlapSize))
            {
                query["OverlapSize"] = request.OverlapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankInstruct))
            {
                query["RerankInstruct"] = request.RerankInstruct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankMinScore))
            {
                query["RerankMinScore"] = request.RerankMinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankMode))
            {
                query["RerankMode"] = request.RerankMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankModelName))
            {
                query["RerankModelName"] = request.RerankModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Separator))
            {
                query["Separator"] = request.Separator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkInstanceId))
            {
                query["SinkInstanceId"] = request.SinkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkRegion))
            {
                query["SinkRegion"] = request.SinkRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkType))
            {
                query["SinkType"] = request.SinkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructureType))
            {
                query["StructureType"] = request.StructureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdsShrink))
            {
                query["TableIds"] = request.TableIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["channelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkMode))
            {
                query["chunkMode"] = request.ChunkMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectId))
            {
                query["connectId"] = request.ConnectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceCode))
            {
                query["datasourceCode"] = request.DatasourceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableHeaders))
            {
                query["enableHeaders"] = request.EnableHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeScene))
            {
                query["knowledgeScene"] = request.KnowledgeScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeType))
            {
                query["knowledgeType"] = request.KnowledgeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaExtractColumnsShrink))
            {
                query["metaExtractColumns"] = request.MetaExtractColumnsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineCommercialCu))
            {
                query["pipelineCommercialCu"] = request.PipelineCommercialCu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineCommercialType))
            {
                query["pipelineCommercialType"] = request.PipelineCommercialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineRetrieveRateLimitStrategy))
            {
                query["pipelineRetrieveRateLimitStrategy"] = request.PipelineRetrieveRateLimitStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                query["table"] = request.Table;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIndex",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Use this API to create two types of knowledge bases: unstructured knowledge bases for documents, audio, or video, and structured knowledge bases for data queries or image Q&amp;A.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Permissions</b>:<list type="bullet">
        /// <item><description><b>RAM user</b>: A RAM user must obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. You can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the \<c>sfm:CreateIndex\\</c> permission required for this operation.</description></item>
        /// <item><description><b>Alibaba Cloud account</b>: By default, Alibaba Cloud accounts have the required permissions and can call this operation directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>How to call</b>: Use the latest version of the &lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation. The SDK handles the complex signature calculation logic to simplify the process.</description></item>
        /// <item><description><b>What to do next</b>: This operation only initializes a knowledge base creation job. After calling this operation, you must call the <b>SubmitIndexJob</b> operation to complete the creation. Otherwise, an empty knowledge base is created. For related code examples, see <a href="https://help.aliyun.com/document_detail/2852772.html">Knowledge base API guide</a>.</description></item>
        /// <item><description><b>Idempotence</b>: This operation is not idempotent. Repeated calls may create multiple knowledge bases with the same name. To ensure idempotence, query for the knowledge base before you create it.
        /// <b>Rate limiting:</b>
        /// Frequent calls to this operation are subject to rate limiting. Do not exceed a frequency of 10 calls per second. If you encounter rate limiting, retry the call later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIndexResponse
        /// </returns>
        public CreateIndexResponse CreateIndex(string WorkspaceId, CreateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIndexWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Use this API to create two types of knowledge bases: unstructured knowledge bases for documents, audio, or video, and structured knowledge bases for data queries or image Q&amp;A.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Permissions</b>:<list type="bullet">
        /// <item><description><b>RAM user</b>: A RAM user must obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. You can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the \<c>sfm:CreateIndex\\</c> permission required for this operation.</description></item>
        /// <item><description><b>Alibaba Cloud account</b>: By default, Alibaba Cloud accounts have the required permissions and can call this operation directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>How to call</b>: Use the latest version of the &lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation. The SDK handles the complex signature calculation logic to simplify the process.</description></item>
        /// <item><description><b>What to do next</b>: This operation only initializes a knowledge base creation job. After calling this operation, you must call the <b>SubmitIndexJob</b> operation to complete the creation. Otherwise, an empty knowledge base is created. For related code examples, see <a href="https://help.aliyun.com/document_detail/2852772.html">Knowledge base API guide</a>.</description></item>
        /// <item><description><b>Idempotence</b>: This operation is not idempotent. Repeated calls may create multiple knowledge bases with the same name. To ensure idempotence, query for the knowledge base before you create it.
        /// <b>Rate limiting:</b>
        /// Frequent calls to this operation are subject to rate limiting. Do not exceed a frequency of 10 calls per second. If you encounter rate limiting, retry the call later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIndexResponse
        /// </returns>
        public async Task<CreateIndexResponse> CreateIndexAsync(string WorkspaceId, CreateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIndexWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can store specific information from conversations (memory nodes. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/long-term-memory">Long-term memory</a>) in a long-term memory. Agent applications can then reference this information in subsequent conversations. This is not an automatic creation procedure. You must first invoke the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-creatememory">CreateMemory</a> operation to create a long-term memory and obtain the <c>memoryId</c>. Then pass the <c>memoryId</c> when you <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/application-calling">invoke the agent application through the API</a>.<remarks>
        /// <para>Long-term memory does not support storing and managing user profiles through the API. Perform related operations in the console. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/long-term-memory#578ebae524m6l">Long-term memory</a>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>If you pass a <c>memoryId</c>, the system uses automatic creation to generate memory nodes (MemoryNode) under the specified long-term memory based on conversation records. You can also invoke the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-creatememorynode">CreateMemoryNode</a> operation to manually create memory nodes.</description></item>
        /// <item><description>This operation does not support idempotence.
        /// <b>Throttling:</b> Ensure that the interval between two consecutive requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryResponse
        /// </returns>
        public CreateMemoryResponse CreateMemoryWithOptions(string workspaceId, CreateMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can store specific information from conversations (memory nodes. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/long-term-memory">Long-term memory</a>) in a long-term memory. Agent applications can then reference this information in subsequent conversations. This is not an automatic creation procedure. You must first invoke the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-creatememory">CreateMemory</a> operation to create a long-term memory and obtain the <c>memoryId</c>. Then pass the <c>memoryId</c> when you <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/application-calling">invoke the agent application through the API</a>.<remarks>
        /// <para>Long-term memory does not support storing and managing user profiles through the API. Perform related operations in the console. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/long-term-memory#578ebae524m6l">Long-term memory</a>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>If you pass a <c>memoryId</c>, the system uses automatic creation to generate memory nodes (MemoryNode) under the specified long-term memory based on conversation records. You can also invoke the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-creatememorynode">CreateMemoryNode</a> operation to manually create memory nodes.</description></item>
        /// <item><description>This operation does not support idempotence.
        /// <b>Throttling:</b> Ensure that the interval between two consecutive requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryResponse
        /// </returns>
        public async Task<CreateMemoryResponse> CreateMemoryWithOptionsAsync(string workspaceId, CreateMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can store specific information from conversations (memory nodes. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/long-term-memory">Long-term memory</a>) in a long-term memory. Agent applications can then reference this information in subsequent conversations. This is not an automatic creation procedure. You must first invoke the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-creatememory">CreateMemory</a> operation to create a long-term memory and obtain the <c>memoryId</c>. Then pass the <c>memoryId</c> when you <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/application-calling">invoke the agent application through the API</a>.<remarks>
        /// <para>Long-term memory does not support storing and managing user profiles through the API. Perform related operations in the console. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/long-term-memory#578ebae524m6l">Long-term memory</a>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>If you pass a <c>memoryId</c>, the system uses automatic creation to generate memory nodes (MemoryNode) under the specified long-term memory based on conversation records. You can also invoke the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-creatememorynode">CreateMemoryNode</a> operation to manually create memory nodes.</description></item>
        /// <item><description>This operation does not support idempotence.
        /// <b>Throttling:</b> Ensure that the interval between two consecutive requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryResponse
        /// </returns>
        public CreateMemoryResponse CreateMemory(string workspaceId, CreateMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMemoryWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can store specific information from conversations (memory nodes. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/long-term-memory">Long-term memory</a>) in a long-term memory. Agent applications can then reference this information in subsequent conversations. This is not an automatic creation procedure. You must first invoke the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-creatememory">CreateMemory</a> operation to create a long-term memory and obtain the <c>memoryId</c>. Then pass the <c>memoryId</c> when you <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/application-calling">invoke the agent application through the API</a>.<remarks>
        /// <para>Long-term memory does not support storing and managing user profiles through the API. Perform related operations in the console. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/long-term-memory#578ebae524m6l">Long-term memory</a>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>If you pass a <c>memoryId</c>, the system uses automatic creation to generate memory nodes (MemoryNode) under the specified long-term memory based on conversation records. You can also invoke the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-creatememorynode">CreateMemoryNode</a> operation to manually create memory nodes.</description></item>
        /// <item><description>This operation does not support idempotence.
        /// <b>Throttling:</b> Ensure that the interval between two consecutive requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryResponse
        /// </returns>
        public async Task<CreateMemoryResponse> CreateMemoryAsync(string workspaceId, CreateMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMemoryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a memory node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryNodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryNodeResponse
        /// </returns>
        public CreateMemoryNodeResponse CreateMemoryNodeWithOptions(string workspaceId, string memoryId, CreateMemoryNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemoryNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a memory node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryNodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryNodeResponse
        /// </returns>
        public async Task<CreateMemoryNodeResponse> CreateMemoryNodeWithOptionsAsync(string workspaceId, string memoryId, CreateMemoryNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemoryNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a memory node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryNodeResponse
        /// </returns>
        public CreateMemoryNodeResponse CreateMemoryNode(string workspaceId, string memoryId, CreateMemoryNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMemoryNodeWithOptions(workspaceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a memory node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryNodeResponse
        /// </returns>
        public async Task<CreateMemoryNodeResponse> CreateMemoryNodeAsync(string workspaceId, string memoryId, CreateMemoryNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMemoryNodeWithOptionsAsync(workspaceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a prompt template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API does not currently support the creation of text-to-image prompt templates.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePromptTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePromptTemplateResponse
        /// </returns>
        public CreatePromptTemplateResponse CreatePromptTemplateWithOptions(string workspaceId, CreatePromptTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePromptTemplate",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/promptTemplates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePromptTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a prompt template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API does not currently support the creation of text-to-image prompt templates.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePromptTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePromptTemplateResponse
        /// </returns>
        public async Task<CreatePromptTemplateResponse> CreatePromptTemplateWithOptionsAsync(string workspaceId, CreatePromptTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePromptTemplate",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/promptTemplates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePromptTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a prompt template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API does not currently support the creation of text-to-image prompt templates.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePromptTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePromptTemplateResponse
        /// </returns>
        public CreatePromptTemplateResponse CreatePromptTemplate(string workspaceId, CreatePromptTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePromptTemplateWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a prompt template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API does not currently support the creation of text-to-image prompt templates.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePromptTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePromptTemplateResponse
        /// </returns>
        public async Task<CreatePromptTemplateResponse> CreatePromptTemplateAsync(string workspaceId, CreatePromptTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePromptTemplateWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public DeleteAgentResponse DeleteAgentWithOptions(string workspaceId, string appCode, DeleteAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appCode),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public async Task<DeleteAgentResponse> DeleteAgentWithOptionsAsync(string workspaceId, string appCode, DeleteAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appCode),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public DeleteAgentResponse DeleteAgent(string workspaceId, string appCode, DeleteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAgentWithOptions(workspaceId, appCode, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public async Task<DeleteAgentResponse> DeleteAgentAsync(string workspaceId, string appCode, DeleteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAgentWithOptionsAsync(workspaceId, appCode, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes a specified category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:DeleteCategory permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. Alibaba Cloud accounts can call this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limiting:</b>
        /// This operation is subject to rate limiting. Do not exceed 5 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCategoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCategoryResponse
        /// </returns>
        public DeleteCategoryResponse DeleteCategoryWithOptions(string CategoryId, string WorkspaceId, DeleteCategoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCategory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/category/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CategoryId) + "/",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes a specified category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:DeleteCategory permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. Alibaba Cloud accounts can call this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limiting:</b>
        /// This operation is subject to rate limiting. Do not exceed 5 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCategoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCategoryResponse
        /// </returns>
        public async Task<DeleteCategoryResponse> DeleteCategoryWithOptionsAsync(string CategoryId, string WorkspaceId, DeleteCategoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCategory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/category/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CategoryId) + "/",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes a specified category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:DeleteCategory permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. Alibaba Cloud accounts can call this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limiting:</b>
        /// This operation is subject to rate limiting. Do not exceed 5 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCategoryResponse
        /// </returns>
        public DeleteCategoryResponse DeleteCategory(string CategoryId, string WorkspaceId, DeleteCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCategoryWithOptions(CategoryId, WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes a specified category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:DeleteCategory permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. Alibaba Cloud accounts can call this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limiting:</b>
        /// This operation is subject to rate limiting. Do not exceed 5 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCategoryResponse
        /// </returns>
        public async Task<DeleteCategoryResponse> DeleteCategoryAsync(string CategoryId, string WorkspaceId, DeleteCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCategoryWithOptionsAsync(CategoryId, WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes specified text chunks from a knowledge base. Deleted text chunks cannot be retrieved or recalled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><warning>  Deleted text chunks cannot be recovered (hard delete). Proceed with caution.</para>
        /// <list type="bullet">
        /// <item><description><b>Permission requirements</b>:<list type="bullet">
        /// <item><description><b>Resource Access Management (RAM) user</b>: Obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio first (you can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:DeleteChunk permission required by this operation), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation.</description></item>
        /// <item><description><b>Alibaba Cloud account</b>: Has permissions by default and can invoke this operation directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Invocation method</b>: Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>. The SDK provides encapsulation of complex signature calculation logic and simplifies the invocation procedure.</description></item>
        /// <item><description><b>Effective latency</b>: Changes typically take effect immediately. During peak hours, there may be a slight delay (seconds).</description></item>
        /// <item><description><b>Idempotence</b>: This operation is idempotent. Repeated calls to delete an already deleted text chunk return a success response.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteChunkRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChunkResponse
        /// </returns>
        public DeleteChunkResponse DeleteChunkWithOptions(string WorkspaceId, DeleteChunkRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteChunkShrinkRequest request = new DeleteChunkShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChunkIds))
            {
                request.ChunkIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChunkIds, "ChunkIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkIdsShrink))
            {
                query["ChunkIds"] = request.ChunkIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChunk",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/chunk/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChunkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes specified text chunks from a knowledge base. Deleted text chunks cannot be retrieved or recalled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><warning>  Deleted text chunks cannot be recovered (hard delete). Proceed with caution.</para>
        /// <list type="bullet">
        /// <item><description><b>Permission requirements</b>:<list type="bullet">
        /// <item><description><b>Resource Access Management (RAM) user</b>: Obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio first (you can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:DeleteChunk permission required by this operation), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation.</description></item>
        /// <item><description><b>Alibaba Cloud account</b>: Has permissions by default and can invoke this operation directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Invocation method</b>: Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>. The SDK provides encapsulation of complex signature calculation logic and simplifies the invocation procedure.</description></item>
        /// <item><description><b>Effective latency</b>: Changes typically take effect immediately. During peak hours, there may be a slight delay (seconds).</description></item>
        /// <item><description><b>Idempotence</b>: This operation is idempotent. Repeated calls to delete an already deleted text chunk return a success response.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteChunkRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChunkResponse
        /// </returns>
        public async Task<DeleteChunkResponse> DeleteChunkWithOptionsAsync(string WorkspaceId, DeleteChunkRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteChunkShrinkRequest request = new DeleteChunkShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChunkIds))
            {
                request.ChunkIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChunkIds, "ChunkIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkIdsShrink))
            {
                query["ChunkIds"] = request.ChunkIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChunk",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/chunk/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChunkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes specified text chunks from a knowledge base. Deleted text chunks cannot be retrieved or recalled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><warning>  Deleted text chunks cannot be recovered (hard delete). Proceed with caution.</para>
        /// <list type="bullet">
        /// <item><description><b>Permission requirements</b>:<list type="bullet">
        /// <item><description><b>Resource Access Management (RAM) user</b>: Obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio first (you can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:DeleteChunk permission required by this operation), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation.</description></item>
        /// <item><description><b>Alibaba Cloud account</b>: Has permissions by default and can invoke this operation directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Invocation method</b>: Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>. The SDK provides encapsulation of complex signature calculation logic and simplifies the invocation procedure.</description></item>
        /// <item><description><b>Effective latency</b>: Changes typically take effect immediately. During peak hours, there may be a slight delay (seconds).</description></item>
        /// <item><description><b>Idempotence</b>: This operation is idempotent. Repeated calls to delete an already deleted text chunk return a success response.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteChunkRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChunkResponse
        /// </returns>
        public DeleteChunkResponse DeleteChunk(string WorkspaceId, DeleteChunkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteChunkWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes specified text chunks from a knowledge base. Deleted text chunks cannot be retrieved or recalled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><warning>  Deleted text chunks cannot be recovered (hard delete). Proceed with caution.</para>
        /// <list type="bullet">
        /// <item><description><b>Permission requirements</b>:<list type="bullet">
        /// <item><description><b>Resource Access Management (RAM) user</b>: Obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio first (you can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:DeleteChunk permission required by this operation), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation.</description></item>
        /// <item><description><b>Alibaba Cloud account</b>: Has permissions by default and can invoke this operation directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Invocation method</b>: Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>. The SDK provides encapsulation of complex signature calculation logic and simplifies the invocation procedure.</description></item>
        /// <item><description><b>Effective latency</b>: Changes typically take effect immediately. During peak hours, there may be a slight delay (seconds).</description></item>
        /// <item><description><b>Idempotence</b>: This operation is idempotent. Repeated calls to delete an already deleted text chunk return a success response.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteChunkRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChunkResponse
        /// </returns>
        public async Task<DeleteChunkResponse> DeleteChunkAsync(string WorkspaceId, DeleteChunkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteChunkWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除连接器</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM用户（子账号）需要首先获取阿里云百炼的<a href="https://help.aliyun.com/document_detail/2848578.html">API权限</a>（需要<c>AliyunBailianDataFullAccess</c>，已包括sfm:DeleteConnector权限点），并<a href="https://help.aliyun.com/document_detail/2851098.html">加入一个业务空间</a>后，方可调用本接口。阿里云账号（主账号）可直接调用无须授权。建议您通过最新版<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a><a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>来调用本接口。</description></item>
        /// <item><description>本接口不具备幂等性。
        /// <b>限流说明：</b>
        /// 本接口频繁调用会被限流，频率请勿超过5次/秒。如遇限流，请稍后重试。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteConnectorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConnectorResponse
        /// </returns>
        public DeleteConnectorResponse DeleteConnectorWithOptions(string ConnectorId, string WorkspaceId, DeleteConnectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConnector",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/connector/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ConnectorId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConnectorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除连接器</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM用户（子账号）需要首先获取阿里云百炼的<a href="https://help.aliyun.com/document_detail/2848578.html">API权限</a>（需要<c>AliyunBailianDataFullAccess</c>，已包括sfm:DeleteConnector权限点），并<a href="https://help.aliyun.com/document_detail/2851098.html">加入一个业务空间</a>后，方可调用本接口。阿里云账号（主账号）可直接调用无须授权。建议您通过最新版<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a><a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>来调用本接口。</description></item>
        /// <item><description>本接口不具备幂等性。
        /// <b>限流说明：</b>
        /// 本接口频繁调用会被限流，频率请勿超过5次/秒。如遇限流，请稍后重试。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteConnectorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConnectorResponse
        /// </returns>
        public async Task<DeleteConnectorResponse> DeleteConnectorWithOptionsAsync(string ConnectorId, string WorkspaceId, DeleteConnectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConnector",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/connector/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ConnectorId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除连接器</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM用户（子账号）需要首先获取阿里云百炼的<a href="https://help.aliyun.com/document_detail/2848578.html">API权限</a>（需要<c>AliyunBailianDataFullAccess</c>，已包括sfm:DeleteConnector权限点），并<a href="https://help.aliyun.com/document_detail/2851098.html">加入一个业务空间</a>后，方可调用本接口。阿里云账号（主账号）可直接调用无须授权。建议您通过最新版<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a><a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>来调用本接口。</description></item>
        /// <item><description>本接口不具备幂等性。
        /// <b>限流说明：</b>
        /// 本接口频繁调用会被限流，频率请勿超过5次/秒。如遇限流，请稍后重试。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteConnectorRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConnectorResponse
        /// </returns>
        public DeleteConnectorResponse DeleteConnector(string ConnectorId, string WorkspaceId, DeleteConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConnectorWithOptions(ConnectorId, WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除连接器</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM用户（子账号）需要首先获取阿里云百炼的<a href="https://help.aliyun.com/document_detail/2848578.html">API权限</a>（需要<c>AliyunBailianDataFullAccess</c>，已包括sfm:DeleteConnector权限点），并<a href="https://help.aliyun.com/document_detail/2851098.html">加入一个业务空间</a>后，方可调用本接口。阿里云账号（主账号）可直接调用无须授权。建议您通过最新版<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a><a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>来调用本接口。</description></item>
        /// <item><description>本接口不具备幂等性。
        /// <b>限流说明：</b>
        /// 本接口频繁调用会被限流，频率请勿超过5次/秒。如遇限流，请稍后重试。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteConnectorRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConnectorResponse
        /// </returns>
        public async Task<DeleteConnectorResponse> DeleteConnectorAsync(string ConnectorId, string WorkspaceId, DeleteConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConnectorWithOptionsAsync(ConnectorId, WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently delete a specified file from application data. Deleting data tables via API is not supported. For details, see the API Guide below.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deleting data tables via API is not supported. To delete a data table or specific data within a table, go to &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> to perform the operation.</description></item>
        /// <item><description>This API is used to delete files in &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> and does not affect any knowledge bases that have already been built. To delete a file from a knowledge base, invoke the <b>DeleteIndexDocument</b> API.</description></item>
        /// <item><description>A RAM user must first obtain the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the <c>sfm:DeleteFile</c> permission point) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this API. An Alibaba Cloud account can invoke this API directly without authorization. We recommend that you use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to invoke this API.</description></item>
        /// <item><description>This API can only delete files whose status is either Failed to Parse (<c>PARSE_FAILED</c>) or Parse Succeeded (<c>PARSE_SUCCESS</c>).</description></item>
        /// <item><description>This API is idempotent.
        /// <b>Rate Limiting Notice:</b>
        /// Frequent invocation of this API will trigger rate limiting. Do not exceed 10 requests per second. If rate limited, retry after a short wait.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileResponse
        /// </returns>
        public DeleteFileResponse DeleteFileWithOptions(string FileId, string WorkspaceId, DeleteFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FileId) + "/",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently delete a specified file from application data. Deleting data tables via API is not supported. For details, see the API Guide below.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deleting data tables via API is not supported. To delete a data table or specific data within a table, go to &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> to perform the operation.</description></item>
        /// <item><description>This API is used to delete files in &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> and does not affect any knowledge bases that have already been built. To delete a file from a knowledge base, invoke the <b>DeleteIndexDocument</b> API.</description></item>
        /// <item><description>A RAM user must first obtain the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the <c>sfm:DeleteFile</c> permission point) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this API. An Alibaba Cloud account can invoke this API directly without authorization. We recommend that you use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to invoke this API.</description></item>
        /// <item><description>This API can only delete files whose status is either Failed to Parse (<c>PARSE_FAILED</c>) or Parse Succeeded (<c>PARSE_SUCCESS</c>).</description></item>
        /// <item><description>This API is idempotent.
        /// <b>Rate Limiting Notice:</b>
        /// Frequent invocation of this API will trigger rate limiting. Do not exceed 10 requests per second. If rate limited, retry after a short wait.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileResponse
        /// </returns>
        public async Task<DeleteFileResponse> DeleteFileWithOptionsAsync(string FileId, string WorkspaceId, DeleteFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FileId) + "/",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently delete a specified file from application data. Deleting data tables via API is not supported. For details, see the API Guide below.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deleting data tables via API is not supported. To delete a data table or specific data within a table, go to &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> to perform the operation.</description></item>
        /// <item><description>This API is used to delete files in &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> and does not affect any knowledge bases that have already been built. To delete a file from a knowledge base, invoke the <b>DeleteIndexDocument</b> API.</description></item>
        /// <item><description>A RAM user must first obtain the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the <c>sfm:DeleteFile</c> permission point) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this API. An Alibaba Cloud account can invoke this API directly without authorization. We recommend that you use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to invoke this API.</description></item>
        /// <item><description>This API can only delete files whose status is either Failed to Parse (<c>PARSE_FAILED</c>) or Parse Succeeded (<c>PARSE_SUCCESS</c>).</description></item>
        /// <item><description>This API is idempotent.
        /// <b>Rate Limiting Notice:</b>
        /// Frequent invocation of this API will trigger rate limiting. Do not exceed 10 requests per second. If rate limited, retry after a short wait.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileResponse
        /// </returns>
        public DeleteFileResponse DeleteFile(string FileId, string WorkspaceId, DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFileWithOptions(FileId, WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently delete a specified file from application data. Deleting data tables via API is not supported. For details, see the API Guide below.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deleting data tables via API is not supported. To delete a data table or specific data within a table, go to &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> to perform the operation.</description></item>
        /// <item><description>This API is used to delete files in &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> and does not affect any knowledge bases that have already been built. To delete a file from a knowledge base, invoke the <b>DeleteIndexDocument</b> API.</description></item>
        /// <item><description>A RAM user must first obtain the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the <c>sfm:DeleteFile</c> permission point) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this API. An Alibaba Cloud account can invoke this API directly without authorization. We recommend that you use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to invoke this API.</description></item>
        /// <item><description>This API can only delete files whose status is either Failed to Parse (<c>PARSE_FAILED</c>) or Parse Succeeded (<c>PARSE_SUCCESS</c>).</description></item>
        /// <item><description>This API is idempotent.
        /// <b>Rate Limiting Notice:</b>
        /// Frequent invocation of this API will trigger rate limiting. Do not exceed 10 requests per second. If rate limited, retry after a short wait.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileResponse
        /// </returns>
        public async Task<DeleteFileResponse> DeleteFileAsync(string FileId, string WorkspaceId, DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFileWithOptionsAsync(FileId, WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete files in batch</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deleting data tables through the API is not supported. To delete a data table or specific data in a table, go to &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>.</description></item>
        /// <item><description>This API is used to delete files in &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>. It does not affect knowledge bases that have already been built. To delete files in a knowledge base, call the <b>DeleteIndexDocument</b> operation.</description></item>
        /// <item><description>A RAM user (sub-account) must first obtain the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which already includes the sfm:DeleteFiles permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. The Alibaba Cloud account (main account) can call this operation directly without authorization. We recommend that you use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation can only delete files whose status is parsing failed (PARSE_FAILED) or parsing succeeded (PARSE_SUCCESS).</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b>
        /// Frequent calls to this operation are throttled. Do not exceed 10 queries per second (QPS). If you are throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteFilesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFilesResponse
        /// </returns>
        public DeleteFilesResponse DeleteFilesWithOptions(string WorkspaceId, DeleteFilesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteFilesShrinkRequest request = new DeleteFilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileIds))
            {
                request.FileIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileIds, "FileIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIdsShrink))
            {
                body["FileIds"] = request.FileIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFiles",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFilesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete files in batch</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deleting data tables through the API is not supported. To delete a data table or specific data in a table, go to &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>.</description></item>
        /// <item><description>This API is used to delete files in &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>. It does not affect knowledge bases that have already been built. To delete files in a knowledge base, call the <b>DeleteIndexDocument</b> operation.</description></item>
        /// <item><description>A RAM user (sub-account) must first obtain the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which already includes the sfm:DeleteFiles permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. The Alibaba Cloud account (main account) can call this operation directly without authorization. We recommend that you use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation can only delete files whose status is parsing failed (PARSE_FAILED) or parsing succeeded (PARSE_SUCCESS).</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b>
        /// Frequent calls to this operation are throttled. Do not exceed 10 queries per second (QPS). If you are throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteFilesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFilesResponse
        /// </returns>
        public async Task<DeleteFilesResponse> DeleteFilesWithOptionsAsync(string WorkspaceId, DeleteFilesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteFilesShrinkRequest request = new DeleteFilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileIds))
            {
                request.FileIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileIds, "FileIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIdsShrink))
            {
                body["FileIds"] = request.FileIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFiles",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete files in batch</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deleting data tables through the API is not supported. To delete a data table or specific data in a table, go to &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>.</description></item>
        /// <item><description>This API is used to delete files in &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>. It does not affect knowledge bases that have already been built. To delete files in a knowledge base, call the <b>DeleteIndexDocument</b> operation.</description></item>
        /// <item><description>A RAM user (sub-account) must first obtain the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which already includes the sfm:DeleteFiles permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. The Alibaba Cloud account (main account) can call this operation directly without authorization. We recommend that you use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation can only delete files whose status is parsing failed (PARSE_FAILED) or parsing succeeded (PARSE_SUCCESS).</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b>
        /// Frequent calls to this operation are throttled. Do not exceed 10 queries per second (QPS). If you are throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFilesResponse
        /// </returns>
        public DeleteFilesResponse DeleteFiles(string WorkspaceId, DeleteFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFilesWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete files in batch</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deleting data tables through the API is not supported. To delete a data table or specific data in a table, go to &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>.</description></item>
        /// <item><description>This API is used to delete files in &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>. It does not affect knowledge bases that have already been built. To delete files in a knowledge base, call the <b>DeleteIndexDocument</b> operation.</description></item>
        /// <item><description>A RAM user (sub-account) must first obtain the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which already includes the sfm:DeleteFiles permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. The Alibaba Cloud account (main account) can call this operation directly without authorization. We recommend that you use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation can only delete files whose status is parsing failed (PARSE_FAILED) or parsing succeeded (PARSE_SUCCESS).</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b>
        /// Frequent calls to this operation are throttled. Do not exceed 10 queries per second (QPS). If you are throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFilesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFilesResponse
        /// </returns>
        public async Task<DeleteFilesResponse> DeleteFilesAsync(string WorkspaceId, DeleteFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFilesWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:DeleteIndex permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>If the knowledge base is associated with an application, you must first dissociate it from the application before deleting it. This can currently only be done through the console. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>.</description></item>
        /// <item><description>Deletion is irreversible. A deleted knowledge base cannot be recovered. Proceed with caution.</description></item>
        /// <item><description>Invoking this operation does not delete files that have been imported into &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>.</description></item>
        /// <item><description>This operation has idempotence.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndexResponse
        /// </returns>
        public DeleteIndexResponse DeleteIndexWithOptions(string WorkspaceId, DeleteIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndex",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndexResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:DeleteIndex permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>If the knowledge base is associated with an application, you must first dissociate it from the application before deleting it. This can currently only be done through the console. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>.</description></item>
        /// <item><description>Deletion is irreversible. A deleted knowledge base cannot be recovered. Proceed with caution.</description></item>
        /// <item><description>Invoking this operation does not delete files that have been imported into &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>.</description></item>
        /// <item><description>This operation has idempotence.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndexResponse
        /// </returns>
        public async Task<DeleteIndexResponse> DeleteIndexWithOptionsAsync(string WorkspaceId, DeleteIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndex",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:DeleteIndex permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>If the knowledge base is associated with an application, you must first dissociate it from the application before deleting it. This can currently only be done through the console. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>.</description></item>
        /// <item><description>Deletion is irreversible. A deleted knowledge base cannot be recovered. Proceed with caution.</description></item>
        /// <item><description>Invoking this operation does not delete files that have been imported into &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>.</description></item>
        /// <item><description>This operation has idempotence.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndexResponse
        /// </returns>
        public DeleteIndexResponse DeleteIndex(string WorkspaceId, DeleteIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIndexWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:DeleteIndex permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>If the knowledge base is associated with an application, you must first dissociate it from the application before deleting it. This can currently only be done through the console. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>.</description></item>
        /// <item><description>Deletion is irreversible. A deleted knowledge base cannot be recovered. Proceed with caution.</description></item>
        /// <item><description>Invoking this operation does not delete files that have been imported into &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>.</description></item>
        /// <item><description>This operation has idempotence.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndexResponse
        /// </returns>
        public async Task<DeleteIndexResponse> DeleteIndexAsync(string WorkspaceId, DeleteIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIndexWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes files from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation does not support deleting data from data query or image Q&amp;A knowledge bases. Use the Model Studio console instead.</description></item>
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:DeleteIndexDocument permission), before calling this operation. Alibaba Cloud accounts can call this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>Before calling this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>You can only delete files whose status is import failed (INSERT_ERROR) or import succeeded (FINISH) in the knowledge base. To query the file status in a specified knowledge base, call the <b>ListIndexDocuments</b> operation.</description></item>
        /// <item><description>Deletion is irreversible. The content of deleted files cannot be recovered, and the <b>Retrieve</b> operation can no longer retrieve related information. Proceed with caution.</description></item>
        /// <item><description>Calling this operation does not delete documents that have been imported into &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteIndexDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndexDocumentResponse
        /// </returns>
        public DeleteIndexDocumentResponse DeleteIndexDocumentWithOptions(string WorkspaceId, DeleteIndexDocumentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteIndexDocumentShrinkRequest request = new DeleteIndexDocumentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentIds))
            {
                request.DocumentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentIds, "DocumentIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIdsShrink))
            {
                query["DocumentIds"] = request.DocumentIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndexDocument",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/delete_index_document",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndexDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes files from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation does not support deleting data from data query or image Q&amp;A knowledge bases. Use the Model Studio console instead.</description></item>
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:DeleteIndexDocument permission), before calling this operation. Alibaba Cloud accounts can call this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>Before calling this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>You can only delete files whose status is import failed (INSERT_ERROR) or import succeeded (FINISH) in the knowledge base. To query the file status in a specified knowledge base, call the <b>ListIndexDocuments</b> operation.</description></item>
        /// <item><description>Deletion is irreversible. The content of deleted files cannot be recovered, and the <b>Retrieve</b> operation can no longer retrieve related information. Proceed with caution.</description></item>
        /// <item><description>Calling this operation does not delete documents that have been imported into &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteIndexDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndexDocumentResponse
        /// </returns>
        public async Task<DeleteIndexDocumentResponse> DeleteIndexDocumentWithOptionsAsync(string WorkspaceId, DeleteIndexDocumentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteIndexDocumentShrinkRequest request = new DeleteIndexDocumentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentIds))
            {
                request.DocumentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentIds, "DocumentIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIdsShrink))
            {
                query["DocumentIds"] = request.DocumentIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndexDocument",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/delete_index_document",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndexDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes files from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation does not support deleting data from data query or image Q&amp;A knowledge bases. Use the Model Studio console instead.</description></item>
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:DeleteIndexDocument permission), before calling this operation. Alibaba Cloud accounts can call this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>Before calling this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>You can only delete files whose status is import failed (INSERT_ERROR) or import succeeded (FINISH) in the knowledge base. To query the file status in a specified knowledge base, call the <b>ListIndexDocuments</b> operation.</description></item>
        /// <item><description>Deletion is irreversible. The content of deleted files cannot be recovered, and the <b>Retrieve</b> operation can no longer retrieve related information. Proceed with caution.</description></item>
        /// <item><description>Calling this operation does not delete documents that have been imported into &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIndexDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndexDocumentResponse
        /// </returns>
        public DeleteIndexDocumentResponse DeleteIndexDocument(string WorkspaceId, DeleteIndexDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIndexDocumentWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes files from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation does not support deleting data from data query or image Q&amp;A knowledge bases. Use the Model Studio console instead.</description></item>
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:DeleteIndexDocument permission), before calling this operation. Alibaba Cloud accounts can call this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>Before calling this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>You can only delete files whose status is import failed (INSERT_ERROR) or import succeeded (FINISH) in the knowledge base. To query the file status in a specified knowledge base, call the <b>ListIndexDocuments</b> operation.</description></item>
        /// <item><description>Deletion is irreversible. The content of deleted files cannot be recovered, and the <b>Retrieve</b> operation can no longer retrieve related information. Proceed with caution.</description></item>
        /// <item><description>Calling this operation does not delete documents that have been imported into &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a>.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIndexDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndexDocumentResponse
        /// </returns>
        public async Task<DeleteIndexDocumentResponse> DeleteIndexDocumentAsync(string WorkspaceId, DeleteIndexDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIndexDocumentWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes a specified long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before calling this operation, make sure that your long-term memory has been created and has not been deleted (that is, the memoryId is valid).</description></item>
        /// <item><description>The delete operation is irreversible. The deleted long-term memory, including all of its long-term memory nodes, cannot be recovered. The <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-getmemory">GetMemory</a> operation will no longer be able to retrieve its information. Proceed with caution.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b> Make sure that the interval between two requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryResponse
        /// </returns>
        public DeleteMemoryResponse DeleteMemoryWithOptions(string workspaceId, string memoryId, DeleteMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes a specified long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before calling this operation, make sure that your long-term memory has been created and has not been deleted (that is, the memoryId is valid).</description></item>
        /// <item><description>The delete operation is irreversible. The deleted long-term memory, including all of its long-term memory nodes, cannot be recovered. The <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-getmemory">GetMemory</a> operation will no longer be able to retrieve its information. Proceed with caution.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b> Make sure that the interval between two requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryResponse
        /// </returns>
        public async Task<DeleteMemoryResponse> DeleteMemoryWithOptionsAsync(string workspaceId, string memoryId, DeleteMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes a specified long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before calling this operation, make sure that your long-term memory has been created and has not been deleted (that is, the memoryId is valid).</description></item>
        /// <item><description>The delete operation is irreversible. The deleted long-term memory, including all of its long-term memory nodes, cannot be recovered. The <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-getmemory">GetMemory</a> operation will no longer be able to retrieve its information. Proceed with caution.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b> Make sure that the interval between two requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryResponse
        /// </returns>
        public DeleteMemoryResponse DeleteMemory(string workspaceId, string memoryId, DeleteMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMemoryWithOptions(workspaceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Permanently deletes a specified long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before calling this operation, make sure that your long-term memory has been created and has not been deleted (that is, the memoryId is valid).</description></item>
        /// <item><description>The delete operation is irreversible. The deleted long-term memory, including all of its long-term memory nodes, cannot be recovered. The <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-getmemory">GetMemory</a> operation will no longer be able to retrieve its information. Proceed with caution.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b> Make sure that the interval between two requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryResponse
        /// </returns>
        public async Task<DeleteMemoryResponse> DeleteMemoryAsync(string workspaceId, string memoryId, DeleteMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMemoryWithOptionsAsync(workspaceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a memory fragment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoryNodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryNodeResponse
        /// </returns>
        public DeleteMemoryNodeResponse DeleteMemoryNodeWithOptions(string workspaceId, string memoryId, string memoryNodeId, DeleteMemoryNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryNodeId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a memory fragment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoryNodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryNodeResponse
        /// </returns>
        public async Task<DeleteMemoryNodeResponse> DeleteMemoryNodeWithOptionsAsync(string workspaceId, string memoryId, string memoryNodeId, DeleteMemoryNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryNodeId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a memory fragment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoryNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryNodeResponse
        /// </returns>
        public DeleteMemoryNodeResponse DeleteMemoryNode(string workspaceId, string memoryId, string memoryNodeId, DeleteMemoryNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMemoryNodeWithOptions(workspaceId, memoryId, memoryNodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a memory fragment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMemoryNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryNodeResponse
        /// </returns>
        public async Task<DeleteMemoryNodeResponse> DeleteMemoryNodeAsync(string workspaceId, string memoryId, string memoryNodeId, DeleteMemoryNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMemoryNodeWithOptionsAsync(workspaceId, memoryId, memoryNodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a prompt template based on the template ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePromptTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePromptTemplateResponse
        /// </returns>
        public DeletePromptTemplateResponse DeletePromptTemplateWithOptions(string workspaceId, string promptTemplateId, DeletePromptTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePromptTemplate",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/promptTemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(promptTemplateId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePromptTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a prompt template based on the template ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePromptTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePromptTemplateResponse
        /// </returns>
        public async Task<DeletePromptTemplateResponse> DeletePromptTemplateWithOptionsAsync(string workspaceId, string promptTemplateId, DeletePromptTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePromptTemplate",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/promptTemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(promptTemplateId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePromptTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a prompt template based on the template ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePromptTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePromptTemplateResponse
        /// </returns>
        public DeletePromptTemplateResponse DeletePromptTemplate(string workspaceId, string promptTemplateId, DeletePromptTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePromptTemplateWithOptions(workspaceId, promptTemplateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a prompt template based on the template ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePromptTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePromptTemplateResponse
        /// </returns>
        public async Task<DeletePromptTemplateResponse> DeletePromptTemplateAsync(string workspaceId, string promptTemplateId, DeletePromptTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePromptTemplateWithOptionsAsync(workspaceId, promptTemplateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about a file in application data, including the file name, type, and status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A Resource Access Management (RAM) user must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (<c>AliyunBailianDataFullAccess</c> or <c>AliyunBailianDataReadOnlyAccess</c>, both of which include the sfm:DescribeFile permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. An Alibaba Cloud account can invoke this operation directly without authorization. Invoke this operation by using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileResponse
        /// </returns>
        public DescribeFileResponse DescribeFileWithOptions(string WorkspaceId, string FileId, DescribeFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FileId) + "/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about a file in application data, including the file name, type, and status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A Resource Access Management (RAM) user must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (<c>AliyunBailianDataFullAccess</c> or <c>AliyunBailianDataReadOnlyAccess</c>, both of which include the sfm:DescribeFile permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. An Alibaba Cloud account can invoke this operation directly without authorization. Invoke this operation by using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileResponse
        /// </returns>
        public async Task<DescribeFileResponse> DescribeFileWithOptionsAsync(string WorkspaceId, string FileId, DescribeFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FileId) + "/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about a file in application data, including the file name, type, and status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A Resource Access Management (RAM) user must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (<c>AliyunBailianDataFullAccess</c> or <c>AliyunBailianDataReadOnlyAccess</c>, both of which include the sfm:DescribeFile permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. An Alibaba Cloud account can invoke this operation directly without authorization. Invoke this operation by using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFileRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileResponse
        /// </returns>
        public DescribeFileResponse DescribeFile(string WorkspaceId, string FileId, DescribeFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeFileWithOptions(WorkspaceId, FileId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about a file in application data, including the file name, type, and status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A Resource Access Management (RAM) user must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (<c>AliyunBailianDataFullAccess</c> or <c>AliyunBailianDataReadOnlyAccess</c>, both of which include the sfm:DescribeFile permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. An Alibaba Cloud account can invoke this operation directly without authorization. Invoke this operation by using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFileRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileResponse
        /// </returns>
        public async Task<DescribeFileResponse> DescribeFileAsync(string WorkspaceId, string FileId, DescribeFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeFileWithOptionsAsync(WorkspaceId, FileId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tipping status of the Alipay wallet bound to an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlipayTransferStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlipayTransferStatusResponse
        /// </returns>
        public GetAlipayTransferStatusResponse GetAlipayTransferStatusWithOptions(GetAlipayTransferStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspace_id"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlipayTransferStatus",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/openapi/alipay/transfer/status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlipayTransferStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tipping status of the Alipay wallet bound to an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlipayTransferStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlipayTransferStatusResponse
        /// </returns>
        public async Task<GetAlipayTransferStatusResponse> GetAlipayTransferStatusWithOptionsAsync(GetAlipayTransferStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspace_id"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlipayTransferStatus",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/openapi/alipay/transfer/status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlipayTransferStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tipping status of the Alipay wallet bound to an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlipayTransferStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlipayTransferStatusResponse
        /// </returns>
        public GetAlipayTransferStatusResponse GetAlipayTransferStatus(GetAlipayTransferStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAlipayTransferStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tipping status of the Alipay wallet bound to an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlipayTransferStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlipayTransferStatusResponse
        /// </returns>
        public async Task<GetAlipayTransferStatusResponse> GetAlipayTransferStatusAsync(GetAlipayTransferStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAlipayTransferStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the Alipay tipping URL for an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlipayUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlipayUrlResponse
        /// </returns>
        public GetAlipayUrlResponse GetAlipayUrlWithOptions(GetAlipayUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["app_id"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspace_id"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlipayUrl",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/openapi/alipay/transfer/url",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlipayUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the Alipay tipping URL for an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlipayUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlipayUrlResponse
        /// </returns>
        public async Task<GetAlipayUrlResponse> GetAlipayUrlWithOptionsAsync(GetAlipayUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["app_id"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspace_id"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlipayUrl",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/openapi/alipay/transfer/url",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlipayUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the Alipay tipping URL for an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlipayUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlipayUrlResponse
        /// </returns>
        public GetAlipayUrlResponse GetAlipayUrl(GetAlipayUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAlipayUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the Alipay tipping URL for an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlipayUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlipayUrlResponse
        /// </returns>
        public async Task<GetAlipayUrlResponse> GetAlipayUrlAsync(GetAlipayUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAlipayUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all supported parser types based on the input file type (file extension).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM用户（子账号）需要首先获取阿里云百炼的<a href="https://help.aliyun.com/document_detail/2848578.html">API权限</a>（<c>AliyunBailianDataFullAccess</c>或<c>AliyunBailianDataReadOnlyAccess</c>均可，已包括sfm:GetAvailableParserTypes权限点），并<a href="https://help.aliyun.com/document_detail/2851098.html">加入一个业务空间</a>后，方可调用本接口。阿里云账号（主账号）可直接调用无须授权。建议您通过最新版&lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>来调用本接口。</description></item>
        /// <item><description>本接口具有幂等性。
        /// <b>限流说明：</b>
        /// 本接口频繁调用会被限流，频率请勿超过10次/秒。如遇限流，请稍后重试。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAvailableParserTypesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAvailableParserTypesResponse
        /// </returns>
        public GetAvailableParserTypesResponse GetAvailableParserTypesWithOptions(string WorkspaceId, GetAvailableParserTypesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAvailableParserTypes",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/parser/parsertype",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAvailableParserTypesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all supported parser types based on the input file type (file extension).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM用户（子账号）需要首先获取阿里云百炼的<a href="https://help.aliyun.com/document_detail/2848578.html">API权限</a>（<c>AliyunBailianDataFullAccess</c>或<c>AliyunBailianDataReadOnlyAccess</c>均可，已包括sfm:GetAvailableParserTypes权限点），并<a href="https://help.aliyun.com/document_detail/2851098.html">加入一个业务空间</a>后，方可调用本接口。阿里云账号（主账号）可直接调用无须授权。建议您通过最新版&lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>来调用本接口。</description></item>
        /// <item><description>本接口具有幂等性。
        /// <b>限流说明：</b>
        /// 本接口频繁调用会被限流，频率请勿超过10次/秒。如遇限流，请稍后重试。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAvailableParserTypesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAvailableParserTypesResponse
        /// </returns>
        public async Task<GetAvailableParserTypesResponse> GetAvailableParserTypesWithOptionsAsync(string WorkspaceId, GetAvailableParserTypesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAvailableParserTypes",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/parser/parsertype",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAvailableParserTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all supported parser types based on the input file type (file extension).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM用户（子账号）需要首先获取阿里云百炼的<a href="https://help.aliyun.com/document_detail/2848578.html">API权限</a>（<c>AliyunBailianDataFullAccess</c>或<c>AliyunBailianDataReadOnlyAccess</c>均可，已包括sfm:GetAvailableParserTypes权限点），并<a href="https://help.aliyun.com/document_detail/2851098.html">加入一个业务空间</a>后，方可调用本接口。阿里云账号（主账号）可直接调用无须授权。建议您通过最新版&lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>来调用本接口。</description></item>
        /// <item><description>本接口具有幂等性。
        /// <b>限流说明：</b>
        /// 本接口频繁调用会被限流，频率请勿超过10次/秒。如遇限流，请稍后重试。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAvailableParserTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAvailableParserTypesResponse
        /// </returns>
        public GetAvailableParserTypesResponse GetAvailableParserTypes(string WorkspaceId, GetAvailableParserTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAvailableParserTypesWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all supported parser types based on the input file type (file extension).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM用户（子账号）需要首先获取阿里云百炼的<a href="https://help.aliyun.com/document_detail/2848578.html">API权限</a>（<c>AliyunBailianDataFullAccess</c>或<c>AliyunBailianDataReadOnlyAccess</c>均可，已包括sfm:GetAvailableParserTypes权限点），并<a href="https://help.aliyun.com/document_detail/2851098.html">加入一个业务空间</a>后，方可调用本接口。阿里云账号（主账号）可直接调用无须授权。建议您通过最新版&lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>来调用本接口。</description></item>
        /// <item><description>本接口具有幂等性。
        /// <b>限流说明：</b>
        /// 本接口频繁调用会被限流，频率请勿超过10次/秒。如遇限流，请稍后重试。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAvailableParserTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAvailableParserTypesResponse
        /// </returns>
        public async Task<GetAvailableParserTypesResponse> GetAvailableParserTypesAsync(string WorkspaceId, GetAvailableParserTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAvailableParserTypesWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves details about a connector. This operation currently supports only file connectors.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this operation, a RAM user (sub-account) must have the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and must <a href="https://help.aliyun.com/document_detail/2851098.html">join a business space</a>. This requires the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:GetConnector permission. An Alibaba Cloud account (primary account) can call this operation directly. We recommend using the latest <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a><a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b>
        /// This operation is subject to throttling. Do not exceed a frequency of 5 calls per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConnectorResponse
        /// </returns>
        public GetConnectorResponse GetConnectorWithOptions(string WorkspaceId, GetConnectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                query["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorName))
            {
                query["ConnectorName"] = request.ConnectorName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnector",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/connector",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves details about a connector. This operation currently supports only file connectors.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this operation, a RAM user (sub-account) must have the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and must <a href="https://help.aliyun.com/document_detail/2851098.html">join a business space</a>. This requires the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:GetConnector permission. An Alibaba Cloud account (primary account) can call this operation directly. We recommend using the latest <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a><a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b>
        /// This operation is subject to throttling. Do not exceed a frequency of 5 calls per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConnectorResponse
        /// </returns>
        public async Task<GetConnectorResponse> GetConnectorWithOptionsAsync(string WorkspaceId, GetConnectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                query["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorName))
            {
                query["ConnectorName"] = request.ConnectorName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnector",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/connector",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves details about a connector. This operation currently supports only file connectors.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this operation, a RAM user (sub-account) must have the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and must <a href="https://help.aliyun.com/document_detail/2851098.html">join a business space</a>. This requires the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:GetConnector permission. An Alibaba Cloud account (primary account) can call this operation directly. We recommend using the latest <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a><a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b>
        /// This operation is subject to throttling. Do not exceed a frequency of 5 calls per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectorRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConnectorResponse
        /// </returns>
        public GetConnectorResponse GetConnector(string WorkspaceId, GetConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetConnectorWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves details about a connector. This operation currently supports only file connectors.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this operation, a RAM user (sub-account) must have the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and must <a href="https://help.aliyun.com/document_detail/2851098.html">join a business space</a>. This requires the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:GetConnector permission. An Alibaba Cloud account (primary account) can call this operation directly. We recommend using the latest <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a><a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b>
        /// This operation is subject to throttling. Do not exceed a frequency of 5 calls per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectorRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConnectorResponse
        /// </returns>
        public async Task<GetConnectorResponse> GetConnectorAsync(string WorkspaceId, GetConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetConnectorWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current status of a specified knowledge base creation job or knowledge base document append job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (<c>AliyunBailianDataFullAccess</c> or <c>AliyunBailianDataReadOnlyAccess</c>, both of which include the sfm:GetIndexJobStatus permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>You must have a knowledge base job task in progress. To create a knowledge base creation task, invoke the <b>SubmitIndexJob</b> operation. To create a knowledge base document append task, invoke the <b>SubmitIndexAddDocumentsJob</b> operation. Obtain the corresponding <c>JobId</c> from the response.</description></item>
        /// <item><description>Invoke this operation at intervals of 5 seconds or more.</description></item>
        /// <item><description>This operation is idempotent.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetIndexJobStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndexJobStatusResponse
        /// </returns>
        public GetIndexJobStatusResponse GetIndexJobStatusWithOptions(string WorkspaceId, GetIndexJobStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndexJobStatus",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/job/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexJobStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current status of a specified knowledge base creation job or knowledge base document append job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (<c>AliyunBailianDataFullAccess</c> or <c>AliyunBailianDataReadOnlyAccess</c>, both of which include the sfm:GetIndexJobStatus permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>You must have a knowledge base job task in progress. To create a knowledge base creation task, invoke the <b>SubmitIndexJob</b> operation. To create a knowledge base document append task, invoke the <b>SubmitIndexAddDocumentsJob</b> operation. Obtain the corresponding <c>JobId</c> from the response.</description></item>
        /// <item><description>Invoke this operation at intervals of 5 seconds or more.</description></item>
        /// <item><description>This operation is idempotent.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetIndexJobStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndexJobStatusResponse
        /// </returns>
        public async Task<GetIndexJobStatusResponse> GetIndexJobStatusWithOptionsAsync(string WorkspaceId, GetIndexJobStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndexJobStatus",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/job/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexJobStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current status of a specified knowledge base creation job or knowledge base document append job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (<c>AliyunBailianDataFullAccess</c> or <c>AliyunBailianDataReadOnlyAccess</c>, both of which include the sfm:GetIndexJobStatus permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>You must have a knowledge base job task in progress. To create a knowledge base creation task, invoke the <b>SubmitIndexJob</b> operation. To create a knowledge base document append task, invoke the <b>SubmitIndexAddDocumentsJob</b> operation. Obtain the corresponding <c>JobId</c> from the response.</description></item>
        /// <item><description>Invoke this operation at intervals of 5 seconds or more.</description></item>
        /// <item><description>This operation is idempotent.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetIndexJobStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIndexJobStatusResponse
        /// </returns>
        public GetIndexJobStatusResponse GetIndexJobStatus(string WorkspaceId, GetIndexJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIndexJobStatusWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current status of a specified knowledge base creation job or knowledge base document append job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (<c>AliyunBailianDataFullAccess</c> or <c>AliyunBailianDataReadOnlyAccess</c>, both of which include the sfm:GetIndexJobStatus permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>You must have a knowledge base job task in progress. To create a knowledge base creation task, invoke the <b>SubmitIndexJob</b> operation. To create a knowledge base document append task, invoke the <b>SubmitIndexAddDocumentsJob</b> operation. Obtain the corresponding <c>JobId</c> from the response.</description></item>
        /// <item><description>Invoke this operation at intervals of 5 seconds or more.</description></item>
        /// <item><description>This operation is idempotent.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetIndexJobStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIndexJobStatusResponse
        /// </returns>
        public async Task<GetIndexJobStatusResponse> GetIndexJobStatusAsync(string WorkspaceId, GetIndexJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIndexJobStatusWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the GetIndexMonitor operation to query monitoring data for a specified knowledge base within a specific time range. This data is crucial for App Performance Analytics, capacity planning, and cost management. The monitoring data includes two main dimensions: storage and retrieval. Storage monitoring retrieves the index storage limit and current usage of the knowledge base. Retrieval monitoring retrieves performance metrics for the query period, such as peak queries per second (QPS), total requests, and average QPS. The metrics are provided as totals and are also broken down by time window. The requests are categorized as successful, failed, and rate-limited.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;intl&quot;&gt;
        /// This operation is not available on the Alibaba Cloud International Website (www\.alibabacloud.com).
        /// &lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, a RAM user must obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (which requires the <c>AliyunBailianDataFullAccess</c> permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. Alibaba Cloud accounts can call this operation directly without authorization. You can call this operation using the latest version of the <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio software development kit (SDK)</a>. Before you call this operation, make sure that the specified knowledge base has been created and has not been deleted. This means that the knowledge base ID (<c>IndexId</c>) must be valid. This operation is idempotent. The maximum query time range (EndTimestamp - StartTimestamp) is 30 days. The granularity of the time window in the returned data is dynamically adjusted based on the query time range.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetIndexMonitorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndexMonitorResponse
        /// </returns>
        public GetIndexMonitorResponse GetIndexMonitorWithOptions(string WorkspaceId, GetIndexMonitorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndexMonitor",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/rag/index/monitor",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexMonitorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the GetIndexMonitor operation to query monitoring data for a specified knowledge base within a specific time range. This data is crucial for App Performance Analytics, capacity planning, and cost management. The monitoring data includes two main dimensions: storage and retrieval. Storage monitoring retrieves the index storage limit and current usage of the knowledge base. Retrieval monitoring retrieves performance metrics for the query period, such as peak queries per second (QPS), total requests, and average QPS. The metrics are provided as totals and are also broken down by time window. The requests are categorized as successful, failed, and rate-limited.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;intl&quot;&gt;
        /// This operation is not available on the Alibaba Cloud International Website (www\.alibabacloud.com).
        /// &lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, a RAM user must obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (which requires the <c>AliyunBailianDataFullAccess</c> permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. Alibaba Cloud accounts can call this operation directly without authorization. You can call this operation using the latest version of the <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio software development kit (SDK)</a>. Before you call this operation, make sure that the specified knowledge base has been created and has not been deleted. This means that the knowledge base ID (<c>IndexId</c>) must be valid. This operation is idempotent. The maximum query time range (EndTimestamp - StartTimestamp) is 30 days. The granularity of the time window in the returned data is dynamically adjusted based on the query time range.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetIndexMonitorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndexMonitorResponse
        /// </returns>
        public async Task<GetIndexMonitorResponse> GetIndexMonitorWithOptionsAsync(string WorkspaceId, GetIndexMonitorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndexMonitor",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/rag/index/monitor",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the GetIndexMonitor operation to query monitoring data for a specified knowledge base within a specific time range. This data is crucial for App Performance Analytics, capacity planning, and cost management. The monitoring data includes two main dimensions: storage and retrieval. Storage monitoring retrieves the index storage limit and current usage of the knowledge base. Retrieval monitoring retrieves performance metrics for the query period, such as peak queries per second (QPS), total requests, and average QPS. The metrics are provided as totals and are also broken down by time window. The requests are categorized as successful, failed, and rate-limited.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;intl&quot;&gt;
        /// This operation is not available on the Alibaba Cloud International Website (www\.alibabacloud.com).
        /// &lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, a RAM user must obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (which requires the <c>AliyunBailianDataFullAccess</c> permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. Alibaba Cloud accounts can call this operation directly without authorization. You can call this operation using the latest version of the <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio software development kit (SDK)</a>. Before you call this operation, make sure that the specified knowledge base has been created and has not been deleted. This means that the knowledge base ID (<c>IndexId</c>) must be valid. This operation is idempotent. The maximum query time range (EndTimestamp - StartTimestamp) is 30 days. The granularity of the time window in the returned data is dynamically adjusted based on the query time range.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetIndexMonitorRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIndexMonitorResponse
        /// </returns>
        public GetIndexMonitorResponse GetIndexMonitor(string WorkspaceId, GetIndexMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIndexMonitorWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the GetIndexMonitor operation to query monitoring data for a specified knowledge base within a specific time range. This data is crucial for App Performance Analytics, capacity planning, and cost management. The monitoring data includes two main dimensions: storage and retrieval. Storage monitoring retrieves the index storage limit and current usage of the knowledge base. Retrieval monitoring retrieves performance metrics for the query period, such as peak queries per second (QPS), total requests, and average QPS. The metrics are provided as totals and are also broken down by time window. The requests are categorized as successful, failed, and rate-limited.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;intl&quot;&gt;
        /// This operation is not available on the Alibaba Cloud International Website (www\.alibabacloud.com).
        /// &lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, a RAM user must obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (which requires the <c>AliyunBailianDataFullAccess</c> permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. Alibaba Cloud accounts can call this operation directly without authorization. You can call this operation using the latest version of the <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio software development kit (SDK)</a>. Before you call this operation, make sure that the specified knowledge base has been created and has not been deleted. This means that the knowledge base ID (<c>IndexId</c>) must be valid. This operation is idempotent. The maximum query time range (EndTimestamp - StartTimestamp) is 30 days. The granularity of the time window in the returned data is dynamically adjusted based on the query time range.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetIndexMonitorRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIndexMonitorResponse
        /// </returns>
        public async Task<GetIndexMonitorResponse> GetIndexMonitorAsync(string WorkspaceId, GetIndexMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIndexMonitorWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the description of a specified long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b> Ensure that the interval between two consecutive requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryResponse
        /// </returns>
        public GetMemoryResponse GetMemoryWithOptions(string workspaceId, string memoryId, GetMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the description of a specified long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b> Ensure that the interval between two consecutive requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryResponse
        /// </returns>
        public async Task<GetMemoryResponse> GetMemoryWithOptionsAsync(string workspaceId, string memoryId, GetMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the description of a specified long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b> Ensure that the interval between two consecutive requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryResponse
        /// </returns>
        public GetMemoryResponse GetMemory(string workspaceId, string memoryId, GetMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemoryWithOptions(workspaceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the description of a specified long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b> Ensure that the interval between two consecutive requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryResponse
        /// </returns>
        public async Task<GetMemoryResponse> GetMemoryAsync(string workspaceId, string memoryId, GetMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemoryWithOptionsAsync(workspaceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a memory fragment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryNodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryNodeResponse
        /// </returns>
        public GetMemoryNodeResponse GetMemoryNodeWithOptions(string workspaceId, string memoryId, string memoryNodeId, GetMemoryNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryNodeId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a memory fragment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryNodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryNodeResponse
        /// </returns>
        public async Task<GetMemoryNodeResponse> GetMemoryNodeWithOptionsAsync(string workspaceId, string memoryId, string memoryNodeId, GetMemoryNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryNodeId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a memory fragment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryNodeResponse
        /// </returns>
        public GetMemoryNodeResponse GetMemoryNode(string workspaceId, string memoryId, string memoryNodeId, GetMemoryNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemoryNodeWithOptions(workspaceId, memoryId, memoryNodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a memory fragment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemoryNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryNodeResponse
        /// </returns>
        public async Task<GetMemoryNodeResponse> GetMemoryNodeAsync(string workspaceId, string memoryId, string memoryNodeId, GetMemoryNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemoryNodeWithOptionsAsync(workspaceId, memoryId, memoryNodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data parsing settings in a specified category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM用户（子账号）需要首先获取阿里云百炼的<a href="https://help.aliyun.com/document_detail/2848578.html">API权限</a>（<c>AliyunBailianDataFullAccess</c>或<c>AliyunBailianDataReadOnlyAccess</c>均可，已包括sfm:GetParseSettings权限点），并<a href="https://help.aliyun.com/document_detail/2851098.html">加入一个业务空间</a>后，方可调用本接口。阿里云账号（主账号）可直接调用无须授权。建议您通过最新版&lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>来调用本接口。</description></item>
        /// <item><description>本接口具有幂等性。
        /// <b>限流说明：</b>
        /// 本接口频繁调用会被限流，频率请勿超过10次/秒。如遇限流，请稍后重试。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetParseSettingsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParseSettingsResponse
        /// </returns>
        public GetParseSettingsResponse GetParseSettingsWithOptions(string WorkspaceId, GetParseSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParseSettings",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/parser/settings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParseSettingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data parsing settings in a specified category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM用户（子账号）需要首先获取阿里云百炼的<a href="https://help.aliyun.com/document_detail/2848578.html">API权限</a>（<c>AliyunBailianDataFullAccess</c>或<c>AliyunBailianDataReadOnlyAccess</c>均可，已包括sfm:GetParseSettings权限点），并<a href="https://help.aliyun.com/document_detail/2851098.html">加入一个业务空间</a>后，方可调用本接口。阿里云账号（主账号）可直接调用无须授权。建议您通过最新版&lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>来调用本接口。</description></item>
        /// <item><description>本接口具有幂等性。
        /// <b>限流说明：</b>
        /// 本接口频繁调用会被限流，频率请勿超过10次/秒。如遇限流，请稍后重试。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetParseSettingsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParseSettingsResponse
        /// </returns>
        public async Task<GetParseSettingsResponse> GetParseSettingsWithOptionsAsync(string WorkspaceId, GetParseSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParseSettings",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/parser/settings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParseSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data parsing settings in a specified category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM用户（子账号）需要首先获取阿里云百炼的<a href="https://help.aliyun.com/document_detail/2848578.html">API权限</a>（<c>AliyunBailianDataFullAccess</c>或<c>AliyunBailianDataReadOnlyAccess</c>均可，已包括sfm:GetParseSettings权限点），并<a href="https://help.aliyun.com/document_detail/2851098.html">加入一个业务空间</a>后，方可调用本接口。阿里云账号（主账号）可直接调用无须授权。建议您通过最新版&lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>来调用本接口。</description></item>
        /// <item><description>本接口具有幂等性。
        /// <b>限流说明：</b>
        /// 本接口频繁调用会被限流，频率请勿超过10次/秒。如遇限流，请稍后重试。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetParseSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParseSettingsResponse
        /// </returns>
        public GetParseSettingsResponse GetParseSettings(string WorkspaceId, GetParseSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetParseSettingsWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data parsing settings in a specified category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>RAM用户（子账号）需要首先获取阿里云百炼的<a href="https://help.aliyun.com/document_detail/2848578.html">API权限</a>（<c>AliyunBailianDataFullAccess</c>或<c>AliyunBailianDataReadOnlyAccess</c>均可，已包括sfm:GetParseSettings权限点），并<a href="https://help.aliyun.com/document_detail/2851098.html">加入一个业务空间</a>后，方可调用本接口。阿里云账号（主账号）可直接调用无须授权。建议您通过最新版&lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">阿里云百炼SDK</a>来调用本接口。</description></item>
        /// <item><description>本接口具有幂等性。
        /// <b>限流说明：</b>
        /// 本接口频繁调用会被限流，频率请勿超过10次/秒。如遇限流，请稍后重试。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetParseSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParseSettingsResponse
        /// </returns>
        public async Task<GetParseSettingsResponse> GetParseSettingsAsync(string WorkspaceId, GetParseSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetParseSettingsWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a prompt template based on the template ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPromptTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPromptTemplateResponse
        /// </returns>
        public GetPromptTemplateResponse GetPromptTemplateWithOptions(string workspaceId, string promptTemplateId, GetPromptTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPromptTemplate",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/promptTemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(promptTemplateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPromptTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a prompt template based on the template ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPromptTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPromptTemplateResponse
        /// </returns>
        public async Task<GetPromptTemplateResponse> GetPromptTemplateWithOptionsAsync(string workspaceId, string promptTemplateId, GetPromptTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPromptTemplate",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/promptTemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(promptTemplateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPromptTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a prompt template based on the template ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPromptTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPromptTemplateResponse
        /// </returns>
        public GetPromptTemplateResponse GetPromptTemplate(string workspaceId, string promptTemplateId, GetPromptTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPromptTemplateWithOptions(workspaceId, promptTemplateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a prompt template based on the template ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPromptTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPromptTemplateResponse
        /// </returns>
        public async Task<GetPromptTemplateResponse> GetPromptTemplateAsync(string workspaceId, string promptTemplateId, GetPromptTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPromptTemplateWithOptionsAsync(workspaceId, promptTemplateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取发布态智能体应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublishedAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPublishedAgentResponse
        /// </returns>
        public GetPublishedAgentResponse GetPublishedAgentWithOptions(string workspaceId, string appCode, GetPublishedAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPublishedAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appCode),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublishedAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取发布态智能体应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublishedAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPublishedAgentResponse
        /// </returns>
        public async Task<GetPublishedAgentResponse> GetPublishedAgentWithOptionsAsync(string workspaceId, string appCode, GetPublishedAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPublishedAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appCode),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublishedAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取发布态智能体应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublishedAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPublishedAgentResponse
        /// </returns>
        public GetPublishedAgentResponse GetPublishedAgent(string workspaceId, string appCode, GetPublishedAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPublishedAgentWithOptions(workspaceId, appCode, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取发布态智能体应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublishedAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPublishedAgentResponse
        /// </returns>
        public async Task<GetPublishedAgentResponse> GetPublishedAgentAsync(string workspaceId, string appCode, GetPublishedAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPublishedAgentWithOptionsAsync(workspaceId, appCode, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>高代码部署服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HighCodeDeployRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HighCodeDeployResponse
        /// </returns>
        public HighCodeDeployResponse HighCodeDeployWithOptions(string workspaceId, HighCodeDeployRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentDesc))
            {
                body["agentDesc"] = request.AgentDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["agentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCodeName))
            {
                body["sourceCodeName"] = request.SourceCodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCodeOssUrl))
            {
                body["sourceCodeOssUrl"] = request.SourceCodeOssUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelemetryEnabled))
            {
                body["telemetryEnabled"] = request.TelemetryEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HighCodeDeploy",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/openapi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/highCode/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HighCodeDeployResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>高代码部署服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HighCodeDeployRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HighCodeDeployResponse
        /// </returns>
        public async Task<HighCodeDeployResponse> HighCodeDeployWithOptionsAsync(string workspaceId, HighCodeDeployRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentDesc))
            {
                body["agentDesc"] = request.AgentDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["agentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCodeName))
            {
                body["sourceCodeName"] = request.SourceCodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCodeOssUrl))
            {
                body["sourceCodeOssUrl"] = request.SourceCodeOssUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelemetryEnabled))
            {
                body["telemetryEnabled"] = request.TelemetryEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HighCodeDeploy",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/openapi/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/highCode/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HighCodeDeployResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>高代码部署服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HighCodeDeployRequest
        /// </param>
        /// 
        /// <returns>
        /// HighCodeDeployResponse
        /// </returns>
        public HighCodeDeployResponse HighCodeDeploy(string workspaceId, HighCodeDeployRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return HighCodeDeployWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>高代码部署服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HighCodeDeployRequest
        /// </param>
        /// 
        /// <returns>
        /// HighCodeDeployResponse
        /// </returns>
        public async Task<HighCodeDeployResponse> HighCodeDeployAsync(string workspaceId, HighCodeDeployRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await HighCodeDeployWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more categories in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This API does not support querying data tables.</description></item>
        /// <item><description>To call this API, a RAM user must first obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permission</a> for Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. This requires the <c>AliyunBailianDataFullAccess</c> permission, which includes the <c>sfm:ListCategory</c> permission. Alibaba Cloud accounts can call this API directly. Use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>.</description></item>
        /// <item><description>This operation supports pagination. When making your first request, set the <c>MaxResults</c> parameter to specify the maximum number of items to return. If more items are available, the response includes a <c>NextToken</c>. To retrieve the next page of results, set the <c>NextToken</c> parameter to the value from the previous response and specify <c>MaxResults</c> again. An empty <c>NextToken</c> indicates that no more results are available.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limiting:</b> This API is subject to rate limiting. Do not exceed 5 requests per second. If the system throttles a request, retry it after a short interval.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCategoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCategoryResponse
        /// </returns>
        public ListCategoryResponse ListCategoryWithOptions(string WorkspaceId, ListCategoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                body["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCategoryId))
            {
                body["ParentCategoryId"] = request.ParentCategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCategory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/categories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more categories in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This API does not support querying data tables.</description></item>
        /// <item><description>To call this API, a RAM user must first obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permission</a> for Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. This requires the <c>AliyunBailianDataFullAccess</c> permission, which includes the <c>sfm:ListCategory</c> permission. Alibaba Cloud accounts can call this API directly. Use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>.</description></item>
        /// <item><description>This operation supports pagination. When making your first request, set the <c>MaxResults</c> parameter to specify the maximum number of items to return. If more items are available, the response includes a <c>NextToken</c>. To retrieve the next page of results, set the <c>NextToken</c> parameter to the value from the previous response and specify <c>MaxResults</c> again. An empty <c>NextToken</c> indicates that no more results are available.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limiting:</b> This API is subject to rate limiting. Do not exceed 5 requests per second. If the system throttles a request, retry it after a short interval.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCategoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCategoryResponse
        /// </returns>
        public async Task<ListCategoryResponse> ListCategoryWithOptionsAsync(string WorkspaceId, ListCategoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                body["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCategoryId))
            {
                body["ParentCategoryId"] = request.ParentCategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCategory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/categories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more categories in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This API does not support querying data tables.</description></item>
        /// <item><description>To call this API, a RAM user must first obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permission</a> for Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. This requires the <c>AliyunBailianDataFullAccess</c> permission, which includes the <c>sfm:ListCategory</c> permission. Alibaba Cloud accounts can call this API directly. Use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>.</description></item>
        /// <item><description>This operation supports pagination. When making your first request, set the <c>MaxResults</c> parameter to specify the maximum number of items to return. If more items are available, the response includes a <c>NextToken</c>. To retrieve the next page of results, set the <c>NextToken</c> parameter to the value from the previous response and specify <c>MaxResults</c> again. An empty <c>NextToken</c> indicates that no more results are available.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limiting:</b> This API is subject to rate limiting. Do not exceed 5 requests per second. If the system throttles a request, retry it after a short interval.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCategoryResponse
        /// </returns>
        public ListCategoryResponse ListCategory(string WorkspaceId, ListCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCategoryWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more categories in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This API does not support querying data tables.</description></item>
        /// <item><description>To call this API, a RAM user must first obtain the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permission</a> for Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. This requires the <c>AliyunBailianDataFullAccess</c> permission, which includes the <c>sfm:ListCategory</c> permission. Alibaba Cloud accounts can call this API directly. Use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>.</description></item>
        /// <item><description>This operation supports pagination. When making your first request, set the <c>MaxResults</c> parameter to specify the maximum number of items to return. If more items are available, the response includes a <c>NextToken</c>. To retrieve the next page of results, set the <c>NextToken</c> parameter to the value from the previous response and specify <c>MaxResults</c> again. An empty <c>NextToken</c> indicates that no more results are available.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limiting:</b> This API is subject to rate limiting. Do not exceed 5 requests per second. If the system throttles a request, retry it after a short interval.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCategoryResponse
        /// </returns>
        public async Task<ListCategoryResponse> ListCategoryAsync(string WorkspaceId, ListCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCategoryWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list and information of text chunks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For document search&lt;props=&quot;china&quot;&gt; or audio/video search knowledge bases, this operation queries all chunks of a specified file. For data query or image Q&amp;A knowledge bases, this operation retrieves information about all text chunks.</description></item>
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ChunkList permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>This operation has idempotence.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChunksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChunksResponse
        /// </returns>
        public ListChunksResponse ListChunksWithOptions(string WorkspaceId, ListChunksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filed))
            {
                body["Filed"] = request.Filed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                body["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChunks",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/list_chunks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChunksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list and information of text chunks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For document search&lt;props=&quot;china&quot;&gt; or audio/video search knowledge bases, this operation queries all chunks of a specified file. For data query or image Q&amp;A knowledge bases, this operation retrieves information about all text chunks.</description></item>
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ChunkList permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>This operation has idempotence.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChunksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChunksResponse
        /// </returns>
        public async Task<ListChunksResponse> ListChunksWithOptionsAsync(string WorkspaceId, ListChunksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filed))
            {
                body["Filed"] = request.Filed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                body["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChunks",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/list_chunks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChunksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list and information of text chunks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For document search&lt;props=&quot;china&quot;&gt; or audio/video search knowledge bases, this operation queries all chunks of a specified file. For data query or image Q&amp;A knowledge bases, this operation retrieves information about all text chunks.</description></item>
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ChunkList permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>This operation has idempotence.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChunksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChunksResponse
        /// </returns>
        public ListChunksResponse ListChunks(string WorkspaceId, ListChunksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListChunksWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list and information of text chunks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For document search&lt;props=&quot;china&quot;&gt; or audio/video search knowledge bases, this operation queries all chunks of a specified file. For data query or image Q&amp;A knowledge bases, this operation retrieves information about all text chunks.</description></item>
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ChunkList permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>This operation has idempotence.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChunksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChunksResponse
        /// </returns>
        public async Task<ListChunksResponse> ListChunksAsync(string WorkspaceId, ListChunksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListChunksWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more documents in a specified category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ListFile permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Invoke this operation by using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>When performing paging for the first page, only set <c>MaxResults</c> to limit the number of entries returned. The <c>NextToken</c> in the response serves as the credential for querying subsequent pages. When querying subsequent pages, set the <c>NextToken</c> parameter to the <c>NextToken</c> value obtained from the previous response as the query credential (if <c>NextToken</c> is empty, all results have been returned and no further requests are needed), and set <c>MaxResults</c> to limit the number of entries returned.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 5 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFileResponse
        /// </returns>
        public ListFileResponse ListFileWithOptions(string WorkspaceId, ListFileRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFileShrinkRequest request = new ListFileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileIds))
            {
                request.FileIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileIds, "FileIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIdsShrink))
            {
                query["FileIds"] = request.FileIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/files",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more documents in a specified category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ListFile permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Invoke this operation by using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>When performing paging for the first page, only set <c>MaxResults</c> to limit the number of entries returned. The <c>NextToken</c> in the response serves as the credential for querying subsequent pages. When querying subsequent pages, set the <c>NextToken</c> parameter to the <c>NextToken</c> value obtained from the previous response as the query credential (if <c>NextToken</c> is empty, all results have been returned and no further requests are needed), and set <c>MaxResults</c> to limit the number of entries returned.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 5 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFileResponse
        /// </returns>
        public async Task<ListFileResponse> ListFileWithOptionsAsync(string WorkspaceId, ListFileRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFileShrinkRequest request = new ListFileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileIds))
            {
                request.FileIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileIds, "FileIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileIdsShrink))
            {
                query["FileIds"] = request.FileIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/files",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more documents in a specified category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ListFile permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Invoke this operation by using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>When performing paging for the first page, only set <c>MaxResults</c> to limit the number of entries returned. The <c>NextToken</c> in the response serves as the credential for querying subsequent pages. When querying subsequent pages, set the <c>NextToken</c> parameter to the <c>NextToken</c> value obtained from the previous response as the query credential (if <c>NextToken</c> is empty, all results have been returned and no further requests are needed), and set <c>MaxResults</c> to limit the number of entries returned.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 5 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFileResponse
        /// </returns>
        public ListFileResponse ListFile(string WorkspaceId, ListFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFileWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more documents in a specified category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ListFile permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Invoke this operation by using the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>When performing paging for the first page, only set <c>MaxResults</c> to limit the number of entries returned. The <c>NextToken</c> in the response serves as the credential for querying subsequent pages. When querying subsequent pages, set the <c>NextToken</c> parameter to the <c>NextToken</c> value obtained from the previous response as the query credential (if <c>NextToken</c> is empty, all results have been returned and no further requests are needed), and set <c>MaxResults</c> to limit the number of entries returned.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 5 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFileResponse
        /// </returns>
        public async Task<ListFileResponse> ListFileAsync(string WorkspaceId, ListFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFileWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the files in a specified knowledge base along with their summary information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ListIndexFiles permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>This operation has idempotence.
        /// <b>Throttling:</b>
        /// This operation is throttled if called too frequently. Do not exceed 15 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndexDocumentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIndexDocumentsResponse
        /// </returns>
        public ListIndexDocumentsResponse ListIndexDocumentsWithOptions(string WorkspaceId, ListIndexDocumentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                query["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentStatus))
            {
                query["DocumentStatus"] = request.DocumentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableNameLike))
            {
                query["EnableNameLike"] = request.EnableNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndexDocuments",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/list_index_documents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndexDocumentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the files in a specified knowledge base along with their summary information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ListIndexFiles permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>This operation has idempotence.
        /// <b>Throttling:</b>
        /// This operation is throttled if called too frequently. Do not exceed 15 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndexDocumentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIndexDocumentsResponse
        /// </returns>
        public async Task<ListIndexDocumentsResponse> ListIndexDocumentsWithOptionsAsync(string WorkspaceId, ListIndexDocumentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                query["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentStatus))
            {
                query["DocumentStatus"] = request.DocumentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableNameLike))
            {
                query["EnableNameLike"] = request.EnableNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndexDocuments",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/list_index_documents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndexDocumentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the files in a specified knowledge base along with their summary information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ListIndexFiles permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>This operation has idempotence.
        /// <b>Throttling:</b>
        /// This operation is throttled if called too frequently. Do not exceed 15 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndexDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIndexDocumentsResponse
        /// </returns>
        public ListIndexDocumentsResponse ListIndexDocuments(string WorkspaceId, ListIndexDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIndexDocumentsWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the files in a specified knowledge base along with their summary information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requiring <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ListIndexFiles permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, make sure that your knowledge base has been created and has not been deleted (that is, the knowledge base ID <c>IndexId</c> is valid).</description></item>
        /// <item><description>This operation has idempotence.
        /// <b>Throttling:</b>
        /// This operation is throttled if called too frequently. Do not exceed 15 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndexDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIndexDocumentsResponse
        /// </returns>
        public async Task<ListIndexDocumentsResponse> ListIndexDocumentsAsync(string WorkspaceId, ListIndexDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIndexDocumentsWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more documents in a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM user must have the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio to call this operation. The <c>AliyunBailianDataFullAccess</c> permission, which includes the \<c>sfm:ListIndexFiles\\</c> permission, is required. An Alibaba Cloud account can call this operation without authorization. You can call this operation using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>Before you call this operation, ensure that your knowledge base exists and its ID, <c>IndexId</c>, is valid.</description></item>
        /// <item><description>This operation is idempotent.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndexFileDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIndexFileDetailsResponse
        /// </returns>
        public ListIndexFileDetailsResponse ListIndexFileDetailsWithOptions(string WorkspaceId, ListIndexFileDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                query["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentStatus))
            {
                query["DocumentStatus"] = request.DocumentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableNameLike))
            {
                query["EnableNameLike"] = request.EnableNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndexFileDetails",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/list_index_file_detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndexFileDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more documents in a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM user must have the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio to call this operation. The <c>AliyunBailianDataFullAccess</c> permission, which includes the \<c>sfm:ListIndexFiles\\</c> permission, is required. An Alibaba Cloud account can call this operation without authorization. You can call this operation using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>Before you call this operation, ensure that your knowledge base exists and its ID, <c>IndexId</c>, is valid.</description></item>
        /// <item><description>This operation is idempotent.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndexFileDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIndexFileDetailsResponse
        /// </returns>
        public async Task<ListIndexFileDetailsResponse> ListIndexFileDetailsWithOptionsAsync(string WorkspaceId, ListIndexFileDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                query["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentStatus))
            {
                query["DocumentStatus"] = request.DocumentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableNameLike))
            {
                query["EnableNameLike"] = request.EnableNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndexFileDetails",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/list_index_file_detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndexFileDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more documents in a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM user must have the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio to call this operation. The <c>AliyunBailianDataFullAccess</c> permission, which includes the \<c>sfm:ListIndexFiles\\</c> permission, is required. An Alibaba Cloud account can call this operation without authorization. You can call this operation using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>Before you call this operation, ensure that your knowledge base exists and its ID, <c>IndexId</c>, is valid.</description></item>
        /// <item><description>This operation is idempotent.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndexFileDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIndexFileDetailsResponse
        /// </returns>
        public ListIndexFileDetailsResponse ListIndexFileDetails(string WorkspaceId, ListIndexFileDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIndexFileDetailsWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more documents in a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM user must have the <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio to call this operation. The <c>AliyunBailianDataFullAccess</c> permission, which includes the \<c>sfm:ListIndexFiles\\</c> permission, is required. An Alibaba Cloud account can call this operation without authorization. You can call this operation using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>Before you call this operation, ensure that your knowledge base exists and its ID, <c>IndexId</c>, is valid.</description></item>
        /// <item><description>This operation is idempotent.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndexFileDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIndexFileDetailsResponse
        /// </returns>
        public async Task<ListIndexFileDetailsResponse> ListIndexFileDetailsAsync(string WorkspaceId, ListIndexFileDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIndexFileDetailsWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of knowledge bases in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ListIndex permission) before calling this operation. Alibaba Cloud accounts can call this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIndicesResponse
        /// </returns>
        public ListIndicesResponse ListIndicesWithOptions(string WorkspaceId, ListIndicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexName))
            {
                query["IndexName"] = request.IndexName;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndices",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/list_indices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of knowledge bases in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ListIndex permission) before calling this operation. Alibaba Cloud accounts can call this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIndicesResponse
        /// </returns>
        public async Task<ListIndicesResponse> ListIndicesWithOptionsAsync(string WorkspaceId, ListIndicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexName))
            {
                query["IndexName"] = request.IndexName;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndices",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/list_indices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of knowledge bases in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ListIndex permission) before calling this operation. Alibaba Cloud accounts can call this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIndicesResponse
        /// </returns>
        public ListIndicesResponse ListIndices(string WorkspaceId, ListIndicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIndicesWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of knowledge bases in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:ListIndex permission) before calling this operation. Alibaba Cloud accounts can call this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIndicesResponse
        /// </returns>
        public async Task<ListIndicesResponse> ListIndicesAsync(string WorkspaceId, ListIndicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIndicesWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more long-term memory entities in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>When querying the first page of a paging query, set only <c>MaxResults</c> to limit the number of entries returned. The <c>NextToken</c> value in the response serves as the credential for querying subsequent pages. When querying subsequent pages, set the <c>NextToken</c> parameter to the <c>NextToken</c> value obtained from the previous response as the query credential (if <c>NextToken</c> is empty, all results have been returned and no further requests are needed), and settings <c>MaxResults</c> to limit the number of entries returned.</description></item>
        /// <item><description>This operation supports idempotence.
        /// <b>Rate limit:</b> Ensure that the interval between two consecutive requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMemoriesResponse
        /// </returns>
        public ListMemoriesResponse ListMemoriesWithOptions(string workspaceId, ListMemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMemories",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more long-term memory entities in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>When querying the first page of a paging query, set only <c>MaxResults</c> to limit the number of entries returned. The <c>NextToken</c> value in the response serves as the credential for querying subsequent pages. When querying subsequent pages, set the <c>NextToken</c> parameter to the <c>NextToken</c> value obtained from the previous response as the query credential (if <c>NextToken</c> is empty, all results have been returned and no further requests are needed), and settings <c>MaxResults</c> to limit the number of entries returned.</description></item>
        /// <item><description>This operation supports idempotence.
        /// <b>Rate limit:</b> Ensure that the interval between two consecutive requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMemoriesResponse
        /// </returns>
        public async Task<ListMemoriesResponse> ListMemoriesWithOptionsAsync(string workspaceId, ListMemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMemories",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more long-term memory entities in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>When querying the first page of a paging query, set only <c>MaxResults</c> to limit the number of entries returned. The <c>NextToken</c> value in the response serves as the credential for querying subsequent pages. When querying subsequent pages, set the <c>NextToken</c> parameter to the <c>NextToken</c> value obtained from the previous response as the query credential (if <c>NextToken</c> is empty, all results have been returned and no further requests are needed), and settings <c>MaxResults</c> to limit the number of entries returned.</description></item>
        /// <item><description>This operation supports idempotence.
        /// <b>Rate limit:</b> Ensure that the interval between two consecutive requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMemoriesResponse
        /// </returns>
        public ListMemoriesResponse ListMemories(string workspaceId, ListMemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMemoriesWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of one or more long-term memory entities in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>When querying the first page of a paging query, set only <c>MaxResults</c> to limit the number of entries returned. The <c>NextToken</c> value in the response serves as the credential for querying subsequent pages. When querying subsequent pages, set the <c>NextToken</c> parameter to the <c>NextToken</c> value obtained from the previous response as the query credential (if <c>NextToken</c> is empty, all results have been returned and no further requests are needed), and settings <c>MaxResults</c> to limit the number of entries returned.</description></item>
        /// <item><description>This operation supports idempotence.
        /// <b>Rate limit:</b> Ensure that the interval between two consecutive requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMemoriesResponse
        /// </returns>
        public async Task<ListMemoriesResponse> ListMemoriesAsync(string workspaceId, ListMemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMemoriesWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of memory nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemoryNodesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMemoryNodesResponse
        /// </returns>
        public ListMemoryNodesResponse ListMemoryNodesWithOptions(string workspaceId, string memoryId, ListMemoryNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMemoryNodes",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemoryNodesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of memory nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemoryNodesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMemoryNodesResponse
        /// </returns>
        public async Task<ListMemoryNodesResponse> ListMemoryNodesWithOptionsAsync(string workspaceId, string memoryId, ListMemoryNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMemoryNodes",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemoryNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of memory nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemoryNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMemoryNodesResponse
        /// </returns>
        public ListMemoryNodesResponse ListMemoryNodes(string workspaceId, string memoryId, ListMemoryNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMemoryNodesWithOptions(workspaceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of memory nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemoryNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMemoryNodesResponse
        /// </returns>
        public async Task<ListMemoryNodesResponse> ListMemoryNodesAsync(string workspaceId, string memoryId, ListMemoryNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMemoryNodesWithOptionsAsync(workspaceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of prompt templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPromptTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPromptTemplatesResponse
        /// </returns>
        public ListPromptTemplatesResponse ListPromptTemplatesWithOptions(string workspaceId, ListPromptTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPromptTemplates",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/promptTemplates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPromptTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of prompt templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPromptTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPromptTemplatesResponse
        /// </returns>
        public async Task<ListPromptTemplatesResponse> ListPromptTemplatesWithOptionsAsync(string workspaceId, ListPromptTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPromptTemplates",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/promptTemplates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPromptTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of prompt templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPromptTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPromptTemplatesResponse
        /// </returns>
        public ListPromptTemplatesResponse ListPromptTemplates(string workspaceId, ListPromptTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPromptTemplatesWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of prompt templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPromptTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPromptTemplatesResponse
        /// </returns>
        public async Task<ListPromptTemplatesResponse> ListPromptTemplatesAsync(string workspaceId, ListPromptTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPromptTemplatesWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已发布的智能体应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublishedAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAgentResponse
        /// </returns>
        public ListPublishedAgentResponse ListPublishedAgentWithOptions(string workspaceId, ListPublishedAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["pageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishedAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已发布的智能体应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublishedAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAgentResponse
        /// </returns>
        public async Task<ListPublishedAgentResponse> ListPublishedAgentWithOptionsAsync(string workspaceId, ListPublishedAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["pageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishedAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已发布的智能体应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublishedAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAgentResponse
        /// </returns>
        public ListPublishedAgentResponse ListPublishedAgent(string workspaceId, ListPublishedAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPublishedAgentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已发布的智能体应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublishedAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedAgentResponse
        /// </returns>
        public async Task<ListPublishedAgentResponse> ListPublishedAgentAsync(string workspaceId, ListPublishedAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPublishedAgentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>How to call</b>: To retrieve information from a knowledge base, use the latest <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> with an <a href="https://help.aliyun.com/document_detail/116401.html">AccessKey</a> or <a href="https://help.aliyun.com/document_detail/2990886.html">Spring AI Alibaba</a> with an Alibaba Cloud Model Studio <a href="https://help.aliyun.com/document_detail/2712195.html">API key</a>. Both tools simplify your API calls by handling the complex signature calculation.</description></item>
        /// <item><description><b>Required permissions</b>:<list type="bullet">
        /// <item><description><b>RAM user (sub-account)</b>: To call this API, a RAM user must be granted <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. You can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the required <c>sfm:Retrieve</c> permission.</description></item>
        /// <item><description><b>Alibaba Cloud account (main account)</b>: This account has the required permissions by default and can call the API directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Response latency</b>: This API call involves complex retrieval and matching operations, which can cause longer response times. We recommend configuring appropriate request timeouts and retry strategies.</description></item>
        /// <item><description><b>Idempotency</b>: This API is idempotent.
        /// &lt;props=&quot;intl&quot;&gt;</description></item>
        /// <item><description><b>How to call</b>: We recommend using the latest <a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this API. The SDK simplifies API calls by handling the complex signature calculation.</description></item>
        /// <item><description><b>Required permissions</b>:<list type="bullet">
        /// <item><description><b>RAM user (sub-account)</b>: To call this API, a RAM user must be granted <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. You can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the required <c>sfm:Retrieve</c> permission.</description></item>
        /// <item><description><b>Alibaba Cloud account (main account)</b>: This account has the required permissions by default and can call the API directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Response latency</b>: This API call involves complex retrieval and matching operations, which can cause longer response times. We recommend configuring appropriate request timeouts and retry strategies.</description></item>
        /// <item><description><b>Idempotency</b>: This API is idempotent.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// RetrieveRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetrieveResponse
        /// </returns>
        public RetrieveResponse RetrieveWithOptions(string WorkspaceId, RetrieveRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RetrieveShrinkRequest request = new RetrieveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "Extra", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Images))
            {
                request.ImagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Images, "Images", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryHistory))
            {
                request.QueryHistoryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryHistory, "QueryHistory", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rerank))
            {
                request.RerankShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rerank, "Rerank", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rewrite))
            {
                request.RewriteShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rewrite, "Rewrite", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchFilters))
            {
                request.SearchFiltersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchFilters, "SearchFilters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DenseSimilarityTopK))
            {
                query["DenseSimilarityTopK"] = request.DenseSimilarityTopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableReranking))
            {
                query["EnableReranking"] = request.EnableReranking;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRewrite))
            {
                query["EnableRewrite"] = request.EnableRewrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                query["Extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagesShrink))
            {
                query["Images"] = request.ImagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryHistoryShrink))
            {
                query["QueryHistory"] = request.QueryHistoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankShrink))
            {
                query["Rerank"] = request.RerankShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankMinScore))
            {
                query["RerankMinScore"] = request.RerankMinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankTopN))
            {
                query["RerankTopN"] = request.RerankTopN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RewriteShrink))
            {
                query["Rewrite"] = request.RewriteShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveRetrieverHistory))
            {
                query["SaveRetrieverHistory"] = request.SaveRetrieverHistory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFiltersShrink))
            {
                query["SearchFilters"] = request.SearchFiltersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SparseSimilarityTopK))
            {
                query["SparseSimilarityTopK"] = request.SparseSimilarityTopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Retrieve",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/retrieve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>How to call</b>: To retrieve information from a knowledge base, use the latest <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> with an <a href="https://help.aliyun.com/document_detail/116401.html">AccessKey</a> or <a href="https://help.aliyun.com/document_detail/2990886.html">Spring AI Alibaba</a> with an Alibaba Cloud Model Studio <a href="https://help.aliyun.com/document_detail/2712195.html">API key</a>. Both tools simplify your API calls by handling the complex signature calculation.</description></item>
        /// <item><description><b>Required permissions</b>:<list type="bullet">
        /// <item><description><b>RAM user (sub-account)</b>: To call this API, a RAM user must be granted <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. You can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the required <c>sfm:Retrieve</c> permission.</description></item>
        /// <item><description><b>Alibaba Cloud account (main account)</b>: This account has the required permissions by default and can call the API directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Response latency</b>: This API call involves complex retrieval and matching operations, which can cause longer response times. We recommend configuring appropriate request timeouts and retry strategies.</description></item>
        /// <item><description><b>Idempotency</b>: This API is idempotent.
        /// &lt;props=&quot;intl&quot;&gt;</description></item>
        /// <item><description><b>How to call</b>: We recommend using the latest <a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this API. The SDK simplifies API calls by handling the complex signature calculation.</description></item>
        /// <item><description><b>Required permissions</b>:<list type="bullet">
        /// <item><description><b>RAM user (sub-account)</b>: To call this API, a RAM user must be granted <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. You can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the required <c>sfm:Retrieve</c> permission.</description></item>
        /// <item><description><b>Alibaba Cloud account (main account)</b>: This account has the required permissions by default and can call the API directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Response latency</b>: This API call involves complex retrieval and matching operations, which can cause longer response times. We recommend configuring appropriate request timeouts and retry strategies.</description></item>
        /// <item><description><b>Idempotency</b>: This API is idempotent.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// RetrieveRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetrieveResponse
        /// </returns>
        public async Task<RetrieveResponse> RetrieveWithOptionsAsync(string WorkspaceId, RetrieveRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RetrieveShrinkRequest request = new RetrieveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "Extra", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Images))
            {
                request.ImagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Images, "Images", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryHistory))
            {
                request.QueryHistoryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryHistory, "QueryHistory", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rerank))
            {
                request.RerankShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rerank, "Rerank", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rewrite))
            {
                request.RewriteShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rewrite, "Rewrite", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchFilters))
            {
                request.SearchFiltersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchFilters, "SearchFilters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DenseSimilarityTopK))
            {
                query["DenseSimilarityTopK"] = request.DenseSimilarityTopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableReranking))
            {
                query["EnableReranking"] = request.EnableReranking;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRewrite))
            {
                query["EnableRewrite"] = request.EnableRewrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                query["Extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagesShrink))
            {
                query["Images"] = request.ImagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryHistoryShrink))
            {
                query["QueryHistory"] = request.QueryHistoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankShrink))
            {
                query["Rerank"] = request.RerankShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankMinScore))
            {
                query["RerankMinScore"] = request.RerankMinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankTopN))
            {
                query["RerankTopN"] = request.RerankTopN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RewriteShrink))
            {
                query["Rewrite"] = request.RewriteShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveRetrieverHistory))
            {
                query["SaveRetrieverHistory"] = request.SaveRetrieverHistory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFiltersShrink))
            {
                query["SearchFilters"] = request.SearchFiltersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SparseSimilarityTopK))
            {
                query["SparseSimilarityTopK"] = request.SparseSimilarityTopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Retrieve",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/retrieve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>How to call</b>: To retrieve information from a knowledge base, use the latest <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> with an <a href="https://help.aliyun.com/document_detail/116401.html">AccessKey</a> or <a href="https://help.aliyun.com/document_detail/2990886.html">Spring AI Alibaba</a> with an Alibaba Cloud Model Studio <a href="https://help.aliyun.com/document_detail/2712195.html">API key</a>. Both tools simplify your API calls by handling the complex signature calculation.</description></item>
        /// <item><description><b>Required permissions</b>:<list type="bullet">
        /// <item><description><b>RAM user (sub-account)</b>: To call this API, a RAM user must be granted <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. You can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the required <c>sfm:Retrieve</c> permission.</description></item>
        /// <item><description><b>Alibaba Cloud account (main account)</b>: This account has the required permissions by default and can call the API directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Response latency</b>: This API call involves complex retrieval and matching operations, which can cause longer response times. We recommend configuring appropriate request timeouts and retry strategies.</description></item>
        /// <item><description><b>Idempotency</b>: This API is idempotent.
        /// &lt;props=&quot;intl&quot;&gt;</description></item>
        /// <item><description><b>How to call</b>: We recommend using the latest <a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this API. The SDK simplifies API calls by handling the complex signature calculation.</description></item>
        /// <item><description><b>Required permissions</b>:<list type="bullet">
        /// <item><description><b>RAM user (sub-account)</b>: To call this API, a RAM user must be granted <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. You can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the required <c>sfm:Retrieve</c> permission.</description></item>
        /// <item><description><b>Alibaba Cloud account (main account)</b>: This account has the required permissions by default and can call the API directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Response latency</b>: This API call involves complex retrieval and matching operations, which can cause longer response times. We recommend configuring appropriate request timeouts and retry strategies.</description></item>
        /// <item><description><b>Idempotency</b>: This API is idempotent.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RetrieveRequest
        /// </param>
        /// 
        /// <returns>
        /// RetrieveResponse
        /// </returns>
        public RetrieveResponse Retrieve(string WorkspaceId, RetrieveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RetrieveWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>How to call</b>: To retrieve information from a knowledge base, use the latest <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> with an <a href="https://help.aliyun.com/document_detail/116401.html">AccessKey</a> or <a href="https://help.aliyun.com/document_detail/2990886.html">Spring AI Alibaba</a> with an Alibaba Cloud Model Studio <a href="https://help.aliyun.com/document_detail/2712195.html">API key</a>. Both tools simplify your API calls by handling the complex signature calculation.</description></item>
        /// <item><description><b>Required permissions</b>:<list type="bullet">
        /// <item><description><b>RAM user (sub-account)</b>: To call this API, a RAM user must be granted <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. You can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the required <c>sfm:Retrieve</c> permission.</description></item>
        /// <item><description><b>Alibaba Cloud account (main account)</b>: This account has the required permissions by default and can call the API directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Response latency</b>: This API call involves complex retrieval and matching operations, which can cause longer response times. We recommend configuring appropriate request timeouts and retry strategies.</description></item>
        /// <item><description><b>Idempotency</b>: This API is idempotent.
        /// &lt;props=&quot;intl&quot;&gt;</description></item>
        /// <item><description><b>How to call</b>: We recommend using the latest <a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this API. The SDK simplifies API calls by handling the complex signature calculation.</description></item>
        /// <item><description><b>Required permissions</b>:<list type="bullet">
        /// <item><description><b>RAM user (sub-account)</b>: To call this API, a RAM user must be granted <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. You can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the required <c>sfm:Retrieve</c> permission.</description></item>
        /// <item><description><b>Alibaba Cloud account (main account)</b>: This account has the required permissions by default and can call the API directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Response latency</b>: This API call involves complex retrieval and matching operations, which can cause longer response times. We recommend configuring appropriate request timeouts and retry strategies.</description></item>
        /// <item><description><b>Idempotency</b>: This API is idempotent.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RetrieveRequest
        /// </param>
        /// 
        /// <returns>
        /// RetrieveResponse
        /// </returns>
        public async Task<RetrieveResponse> RetrieveAsync(string WorkspaceId, RetrieveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RetrieveWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds parsed files to the specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>This API does not support knowledge bases for data queries or image Q\&amp;A. To update these knowledge bases, see the <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a> documentation.
        /// &lt;props=&quot;intl&quot;&gt;</description></item>
        /// <item><description>This API does not support knowledge bases for data queries or image Q\&amp;A. To update these knowledge bases, see the <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a> documentation.</description></item>
        /// <item><description>A RAM user (sub-account) can call this API only after being granted the required <a href="https://help.aliyun.com/document_detail/2848578.html">api permission</a> for Alibaba Cloud Model Studio (specifically, the <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:SubmitIndexAddDocumentsJob</c> permission) and joining a <a href="https://help.aliyun.com/document_detail/2851098.html">workspace</a>. An Alibaba Cloud account can call this API directly without authorization. We recommend using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this API.</description></item>
        /// <item><description>Before calling this API, ensure your knowledge base exists and has a valid knowledge base ID (<c>IndexId</c>).</description></item>
        /// <item><description>Before calling this API, you must first upload files to Alibaba Cloud Model Studio using the <b>AddFile</b> API.</description></item>
        /// <item><description>After calling this API, the job runs in the background and may take several hours to complete, especially during peak times. Do not submit duplicate requests until the job is complete. To check the job status, call the <b>GetIndexJobStatus</b> API. The <c>Documents</c> file list returned by the GetIndexJobStatus API contains all files for the job, which is uniquely identified by the <c>job_id</c> you provided. You can check this list to verify whether each file was imported (parsed) successfully. Note that frequent calls to the GetIndexJobStatus API are subject to rate limiting. Do not exceed 20 calls per minute.</description></item>
        /// <item><description>A successful API call indicates the job has been submitted for processing, which takes time. This API is not idempotent, so do not send duplicate requests; doing so will create multiple jobs.
        /// <b>Rate limiting:</b> This API is limited to 10 calls per second. If you exceed this limit, wait before retrying.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SubmitIndexAddDocumentsJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitIndexAddDocumentsJobResponse
        /// </returns>
        public SubmitIndexAddDocumentsJobResponse SubmitIndexAddDocumentsJobWithOptions(string WorkspaceId, SubmitIndexAddDocumentsJobRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitIndexAddDocumentsJobShrinkRequest request = new SubmitIndexAddDocumentsJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CategoryIds))
            {
                request.CategoryIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CategoryIds, "CategoryIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentIds))
            {
                request.DocumentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentIds, "DocumentIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "Extra", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryIdsShrink))
            {
                query["CategoryIds"] = request.CategoryIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkMode))
            {
                query["ChunkMode"] = request.ChunkMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkSize))
            {
                query["ChunkSize"] = request.ChunkSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIdsShrink))
            {
                query["DocumentIds"] = request.DocumentIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableHeaders))
            {
                query["EnableHeaders"] = request.EnableHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                query["Extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverlapSize))
            {
                query["OverlapSize"] = request.OverlapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Separator))
            {
                query["Separator"] = request.Separator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitIndexAddDocumentsJob",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/add_documents_to_index",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIndexAddDocumentsJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds parsed files to the specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>This API does not support knowledge bases for data queries or image Q\&amp;A. To update these knowledge bases, see the <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a> documentation.
        /// &lt;props=&quot;intl&quot;&gt;</description></item>
        /// <item><description>This API does not support knowledge bases for data queries or image Q\&amp;A. To update these knowledge bases, see the <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a> documentation.</description></item>
        /// <item><description>A RAM user (sub-account) can call this API only after being granted the required <a href="https://help.aliyun.com/document_detail/2848578.html">api permission</a> for Alibaba Cloud Model Studio (specifically, the <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:SubmitIndexAddDocumentsJob</c> permission) and joining a <a href="https://help.aliyun.com/document_detail/2851098.html">workspace</a>. An Alibaba Cloud account can call this API directly without authorization. We recommend using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this API.</description></item>
        /// <item><description>Before calling this API, ensure your knowledge base exists and has a valid knowledge base ID (<c>IndexId</c>).</description></item>
        /// <item><description>Before calling this API, you must first upload files to Alibaba Cloud Model Studio using the <b>AddFile</b> API.</description></item>
        /// <item><description>After calling this API, the job runs in the background and may take several hours to complete, especially during peak times. Do not submit duplicate requests until the job is complete. To check the job status, call the <b>GetIndexJobStatus</b> API. The <c>Documents</c> file list returned by the GetIndexJobStatus API contains all files for the job, which is uniquely identified by the <c>job_id</c> you provided. You can check this list to verify whether each file was imported (parsed) successfully. Note that frequent calls to the GetIndexJobStatus API are subject to rate limiting. Do not exceed 20 calls per minute.</description></item>
        /// <item><description>A successful API call indicates the job has been submitted for processing, which takes time. This API is not idempotent, so do not send duplicate requests; doing so will create multiple jobs.
        /// <b>Rate limiting:</b> This API is limited to 10 calls per second. If you exceed this limit, wait before retrying.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SubmitIndexAddDocumentsJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitIndexAddDocumentsJobResponse
        /// </returns>
        public async Task<SubmitIndexAddDocumentsJobResponse> SubmitIndexAddDocumentsJobWithOptionsAsync(string WorkspaceId, SubmitIndexAddDocumentsJobRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitIndexAddDocumentsJobShrinkRequest request = new SubmitIndexAddDocumentsJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CategoryIds))
            {
                request.CategoryIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CategoryIds, "CategoryIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentIds))
            {
                request.DocumentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentIds, "DocumentIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "Extra", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryIdsShrink))
            {
                query["CategoryIds"] = request.CategoryIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkMode))
            {
                query["ChunkMode"] = request.ChunkMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkSize))
            {
                query["ChunkSize"] = request.ChunkSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIdsShrink))
            {
                query["DocumentIds"] = request.DocumentIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableHeaders))
            {
                query["EnableHeaders"] = request.EnableHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                query["Extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverlapSize))
            {
                query["OverlapSize"] = request.OverlapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Separator))
            {
                query["Separator"] = request.Separator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitIndexAddDocumentsJob",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/add_documents_to_index",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIndexAddDocumentsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds parsed files to the specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>This API does not support knowledge bases for data queries or image Q\&amp;A. To update these knowledge bases, see the <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a> documentation.
        /// &lt;props=&quot;intl&quot;&gt;</description></item>
        /// <item><description>This API does not support knowledge bases for data queries or image Q\&amp;A. To update these knowledge bases, see the <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a> documentation.</description></item>
        /// <item><description>A RAM user (sub-account) can call this API only after being granted the required <a href="https://help.aliyun.com/document_detail/2848578.html">api permission</a> for Alibaba Cloud Model Studio (specifically, the <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:SubmitIndexAddDocumentsJob</c> permission) and joining a <a href="https://help.aliyun.com/document_detail/2851098.html">workspace</a>. An Alibaba Cloud account can call this API directly without authorization. We recommend using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this API.</description></item>
        /// <item><description>Before calling this API, ensure your knowledge base exists and has a valid knowledge base ID (<c>IndexId</c>).</description></item>
        /// <item><description>Before calling this API, you must first upload files to Alibaba Cloud Model Studio using the <b>AddFile</b> API.</description></item>
        /// <item><description>After calling this API, the job runs in the background and may take several hours to complete, especially during peak times. Do not submit duplicate requests until the job is complete. To check the job status, call the <b>GetIndexJobStatus</b> API. The <c>Documents</c> file list returned by the GetIndexJobStatus API contains all files for the job, which is uniquely identified by the <c>job_id</c> you provided. You can check this list to verify whether each file was imported (parsed) successfully. Note that frequent calls to the GetIndexJobStatus API are subject to rate limiting. Do not exceed 20 calls per minute.</description></item>
        /// <item><description>A successful API call indicates the job has been submitted for processing, which takes time. This API is not idempotent, so do not send duplicate requests; doing so will create multiple jobs.
        /// <b>Rate limiting:</b> This API is limited to 10 calls per second. If you exceed this limit, wait before retrying.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitIndexAddDocumentsJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitIndexAddDocumentsJobResponse
        /// </returns>
        public SubmitIndexAddDocumentsJobResponse SubmitIndexAddDocumentsJob(string WorkspaceId, SubmitIndexAddDocumentsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitIndexAddDocumentsJobWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds parsed files to the specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>This API does not support knowledge bases for data queries or image Q\&amp;A. To update these knowledge bases, see the <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a> documentation.
        /// &lt;props=&quot;intl&quot;&gt;</description></item>
        /// <item><description>This API does not support knowledge bases for data queries or image Q\&amp;A. To update these knowledge bases, see the <a href="https://help.aliyun.com/document_detail/2807740.html">knowledge base</a> documentation.</description></item>
        /// <item><description>A RAM user (sub-account) can call this API only after being granted the required <a href="https://help.aliyun.com/document_detail/2848578.html">api permission</a> for Alibaba Cloud Model Studio (specifically, the <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:SubmitIndexAddDocumentsJob</c> permission) and joining a <a href="https://help.aliyun.com/document_detail/2851098.html">workspace</a>. An Alibaba Cloud account can call this API directly without authorization. We recommend using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this API.</description></item>
        /// <item><description>Before calling this API, ensure your knowledge base exists and has a valid knowledge base ID (<c>IndexId</c>).</description></item>
        /// <item><description>Before calling this API, you must first upload files to Alibaba Cloud Model Studio using the <b>AddFile</b> API.</description></item>
        /// <item><description>After calling this API, the job runs in the background and may take several hours to complete, especially during peak times. Do not submit duplicate requests until the job is complete. To check the job status, call the <b>GetIndexJobStatus</b> API. The <c>Documents</c> file list returned by the GetIndexJobStatus API contains all files for the job, which is uniquely identified by the <c>job_id</c> you provided. You can check this list to verify whether each file was imported (parsed) successfully. Note that frequent calls to the GetIndexJobStatus API are subject to rate limiting. Do not exceed 20 calls per minute.</description></item>
        /// <item><description>A successful API call indicates the job has been submitted for processing, which takes time. This API is not idempotent, so do not send duplicate requests; doing so will create multiple jobs.
        /// <b>Rate limiting:</b> This API is limited to 10 calls per second. If you exceed this limit, wait before retrying.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitIndexAddDocumentsJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitIndexAddDocumentsJobResponse
        /// </returns>
        public async Task<SubmitIndexAddDocumentsJobResponse> SubmitIndexAddDocumentsJobAsync(string WorkspaceId, SubmitIndexAddDocumentsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitIndexAddDocumentsJobWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a specified CreateIndex task to complete knowledge base creation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:SubmitIndexJob permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, you must invoke the <b>CreateIndex</b> operation and obtain the corresponding <c>IndexId</c>.</description></item>
        /// <item><description>After invoking this operation, the node requires time to execute and may take several hours during peak periods. Do not submit duplicate requests before the node completes. To query the node execution status, invoke the <b>GetIndexJobStatus</b> operation.</description></item>
        /// <item><description>After the knowledge base is created, you can associate it with an agent application&lt;props=&quot;china&quot;&gt; or workflow application in the same workspace through &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/app-center">Application Management</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/app-center">Application Management</a> (or pass the <c>IndexID</c> through <c>rag_options</c> in <a href="https://help.aliyun.com/document_detail/2846132.html">Application Calls</a>) to supplement your Model Studio application with private knowledge and up-to-date information. You can also choose not to use a Model Studio application and directly query the knowledge base by invoking the <b>Retrieve</b> operation.</description></item>
        /// <item><description>This operation does not support idempotence.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitIndexJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitIndexJobResponse
        /// </returns>
        public SubmitIndexJobResponse SubmitIndexJobWithOptions(string WorkspaceId, SubmitIndexJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitIndexJob",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/submit_index_job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIndexJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a specified CreateIndex task to complete knowledge base creation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:SubmitIndexJob permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, you must invoke the <b>CreateIndex</b> operation and obtain the corresponding <c>IndexId</c>.</description></item>
        /// <item><description>After invoking this operation, the node requires time to execute and may take several hours during peak periods. Do not submit duplicate requests before the node completes. To query the node execution status, invoke the <b>GetIndexJobStatus</b> operation.</description></item>
        /// <item><description>After the knowledge base is created, you can associate it with an agent application&lt;props=&quot;china&quot;&gt; or workflow application in the same workspace through &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/app-center">Application Management</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/app-center">Application Management</a> (or pass the <c>IndexID</c> through <c>rag_options</c> in <a href="https://help.aliyun.com/document_detail/2846132.html">Application Calls</a>) to supplement your Model Studio application with private knowledge and up-to-date information. You can also choose not to use a Model Studio application and directly query the knowledge base by invoking the <b>Retrieve</b> operation.</description></item>
        /// <item><description>This operation does not support idempotence.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitIndexJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitIndexJobResponse
        /// </returns>
        public async Task<SubmitIndexJobResponse> SubmitIndexJobWithOptionsAsync(string WorkspaceId, SubmitIndexJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitIndexJob",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/submit_index_job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIndexJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a specified CreateIndex task to complete knowledge base creation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:SubmitIndexJob permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, you must invoke the <b>CreateIndex</b> operation and obtain the corresponding <c>IndexId</c>.</description></item>
        /// <item><description>After invoking this operation, the node requires time to execute and may take several hours during peak periods. Do not submit duplicate requests before the node completes. To query the node execution status, invoke the <b>GetIndexJobStatus</b> operation.</description></item>
        /// <item><description>After the knowledge base is created, you can associate it with an agent application&lt;props=&quot;china&quot;&gt; or workflow application in the same workspace through &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/app-center">Application Management</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/app-center">Application Management</a> (or pass the <c>IndexID</c> through <c>rag_options</c> in <a href="https://help.aliyun.com/document_detail/2846132.html">Application Calls</a>) to supplement your Model Studio application with private knowledge and up-to-date information. You can also choose not to use a Model Studio application and directly query the knowledge base by invoking the <b>Retrieve</b> operation.</description></item>
        /// <item><description>This operation does not support idempotence.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitIndexJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitIndexJobResponse
        /// </returns>
        public SubmitIndexJobResponse SubmitIndexJob(string WorkspaceId, SubmitIndexJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitIndexJobWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a specified CreateIndex task to complete knowledge base creation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Resource Access Management (RAM) users must first obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (requires <c>AliyunBailianDataFullAccess</c>, which includes the sfm:SubmitIndexJob permission), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before invoking this operation. Alibaba Cloud accounts can invoke this operation directly without authorization. Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a> to invoke this operation.</description></item>
        /// <item><description>Before invoking this operation, you must invoke the <b>CreateIndex</b> operation and obtain the corresponding <c>IndexId</c>.</description></item>
        /// <item><description>After invoking this operation, the node requires time to execute and may take several hours during peak periods. Do not submit duplicate requests before the node completes. To query the node execution status, invoke the <b>GetIndexJobStatus</b> operation.</description></item>
        /// <item><description>After the knowledge base is created, you can associate it with an agent application&lt;props=&quot;china&quot;&gt; or workflow application in the same workspace through &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/app-center">Application Management</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/app-center">Application Management</a> (or pass the <c>IndexID</c> through <c>rag_options</c> in <a href="https://help.aliyun.com/document_detail/2846132.html">Application Calls</a>) to supplement your Model Studio application with private knowledge and up-to-date information. You can also choose not to use a Model Studio application and directly query the knowledge base by invoking the <b>Retrieve</b> operation.</description></item>
        /// <item><description>This operation does not support idempotence.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitIndexJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitIndexJobResponse
        /// </returns>
        public async Task<SubmitIndexJobResponse> SubmitIndexJobAsync(string WorkspaceId, SubmitIndexJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitIndexJobWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新并发布智能体应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateAndPublishAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAndPublishAgentResponse
        /// </returns>
        public UpdateAndPublishAgentResponse UpdateAndPublishAgentWithOptions(string workspaceId, string appCode, UpdateAndPublishAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAndPublishAgentShrinkRequest request = new UpdateAndPublishAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApplicationConfig))
            {
                request.ApplicationConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApplicationConfig, "applicationConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SampleLibrary))
            {
                request.SampleLibraryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SampleLibrary, "sampleLibrary", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigShrink))
            {
                body["applicationConfig"] = request.ApplicationConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleLibraryShrink))
            {
                body["sampleLibrary"] = request.SampleLibraryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAndPublishAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appCode),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAndPublishAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新并发布智能体应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateAndPublishAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAndPublishAgentResponse
        /// </returns>
        public async Task<UpdateAndPublishAgentResponse> UpdateAndPublishAgentWithOptionsAsync(string workspaceId, string appCode, UpdateAndPublishAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAndPublishAgentShrinkRequest request = new UpdateAndPublishAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApplicationConfig))
            {
                request.ApplicationConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApplicationConfig, "applicationConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SampleLibrary))
            {
                request.SampleLibraryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SampleLibrary, "sampleLibrary", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigShrink))
            {
                body["applicationConfig"] = request.ApplicationConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleLibraryShrink))
            {
                body["sampleLibrary"] = request.SampleLibraryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAndPublishAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appCode),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAndPublishAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新并发布智能体应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAndPublishAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAndPublishAgentResponse
        /// </returns>
        public UpdateAndPublishAgentResponse UpdateAndPublishAgent(string workspaceId, string appCode, UpdateAndPublishAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAndPublishAgentWithOptions(workspaceId, appCode, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新并发布智能体应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAndPublishAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAndPublishAgentResponse
        /// </returns>
        public async Task<UpdateAndPublishAgentResponse> UpdateAndPublishAgentAsync(string workspaceId, string appCode, UpdateAndPublishAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAndPublishAgentWithOptionsAsync(workspaceId, appCode, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>选择更新并发布智能体应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateAndPublishAgentSelectiveRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAndPublishAgentSelectiveResponse
        /// </returns>
        public UpdateAndPublishAgentSelectiveResponse UpdateAndPublishAgentSelectiveWithOptions(string workspaceId, string appCode, UpdateAndPublishAgentSelectiveRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAndPublishAgentSelectiveShrinkRequest request = new UpdateAndPublishAgentSelectiveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApplicationConfig))
            {
                request.ApplicationConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApplicationConfig, "applicationConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SampleLibrary))
            {
                request.SampleLibraryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SampleLibrary, "sampleLibrary", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigShrink))
            {
                body["applicationConfig"] = request.ApplicationConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleLibraryShrink))
            {
                body["sampleLibrary"] = request.SampleLibraryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAndPublishAgentSelective",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appCode) + "/updateAndPublishAgentSelective",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAndPublishAgentSelectiveResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>选择更新并发布智能体应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateAndPublishAgentSelectiveRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAndPublishAgentSelectiveResponse
        /// </returns>
        public async Task<UpdateAndPublishAgentSelectiveResponse> UpdateAndPublishAgentSelectiveWithOptionsAsync(string workspaceId, string appCode, UpdateAndPublishAgentSelectiveRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAndPublishAgentSelectiveShrinkRequest request = new UpdateAndPublishAgentSelectiveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApplicationConfig))
            {
                request.ApplicationConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApplicationConfig, "applicationConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SampleLibrary))
            {
                request.SampleLibraryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SampleLibrary, "sampleLibrary", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigShrink))
            {
                body["applicationConfig"] = request.ApplicationConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleLibraryShrink))
            {
                body["sampleLibrary"] = request.SampleLibraryShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAndPublishAgentSelective",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appCode) + "/updateAndPublishAgentSelective",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAndPublishAgentSelectiveResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>选择更新并发布智能体应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAndPublishAgentSelectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAndPublishAgentSelectiveResponse
        /// </returns>
        public UpdateAndPublishAgentSelectiveResponse UpdateAndPublishAgentSelective(string workspaceId, string appCode, UpdateAndPublishAgentSelectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAndPublishAgentSelectiveWithOptions(workspaceId, appCode, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>选择更新并发布智能体应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAndPublishAgentSelectiveRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAndPublishAgentSelectiveResponse
        /// </returns>
        public async Task<UpdateAndPublishAgentSelectiveResponse> UpdateAndPublishAgentSelectiveAsync(string workspaceId, string appCode, UpdateAndPublishAgentSelectiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAndPublishAgentSelectiveWithOptionsAsync(workspaceId, appCode, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the content and title of a specified text chunk in a knowledge base, and specifies whether the chunk participates in knowledge base retrieval.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Key limits</b>: This operation supports only document search knowledge bases. Data query and image Q&amp;A knowledge bases are not supported.</description></item>
        /// <item><description><b>Permission requirements</b>:<list type="bullet">
        /// <item><description><b>Resource Access Management (RAM) user</b>: Before invoking this operation, obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (you can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:UpdateChunk permission required by this operation), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>.</description></item>
        /// <item><description><b>Alibaba Cloud account</b>: Has permissions by default and can invoke this operation directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Calling method</b>: Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>. The SDK provides encapsulation of complex signature calculation logic and simplifies the invocation procedure.</description></item>
        /// <item><description><b>Effective latency</b>: Updates typically take effect immediately. During peak hours, a slight delay (seconds) may occur.</description></item>
        /// <item><description><b>Idempotence</b>: This operation is idempotent. If you repeat the operation on a text chunk that has already been updated, the operation returns a success response.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateChunkRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateChunkResponse
        /// </returns>
        public UpdateChunkResponse UpdateChunkWithOptions(string WorkspaceId, UpdateChunkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkId))
            {
                query["ChunkId"] = request.ChunkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDisplayedChunkContent))
            {
                query["IsDisplayedChunkContent"] = request.IsDisplayedChunkContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateChunk",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/chunk/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateChunkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the content and title of a specified text chunk in a knowledge base, and specifies whether the chunk participates in knowledge base retrieval.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Key limits</b>: This operation supports only document search knowledge bases. Data query and image Q&amp;A knowledge bases are not supported.</description></item>
        /// <item><description><b>Permission requirements</b>:<list type="bullet">
        /// <item><description><b>Resource Access Management (RAM) user</b>: Before invoking this operation, obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (you can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:UpdateChunk permission required by this operation), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>.</description></item>
        /// <item><description><b>Alibaba Cloud account</b>: Has permissions by default and can invoke this operation directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Calling method</b>: Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>. The SDK provides encapsulation of complex signature calculation logic and simplifies the invocation procedure.</description></item>
        /// <item><description><b>Effective latency</b>: Updates typically take effect immediately. During peak hours, a slight delay (seconds) may occur.</description></item>
        /// <item><description><b>Idempotence</b>: This operation is idempotent. If you repeat the operation on a text chunk that has already been updated, the operation returns a success response.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateChunkRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateChunkResponse
        /// </returns>
        public async Task<UpdateChunkResponse> UpdateChunkWithOptionsAsync(string WorkspaceId, UpdateChunkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkId))
            {
                query["ChunkId"] = request.ChunkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDisplayedChunkContent))
            {
                query["IsDisplayedChunkContent"] = request.IsDisplayedChunkContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateChunk",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/chunk/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateChunkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the content and title of a specified text chunk in a knowledge base, and specifies whether the chunk participates in knowledge base retrieval.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Key limits</b>: This operation supports only document search knowledge bases. Data query and image Q&amp;A knowledge bases are not supported.</description></item>
        /// <item><description><b>Permission requirements</b>:<list type="bullet">
        /// <item><description><b>Resource Access Management (RAM) user</b>: Before invoking this operation, obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (you can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:UpdateChunk permission required by this operation), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>.</description></item>
        /// <item><description><b>Alibaba Cloud account</b>: Has permissions by default and can invoke this operation directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Calling method</b>: Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>. The SDK provides encapsulation of complex signature calculation logic and simplifies the invocation procedure.</description></item>
        /// <item><description><b>Effective latency</b>: Updates typically take effect immediately. During peak hours, a slight delay (seconds) may occur.</description></item>
        /// <item><description><b>Idempotence</b>: This operation is idempotent. If you repeat the operation on a text chunk that has already been updated, the operation returns a success response.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateChunkRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateChunkResponse
        /// </returns>
        public UpdateChunkResponse UpdateChunk(string WorkspaceId, UpdateChunkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateChunkWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the content and title of a specified text chunk in a knowledge base, and specifies whether the chunk participates in knowledge base retrieval.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Key limits</b>: This operation supports only document search knowledge bases. Data query and image Q&amp;A knowledge bases are not supported.</description></item>
        /// <item><description><b>Permission requirements</b>:<list type="bullet">
        /// <item><description><b>Resource Access Management (RAM) user</b>: Before invoking this operation, obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Model Studio (you can use the <c>AliyunBailianDataFullAccess</c> policy, which includes the sfm:UpdateChunk permission required by this operation), and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>.</description></item>
        /// <item><description><b>Alibaba Cloud account</b>: Has permissions by default and can invoke this operation directly.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Calling method</b>: Use the latest &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Model Studio SDK</a>. The SDK provides encapsulation of complex signature calculation logic and simplifies the invocation procedure.</description></item>
        /// <item><description><b>Effective latency</b>: Updates typically take effect immediately. During peak hours, a slight delay (seconds) may occur.</description></item>
        /// <item><description><b>Idempotence</b>: This operation is idempotent. If you repeat the operation on a text chunk that has already been updated, the operation returns a success response.
        /// <b>Rate limit:</b>
        /// This operation is throttled if called too frequently. Do not exceed 10 calls per second. If you are throttled, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateChunkRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateChunkResponse
        /// </returns>
        public async Task<UpdateChunkResponse> UpdateChunkAsync(string WorkspaceId, UpdateChunkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateChunkWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a connector.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM user can call this operation only after they join a workspace and are granted the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permission</a> for Alibaba Cloud Model Studio (Bailian). The <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:UpdateConnector</c> permission, is required. An Alibaba Cloud account can call this operation directly. Use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio (Bailian) SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio (Bailian) SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Throttling:</b> If you call this operation too frequently, the system may throttle your requests. Do not exceed a frequency of 5 calls per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateConnectorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConnectorResponse
        /// </returns>
        public UpdateConnectorResponse UpdateConnectorWithOptions(string WorkspaceId, string ConnectorId, UpdateConnectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorName))
            {
                body["ConnectorName"] = request.ConnectorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConnector",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/connector/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ConnectorId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConnectorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a connector.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM user can call this operation only after they join a workspace and are granted the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permission</a> for Alibaba Cloud Model Studio (Bailian). The <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:UpdateConnector</c> permission, is required. An Alibaba Cloud account can call this operation directly. Use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio (Bailian) SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio (Bailian) SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Throttling:</b> If you call this operation too frequently, the system may throttle your requests. Do not exceed a frequency of 5 calls per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateConnectorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConnectorResponse
        /// </returns>
        public async Task<UpdateConnectorResponse> UpdateConnectorWithOptionsAsync(string WorkspaceId, string ConnectorId, UpdateConnectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorName))
            {
                body["ConnectorName"] = request.ConnectorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConnector",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/connector/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ConnectorId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a connector.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM user can call this operation only after they join a workspace and are granted the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permission</a> for Alibaba Cloud Model Studio (Bailian). The <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:UpdateConnector</c> permission, is required. An Alibaba Cloud account can call this operation directly. Use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio (Bailian) SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio (Bailian) SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Throttling:</b> If you call this operation too frequently, the system may throttle your requests. Do not exceed a frequency of 5 calls per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateConnectorRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConnectorResponse
        /// </returns>
        public UpdateConnectorResponse UpdateConnector(string WorkspaceId, string ConnectorId, UpdateConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConnectorWithOptions(WorkspaceId, ConnectorId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a connector.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM user can call this operation only after they join a workspace and are granted the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permission</a> for Alibaba Cloud Model Studio (Bailian). The <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:UpdateConnector</c> permission, is required. An Alibaba Cloud account can call this operation directly. Use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio (Bailian) SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio (Bailian) SDK</a> to call this operation.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Throttling:</b> If you call this operation too frequently, the system may throttle your requests. Do not exceed a frequency of 5 calls per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateConnectorRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConnectorResponse
        /// </returns>
        public async Task<UpdateConnectorResponse> UpdateConnectorAsync(string WorkspaceId, string ConnectorId, UpdateConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConnectorWithOptionsAsync(WorkspaceId, ConnectorId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the tags for a specified file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM User (sub-account) must be granted the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (the <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:UpdateFileTag</c> permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. An Alibaba Cloud account (main account) can call this operation directly without authorization. We recommend using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.
        /// <b>Throttling:</b> Do not call this operation more than 5 times per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateFileTagRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileTagResponse
        /// </returns>
        public UpdateFileTagResponse UpdateFileTagWithOptions(string WorkspaceId, string FileId, UpdateFileTagRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFileTagShrinkRequest request = new UpdateFileTagShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFileTag",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FileId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the tags for a specified file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM User (sub-account) must be granted the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (the <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:UpdateFileTag</c> permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. An Alibaba Cloud account (main account) can call this operation directly without authorization. We recommend using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.
        /// <b>Throttling:</b> Do not call this operation more than 5 times per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateFileTagRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileTagResponse
        /// </returns>
        public async Task<UpdateFileTagResponse> UpdateFileTagWithOptionsAsync(string WorkspaceId, string FileId, UpdateFileTagRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFileTagShrinkRequest request = new UpdateFileTagShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFileTag",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FileId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the tags for a specified file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM User (sub-account) must be granted the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (the <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:UpdateFileTag</c> permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. An Alibaba Cloud account (main account) can call this operation directly without authorization. We recommend using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.
        /// <b>Throttling:</b> Do not call this operation more than 5 times per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFileTagRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileTagResponse
        /// </returns>
        public UpdateFileTagResponse UpdateFileTag(string WorkspaceId, string FileId, UpdateFileTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFileTagWithOptions(WorkspaceId, FileId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the tags for a specified file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A RAM User (sub-account) must be granted the required <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio (the <c>AliyunBailianDataFullAccess</c> policy, which includes the <c>sfm:UpdateFileTag</c> permission) and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a> before calling this operation. An Alibaba Cloud account (main account) can call this operation directly without authorization. We recommend using the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>&lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> to call this operation.
        /// <b>Throttling:</b> Do not call this operation more than 5 times per second. If a request is throttled, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFileTagRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFileTagResponse
        /// </returns>
        public async Task<UpdateFileTagResponse> UpdateFileTagAsync(string WorkspaceId, string FileId, UpdateFileTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFileTagWithOptionsAsync(WorkspaceId, FileId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;intl&quot;&gt;This operation is not available on the Alibaba Cloud International Website (www\.alibabacloud.com).&lt;props=&quot;china&quot;&gt;
        /// Before a RAM user can call this operation, the RAM user must have the <c>AliyunBailianDataFullAccess</c> permission for Alibaba Cloud Model Studio. For more information, see <a href="https://help.aliyun.com/document_detail/2848578.html">Grant permissions</a>. The RAM user must also be added to a workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2851098.html">Add a member to a workspace</a>. An Alibaba Cloud account can call this operation without authorization. Use the latest version of the Alibaba Cloud Model Studio SDK to call this operation. For more information, see <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.
        /// Before you call this operation, ensure that the knowledge base is created and has not been deleted. The knowledge base ID (<c>Id</c>) must be valid.
        /// This operation is idempotent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIndexResponse
        /// </returns>
        public UpdateIndexResponse UpdateIndexWithOptions(string WorkspaceId, UpdateIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DenseSimilarityTopK))
            {
                query["DenseSimilarityTopK"] = request.DenseSimilarityTopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineCommercialCu))
            {
                query["PipelineCommercialCu"] = request.PipelineCommercialCu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineCommercialType))
            {
                query["PipelineCommercialType"] = request.PipelineCommercialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankMinScore))
            {
                query["RerankMinScore"] = request.RerankMinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SparseSimilarityTopK))
            {
                query["SparseSimilarityTopK"] = request.SparseSimilarityTopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIndex",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIndexResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;intl&quot;&gt;This operation is not available on the Alibaba Cloud International Website (www\.alibabacloud.com).&lt;props=&quot;china&quot;&gt;
        /// Before a RAM user can call this operation, the RAM user must have the <c>AliyunBailianDataFullAccess</c> permission for Alibaba Cloud Model Studio. For more information, see <a href="https://help.aliyun.com/document_detail/2848578.html">Grant permissions</a>. The RAM user must also be added to a workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2851098.html">Add a member to a workspace</a>. An Alibaba Cloud account can call this operation without authorization. Use the latest version of the Alibaba Cloud Model Studio SDK to call this operation. For more information, see <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.
        /// Before you call this operation, ensure that the knowledge base is created and has not been deleted. The knowledge base ID (<c>Id</c>) must be valid.
        /// This operation is idempotent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIndexResponse
        /// </returns>
        public async Task<UpdateIndexResponse> UpdateIndexWithOptionsAsync(string WorkspaceId, UpdateIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DenseSimilarityTopK))
            {
                query["DenseSimilarityTopK"] = request.DenseSimilarityTopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineCommercialCu))
            {
                query["PipelineCommercialCu"] = request.PipelineCommercialCu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineCommercialType))
            {
                query["PipelineCommercialType"] = request.PipelineCommercialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankMinScore))
            {
                query["RerankMinScore"] = request.RerankMinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SparseSimilarityTopK))
            {
                query["SparseSimilarityTopK"] = request.SparseSimilarityTopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIndex",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;intl&quot;&gt;This operation is not available on the Alibaba Cloud International Website (www\.alibabacloud.com).&lt;props=&quot;china&quot;&gt;
        /// Before a RAM user can call this operation, the RAM user must have the <c>AliyunBailianDataFullAccess</c> permission for Alibaba Cloud Model Studio. For more information, see <a href="https://help.aliyun.com/document_detail/2848578.html">Grant permissions</a>. The RAM user must also be added to a workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2851098.html">Add a member to a workspace</a>. An Alibaba Cloud account can call this operation without authorization. Use the latest version of the Alibaba Cloud Model Studio SDK to call this operation. For more information, see <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.
        /// Before you call this operation, ensure that the knowledge base is created and has not been deleted. The knowledge base ID (<c>Id</c>) must be valid.
        /// This operation is idempotent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIndexResponse
        /// </returns>
        public UpdateIndexResponse UpdateIndex(string WorkspaceId, UpdateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateIndexWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;intl&quot;&gt;This operation is not available on the Alibaba Cloud International Website (www\.alibabacloud.com).&lt;props=&quot;china&quot;&gt;
        /// Before a RAM user can call this operation, the RAM user must have the <c>AliyunBailianDataFullAccess</c> permission for Alibaba Cloud Model Studio. For more information, see <a href="https://help.aliyun.com/document_detail/2848578.html">Grant permissions</a>. The RAM user must also be added to a workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2851098.html">Add a member to a workspace</a>. An Alibaba Cloud account can call this operation without authorization. Use the latest version of the Alibaba Cloud Model Studio SDK to call this operation. For more information, see <a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.
        /// Before you call this operation, ensure that the knowledge base is created and has not been deleted. The knowledge base ID (<c>Id</c>) must be valid.
        /// This operation is idempotent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIndexResponse
        /// </returns>
        public async Task<UpdateIndexResponse> UpdateIndexAsync(string WorkspaceId, UpdateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateIndexWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of a specified long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b> Ensure that the interval between two requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryResponse
        /// </returns>
        public UpdateMemoryResponse UpdateMemoryWithOptions(string workspaceId, string memoryId, UpdateMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of a specified long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b> Ensure that the interval between two requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryResponse
        /// </returns>
        public async Task<UpdateMemoryResponse> UpdateMemoryWithOptionsAsync(string workspaceId, string memoryId, UpdateMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of a specified long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b> Ensure that the interval between two requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryResponse
        /// </returns>
        public UpdateMemoryResponse UpdateMemory(string workspaceId, string memoryId, UpdateMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMemoryWithOptions(workspaceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of a specified long-term memory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>This operation is idempotent.
        /// <b>Rate limit:</b> Ensure that the interval between two requests is at least 1 second. Otherwise, throttling may be triggered. If throttling occurs, retry later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryResponse
        /// </returns>
        public async Task<UpdateMemoryResponse> UpdateMemoryAsync(string workspaceId, string memoryId, UpdateMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMemoryWithOptionsAsync(workspaceId, memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a memory fragment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryNodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryNodeResponse
        /// </returns>
        public UpdateMemoryNodeResponse UpdateMemoryNodeWithOptions(string workspaceId, string memoryId, string memoryNodeId, UpdateMemoryNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryNodeId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a memory fragment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryNodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryNodeResponse
        /// </returns>
        public async Task<UpdateMemoryNodeResponse> UpdateMemoryNodeWithOptionsAsync(string workspaceId, string memoryId, string memoryNodeId, UpdateMemoryNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryNodeId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a memory fragment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryNodeResponse
        /// </returns>
        public UpdateMemoryNodeResponse UpdateMemoryNode(string workspaceId, string memoryId, string memoryNodeId, UpdateMemoryNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMemoryNodeWithOptions(workspaceId, memoryId, memoryNodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a memory fragment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryNodeResponse
        /// </returns>
        public async Task<UpdateMemoryNodeResponse> UpdateMemoryNodeAsync(string workspaceId, string memoryId, string memoryNodeId, UpdateMemoryNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMemoryNodeWithOptionsAsync(workspaceId, memoryId, memoryNodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a prompt template based on the template ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePromptTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePromptTemplateResponse
        /// </returns>
        public UpdatePromptTemplateResponse UpdatePromptTemplateWithOptions(string workspaceId, string promptTemplateId, UpdatePromptTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePromptTemplate",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/promptTemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(promptTemplateId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePromptTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a prompt template based on the template ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePromptTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePromptTemplateResponse
        /// </returns>
        public async Task<UpdatePromptTemplateResponse> UpdatePromptTemplateWithOptionsAsync(string workspaceId, string promptTemplateId, UpdatePromptTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePromptTemplate",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/promptTemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(promptTemplateId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePromptTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a prompt template based on the template ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePromptTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePromptTemplateResponse
        /// </returns>
        public UpdatePromptTemplateResponse UpdatePromptTemplate(string workspaceId, string promptTemplateId, UpdatePromptTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePromptTemplateWithOptions(workspaceId, promptTemplateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a prompt template based on the template ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePromptTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePromptTemplateResponse
        /// </returns>
        public async Task<UpdatePromptTemplateResponse> UpdatePromptTemplateAsync(string workspaceId, string promptTemplateId, UpdatePromptTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePromptTemplateWithOptionsAsync(workspaceId, promptTemplateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a table in an Alibaba Cloud Model Studio data connector using a file from an authorized OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Ensure that the OSS bucket belongs to the same Alibaba Cloud account as your Alibaba Cloud Model Studio instance. You must also complete the authorization steps described in <a href="https://help.aliyun.com/document_detail/2782155.html">Configure data import from OSS</a>.<list type="bullet">
        /// <item><description>The bucket storage class must not be Archive, Cold Archive, or Deep Cold Archive. Buckets with server-side encryption are supported. public-read-write, public-read, and private buckets are also supported.</description></item>
        /// <item><description>If you use a bucket with <a href="https://help.aliyun.com/document_detail/2636937.html">Referer-based hotlink protection</a>, you must add <c>*.console.aliyun.com</c> to the Referer whitelist. For more information, see <a href="https://help.aliyun.com/document_detail/2636937.html">Allow access only from trusted websites</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Before a RAM user (sub-account) can call this operation, they must obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. The AliyunBailianDataFullAccess policy includes the required <c>sfm:UpdateTableFromAuthorizedOss</c> permission. An Alibaba Cloud account (root account) can call this operation directly without additional permissions. We recommend that you use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> or &lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Rate limiting:</b> This operation is subject to rate limiting. Do not call it more than five times per second. If you reach the limit, wait before you try again.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTableFromAuthorizedOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableFromAuthorizedOssResponse
        /// </returns>
        public UpdateTableFromAuthorizedOssResponse UpdateTableFromAuthorizedOssWithOptions(string WorkspaceId, string TableId, UpdateTableFromAuthorizedOssRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                body["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                body["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssRegionId))
            {
                body["OssRegionId"] = request.OssRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateMode))
            {
                body["UpdateMode"] = request.UpdateMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTableFromAuthorizedOss",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/table/fromoss/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTableFromAuthorizedOssResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a table in an Alibaba Cloud Model Studio data connector using a file from an authorized OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Ensure that the OSS bucket belongs to the same Alibaba Cloud account as your Alibaba Cloud Model Studio instance. You must also complete the authorization steps described in <a href="https://help.aliyun.com/document_detail/2782155.html">Configure data import from OSS</a>.<list type="bullet">
        /// <item><description>The bucket storage class must not be Archive, Cold Archive, or Deep Cold Archive. Buckets with server-side encryption are supported. public-read-write, public-read, and private buckets are also supported.</description></item>
        /// <item><description>If you use a bucket with <a href="https://help.aliyun.com/document_detail/2636937.html">Referer-based hotlink protection</a>, you must add <c>*.console.aliyun.com</c> to the Referer whitelist. For more information, see <a href="https://help.aliyun.com/document_detail/2636937.html">Allow access only from trusted websites</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Before a RAM user (sub-account) can call this operation, they must obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. The AliyunBailianDataFullAccess policy includes the required <c>sfm:UpdateTableFromAuthorizedOss</c> permission. An Alibaba Cloud account (root account) can call this operation directly without additional permissions. We recommend that you use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> or &lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Rate limiting:</b> This operation is subject to rate limiting. Do not call it more than five times per second. If you reach the limit, wait before you try again.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTableFromAuthorizedOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableFromAuthorizedOssResponse
        /// </returns>
        public async Task<UpdateTableFromAuthorizedOssResponse> UpdateTableFromAuthorizedOssWithOptionsAsync(string WorkspaceId, string TableId, UpdateTableFromAuthorizedOssRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                body["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                body["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssRegionId))
            {
                body["OssRegionId"] = request.OssRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateMode))
            {
                body["UpdateMode"] = request.UpdateMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTableFromAuthorizedOss",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/table/fromoss/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTableFromAuthorizedOssResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a table in an Alibaba Cloud Model Studio data connector using a file from an authorized OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Ensure that the OSS bucket belongs to the same Alibaba Cloud account as your Alibaba Cloud Model Studio instance. You must also complete the authorization steps described in <a href="https://help.aliyun.com/document_detail/2782155.html">Configure data import from OSS</a>.<list type="bullet">
        /// <item><description>The bucket storage class must not be Archive, Cold Archive, or Deep Cold Archive. Buckets with server-side encryption are supported. public-read-write, public-read, and private buckets are also supported.</description></item>
        /// <item><description>If you use a bucket with <a href="https://help.aliyun.com/document_detail/2636937.html">Referer-based hotlink protection</a>, you must add <c>*.console.aliyun.com</c> to the Referer whitelist. For more information, see <a href="https://help.aliyun.com/document_detail/2636937.html">Allow access only from trusted websites</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Before a RAM user (sub-account) can call this operation, they must obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. The AliyunBailianDataFullAccess policy includes the required <c>sfm:UpdateTableFromAuthorizedOss</c> permission. An Alibaba Cloud account (root account) can call this operation directly without additional permissions. We recommend that you use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> or &lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Rate limiting:</b> This operation is subject to rate limiting. Do not call it more than five times per second. If you reach the limit, wait before you try again.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTableFromAuthorizedOssRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableFromAuthorizedOssResponse
        /// </returns>
        public UpdateTableFromAuthorizedOssResponse UpdateTableFromAuthorizedOss(string WorkspaceId, string TableId, UpdateTableFromAuthorizedOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTableFromAuthorizedOssWithOptions(WorkspaceId, TableId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a table in an Alibaba Cloud Model Studio data connector using a file from an authorized OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Ensure that the OSS bucket belongs to the same Alibaba Cloud account as your Alibaba Cloud Model Studio instance. You must also complete the authorization steps described in <a href="https://help.aliyun.com/document_detail/2782155.html">Configure data import from OSS</a>.<list type="bullet">
        /// <item><description>The bucket storage class must not be Archive, Cold Archive, or Deep Cold Archive. Buckets with server-side encryption are supported. public-read-write, public-read, and private buckets are also supported.</description></item>
        /// <item><description>If you use a bucket with <a href="https://help.aliyun.com/document_detail/2636937.html">Referer-based hotlink protection</a>, you must add <c>*.console.aliyun.com</c> to the Referer whitelist. For more information, see <a href="https://help.aliyun.com/document_detail/2636937.html">Allow access only from trusted websites</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Before a RAM user (sub-account) can call this operation, they must obtain <a href="https://help.aliyun.com/document_detail/2848578.html">API permissions</a> for Alibaba Cloud Model Studio and <a href="https://help.aliyun.com/document_detail/2851098.html">join a workspace</a>. The AliyunBailianDataFullAccess policy includes the required <c>sfm:UpdateTableFromAuthorizedOss</c> permission. An Alibaba Cloud account (root account) can call this operation directly without additional permissions. We recommend that you use the latest version of the &lt;props=&quot;china&quot;&gt;<a href="https://api.aliyun.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a> or &lt;props=&quot;intl&quot;&gt;<a href="https://api.alibabacloud.com/api-tools/sdk/bailian?version=2023-12-29">Alibaba Cloud Model Studio SDK</a>.</description></item>
        /// <item><description>This operation is not idempotent.
        /// <b>Rate limiting:</b> This operation is subject to rate limiting. Do not call it more than five times per second. If you reach the limit, wait before you try again.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTableFromAuthorizedOssRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableFromAuthorizedOssResponse
        /// </returns>
        public async Task<UpdateTableFromAuthorizedOssResponse> UpdateTableFromAuthorizedOssAsync(string WorkspaceId, string TableId, UpdateTableFromAuthorizedOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTableFromAuthorizedOssWithOptionsAsync(WorkspaceId, TableId, request, headers, runtime);
        }

    }
}
