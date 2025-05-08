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
            this._endpointRule = "";
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
        /// <para>添加类目</para>
        /// </summary>
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
        /// <para>添加类目</para>
        /// </summary>
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
        /// <para>添加类目</para>
        /// </summary>
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
        /// <para>添加类目</para>
        /// </summary>
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
        /// <para>Imports an unstructured document stored in the temporary storage space to Data Management. You cannot use the API to import structured documents. Use the console instead.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you have obtained the lease and uploaded the document to the temporary storage space by using the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-applyfileuploadlease">ApplyFileUploadLease</a> operation. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/upload-files-by-calling-api">Upload files by calling API</a>.</para>
        /// <remarks>
        /// <para> After you call this operation, the used lease ID expires immediately. Do not use the same lease ID to submit new requests.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You must call this operation within 12 hours after you call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-applyfileuploadlease">ApplyFileUploadLease</a> operation. Otherwise, the lease expires and the request fails.</description></item>
        /// <item><description>After you call this operation, the system parses and imports your document. The process takes some time.</description></item>
        /// <item><description>This interface is not idempotent.</description></item>
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
        /// <para>Imports an unstructured document stored in the temporary storage space to Data Management. You cannot use the API to import structured documents. Use the console instead.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you have obtained the lease and uploaded the document to the temporary storage space by using the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-applyfileuploadlease">ApplyFileUploadLease</a> operation. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/upload-files-by-calling-api">Upload files by calling API</a>.</para>
        /// <remarks>
        /// <para> After you call this operation, the used lease ID expires immediately. Do not use the same lease ID to submit new requests.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You must call this operation within 12 hours after you call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-applyfileuploadlease">ApplyFileUploadLease</a> operation. Otherwise, the lease expires and the request fails.</description></item>
        /// <item><description>After you call this operation, the system parses and imports your document. The process takes some time.</description></item>
        /// <item><description>This interface is not idempotent.</description></item>
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
        /// <para>Imports an unstructured document stored in the temporary storage space to Data Management. You cannot use the API to import structured documents. Use the console instead.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you have obtained the lease and uploaded the document to the temporary storage space by using the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-applyfileuploadlease">ApplyFileUploadLease</a> operation. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/upload-files-by-calling-api">Upload files by calling API</a>.</para>
        /// <remarks>
        /// <para> After you call this operation, the used lease ID expires immediately. Do not use the same lease ID to submit new requests.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You must call this operation within 12 hours after you call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-applyfileuploadlease">ApplyFileUploadLease</a> operation. Otherwise, the lease expires and the request fails.</description></item>
        /// <item><description>After you call this operation, the system parses and imports your document. The process takes some time.</description></item>
        /// <item><description>This interface is not idempotent.</description></item>
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
        /// <para>Imports an unstructured document stored in the temporary storage space to Data Management. You cannot use the API to import structured documents. Use the console instead.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you have obtained the lease and uploaded the document to the temporary storage space by using the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-applyfileuploadlease">ApplyFileUploadLease</a> operation. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/upload-files-by-calling-api">Upload files by calling API</a>.</para>
        /// <remarks>
        /// <para> After you call this operation, the used lease ID expires immediately. Do not use the same lease ID to submit new requests.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You must call this operation within 12 hours after you call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-applyfileuploadlease">ApplyFileUploadLease</a> operation. Otherwise, the lease expires and the request fails.</description></item>
        /// <item><description>After you call this operation, the system parses and imports your document. The process takes some time.</description></item>
        /// <item><description>This interface is not idempotent.</description></item>
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
        /// <para>Applies for a document upload lease to upload a document.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation returns an HTTP URL that can be used to upload an unstructured document (the lease) and parameters required for the upload. Structured documents are not supported.</para>
        /// <list type="bullet">
        /// <item><description>The HTTP URL returned by this operation is valid only for minutes. Upload the document before the URL expires.</description></item>
        /// <item><description>After you apply for a lease and upload a document, the document is stored in a temporary storage space for 12 hours. </description></item>
        /// <item><description>This interface is not idempotent.</description></item>
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
        /// <para>Applies for a document upload lease to upload a document.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation returns an HTTP URL that can be used to upload an unstructured document (the lease) and parameters required for the upload. Structured documents are not supported.</para>
        /// <list type="bullet">
        /// <item><description>The HTTP URL returned by this operation is valid only for minutes. Upload the document before the URL expires.</description></item>
        /// <item><description>After you apply for a lease and upload a document, the document is stored in a temporary storage space for 12 hours. </description></item>
        /// <item><description>This interface is not idempotent.</description></item>
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
        /// <para>Applies for a document upload lease to upload a document.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation returns an HTTP URL that can be used to upload an unstructured document (the lease) and parameters required for the upload. Structured documents are not supported.</para>
        /// <list type="bullet">
        /// <item><description>The HTTP URL returned by this operation is valid only for minutes. Upload the document before the URL expires.</description></item>
        /// <item><description>After you apply for a lease and upload a document, the document is stored in a temporary storage space for 12 hours. </description></item>
        /// <item><description>This interface is not idempotent.</description></item>
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
        /// <para>Applies for a document upload lease to upload a document.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation returns an HTTP URL that can be used to upload an unstructured document (the lease) and parameters required for the upload. Structured documents are not supported.</para>
        /// <list type="bullet">
        /// <item><description>The HTTP URL returned by this operation is valid only for minutes. Upload the document before the URL expires.</description></item>
        /// <item><description>After you apply for a lease and upload a document, the document is stored in a temporary storage space for 12 hours. </description></item>
        /// <item><description>This interface is not idempotent.</description></item>
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
        /// <para>Creates an unstructured knowledge base and imports one or more parsed documents into the knowledge base. You cannot create a structured knowledge base by calling an API operation. Use the console instead.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>You must first upload documents to <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> and obtain the <c>FileId</c>. The documents are the knowledge source of the knowledge base. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/data-import-instructions">Import Data</a>.</description></item>
        /// <item><description>This operation only initializes a knowledge base creation job. You must also call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-submitindexjob">SubmitIndexJob</a> operation to complete the job.</description></item>
        /// <item><description>This interface is not idempotent.</description></item>
        /// </ol>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSource))
            {
                request.DataSourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSource, "DataSource", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentIds))
            {
                request.DocumentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentIds, "DocumentIds", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceShrink))
            {
                query["DataSource"] = request.DataSourceShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverlapSize))
            {
                query["OverlapSize"] = request.OverlapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankMinScore))
            {
                query["RerankMinScore"] = request.RerankMinScore;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkMode))
            {
                query["chunkMode"] = request.ChunkMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableHeaders))
            {
                query["enableHeaders"] = request.EnableHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaExtractColumnsShrink))
            {
                query["metaExtractColumns"] = request.MetaExtractColumnsShrink;
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
        /// <para>Creates an unstructured knowledge base and imports one or more parsed documents into the knowledge base. You cannot create a structured knowledge base by calling an API operation. Use the console instead.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>You must first upload documents to <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> and obtain the <c>FileId</c>. The documents are the knowledge source of the knowledge base. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/data-import-instructions">Import Data</a>.</description></item>
        /// <item><description>This operation only initializes a knowledge base creation job. You must also call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-submitindexjob">SubmitIndexJob</a> operation to complete the job.</description></item>
        /// <item><description>This interface is not idempotent.</description></item>
        /// </ol>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSource))
            {
                request.DataSourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSource, "DataSource", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentIds))
            {
                request.DocumentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentIds, "DocumentIds", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceShrink))
            {
                query["DataSource"] = request.DataSourceShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverlapSize))
            {
                query["OverlapSize"] = request.OverlapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankMinScore))
            {
                query["RerankMinScore"] = request.RerankMinScore;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkMode))
            {
                query["chunkMode"] = request.ChunkMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableHeaders))
            {
                query["enableHeaders"] = request.EnableHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaExtractColumnsShrink))
            {
                query["metaExtractColumns"] = request.MetaExtractColumnsShrink;
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
        /// <para>Creates an unstructured knowledge base and imports one or more parsed documents into the knowledge base. You cannot create a structured knowledge base by calling an API operation. Use the console instead.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>You must first upload documents to <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> and obtain the <c>FileId</c>. The documents are the knowledge source of the knowledge base. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/data-import-instructions">Import Data</a>.</description></item>
        /// <item><description>This operation only initializes a knowledge base creation job. You must also call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-submitindexjob">SubmitIndexJob</a> operation to complete the job.</description></item>
        /// <item><description>This interface is not idempotent.</description></item>
        /// </ol>
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
        /// <para>Creates an unstructured knowledge base and imports one or more parsed documents into the knowledge base. You cannot create a structured knowledge base by calling an API operation. Use the console instead.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>You must first upload documents to <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> and obtain the <c>FileId</c>. The documents are the knowledge source of the knowledge base. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/data-import-instructions">Import Data</a>.</description></item>
        /// <item><description>This operation only initializes a knowledge base creation job. You must also call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-submitindexjob">SubmitIndexJob</a> operation to complete the job.</description></item>
        /// <item><description>This interface is not idempotent.</description></item>
        /// </ol>
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
        /// <para>创建Memory</para>
        /// </summary>
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
        /// <para>创建Memory</para>
        /// </summary>
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
        /// <para>创建Memory</para>
        /// </summary>
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
        /// <para>创建Memory</para>
        /// </summary>
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
        /// <para>创建记忆Node</para>
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
        /// <para>创建记忆Node</para>
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
        /// <para>创建记忆Node</para>
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
        /// <para>创建记忆Node</para>
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
        /// <para>Creates a prompt template.</para>
        /// </summary>
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
        /// <para>Creates a prompt template.</para>
        /// </summary>
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
        /// <para>Creates a prompt template.</para>
        /// </summary>
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
        /// <para>Creates a prompt template.</para>
        /// </summary>
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
        public DeleteAgentResponse DeleteAgentWithOptions(string workspaceId, string appCode, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        public async Task<DeleteAgentResponse> DeleteAgentWithOptionsAsync(string workspaceId, string appCode, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public DeleteAgentResponse DeleteAgent(string workspaceId, string appCode)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAgentWithOptions(workspaceId, appCode, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能体</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public async Task<DeleteAgentResponse> DeleteAgentAsync(string workspaceId, string appCode)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAgentWithOptionsAsync(workspaceId, appCode, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除类目</para>
        /// </summary>
        /// 
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
        public DeleteCategoryResponse DeleteCategoryWithOptions(string CategoryId, string WorkspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <para>删除类目</para>
        /// </summary>
        /// 
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
        public async Task<DeleteCategoryResponse> DeleteCategoryWithOptionsAsync(string CategoryId, string WorkspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <para>删除类目</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteCategoryResponse
        /// </returns>
        public DeleteCategoryResponse DeleteCategory(string CategoryId, string WorkspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCategoryWithOptions(CategoryId, WorkspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除类目</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteCategoryResponse
        /// </returns>
        public async Task<DeleteCategoryResponse> DeleteCategoryAsync(string CategoryId, string WorkspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCategoryWithOptionsAsync(CategoryId, WorkspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档</para>
        /// </summary>
        /// 
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
        public DeleteFileResponse DeleteFileWithOptions(string FileId, string WorkspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <para>删除文档</para>
        /// </summary>
        /// 
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
        public async Task<DeleteFileResponse> DeleteFileWithOptionsAsync(string FileId, string WorkspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <para>删除文档</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteFileResponse
        /// </returns>
        public DeleteFileResponse DeleteFile(string FileId, string WorkspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFileWithOptions(FileId, WorkspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteFileResponse
        /// </returns>
        public async Task<DeleteFileResponse> DeleteFileAsync(string FileId, string WorkspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFileWithOptionsAsync(FileId, WorkspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified knowledge base permanently.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>If a knowledge base is being called by an application, disassociate the knowledge base before you can delete it. To disassociate the knowledge base, you must use the console. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>.</description></item>
        /// <item><description>After you delete a knowledge base, it cannot be recovered. We recommend that you proceed with caution.</description></item>
        /// <item><description>Imported documents are not deleted from the <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> if you call this operation.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>Deletes a specified knowledge base permanently.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>If a knowledge base is being called by an application, disassociate the knowledge base before you can delete it. To disassociate the knowledge base, you must use the console. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>.</description></item>
        /// <item><description>After you delete a knowledge base, it cannot be recovered. We recommend that you proceed with caution.</description></item>
        /// <item><description>Imported documents are not deleted from the <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> if you call this operation.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>Deletes a specified knowledge base permanently.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>If a knowledge base is being called by an application, disassociate the knowledge base before you can delete it. To disassociate the knowledge base, you must use the console. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>.</description></item>
        /// <item><description>After you delete a knowledge base, it cannot be recovered. We recommend that you proceed with caution.</description></item>
        /// <item><description>Imported documents are not deleted from the <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> if you call this operation.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>Deletes a specified knowledge base permanently.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>If a knowledge base is being called by an application, disassociate the knowledge base before you can delete it. To disassociate the knowledge base, you must use the console. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/rag-knowledge-base">Create a knowledge base</a>.</description></item>
        /// <item><description>After you delete a knowledge base, it cannot be recovered. We recommend that you proceed with caution.</description></item>
        /// <item><description>Imported documents are not deleted from the <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> if you call this operation.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>Deletes one or more documents from a specified unstructured knowledge base permanently.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>Only documents with the INSERT_ERROR and FINISH states can be deleted. To query the status of documents in a specified knowledge base, call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-listindexdocuments">ListIndexDocuments</a> operation.</description></item>
        /// <item><description>After you delete a document, it cannot be recovered and the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-retrieve">Retrieve</a> operation cannot query information about the document. We recommend that you proceed with caution.</description></item>
        /// <item><description>Imported documents are not deleted from the <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> if you call this operation.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>Deletes one or more documents from a specified unstructured knowledge base permanently.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>Only documents with the INSERT_ERROR and FINISH states can be deleted. To query the status of documents in a specified knowledge base, call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-listindexdocuments">ListIndexDocuments</a> operation.</description></item>
        /// <item><description>After you delete a document, it cannot be recovered and the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-retrieve">Retrieve</a> operation cannot query information about the document. We recommend that you proceed with caution.</description></item>
        /// <item><description>Imported documents are not deleted from the <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> if you call this operation.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>Deletes one or more documents from a specified unstructured knowledge base permanently.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>Only documents with the INSERT_ERROR and FINISH states can be deleted. To query the status of documents in a specified knowledge base, call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-listindexdocuments">ListIndexDocuments</a> operation.</description></item>
        /// <item><description>After you delete a document, it cannot be recovered and the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-retrieve">Retrieve</a> operation cannot query information about the document. We recommend that you proceed with caution.</description></item>
        /// <item><description>Imported documents are not deleted from the <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> if you call this operation.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>Deletes one or more documents from a specified unstructured knowledge base permanently.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>Only documents with the INSERT_ERROR and FINISH states can be deleted. To query the status of documents in a specified knowledge base, call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-listindexdocuments">ListIndexDocuments</a> operation.</description></item>
        /// <item><description>After you delete a document, it cannot be recovered and the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-retrieve">Retrieve</a> operation cannot query information about the document. We recommend that you proceed with caution.</description></item>
        /// <item><description>Imported documents are not deleted from the <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> if you call this operation.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>删除memory</para>
        /// </summary>
        /// 
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
        public DeleteMemoryResponse DeleteMemoryWithOptions(string workspaceId, string memoryId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <para>删除memory</para>
        /// </summary>
        /// 
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
        public async Task<DeleteMemoryResponse> DeleteMemoryWithOptionsAsync(string workspaceId, string memoryId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <para>删除memory</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteMemoryResponse
        /// </returns>
        public DeleteMemoryResponse DeleteMemory(string workspaceId, string memoryId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMemoryWithOptions(workspaceId, memoryId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除memory</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteMemoryResponse
        /// </returns>
        public async Task<DeleteMemoryResponse> DeleteMemoryAsync(string workspaceId, string memoryId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMemoryWithOptionsAsync(workspaceId, memoryId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记忆Node</para>
        /// </summary>
        /// 
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
        public DeleteMemoryNodeResponse DeleteMemoryNodeWithOptions(string workspaceId, string memoryId, string memoryNodeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <para>删除记忆Node</para>
        /// </summary>
        /// 
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
        public async Task<DeleteMemoryNodeResponse> DeleteMemoryNodeWithOptionsAsync(string workspaceId, string memoryId, string memoryNodeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <para>删除记忆Node</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteMemoryNodeResponse
        /// </returns>
        public DeleteMemoryNodeResponse DeleteMemoryNode(string workspaceId, string memoryId, string memoryNodeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMemoryNodeWithOptions(workspaceId, memoryId, memoryNodeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记忆Node</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteMemoryNodeResponse
        /// </returns>
        public async Task<DeleteMemoryNodeResponse> DeleteMemoryNodeAsync(string workspaceId, string memoryId, string memoryNodeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMemoryNodeWithOptionsAsync(workspaceId, memoryId, memoryNodeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a prompt template based on the template ID.</para>
        /// </summary>
        /// 
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
        public DeletePromptTemplateResponse DeletePromptTemplateWithOptions(string workspaceId, string promptTemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        public async Task<DeletePromptTemplateResponse> DeletePromptTemplateWithOptionsAsync(string workspaceId, string promptTemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <returns>
        /// DeletePromptTemplateResponse
        /// </returns>
        public DeletePromptTemplateResponse DeletePromptTemplate(string workspaceId, string promptTemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePromptTemplateWithOptions(workspaceId, promptTemplateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a prompt template based on the template ID.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeletePromptTemplateResponse
        /// </returns>
        public async Task<DeletePromptTemplateResponse> DeletePromptTemplateAsync(string workspaceId, string promptTemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePromptTemplateWithOptionsAsync(workspaceId, promptTemplateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an unstructured document.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this API, make sure that your document is uploaded to the <a href="https://bailian.console.aliyun.com/knowledge-base#/data-center">Data Management</a> page of Alibaba Cloud Model Studio.</para>
        /// <list type="bullet">
        /// <item><description>You can also call this operation to query unstructured documents that you upload on the <a href="https://bailian.console.aliyun.com/knowledge-base#/data-center">Data Management</a> page.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b> Make sure that the interval between the two queries is at least 15 seconds. Otherwise, you may trigger system throttling. If throttling is triggered, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
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
        public DescribeFileResponse DescribeFileWithOptions(string WorkspaceId, string FileId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <para>Queries the details of an unstructured document.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this API, make sure that your document is uploaded to the <a href="https://bailian.console.aliyun.com/knowledge-base#/data-center">Data Management</a> page of Alibaba Cloud Model Studio.</para>
        /// <list type="bullet">
        /// <item><description>You can also call this operation to query unstructured documents that you upload on the <a href="https://bailian.console.aliyun.com/knowledge-base#/data-center">Data Management</a> page.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b> Make sure that the interval between the two queries is at least 15 seconds. Otherwise, you may trigger system throttling. If throttling is triggered, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
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
        public async Task<DescribeFileResponse> DescribeFileWithOptionsAsync(string WorkspaceId, string FileId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <para>Queries the details of an unstructured document.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this API, make sure that your document is uploaded to the <a href="https://bailian.console.aliyun.com/knowledge-base#/data-center">Data Management</a> page of Alibaba Cloud Model Studio.</para>
        /// <list type="bullet">
        /// <item><description>You can also call this operation to query unstructured documents that you upload on the <a href="https://bailian.console.aliyun.com/knowledge-base#/data-center">Data Management</a> page.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b> Make sure that the interval between the two queries is at least 15 seconds. Otherwise, you may trigger system throttling. If throttling is triggered, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <returns>
        /// DescribeFileResponse
        /// </returns>
        public DescribeFileResponse DescribeFile(string WorkspaceId, string FileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeFileWithOptions(WorkspaceId, FileId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an unstructured document.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this API, make sure that your document is uploaded to the <a href="https://bailian.console.aliyun.com/knowledge-base#/data-center">Data Management</a> page of Alibaba Cloud Model Studio.</para>
        /// <list type="bullet">
        /// <item><description>You can also call this operation to query unstructured documents that you upload on the <a href="https://bailian.console.aliyun.com/knowledge-base#/data-center">Data Management</a> page.</description></item>
        /// <item><description>This operation is idempotent.
        /// <b>Throttling:</b> Make sure that the interval between the two queries is at least 15 seconds. Otherwise, you may trigger system throttling. If throttling is triggered, try again later.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <returns>
        /// DescribeFileResponse
        /// </returns>
        public async Task<DescribeFileResponse> DescribeFileAsync(string WorkspaceId, string FileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeFileWithOptionsAsync(WorkspaceId, FileId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current status of a specified knowledge base creation or add document job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A knowledge base job is running. You can call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-submitindexjob">SubmitIndexJob</a> operation to create a creation job or the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-submitindexadddocumentsjob">SubmitIndexAddDocumentsJob</a> operation to create a add document job. Then, obtain the <c>JobId</c> returned by the operations.</description></item>
        /// <item><description>We recommend that you call this operation at intervals of more than 5 seconds.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
        /// </ol>
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
        /// <para>Queries the current status of a specified knowledge base creation or add document job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A knowledge base job is running. You can call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-submitindexjob">SubmitIndexJob</a> operation to create a creation job or the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-submitindexadddocumentsjob">SubmitIndexAddDocumentsJob</a> operation to create a add document job. Then, obtain the <c>JobId</c> returned by the operations.</description></item>
        /// <item><description>We recommend that you call this operation at intervals of more than 5 seconds.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
        /// </ol>
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
        /// <para>Queries the current status of a specified knowledge base creation or add document job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A knowledge base job is running. You can call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-submitindexjob">SubmitIndexJob</a> operation to create a creation job or the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-submitindexadddocumentsjob">SubmitIndexAddDocumentsJob</a> operation to create a add document job. Then, obtain the <c>JobId</c> returned by the operations.</description></item>
        /// <item><description>We recommend that you call this operation at intervals of more than 5 seconds.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
        /// </ol>
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
        /// <para>Queries the current status of a specified knowledge base creation or add document job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A knowledge base job is running. You can call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-submitindexjob">SubmitIndexJob</a> operation to create a creation job or the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-submitindexadddocumentsjob">SubmitIndexAddDocumentsJob</a> operation to create a add document job. Then, obtain the <c>JobId</c> returned by the operations.</description></item>
        /// <item><description>We recommend that you call this operation at intervals of more than 5 seconds.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
        /// </ol>
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
        /// <para>获取memory</para>
        /// </summary>
        /// 
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
        public GetMemoryResponse GetMemoryWithOptions(string workspaceId, string memoryId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <para>获取memory</para>
        /// </summary>
        /// 
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
        public async Task<GetMemoryResponse> GetMemoryWithOptionsAsync(string workspaceId, string memoryId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <para>获取memory</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMemoryResponse
        /// </returns>
        public GetMemoryResponse GetMemory(string workspaceId, string memoryId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemoryWithOptions(workspaceId, memoryId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取memory</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMemoryResponse
        /// </returns>
        public async Task<GetMemoryResponse> GetMemoryAsync(string workspaceId, string memoryId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemoryWithOptionsAsync(workspaceId, memoryId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取记忆Node</para>
        /// </summary>
        /// 
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
        public GetMemoryNodeResponse GetMemoryNodeWithOptions(string workspaceId, string memoryId, string memoryNodeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <para>获取记忆Node</para>
        /// </summary>
        /// 
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
        public async Task<GetMemoryNodeResponse> GetMemoryNodeWithOptionsAsync(string workspaceId, string memoryId, string memoryNodeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <para>获取记忆Node</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMemoryNodeResponse
        /// </returns>
        public GetMemoryNodeResponse GetMemoryNode(string workspaceId, string memoryId, string memoryNodeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemoryNodeWithOptions(workspaceId, memoryId, memoryNodeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取记忆Node</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMemoryNodeResponse
        /// </returns>
        public async Task<GetMemoryNodeResponse> GetMemoryNodeAsync(string workspaceId, string memoryId, string memoryNodeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemoryNodeWithOptionsAsync(workspaceId, memoryId, memoryNodeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a prompt template based on the template ID.</para>
        /// </summary>
        /// 
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
        public GetPromptTemplateResponse GetPromptTemplateWithOptions(string workspaceId, string promptTemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        public async Task<GetPromptTemplateResponse> GetPromptTemplateWithOptionsAsync(string workspaceId, string promptTemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <returns>
        /// GetPromptTemplateResponse
        /// </returns>
        public GetPromptTemplateResponse GetPromptTemplate(string workspaceId, string promptTemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPromptTemplateWithOptions(workspaceId, promptTemplateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a prompt template based on the template ID.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPromptTemplateResponse
        /// </returns>
        public async Task<GetPromptTemplateResponse> GetPromptTemplateAsync(string workspaceId, string promptTemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPromptTemplateWithOptionsAsync(workspaceId, promptTemplateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取发布态智能体应用</para>
        /// </summary>
        /// 
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
        public GetPublishedAgentResponse GetPublishedAgentWithOptions(string workspaceId, string appCode, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        public async Task<GetPublishedAgentResponse> GetPublishedAgentWithOptionsAsync(string workspaceId, string appCode, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
        /// <returns>
        /// GetPublishedAgentResponse
        /// </returns>
        public GetPublishedAgentResponse GetPublishedAgent(string workspaceId, string appCode)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPublishedAgentWithOptions(workspaceId, appCode, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取发布态智能体应用</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPublishedAgentResponse
        /// </returns>
        public async Task<GetPublishedAgentResponse> GetPublishedAgentAsync(string workspaceId, string appCode)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPublishedAgentWithOptionsAsync(workspaceId, appCode, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListCategory</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
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
        /// <para>ListCategory</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
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
        /// <para>ListCategory</para>
        /// </summary>
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
        /// <para>ListCategory</para>
        /// </summary>
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
        /// <para>For unstructured knowledge base, obtains the details of all chunks of a specified document; for structured knowledge base, obtains the details of all chunks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>For unstructured knowledge base, obtains the details of all chunks of a specified document; for structured knowledge base, obtains the details of all chunks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>For unstructured knowledge base, obtains the details of all chunks of a specified document; for structured knowledge base, obtains the details of all chunks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>For unstructured knowledge base, obtains the details of all chunks of a specified document; for structured knowledge base, obtains the details of all chunks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>获取文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
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
        public ListFileResponse ListFileWithOptions(string WorkspaceId, ListFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
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
        /// <para>获取文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
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
        public async Task<ListFileResponse> ListFileWithOptionsAsync(string WorkspaceId, ListFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
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
        /// <para>获取文档列表</para>
        /// </summary>
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
        /// <para>获取文档列表</para>
        /// </summary>
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
        /// <para>Queries the details of one or more documents in a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>Queries the details of one or more documents in a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>Queries the details of one or more documents in a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>Queries the details of one or more documents in a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>Lists knowledge bases in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is idempotent.</para>
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
        /// <para>Lists knowledge bases in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is idempotent.</para>
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
        /// <para>Lists knowledge bases in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is idempotent.</para>
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
        /// <para>Lists knowledge bases in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This interface is idempotent.</para>
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
        /// <para>获取memory</para>
        /// </summary>
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
        /// <para>获取memory</para>
        /// </summary>
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
        /// <para>获取memory</para>
        /// </summary>
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
        /// <para>获取memory</para>
        /// </summary>
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
        /// <para>获取记忆Node列表</para>
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
        /// <para>获取记忆Node列表</para>
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
        /// <para>获取记忆Node列表</para>
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
        /// <para>获取记忆Node列表</para>
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
        /// <para>Queries information from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>The response time may be long because this operation involves complex retrieval and matching. We recommend that you set appropriate timeout and retry policy for requests.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>Queries information from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>The response time may be long because this operation involves complex retrieval and matching. We recommend that you set appropriate timeout and retry policy for requests.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>Queries information from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>The response time may be long because this operation involves complex retrieval and matching. We recommend that you set appropriate timeout and retry policy for requests.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>Queries information from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</para>
        /// <list type="bullet">
        /// <item><description>The response time may be long because this operation involves complex retrieval and matching. We recommend that you set appropriate timeout and retry policy for requests.</description></item>
        /// <item><description>This interface is idempotent.</description></item>
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
        /// <para>Adds parsed documents to an unstructured knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You must first upload documents to <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> and obtain the <c>FileId</c>. The documents are the knowledge source of the knowledge base. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/data-import-instructions">Import Data</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</description></item>
        /// <item><description>After you call this operation, you can call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-getindexjobstatus">GetIndexJobStatus</a> operation to query the status of the job. More than 20 calls to the GetIndexJobStatus operation per minute may trigger throttling.</description></item>
        /// <item><description>Execution takes a period of time after this operation is called. Do not make new request before the request is returned. This interface is not idempotent.</description></item>
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
        /// <para>Adds parsed documents to an unstructured knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You must first upload documents to <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> and obtain the <c>FileId</c>. The documents are the knowledge source of the knowledge base. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/data-import-instructions">Import Data</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</description></item>
        /// <item><description>After you call this operation, you can call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-getindexjobstatus">GetIndexJobStatus</a> operation to query the status of the job. More than 20 calls to the GetIndexJobStatus operation per minute may trigger throttling.</description></item>
        /// <item><description>Execution takes a period of time after this operation is called. Do not make new request before the request is returned. This interface is not idempotent.</description></item>
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
        /// <para>Adds parsed documents to an unstructured knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You must first upload documents to <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> and obtain the <c>FileId</c>. The documents are the knowledge source of the knowledge base. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/data-import-instructions">Import Data</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</description></item>
        /// <item><description>After you call this operation, you can call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-getindexjobstatus">GetIndexJobStatus</a> operation to query the status of the job. More than 20 calls to the GetIndexJobStatus operation per minute may trigger throttling.</description></item>
        /// <item><description>Execution takes a period of time after this operation is called. Do not make new request before the request is returned. This interface is not idempotent.</description></item>
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
        /// <para>Adds parsed documents to an unstructured knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You must first upload documents to <a href="https://bailian.console.aliyun.com/#/data-center">Data Management</a> and obtain the <c>FileId</c>. The documents are the knowledge source of the knowledge base. For more information, see <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/data-import-instructions">Import Data</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that your knowledge base is created and is not deleted. That is, the primary key ID of the knowledge base <c>IndexId</c> is valid.</description></item>
        /// <item><description>After you call this operation, you can call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-getindexjobstatus">GetIndexJobStatus</a> operation to query the status of the job. More than 20 calls to the GetIndexJobStatus operation per minute may trigger throttling.</description></item>
        /// <item><description>Execution takes a period of time after this operation is called. Do not make new request before the request is returned. This interface is not idempotent.</description></item>
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
        /// <para>Submits a specified CreateIndex job to complete knowledge base creation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Before you call this operation, you must call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-createindex">CreateIndex</a> operation and obtain the <c>IndexId</c>.</description></item>
        /// <item><description>Execution takes a period of time after this operation is called. Do not make new request before the request is returned.</description></item>
        /// <item><description>If you want to query the execution status of the job after you call this operation, call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-getindexjobstatus">GetIndexJobStatus</a> operation.</description></item>
        /// <item><description>This interface is not idempotent.</description></item>
        /// </ol>
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
        /// <para>Submits a specified CreateIndex job to complete knowledge base creation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Before you call this operation, you must call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-createindex">CreateIndex</a> operation and obtain the <c>IndexId</c>.</description></item>
        /// <item><description>Execution takes a period of time after this operation is called. Do not make new request before the request is returned.</description></item>
        /// <item><description>If you want to query the execution status of the job after you call this operation, call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-getindexjobstatus">GetIndexJobStatus</a> operation.</description></item>
        /// <item><description>This interface is not idempotent.</description></item>
        /// </ol>
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
        /// <para>Submits a specified CreateIndex job to complete knowledge base creation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Before you call this operation, you must call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-createindex">CreateIndex</a> operation and obtain the <c>IndexId</c>.</description></item>
        /// <item><description>Execution takes a period of time after this operation is called. Do not make new request before the request is returned.</description></item>
        /// <item><description>If you want to query the execution status of the job after you call this operation, call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-getindexjobstatus">GetIndexJobStatus</a> operation.</description></item>
        /// <item><description>This interface is not idempotent.</description></item>
        /// </ol>
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
        /// <para>Submits a specified CreateIndex job to complete knowledge base creation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Before you call this operation, you must call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-createindex">CreateIndex</a> operation and obtain the <c>IndexId</c>.</description></item>
        /// <item><description>Execution takes a period of time after this operation is called. Do not make new request before the request is returned.</description></item>
        /// <item><description>If you want to query the execution status of the job after you call this operation, call the <a href="https://www.alibabacloud.com/help/en/model-studio/developer-reference/api-bailian-2023-12-29-getindexjobstatus">GetIndexJobStatus</a> operation.</description></item>
        /// <item><description>This interface is not idempotent.</description></item>
        /// </ol>
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
        /// <para>更新文档Tag</para>
        /// </summary>
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
        /// <para>更新文档Tag</para>
        /// </summary>
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
        /// <para>更新文档Tag</para>
        /// </summary>
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
        /// <para>更新文档Tag</para>
        /// </summary>
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
        /// <para>更新memory</para>
        /// </summary>
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
        /// <para>更新memory</para>
        /// </summary>
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
        /// <para>更新memory</para>
        /// </summary>
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
        /// <para>更新memory</para>
        /// </summary>
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
        /// <para>更新记忆Node</para>
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
        /// <para>更新记忆Node</para>
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
        /// <para>更新记忆Node</para>
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
        /// <para>更新记忆Node</para>
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

    }
}
