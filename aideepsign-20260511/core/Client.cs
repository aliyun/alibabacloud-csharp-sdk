// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AIDeepSign20260511.Models;

namespace AlibabaCloud.SDK.AIDeepSign20260511
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aideepsign", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Stops a batch C2PA trusted signing task for a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation stops a batch trusted signing task for a bucket owned by the currently authenticated account. TaskId is the parent task ID of the bucket returned by CreateC2paBucketSignTask.</description></item>
        /// <item><description>When the returned Status is <c>CANCELING</c>, the task is completing the stop process. Repeated requests may return the completed <c>CANCELED</c> status.</description></item>
        /// <item><description>Call GetC2paSignResult to query the task status and final result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelC2paBucketSignTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelC2paBucketSignTaskResponse
        /// </returns>
        public CancelC2paBucketSignTaskResponse CancelC2paBucketSignTaskWithOptions(CancelC2paBucketSignTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "CancelC2paBucketSignTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelC2paBucketSignTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a batch C2PA trusted signing task for a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation stops a batch trusted signing task for a bucket owned by the currently authenticated account. TaskId is the parent task ID of the bucket returned by CreateC2paBucketSignTask.</description></item>
        /// <item><description>When the returned Status is <c>CANCELING</c>, the task is completing the stop process. Repeated requests may return the completed <c>CANCELED</c> status.</description></item>
        /// <item><description>Call GetC2paSignResult to query the task status and final result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelC2paBucketSignTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelC2paBucketSignTaskResponse
        /// </returns>
        public async Task<CancelC2paBucketSignTaskResponse> CancelC2paBucketSignTaskWithOptionsAsync(CancelC2paBucketSignTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "CancelC2paBucketSignTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelC2paBucketSignTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a batch C2PA trusted signing task for a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation stops a batch trusted signing task for a bucket owned by the currently authenticated account. TaskId is the parent task ID of the bucket returned by CreateC2paBucketSignTask.</description></item>
        /// <item><description>When the returned Status is <c>CANCELING</c>, the task is completing the stop process. Repeated requests may return the completed <c>CANCELED</c> status.</description></item>
        /// <item><description>Call GetC2paSignResult to query the task status and final result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelC2paBucketSignTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelC2paBucketSignTaskResponse
        /// </returns>
        public CancelC2paBucketSignTaskResponse CancelC2paBucketSignTask(CancelC2paBucketSignTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelC2paBucketSignTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a batch C2PA trusted signing task for a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation stops a batch trusted signing task for a bucket owned by the currently authenticated account. TaskId is the parent task ID of the bucket returned by CreateC2paBucketSignTask.</description></item>
        /// <item><description>When the returned Status is <c>CANCELING</c>, the task is completing the stop process. Repeated requests may return the completed <c>CANCELED</c> status.</description></item>
        /// <item><description>Call GetC2paSignResult to query the task status and final result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelC2paBucketSignTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelC2paBucketSignTaskResponse
        /// </returns>
        public async Task<CancelC2paBucketSignTaskResponse> CancelC2paBucketSignTaskAsync(CancelC2paBucketSignTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelC2paBucketSignTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a batch C2PA content credential signing task for objects in a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates a batch C2PA content credential signing task for files under a specified source prefix in an OSS bucket. It supports JPEG, JPG, PNG, MP4, FLAC, M4A, MP3, and WAV formats, and allows mixed processing under the same prefix.</description></item>
        /// <item><description><c>SourcePrefix</c> must be <c>ai-deepsign/</c> or its subdirectory, and must not overlap with the output prefix <c>ai-deepsign-signed/</c>.</description></item>
        /// <item><description>By default, a single task processes up to 20,000 non-directory objects. The size of a single file must not exceed 800 MiB.</description></item>
        /// <item><description>The RAM identity of the caller must have permissions to call this operation. The service-linked role <c>AliyunServiceRoleForAIDeepSign</c> must have access permissions to the specified bucket and associated paths.</description></item>
        /// <item><description>File name extensions are case-insensitive. Files in unsupported formats are recorded as failed, but this does not abort the processing of other files.</description></item>
        /// <item><description>The signing results are written to the <c>ai-deepsign-signed/&lt;TaskId&gt;/</c> directory in the same bucket. The subdirectories relative to <c>SourcePrefix</c> and the source file name extensions are preserved, and <c>_signed</c> is added before the file name extension. The processing report is <c>c2pa_report.json</c> in the task directory.</description></item>
        /// <item><description>For example, if <c>SourcePrefix=ai-deepsign/images/</c>, the signing result for the source file <c>ai-deepsign/images/audio/demo.m4a</c> is <c>ai-deepsign-signed/&lt;TaskId&gt;/audio/demo_signed.m4a</c>.</description></item>
        /// <item><description>A successful creation only indicates that the task has been accepted. Call <c>GetC2paSignResult</c> to query the results. A <c>SUCCEEDED</c> status for a batch task does not mean that every file was signed successfully. Check the final statistics and processing report for file-by-file results.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateC2paBucketSignTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateC2paBucketSignTaskResponse
        /// </returns>
        public CreateC2paBucketSignTaskResponse CreateC2paBucketSignTaskWithOptions(CreateC2paBucketSignTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketRegionId))
            {
                query["BucketRegionId"] = request.BucketRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SoftwareAgent))
            {
                query["SoftwareAgent"] = request.SoftwareAgent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePrefix))
            {
                query["SourcePrefix"] = request.SourcePrefix;
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
                Action = "CreateC2paBucketSignTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateC2paBucketSignTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a batch C2PA content credential signing task for objects in a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates a batch C2PA content credential signing task for files under a specified source prefix in an OSS bucket. It supports JPEG, JPG, PNG, MP4, FLAC, M4A, MP3, and WAV formats, and allows mixed processing under the same prefix.</description></item>
        /// <item><description><c>SourcePrefix</c> must be <c>ai-deepsign/</c> or its subdirectory, and must not overlap with the output prefix <c>ai-deepsign-signed/</c>.</description></item>
        /// <item><description>By default, a single task processes up to 20,000 non-directory objects. The size of a single file must not exceed 800 MiB.</description></item>
        /// <item><description>The RAM identity of the caller must have permissions to call this operation. The service-linked role <c>AliyunServiceRoleForAIDeepSign</c> must have access permissions to the specified bucket and associated paths.</description></item>
        /// <item><description>File name extensions are case-insensitive. Files in unsupported formats are recorded as failed, but this does not abort the processing of other files.</description></item>
        /// <item><description>The signing results are written to the <c>ai-deepsign-signed/&lt;TaskId&gt;/</c> directory in the same bucket. The subdirectories relative to <c>SourcePrefix</c> and the source file name extensions are preserved, and <c>_signed</c> is added before the file name extension. The processing report is <c>c2pa_report.json</c> in the task directory.</description></item>
        /// <item><description>For example, if <c>SourcePrefix=ai-deepsign/images/</c>, the signing result for the source file <c>ai-deepsign/images/audio/demo.m4a</c> is <c>ai-deepsign-signed/&lt;TaskId&gt;/audio/demo_signed.m4a</c>.</description></item>
        /// <item><description>A successful creation only indicates that the task has been accepted. Call <c>GetC2paSignResult</c> to query the results. A <c>SUCCEEDED</c> status for a batch task does not mean that every file was signed successfully. Check the final statistics and processing report for file-by-file results.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateC2paBucketSignTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateC2paBucketSignTaskResponse
        /// </returns>
        public async Task<CreateC2paBucketSignTaskResponse> CreateC2paBucketSignTaskWithOptionsAsync(CreateC2paBucketSignTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketRegionId))
            {
                query["BucketRegionId"] = request.BucketRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SoftwareAgent))
            {
                query["SoftwareAgent"] = request.SoftwareAgent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePrefix))
            {
                query["SourcePrefix"] = request.SourcePrefix;
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
                Action = "CreateC2paBucketSignTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateC2paBucketSignTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a batch C2PA content credential signing task for objects in a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates a batch C2PA content credential signing task for files under a specified source prefix in an OSS bucket. It supports JPEG, JPG, PNG, MP4, FLAC, M4A, MP3, and WAV formats, and allows mixed processing under the same prefix.</description></item>
        /// <item><description><c>SourcePrefix</c> must be <c>ai-deepsign/</c> or its subdirectory, and must not overlap with the output prefix <c>ai-deepsign-signed/</c>.</description></item>
        /// <item><description>By default, a single task processes up to 20,000 non-directory objects. The size of a single file must not exceed 800 MiB.</description></item>
        /// <item><description>The RAM identity of the caller must have permissions to call this operation. The service-linked role <c>AliyunServiceRoleForAIDeepSign</c> must have access permissions to the specified bucket and associated paths.</description></item>
        /// <item><description>File name extensions are case-insensitive. Files in unsupported formats are recorded as failed, but this does not abort the processing of other files.</description></item>
        /// <item><description>The signing results are written to the <c>ai-deepsign-signed/&lt;TaskId&gt;/</c> directory in the same bucket. The subdirectories relative to <c>SourcePrefix</c> and the source file name extensions are preserved, and <c>_signed</c> is added before the file name extension. The processing report is <c>c2pa_report.json</c> in the task directory.</description></item>
        /// <item><description>For example, if <c>SourcePrefix=ai-deepsign/images/</c>, the signing result for the source file <c>ai-deepsign/images/audio/demo.m4a</c> is <c>ai-deepsign-signed/&lt;TaskId&gt;/audio/demo_signed.m4a</c>.</description></item>
        /// <item><description>A successful creation only indicates that the task has been accepted. Call <c>GetC2paSignResult</c> to query the results. A <c>SUCCEEDED</c> status for a batch task does not mean that every file was signed successfully. Check the final statistics and processing report for file-by-file results.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateC2paBucketSignTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateC2paBucketSignTaskResponse
        /// </returns>
        public CreateC2paBucketSignTaskResponse CreateC2paBucketSignTask(CreateC2paBucketSignTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateC2paBucketSignTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a batch C2PA content credential signing task for objects in a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates a batch C2PA content credential signing task for files under a specified source prefix in an OSS bucket. It supports JPEG, JPG, PNG, MP4, FLAC, M4A, MP3, and WAV formats, and allows mixed processing under the same prefix.</description></item>
        /// <item><description><c>SourcePrefix</c> must be <c>ai-deepsign/</c> or its subdirectory, and must not overlap with the output prefix <c>ai-deepsign-signed/</c>.</description></item>
        /// <item><description>By default, a single task processes up to 20,000 non-directory objects. The size of a single file must not exceed 800 MiB.</description></item>
        /// <item><description>The RAM identity of the caller must have permissions to call this operation. The service-linked role <c>AliyunServiceRoleForAIDeepSign</c> must have access permissions to the specified bucket and associated paths.</description></item>
        /// <item><description>File name extensions are case-insensitive. Files in unsupported formats are recorded as failed, but this does not abort the processing of other files.</description></item>
        /// <item><description>The signing results are written to the <c>ai-deepsign-signed/&lt;TaskId&gt;/</c> directory in the same bucket. The subdirectories relative to <c>SourcePrefix</c> and the source file name extensions are preserved, and <c>_signed</c> is added before the file name extension. The processing report is <c>c2pa_report.json</c> in the task directory.</description></item>
        /// <item><description>For example, if <c>SourcePrefix=ai-deepsign/images/</c>, the signing result for the source file <c>ai-deepsign/images/audio/demo.m4a</c> is <c>ai-deepsign-signed/&lt;TaskId&gt;/audio/demo_signed.m4a</c>.</description></item>
        /// <item><description>A successful creation only indicates that the task has been accepted. Call <c>GetC2paSignResult</c> to query the results. A <c>SUCCEEDED</c> status for a batch task does not mean that every file was signed successfully. Check the final statistics and processing report for file-by-file results.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateC2paBucketSignTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateC2paBucketSignTaskResponse
        /// </returns>
        public async Task<CreateC2paBucketSignTaskResponse> CreateC2paBucketSignTaskAsync(CreateC2paBucketSignTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateC2paBucketSignTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a C2PA content credential signing task for a specified file and returns the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation adds standard C2PA content credentials to a single JPEG/JPG, PNG, MP4, FLAC, M4A, MP3, or WAV file.</description></item>
        /// <item><description><c>FileUrl</c> must be an absolute HTTP or HTTPS URL accessible by the service and cannot contain a username or password.</description></item>
        /// <item><description>File name extensions are case-insensitive, and URL query parameters are not used for file name identification. For example, the file name for <c>https://example.com/media/demo.m4a?token=xxx</c> is <c>demo.m4a</c>.</description></item>
        /// <item><description>The source URL must directly return an HTTP 200 status code. Redirect URLs are not supported.</description></item>
        /// <item><description>The size of a single file cannot exceed 800 MiB. Provide a valid file in a supported format. Changing only the file name extension does not transform the file format.</description></item>
        /// <item><description>The signing result retains the source file name extension and adds <c>_signed</c> before the extension. For example, <c>demo.m4a</c> becomes <c>demo_signed.m4a</c>.</description></item>
        /// <item><description>Unsupported file name extensions return <c>InvalidParam</c>, and the error message is <c>FileUrl only supports files with .jpg, .jpeg, .png, .mp4, .flac, .m4a, .mp3, or .wav extensions</c>.</description></item>
        /// <item><description>A successful creation only indicates that the task has been accepted. Save the returned <c>TaskId</c> and invoke <c>GetC2paSignResult</c> to query the task status and final result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateC2paSignTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateC2paSignTaskResponse
        /// </returns>
        public CreateC2paSignTaskResponse CreateC2paSignTaskWithOptions(CreateC2paSignTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SoftwareAgent))
            {
                query["SoftwareAgent"] = request.SoftwareAgent;
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
                Action = "CreateC2paSignTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateC2paSignTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a C2PA content credential signing task for a specified file and returns the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation adds standard C2PA content credentials to a single JPEG/JPG, PNG, MP4, FLAC, M4A, MP3, or WAV file.</description></item>
        /// <item><description><c>FileUrl</c> must be an absolute HTTP or HTTPS URL accessible by the service and cannot contain a username or password.</description></item>
        /// <item><description>File name extensions are case-insensitive, and URL query parameters are not used for file name identification. For example, the file name for <c>https://example.com/media/demo.m4a?token=xxx</c> is <c>demo.m4a</c>.</description></item>
        /// <item><description>The source URL must directly return an HTTP 200 status code. Redirect URLs are not supported.</description></item>
        /// <item><description>The size of a single file cannot exceed 800 MiB. Provide a valid file in a supported format. Changing only the file name extension does not transform the file format.</description></item>
        /// <item><description>The signing result retains the source file name extension and adds <c>_signed</c> before the extension. For example, <c>demo.m4a</c> becomes <c>demo_signed.m4a</c>.</description></item>
        /// <item><description>Unsupported file name extensions return <c>InvalidParam</c>, and the error message is <c>FileUrl only supports files with .jpg, .jpeg, .png, .mp4, .flac, .m4a, .mp3, or .wav extensions</c>.</description></item>
        /// <item><description>A successful creation only indicates that the task has been accepted. Save the returned <c>TaskId</c> and invoke <c>GetC2paSignResult</c> to query the task status and final result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateC2paSignTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateC2paSignTaskResponse
        /// </returns>
        public async Task<CreateC2paSignTaskResponse> CreateC2paSignTaskWithOptionsAsync(CreateC2paSignTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SoftwareAgent))
            {
                query["SoftwareAgent"] = request.SoftwareAgent;
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
                Action = "CreateC2paSignTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateC2paSignTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a C2PA content credential signing task for a specified file and returns the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation adds standard C2PA content credentials to a single JPEG/JPG, PNG, MP4, FLAC, M4A, MP3, or WAV file.</description></item>
        /// <item><description><c>FileUrl</c> must be an absolute HTTP or HTTPS URL accessible by the service and cannot contain a username or password.</description></item>
        /// <item><description>File name extensions are case-insensitive, and URL query parameters are not used for file name identification. For example, the file name for <c>https://example.com/media/demo.m4a?token=xxx</c> is <c>demo.m4a</c>.</description></item>
        /// <item><description>The source URL must directly return an HTTP 200 status code. Redirect URLs are not supported.</description></item>
        /// <item><description>The size of a single file cannot exceed 800 MiB. Provide a valid file in a supported format. Changing only the file name extension does not transform the file format.</description></item>
        /// <item><description>The signing result retains the source file name extension and adds <c>_signed</c> before the extension. For example, <c>demo.m4a</c> becomes <c>demo_signed.m4a</c>.</description></item>
        /// <item><description>Unsupported file name extensions return <c>InvalidParam</c>, and the error message is <c>FileUrl only supports files with .jpg, .jpeg, .png, .mp4, .flac, .m4a, .mp3, or .wav extensions</c>.</description></item>
        /// <item><description>A successful creation only indicates that the task has been accepted. Save the returned <c>TaskId</c> and invoke <c>GetC2paSignResult</c> to query the task status and final result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateC2paSignTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateC2paSignTaskResponse
        /// </returns>
        public CreateC2paSignTaskResponse CreateC2paSignTask(CreateC2paSignTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateC2paSignTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a C2PA content credential signing task for a specified file and returns the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation adds standard C2PA content credentials to a single JPEG/JPG, PNG, MP4, FLAC, M4A, MP3, or WAV file.</description></item>
        /// <item><description><c>FileUrl</c> must be an absolute HTTP or HTTPS URL accessible by the service and cannot contain a username or password.</description></item>
        /// <item><description>File name extensions are case-insensitive, and URL query parameters are not used for file name identification. For example, the file name for <c>https://example.com/media/demo.m4a?token=xxx</c> is <c>demo.m4a</c>.</description></item>
        /// <item><description>The source URL must directly return an HTTP 200 status code. Redirect URLs are not supported.</description></item>
        /// <item><description>The size of a single file cannot exceed 800 MiB. Provide a valid file in a supported format. Changing only the file name extension does not transform the file format.</description></item>
        /// <item><description>The signing result retains the source file name extension and adds <c>_signed</c> before the extension. For example, <c>demo.m4a</c> becomes <c>demo_signed.m4a</c>.</description></item>
        /// <item><description>Unsupported file name extensions return <c>InvalidParam</c>, and the error message is <c>FileUrl only supports files with .jpg, .jpeg, .png, .mp4, .flac, .m4a, .mp3, or .wav extensions</c>.</description></item>
        /// <item><description>A successful creation only indicates that the task has been accepted. Save the returned <c>TaskId</c> and invoke <c>GetC2paSignResult</c> to query the task status and final result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateC2paSignTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateC2paSignTaskResponse
        /// </returns>
        public async Task<CreateC2paSignTaskResponse> CreateC2paSignTaskAsync(CreateC2paSignTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateC2paSignTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image for defect detection and returns a task ID for querying results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation commits an image to the server for defect detection, including but not limited to blurriness, distortion, glare, and other anomalies in the image subject.</description></item>
        /// <item><description><b>ImageUrl is required</b> and must be a publicly accessible HTTP/HTTPS URL. Currently, only image URLs accessible from the Chinese mainland public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL of the image as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single object or the URLs of multiple objects</a></description></item>
        /// <item><description>After successful commit, a node ID is returned immediately. Regardless of whether the node has been completed or is still being processed, call the GetImageDefectDetectionTaskResult operation to perform polling for the final detection result.</description></item>
        /// <item><description>If a parameter fault or other issue occurs during the commit procedure, the corresponding error message is returned directly without creating a node record.</description></item>
        /// <item><description>The image file size cannot exceed 10 MB. Detection is failed for images that exceed this limit.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageDefectDetectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageDefectDetectionTaskResponse
        /// </returns>
        public CreateImageDefectDetectionTaskResponse CreateImageDefectDetectionTaskWithOptions(CreateImageDefectDetectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageDefectDetectionTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageDefectDetectionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image for defect detection and returns a task ID for querying results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation commits an image to the server for defect detection, including but not limited to blurriness, distortion, glare, and other anomalies in the image subject.</description></item>
        /// <item><description><b>ImageUrl is required</b> and must be a publicly accessible HTTP/HTTPS URL. Currently, only image URLs accessible from the Chinese mainland public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL of the image as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single object or the URLs of multiple objects</a></description></item>
        /// <item><description>After successful commit, a node ID is returned immediately. Regardless of whether the node has been completed or is still being processed, call the GetImageDefectDetectionTaskResult operation to perform polling for the final detection result.</description></item>
        /// <item><description>If a parameter fault or other issue occurs during the commit procedure, the corresponding error message is returned directly without creating a node record.</description></item>
        /// <item><description>The image file size cannot exceed 10 MB. Detection is failed for images that exceed this limit.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageDefectDetectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageDefectDetectionTaskResponse
        /// </returns>
        public async Task<CreateImageDefectDetectionTaskResponse> CreateImageDefectDetectionTaskWithOptionsAsync(CreateImageDefectDetectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageDefectDetectionTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageDefectDetectionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image for defect detection and returns a task ID for querying results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation commits an image to the server for defect detection, including but not limited to blurriness, distortion, glare, and other anomalies in the image subject.</description></item>
        /// <item><description><b>ImageUrl is required</b> and must be a publicly accessible HTTP/HTTPS URL. Currently, only image URLs accessible from the Chinese mainland public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL of the image as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single object or the URLs of multiple objects</a></description></item>
        /// <item><description>After successful commit, a node ID is returned immediately. Regardless of whether the node has been completed or is still being processed, call the GetImageDefectDetectionTaskResult operation to perform polling for the final detection result.</description></item>
        /// <item><description>If a parameter fault or other issue occurs during the commit procedure, the corresponding error message is returned directly without creating a node record.</description></item>
        /// <item><description>The image file size cannot exceed 10 MB. Detection is failed for images that exceed this limit.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageDefectDetectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageDefectDetectionTaskResponse
        /// </returns>
        public CreateImageDefectDetectionTaskResponse CreateImageDefectDetectionTask(CreateImageDefectDetectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageDefectDetectionTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image for defect detection and returns a task ID for querying results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation commits an image to the server for defect detection, including but not limited to blurriness, distortion, glare, and other anomalies in the image subject.</description></item>
        /// <item><description><b>ImageUrl is required</b> and must be a publicly accessible HTTP/HTTPS URL. Currently, only image URLs accessible from the Chinese mainland public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL of the image as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single object or the URLs of multiple objects</a></description></item>
        /// <item><description>After successful commit, a node ID is returned immediately. Regardless of whether the node has been completed or is still being processed, call the GetImageDefectDetectionTaskResult operation to perform polling for the final detection result.</description></item>
        /// <item><description>If a parameter fault or other issue occurs during the commit procedure, the corresponding error message is returned directly without creating a node record.</description></item>
        /// <item><description>The image file size cannot exceed 10 MB. Detection is failed for images that exceed this limit.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageDefectDetectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageDefectDetectionTaskResponse
        /// </returns>
        public async Task<CreateImageDefectDetectionTaskResponse> CreateImageDefectDetectionTaskAsync(CreateImageDefectDetectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageDefectDetectionTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an asynchronous image tampering detection task and returns the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>ImageUrl</b> is required and must be a publicly accessible HTTP/HTTPS URL.</description></item>
        /// <item><description>External images are not currently supported. Only image URLs accessible from the Chinese mainland public network are supported. Upload images to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single object or the URLs of multiple objects</a>.</description></item>
        /// <item><description>The <b>DetectType</b> parameter is deprecated. This parameter is still accepted (<c>tamper</c>/<c>aigc</c>) but does not affect the actual detection pattern. Regardless of the value passed, tampering detection is executed and <c>DetectMode=tamper</c> is returned. New callers should not pass this parameter.</description></item>
        /// <item><description>The <b>UseTamperSmallModel</b> parameter specifies whether to use the small model. If set to <c>true</c>, the small model is used and no large model report is generated. If set to <c>false</c> or not passed, the large model is used by default and a comprehensive large model analysis report is returned.</description></item>
        /// </list>
        /// <h2>Settings</h2>
        /// <list type="bullet">
        /// <item><description>When <b>UseTamperSmallModel</b> is not specified, the large model is used by default.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageDetectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageDetectionTaskResponse
        /// </returns>
        public CreateImageDetectionTaskResponse CreateImageDetectionTaskWithOptions(CreateImageDetectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectType))
            {
                query["DetectType"] = request.DetectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseTamperSmallModel))
            {
                query["UseTamperSmallModel"] = request.UseTamperSmallModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageDetectionTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageDetectionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an asynchronous image tampering detection task and returns the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>ImageUrl</b> is required and must be a publicly accessible HTTP/HTTPS URL.</description></item>
        /// <item><description>External images are not currently supported. Only image URLs accessible from the Chinese mainland public network are supported. Upload images to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single object or the URLs of multiple objects</a>.</description></item>
        /// <item><description>The <b>DetectType</b> parameter is deprecated. This parameter is still accepted (<c>tamper</c>/<c>aigc</c>) but does not affect the actual detection pattern. Regardless of the value passed, tampering detection is executed and <c>DetectMode=tamper</c> is returned. New callers should not pass this parameter.</description></item>
        /// <item><description>The <b>UseTamperSmallModel</b> parameter specifies whether to use the small model. If set to <c>true</c>, the small model is used and no large model report is generated. If set to <c>false</c> or not passed, the large model is used by default and a comprehensive large model analysis report is returned.</description></item>
        /// </list>
        /// <h2>Settings</h2>
        /// <list type="bullet">
        /// <item><description>When <b>UseTamperSmallModel</b> is not specified, the large model is used by default.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageDetectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageDetectionTaskResponse
        /// </returns>
        public async Task<CreateImageDetectionTaskResponse> CreateImageDetectionTaskWithOptionsAsync(CreateImageDetectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectType))
            {
                query["DetectType"] = request.DetectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseTamperSmallModel))
            {
                query["UseTamperSmallModel"] = request.UseTamperSmallModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageDetectionTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageDetectionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an asynchronous image tampering detection task and returns the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>ImageUrl</b> is required and must be a publicly accessible HTTP/HTTPS URL.</description></item>
        /// <item><description>External images are not currently supported. Only image URLs accessible from the Chinese mainland public network are supported. Upload images to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single object or the URLs of multiple objects</a>.</description></item>
        /// <item><description>The <b>DetectType</b> parameter is deprecated. This parameter is still accepted (<c>tamper</c>/<c>aigc</c>) but does not affect the actual detection pattern. Regardless of the value passed, tampering detection is executed and <c>DetectMode=tamper</c> is returned. New callers should not pass this parameter.</description></item>
        /// <item><description>The <b>UseTamperSmallModel</b> parameter specifies whether to use the small model. If set to <c>true</c>, the small model is used and no large model report is generated. If set to <c>false</c> or not passed, the large model is used by default and a comprehensive large model analysis report is returned.</description></item>
        /// </list>
        /// <h2>Settings</h2>
        /// <list type="bullet">
        /// <item><description>When <b>UseTamperSmallModel</b> is not specified, the large model is used by default.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageDetectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageDetectionTaskResponse
        /// </returns>
        public CreateImageDetectionTaskResponse CreateImageDetectionTask(CreateImageDetectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageDetectionTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an asynchronous image tampering detection task and returns the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>ImageUrl</b> is required and must be a publicly accessible HTTP/HTTPS URL.</description></item>
        /// <item><description>External images are not currently supported. Only image URLs accessible from the Chinese mainland public network are supported. Upload images to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single object or the URLs of multiple objects</a>.</description></item>
        /// <item><description>The <b>DetectType</b> parameter is deprecated. This parameter is still accepted (<c>tamper</c>/<c>aigc</c>) but does not affect the actual detection pattern. Regardless of the value passed, tampering detection is executed and <c>DetectMode=tamper</c> is returned. New callers should not pass this parameter.</description></item>
        /// <item><description>The <b>UseTamperSmallModel</b> parameter specifies whether to use the small model. If set to <c>true</c>, the small model is used and no large model report is generated. If set to <c>false</c> or not passed, the large model is used by default and a comprehensive large model analysis report is returned.</description></item>
        /// </list>
        /// <h2>Settings</h2>
        /// <list type="bullet">
        /// <item><description>When <b>UseTamperSmallModel</b> is not specified, the large model is used by default.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageDetectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageDetectionTaskResponse
        /// </returns>
        public async Task<CreateImageDetectionTaskResponse> CreateImageDetectionTaskAsync(CreateImageDetectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageDetectionTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a personal income tax record screenshot for forgery detection and returns a task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>ImageUrl</b> is required and must be a publicly accessible HTTP/HTTPS URL (the server needs to download the image).</description></item>
        /// <item><description>External images are not supported. Only image URLs accessible from the Chinese mainland public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL of the image as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more files?</a></description></item>
        /// <item><description>The image file size cannot exceed 10 MB. Detection of images that exceed this limit will be failed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageIncomeTaxDetectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageIncomeTaxDetectionTaskResponse
        /// </returns>
        public CreateImageIncomeTaxDetectionTaskResponse CreateImageIncomeTaxDetectionTaskWithOptions(CreateImageIncomeTaxDetectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageIncomeTaxDetectionTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageIncomeTaxDetectionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a personal income tax record screenshot for forgery detection and returns a task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>ImageUrl</b> is required and must be a publicly accessible HTTP/HTTPS URL (the server needs to download the image).</description></item>
        /// <item><description>External images are not supported. Only image URLs accessible from the Chinese mainland public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL of the image as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more files?</a></description></item>
        /// <item><description>The image file size cannot exceed 10 MB. Detection of images that exceed this limit will be failed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageIncomeTaxDetectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageIncomeTaxDetectionTaskResponse
        /// </returns>
        public async Task<CreateImageIncomeTaxDetectionTaskResponse> CreateImageIncomeTaxDetectionTaskWithOptionsAsync(CreateImageIncomeTaxDetectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageIncomeTaxDetectionTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageIncomeTaxDetectionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a personal income tax record screenshot for forgery detection and returns a task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>ImageUrl</b> is required and must be a publicly accessible HTTP/HTTPS URL (the server needs to download the image).</description></item>
        /// <item><description>External images are not supported. Only image URLs accessible from the Chinese mainland public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL of the image as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more files?</a></description></item>
        /// <item><description>The image file size cannot exceed 10 MB. Detection of images that exceed this limit will be failed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageIncomeTaxDetectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageIncomeTaxDetectionTaskResponse
        /// </returns>
        public CreateImageIncomeTaxDetectionTaskResponse CreateImageIncomeTaxDetectionTask(CreateImageIncomeTaxDetectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageIncomeTaxDetectionTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a personal income tax record screenshot for forgery detection and returns a task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>ImageUrl</b> is required and must be a publicly accessible HTTP/HTTPS URL (the server needs to download the image).</description></item>
        /// <item><description>External images are not supported. Only image URLs accessible from the Chinese mainland public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL of the image as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more files?</a></description></item>
        /// <item><description>The image file size cannot exceed 10 MB. Detection of images that exceed this limit will be failed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageIncomeTaxDetectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageIncomeTaxDetectionTaskResponse
        /// </returns>
        public async Task<CreateImageIncomeTaxDetectionTaskResponse> CreateImageIncomeTaxDetectionTaskAsync(CreateImageIncomeTaxDetectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageIncomeTaxDetectionTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates images based on a provided text description and returns a task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an AI image generation task. The system generates images based on the positive prompt provided by the user.</description></item>
        /// <item><description>You can configure parameters such as negative prompt, model, and image size to optimize the generation results.</description></item>
        /// <item><description>By default, generated images are automatically embedded with a C2PA digital signature. You can optionally add a watermark in the lower-right corner.</description></item>
        /// <item><description>Set the ClientToken parameter to ensure the idempotence of the request and guarantee uniqueness across different requests.</description></item>
        /// <item><description>After the task is created, call the GetImageTaskResult operation with the TaskId to query the generation results.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageTaskResponse
        /// </returns>
        public CreateImageTaskResponse CreateImageTaskWithOptions(CreateImageTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.N))
            {
                query["N"] = request.N;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NegativePrompt))
            {
                query["NegativePrompt"] = request.NegativePrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptExtend))
            {
                query["PromptExtend"] = request.PromptExtend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Seed))
            {
                query["Seed"] = request.Seed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates images based on a provided text description and returns a task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an AI image generation task. The system generates images based on the positive prompt provided by the user.</description></item>
        /// <item><description>You can configure parameters such as negative prompt, model, and image size to optimize the generation results.</description></item>
        /// <item><description>By default, generated images are automatically embedded with a C2PA digital signature. You can optionally add a watermark in the lower-right corner.</description></item>
        /// <item><description>Set the ClientToken parameter to ensure the idempotence of the request and guarantee uniqueness across different requests.</description></item>
        /// <item><description>After the task is created, call the GetImageTaskResult operation with the TaskId to query the generation results.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageTaskResponse
        /// </returns>
        public async Task<CreateImageTaskResponse> CreateImageTaskWithOptionsAsync(CreateImageTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.N))
            {
                query["N"] = request.N;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NegativePrompt))
            {
                query["NegativePrompt"] = request.NegativePrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptExtend))
            {
                query["PromptExtend"] = request.PromptExtend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Seed))
            {
                query["Seed"] = request.Seed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates images based on a provided text description and returns a task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an AI image generation task. The system generates images based on the positive prompt provided by the user.</description></item>
        /// <item><description>You can configure parameters such as negative prompt, model, and image size to optimize the generation results.</description></item>
        /// <item><description>By default, generated images are automatically embedded with a C2PA digital signature. You can optionally add a watermark in the lower-right corner.</description></item>
        /// <item><description>Set the ClientToken parameter to ensure the idempotence of the request and guarantee uniqueness across different requests.</description></item>
        /// <item><description>After the task is created, call the GetImageTaskResult operation with the TaskId to query the generation results.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageTaskResponse
        /// </returns>
        public CreateImageTaskResponse CreateImageTask(CreateImageTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates images based on a provided text description and returns a task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an AI image generation task. The system generates images based on the positive prompt provided by the user.</description></item>
        /// <item><description>You can configure parameters such as negative prompt, model, and image size to optimize the generation results.</description></item>
        /// <item><description>By default, generated images are automatically embedded with a C2PA digital signature. You can optionally add a watermark in the lower-right corner.</description></item>
        /// <item><description>Set the ClientToken parameter to ensure the idempotence of the request and guarantee uniqueness across different requests.</description></item>
        /// <item><description>After the task is created, call the GetImageTaskResult operation with the TaskId to query the generation results.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageTaskResponse
        /// </returns>
        public async Task<CreateImageTaskResponse> CreateImageTaskAsync(CreateImageTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image sensitive information scan task and returns the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>ImageUrl</b> is required and must be a publicly accessible HTTP/HTTPS URL.</description></item>
        /// <item><description>External images are not supported. Only image URLs accessible from the Chinese mainland public network are supported. Upload images to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the pre-signed URL of the image as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single file or the URLs of multiple files</a>.</description></item>
        /// <item><description>The size of the image uploaded by using ImageUrl cannot exceed 10 MB.</description></item>
        /// <item><description>The optional parameter <b>ClientToken</b> ensures the idempotence of the request. The client generates this parameter value, which must be unique across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSensitiveScanTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSensitiveScanTaskResponse
        /// </returns>
        public CreateSensitiveScanTaskResponse CreateSensitiveScanTaskWithOptions(CreateSensitiveScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSensitiveScanTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSensitiveScanTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image sensitive information scan task and returns the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>ImageUrl</b> is required and must be a publicly accessible HTTP/HTTPS URL.</description></item>
        /// <item><description>External images are not supported. Only image URLs accessible from the Chinese mainland public network are supported. Upload images to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the pre-signed URL of the image as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single file or the URLs of multiple files</a>.</description></item>
        /// <item><description>The size of the image uploaded by using ImageUrl cannot exceed 10 MB.</description></item>
        /// <item><description>The optional parameter <b>ClientToken</b> ensures the idempotence of the request. The client generates this parameter value, which must be unique across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSensitiveScanTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSensitiveScanTaskResponse
        /// </returns>
        public async Task<CreateSensitiveScanTaskResponse> CreateSensitiveScanTaskWithOptionsAsync(CreateSensitiveScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSensitiveScanTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSensitiveScanTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image sensitive information scan task and returns the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>ImageUrl</b> is required and must be a publicly accessible HTTP/HTTPS URL.</description></item>
        /// <item><description>External images are not supported. Only image URLs accessible from the Chinese mainland public network are supported. Upload images to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the pre-signed URL of the image as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single file or the URLs of multiple files</a>.</description></item>
        /// <item><description>The size of the image uploaded by using ImageUrl cannot exceed 10 MB.</description></item>
        /// <item><description>The optional parameter <b>ClientToken</b> ensures the idempotence of the request. The client generates this parameter value, which must be unique across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSensitiveScanTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSensitiveScanTaskResponse
        /// </returns>
        public CreateSensitiveScanTaskResponse CreateSensitiveScanTask(CreateSensitiveScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSensitiveScanTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image sensitive information scan task and returns the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>ImageUrl</b> is required and must be a publicly accessible HTTP/HTTPS URL.</description></item>
        /// <item><description>External images are not supported. Only image URLs accessible from the Chinese mainland public network are supported. Upload images to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the pre-signed URL of the image as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single file or the URLs of multiple files</a>.</description></item>
        /// <item><description>The size of the image uploaded by using ImageUrl cannot exceed 10 MB.</description></item>
        /// <item><description>The optional parameter <b>ClientToken</b> ensures the idempotence of the request. The client generates this parameter value, which must be unique across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSensitiveScanTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSensitiveScanTaskResponse
        /// </returns>
        public async Task<CreateSensitiveScanTaskResponse> CreateSensitiveScanTaskAsync(CreateSensitiveScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSensitiveScanTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a video generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an AI video generation task. The system generates a video based on the positive prompt provided by the user.</description></item>
        /// <item><description>By default, the generated video is automatically embedded with a C2PA digital signature.</description></item>
        /// <item><description>After creating the task, use the <c>TaskId</c> to call the <c>GetVideoTaskResult</c> operation to query the generation result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVideoTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoTaskResponse
        /// </returns>
        public CreateVideoTaskResponse CreateVideoTaskWithOptions(CreateVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Audio))
            {
                query["Audio"] = request.Audio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptExtend))
            {
                query["PromptExtend"] = request.PromptExtend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ratio))
            {
                query["Ratio"] = request.Ratio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Seed))
            {
                query["Seed"] = request.Seed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermark))
            {
                query["Watermark"] = request.Watermark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Media))
            {
                query["Media"] = request.Media;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a video generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an AI video generation task. The system generates a video based on the positive prompt provided by the user.</description></item>
        /// <item><description>By default, the generated video is automatically embedded with a C2PA digital signature.</description></item>
        /// <item><description>After creating the task, use the <c>TaskId</c> to call the <c>GetVideoTaskResult</c> operation to query the generation result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVideoTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoTaskResponse
        /// </returns>
        public async Task<CreateVideoTaskResponse> CreateVideoTaskWithOptionsAsync(CreateVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Audio))
            {
                query["Audio"] = request.Audio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptExtend))
            {
                query["PromptExtend"] = request.PromptExtend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ratio))
            {
                query["Ratio"] = request.Ratio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Seed))
            {
                query["Seed"] = request.Seed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermark))
            {
                query["Watermark"] = request.Watermark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Media))
            {
                query["Media"] = request.Media;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a video generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an AI video generation task. The system generates a video based on the positive prompt provided by the user.</description></item>
        /// <item><description>By default, the generated video is automatically embedded with a C2PA digital signature.</description></item>
        /// <item><description>After creating the task, use the <c>TaskId</c> to call the <c>GetVideoTaskResult</c> operation to query the generation result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVideoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoTaskResponse
        /// </returns>
        public CreateVideoTaskResponse CreateVideoTask(CreateVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVideoTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a video generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an AI video generation task. The system generates a video based on the positive prompt provided by the user.</description></item>
        /// <item><description>By default, the generated video is automatically embedded with a C2PA digital signature.</description></item>
        /// <item><description>After creating the task, use the <c>TaskId</c> to call the <c>GetVideoTaskResult</c> operation to query the generation result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVideoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoTaskResponse
        /// </returns>
        public async Task<CreateVideoTaskResponse> CreateVideoTaskAsync(CreateVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVideoTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image or video file for invisible watermark embedding and returns a task ID for querying the result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>FileUrl</b> must be a publicly accessible HTTP/HTTPS URL. External files are not supported. Only file URLs accessible over the Chinese mainland public network are supported. Upload the file to an Alibaba Cloud Object Storage Service (OSS) bucket in a Chinese mainland region first, and then use the presigned URL of the file as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// <item><description><b>FileType</b> must match the actual file type. The same value must be specified during both embedding and fetch.</description></item>
        /// <item><description>Supported file specifications: Video files must be no longer than 10 minutes and no larger than 100 MB. Image files must be no larger than 100 MB.</description></item>
        /// <item><description>The task completion time is approximately equal to the file duration. For example, embedding a 10-second video takes about 10 seconds.</description></item>
        /// <item><description>If the submission fails, no task record is created and a synchronous error is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWatermarkEmbedTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWatermarkEmbedTaskResponse
        /// </returns>
        public CreateWatermarkEmbedTaskResponse CreateWatermarkEmbedTaskWithOptions(CreateWatermarkEmbedTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reserved))
            {
                query["Reserved"] = request.Reserved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkContent))
            {
                query["WatermarkContent"] = request.WatermarkContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWatermarkEmbedTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWatermarkEmbedTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image or video file for invisible watermark embedding and returns a task ID for querying the result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>FileUrl</b> must be a publicly accessible HTTP/HTTPS URL. External files are not supported. Only file URLs accessible over the Chinese mainland public network are supported. Upload the file to an Alibaba Cloud Object Storage Service (OSS) bucket in a Chinese mainland region first, and then use the presigned URL of the file as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// <item><description><b>FileType</b> must match the actual file type. The same value must be specified during both embedding and fetch.</description></item>
        /// <item><description>Supported file specifications: Video files must be no longer than 10 minutes and no larger than 100 MB. Image files must be no larger than 100 MB.</description></item>
        /// <item><description>The task completion time is approximately equal to the file duration. For example, embedding a 10-second video takes about 10 seconds.</description></item>
        /// <item><description>If the submission fails, no task record is created and a synchronous error is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWatermarkEmbedTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWatermarkEmbedTaskResponse
        /// </returns>
        public async Task<CreateWatermarkEmbedTaskResponse> CreateWatermarkEmbedTaskWithOptionsAsync(CreateWatermarkEmbedTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reserved))
            {
                query["Reserved"] = request.Reserved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkContent))
            {
                query["WatermarkContent"] = request.WatermarkContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWatermarkEmbedTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWatermarkEmbedTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image or video file for invisible watermark embedding and returns a task ID for querying the result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>FileUrl</b> must be a publicly accessible HTTP/HTTPS URL. External files are not supported. Only file URLs accessible over the Chinese mainland public network are supported. Upload the file to an Alibaba Cloud Object Storage Service (OSS) bucket in a Chinese mainland region first, and then use the presigned URL of the file as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// <item><description><b>FileType</b> must match the actual file type. The same value must be specified during both embedding and fetch.</description></item>
        /// <item><description>Supported file specifications: Video files must be no longer than 10 minutes and no larger than 100 MB. Image files must be no larger than 100 MB.</description></item>
        /// <item><description>The task completion time is approximately equal to the file duration. For example, embedding a 10-second video takes about 10 seconds.</description></item>
        /// <item><description>If the submission fails, no task record is created and a synchronous error is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWatermarkEmbedTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWatermarkEmbedTaskResponse
        /// </returns>
        public CreateWatermarkEmbedTaskResponse CreateWatermarkEmbedTask(CreateWatermarkEmbedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWatermarkEmbedTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image or video file for invisible watermark embedding and returns a task ID for querying the result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>FileUrl</b> must be a publicly accessible HTTP/HTTPS URL. External files are not supported. Only file URLs accessible over the Chinese mainland public network are supported. Upload the file to an Alibaba Cloud Object Storage Service (OSS) bucket in a Chinese mainland region first, and then use the presigned URL of the file as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// <item><description><b>FileType</b> must match the actual file type. The same value must be specified during both embedding and fetch.</description></item>
        /// <item><description>Supported file specifications: Video files must be no longer than 10 minutes and no larger than 100 MB. Image files must be no larger than 100 MB.</description></item>
        /// <item><description>The task completion time is approximately equal to the file duration. For example, embedding a 10-second video takes about 10 seconds.</description></item>
        /// <item><description>If the submission fails, no task record is created and a synchronous error is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWatermarkEmbedTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWatermarkEmbedTaskResponse
        /// </returns>
        public async Task<CreateWatermarkEmbedTaskResponse> CreateWatermarkEmbedTaskAsync(CreateWatermarkEmbedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWatermarkEmbedTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image or video file to extract a dark watermark and returns a task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>FileUrl</b> must be a publicly accessible HTTP/HTTPS URL. External files are not supported. Only file URLs accessible from the Chinese mainland public network are supported. Upload the file to an Alibaba Cloud OSS bucket in a region within the Chinese mainland first, and then use the presigned URL of the file as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// <item><description><b>FileType must be the same as the one used during embedding</b>: Make sure that the file type (image or video) for extraction is the same as the file type used when the watermark was embedded.</description></item>
        /// <item><description><b>File specification limits</b>: Video files must be no longer than 10 minutes and no larger than 100 MB. Image files must also be no larger than 100 MB.</description></item>
        /// <item><description><b>Processing time</b>: Approximately equal to the actual playback duration of the file. For example, a 10-second video takes approximately 10 seconds to complete the watermark fetch procedure.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWatermarkExtractTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWatermarkExtractTaskResponse
        /// </returns>
        public CreateWatermarkExtractTaskResponse CreateWatermarkExtractTaskWithOptions(CreateWatermarkExtractTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reserved))
            {
                query["Reserved"] = request.Reserved;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWatermarkExtractTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWatermarkExtractTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image or video file to extract a dark watermark and returns a task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>FileUrl</b> must be a publicly accessible HTTP/HTTPS URL. External files are not supported. Only file URLs accessible from the Chinese mainland public network are supported. Upload the file to an Alibaba Cloud OSS bucket in a region within the Chinese mainland first, and then use the presigned URL of the file as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// <item><description><b>FileType must be the same as the one used during embedding</b>: Make sure that the file type (image or video) for extraction is the same as the file type used when the watermark was embedded.</description></item>
        /// <item><description><b>File specification limits</b>: Video files must be no longer than 10 minutes and no larger than 100 MB. Image files must also be no larger than 100 MB.</description></item>
        /// <item><description><b>Processing time</b>: Approximately equal to the actual playback duration of the file. For example, a 10-second video takes approximately 10 seconds to complete the watermark fetch procedure.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWatermarkExtractTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWatermarkExtractTaskResponse
        /// </returns>
        public async Task<CreateWatermarkExtractTaskResponse> CreateWatermarkExtractTaskWithOptionsAsync(CreateWatermarkExtractTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reserved))
            {
                query["Reserved"] = request.Reserved;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWatermarkExtractTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWatermarkExtractTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image or video file to extract a dark watermark and returns a task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>FileUrl</b> must be a publicly accessible HTTP/HTTPS URL. External files are not supported. Only file URLs accessible from the Chinese mainland public network are supported. Upload the file to an Alibaba Cloud OSS bucket in a region within the Chinese mainland first, and then use the presigned URL of the file as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// <item><description><b>FileType must be the same as the one used during embedding</b>: Make sure that the file type (image or video) for extraction is the same as the file type used when the watermark was embedded.</description></item>
        /// <item><description><b>File specification limits</b>: Video files must be no longer than 10 minutes and no larger than 100 MB. Image files must also be no larger than 100 MB.</description></item>
        /// <item><description><b>Processing time</b>: Approximately equal to the actual playback duration of the file. For example, a 10-second video takes approximately 10 seconds to complete the watermark fetch procedure.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWatermarkExtractTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWatermarkExtractTaskResponse
        /// </returns>
        public CreateWatermarkExtractTaskResponse CreateWatermarkExtractTask(CreateWatermarkExtractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWatermarkExtractTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image or video file to extract a dark watermark and returns a task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>FileUrl</b> must be a publicly accessible HTTP/HTTPS URL. External files are not supported. Only file URLs accessible from the Chinese mainland public network are supported. Upload the file to an Alibaba Cloud OSS bucket in a region within the Chinese mainland first, and then use the presigned URL of the file as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// <item><description><b>FileType must be the same as the one used during embedding</b>: Make sure that the file type (image or video) for extraction is the same as the file type used when the watermark was embedded.</description></item>
        /// <item><description><b>File specification limits</b>: Video files must be no longer than 10 minutes and no larger than 100 MB. Image files must also be no larger than 100 MB.</description></item>
        /// <item><description><b>Processing time</b>: Approximately equal to the actual playback duration of the file. For example, a 10-second video takes approximately 10 seconds to complete the watermark fetch procedure.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWatermarkExtractTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWatermarkExtractTaskResponse
        /// </returns>
        public async Task<CreateWatermarkExtractTaskResponse> CreateWatermarkExtractTaskAsync(CreateWatermarkExtractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWatermarkExtractTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Determines whether an image is AI-generated and returns detection labels with confidence scores.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation detects whether a specified image is AI-generated content (AIGC). You can specify the image to detect by using an image URL or an OSS ObjectKey.</description></item>
        /// <item><description>You must provide at least one of ImageUrl and ObjectKey. If both are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When using the ObjectKey method, the system verifies whether the ObjectKey belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>This is a synchronous operation suitable for real-time detection of a single image. If you need asynchronous detection or credential detection at the same time, use the CreateImageDetectionTask operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetectAigcImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectAigcImageResponse
        /// </returns>
        public DetectAigcImageResponse DetectAigcImageWithOptions(DetectAigcImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectAigcImage",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectAigcImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Determines whether an image is AI-generated and returns detection labels with confidence scores.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation detects whether a specified image is AI-generated content (AIGC). You can specify the image to detect by using an image URL or an OSS ObjectKey.</description></item>
        /// <item><description>You must provide at least one of ImageUrl and ObjectKey. If both are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When using the ObjectKey method, the system verifies whether the ObjectKey belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>This is a synchronous operation suitable for real-time detection of a single image. If you need asynchronous detection or credential detection at the same time, use the CreateImageDetectionTask operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetectAigcImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectAigcImageResponse
        /// </returns>
        public async Task<DetectAigcImageResponse> DetectAigcImageWithOptionsAsync(DetectAigcImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectAigcImage",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectAigcImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Determines whether an image is AI-generated and returns detection labels with confidence scores.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation detects whether a specified image is AI-generated content (AIGC). You can specify the image to detect by using an image URL or an OSS ObjectKey.</description></item>
        /// <item><description>You must provide at least one of ImageUrl and ObjectKey. If both are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When using the ObjectKey method, the system verifies whether the ObjectKey belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>This is a synchronous operation suitable for real-time detection of a single image. If you need asynchronous detection or credential detection at the same time, use the CreateImageDetectionTask operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetectAigcImageRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectAigcImageResponse
        /// </returns>
        public DetectAigcImageResponse DetectAigcImage(DetectAigcImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectAigcImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Determines whether an image is AI-generated and returns detection labels with confidence scores.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation detects whether a specified image is AI-generated content (AIGC). You can specify the image to detect by using an image URL or an OSS ObjectKey.</description></item>
        /// <item><description>You must provide at least one of ImageUrl and ObjectKey. If both are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When using the ObjectKey method, the system verifies whether the ObjectKey belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>This is a synchronous operation suitable for real-time detection of a single image. If you need asynchronous detection or credential detection at the same time, use the CreateImageDetectionTask operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetectAigcImageRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectAigcImageResponse
        /// </returns>
        public async Task<DetectAigcImageResponse> DetectAigcImageAsync(DetectAigcImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectAigcImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves basic information about a specified image, such as the file name, format, size, and resolution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <list type="bullet">
        /// <item><description>This operation detects and returns basic information about an image, including but not limited to the file name, image format (such as JPEG/PNG), file size, and resolution.</description></item>
        /// <item><description><c>ImageUrl</c> is required and must be a publicly accessible HTTP/HTTPS URL. Currently, only image URLs accessible from the Chinese mainland public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL of the image as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetectImageBasicInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectImageBasicInfoResponse
        /// </returns>
        public DetectImageBasicInfoResponse DetectImageBasicInfoWithOptions(DetectImageBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageBasicInfo",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageBasicInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves basic information about a specified image, such as the file name, format, size, and resolution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <list type="bullet">
        /// <item><description>This operation detects and returns basic information about an image, including but not limited to the file name, image format (such as JPEG/PNG), file size, and resolution.</description></item>
        /// <item><description><c>ImageUrl</c> is required and must be a publicly accessible HTTP/HTTPS URL. Currently, only image URLs accessible from the Chinese mainland public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL of the image as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetectImageBasicInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectImageBasicInfoResponse
        /// </returns>
        public async Task<DetectImageBasicInfoResponse> DetectImageBasicInfoWithOptionsAsync(DetectImageBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageBasicInfo",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageBasicInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves basic information about a specified image, such as the file name, format, size, and resolution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <list type="bullet">
        /// <item><description>This operation detects and returns basic information about an image, including but not limited to the file name, image format (such as JPEG/PNG), file size, and resolution.</description></item>
        /// <item><description><c>ImageUrl</c> is required and must be a publicly accessible HTTP/HTTPS URL. Currently, only image URLs accessible from the Chinese mainland public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL of the image as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetectImageBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectImageBasicInfoResponse
        /// </returns>
        public DetectImageBasicInfoResponse DetectImageBasicInfo(DetectImageBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageBasicInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves basic information about a specified image, such as the file name, format, size, and resolution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <list type="bullet">
        /// <item><description>This operation detects and returns basic information about an image, including but not limited to the file name, image format (such as JPEG/PNG), file size, and resolution.</description></item>
        /// <item><description><c>ImageUrl</c> is required and must be a publicly accessible HTTP/HTTPS URL. Currently, only image URLs accessible from the Chinese mainland public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a Chinese mainland region first, and then use the presigned URL of the image as the input parameter for this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetectImageBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectImageBasicInfoResponse
        /// </returns>
        public async Task<DetectImageBasicInfoResponse> DetectImageBasicInfoAsync(DetectImageBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageBasicInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and results of a single-file or OSS Bucket batch C2PA signing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the status and final results of nodes created by using CreateC2paSignTask or CreateC2paBucketSignTask.</description></item>
        /// <item><description>It supports signing node queries for images, videos, and various audio formats (FLAC, M4A, MP3, and WAV).</description></item>
        /// <item><description>For BUCKET nodes, intermediate statistics information is not provided when the node is in the PROCESSING, PAUSING, PAUSED, or CANCELING state. Complete statistics information and the report location are returned only after the node enters the SUCCEEDED or CANCELED state.</description></item>
        /// <item><description>A valid TaskId must be provided for the query. This ID must be the value returned when the node was created. It supports the standard UUID format and is compatible with legacy decimal node IDs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetC2paSignResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetC2paSignResultResponse
        /// </returns>
        public GetC2paSignResultResponse GetC2paSignResultWithOptions(GetC2paSignResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetC2paSignResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetC2paSignResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and results of a single-file or OSS Bucket batch C2PA signing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the status and final results of nodes created by using CreateC2paSignTask or CreateC2paBucketSignTask.</description></item>
        /// <item><description>It supports signing node queries for images, videos, and various audio formats (FLAC, M4A, MP3, and WAV).</description></item>
        /// <item><description>For BUCKET nodes, intermediate statistics information is not provided when the node is in the PROCESSING, PAUSING, PAUSED, or CANCELING state. Complete statistics information and the report location are returned only after the node enters the SUCCEEDED or CANCELED state.</description></item>
        /// <item><description>A valid TaskId must be provided for the query. This ID must be the value returned when the node was created. It supports the standard UUID format and is compatible with legacy decimal node IDs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetC2paSignResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetC2paSignResultResponse
        /// </returns>
        public async Task<GetC2paSignResultResponse> GetC2paSignResultWithOptionsAsync(GetC2paSignResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetC2paSignResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetC2paSignResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and results of a single-file or OSS Bucket batch C2PA signing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the status and final results of nodes created by using CreateC2paSignTask or CreateC2paBucketSignTask.</description></item>
        /// <item><description>It supports signing node queries for images, videos, and various audio formats (FLAC, M4A, MP3, and WAV).</description></item>
        /// <item><description>For BUCKET nodes, intermediate statistics information is not provided when the node is in the PROCESSING, PAUSING, PAUSED, or CANCELING state. Complete statistics information and the report location are returned only after the node enters the SUCCEEDED or CANCELED state.</description></item>
        /// <item><description>A valid TaskId must be provided for the query. This ID must be the value returned when the node was created. It supports the standard UUID format and is compatible with legacy decimal node IDs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetC2paSignResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetC2paSignResultResponse
        /// </returns>
        public GetC2paSignResultResponse GetC2paSignResult(GetC2paSignResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetC2paSignResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and results of a single-file or OSS Bucket batch C2PA signing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the status and final results of nodes created by using CreateC2paSignTask or CreateC2paBucketSignTask.</description></item>
        /// <item><description>It supports signing node queries for images, videos, and various audio formats (FLAC, M4A, MP3, and WAV).</description></item>
        /// <item><description>For BUCKET nodes, intermediate statistics information is not provided when the node is in the PROCESSING, PAUSING, PAUSED, or CANCELING state. Complete statistics information and the report location are returned only after the node enters the SUCCEEDED or CANCELED state.</description></item>
        /// <item><description>A valid TaskId must be provided for the query. This ID must be the value returned when the node was created. It supports the standard UUID format and is compatible with legacy decimal node IDs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetC2paSignResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetC2paSignResultResponse
        /// </returns>
        public async Task<GetC2paSignResultResponse> GetC2paSignResultAsync(GetC2paSignResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetC2paSignResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of an image defect detection task, including the abnormality score and reason.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation queries the execution status and result of an image defect detection task created by <c>CreateImageDefectDetectionTask</c>. Follow these polling conventions:</para>
        /// <list type="bullet">
        /// <item><description><b>Set the polling interval to at least 5 seconds</b>: When the task is in the <c>running</c> state, each call to this operation triggers a real downstream query. Excessively frequent polling only increases system load and does not speed up result retrieval.</description></item>
        /// <item><description><b>Total timeout is 30 minutes</b>: If no result is received within 30 minutes after the task is created, the server marks the task as <c>failed</c> with the message <c>poll timeout: no result within 30m0s</c>. After that, the task no longer initiates new downstream query requests.</description></item>
        /// <item><description>After the task reaches the <c>succeeded</c> or <c>failed</c> desired state, subsequent calls to this operation directly return the stored result without triggering additional downstream processing.
        /// Note: The content in the <c>Result</c> field may be HTML-escaped JSON data. Unescape it before parsing.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageDefectDetectionTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageDefectDetectionTaskResultResponse
        /// </returns>
        public GetImageDefectDetectionTaskResultResponse GetImageDefectDetectionTaskResultWithOptions(GetImageDefectDetectionTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "GetImageDefectDetectionTaskResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageDefectDetectionTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of an image defect detection task, including the abnormality score and reason.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation queries the execution status and result of an image defect detection task created by <c>CreateImageDefectDetectionTask</c>. Follow these polling conventions:</para>
        /// <list type="bullet">
        /// <item><description><b>Set the polling interval to at least 5 seconds</b>: When the task is in the <c>running</c> state, each call to this operation triggers a real downstream query. Excessively frequent polling only increases system load and does not speed up result retrieval.</description></item>
        /// <item><description><b>Total timeout is 30 minutes</b>: If no result is received within 30 minutes after the task is created, the server marks the task as <c>failed</c> with the message <c>poll timeout: no result within 30m0s</c>. After that, the task no longer initiates new downstream query requests.</description></item>
        /// <item><description>After the task reaches the <c>succeeded</c> or <c>failed</c> desired state, subsequent calls to this operation directly return the stored result without triggering additional downstream processing.
        /// Note: The content in the <c>Result</c> field may be HTML-escaped JSON data. Unescape it before parsing.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageDefectDetectionTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageDefectDetectionTaskResultResponse
        /// </returns>
        public async Task<GetImageDefectDetectionTaskResultResponse> GetImageDefectDetectionTaskResultWithOptionsAsync(GetImageDefectDetectionTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "GetImageDefectDetectionTaskResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageDefectDetectionTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of an image defect detection task, including the abnormality score and reason.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation queries the execution status and result of an image defect detection task created by <c>CreateImageDefectDetectionTask</c>. Follow these polling conventions:</para>
        /// <list type="bullet">
        /// <item><description><b>Set the polling interval to at least 5 seconds</b>: When the task is in the <c>running</c> state, each call to this operation triggers a real downstream query. Excessively frequent polling only increases system load and does not speed up result retrieval.</description></item>
        /// <item><description><b>Total timeout is 30 minutes</b>: If no result is received within 30 minutes after the task is created, the server marks the task as <c>failed</c> with the message <c>poll timeout: no result within 30m0s</c>. After that, the task no longer initiates new downstream query requests.</description></item>
        /// <item><description>After the task reaches the <c>succeeded</c> or <c>failed</c> desired state, subsequent calls to this operation directly return the stored result without triggering additional downstream processing.
        /// Note: The content in the <c>Result</c> field may be HTML-escaped JSON data. Unescape it before parsing.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageDefectDetectionTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageDefectDetectionTaskResultResponse
        /// </returns>
        public GetImageDefectDetectionTaskResultResponse GetImageDefectDetectionTaskResult(GetImageDefectDetectionTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageDefectDetectionTaskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of an image defect detection task, including the abnormality score and reason.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation queries the execution status and result of an image defect detection task created by <c>CreateImageDefectDetectionTask</c>. Follow these polling conventions:</para>
        /// <list type="bullet">
        /// <item><description><b>Set the polling interval to at least 5 seconds</b>: When the task is in the <c>running</c> state, each call to this operation triggers a real downstream query. Excessively frequent polling only increases system load and does not speed up result retrieval.</description></item>
        /// <item><description><b>Total timeout is 30 minutes</b>: If no result is received within 30 minutes after the task is created, the server marks the task as <c>failed</c> with the message <c>poll timeout: no result within 30m0s</c>. After that, the task no longer initiates new downstream query requests.</description></item>
        /// <item><description>After the task reaches the <c>succeeded</c> or <c>failed</c> desired state, subsequent calls to this operation directly return the stored result without triggering additional downstream processing.
        /// Note: The content in the <c>Result</c> field may be HTML-escaped JSON data. Unescape it before parsing.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageDefectDetectionTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageDefectDetectionTaskResultResponse
        /// </returns>
        public async Task<GetImageDefectDetectionTaskResultResponse> GetImageDefectDetectionTaskResultAsync(GetImageDefectDetectionTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageDefectDetectionTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of an image detection task created by CreateImageDetectionTask.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para>Call this operation to query the execution status and result of a specified image detection task, including AIGC detection labels and tamper detection results. Poll at intervals of 2 to 5 seconds until the task status changes to succeeded or failed.</para>
        /// <h2>Precautions</h2>
        /// <list type="bullet">
        /// <item><description>Ensure that you use a valid TaskId for the query.</description></item>
        /// <item><description>If the task is not complete, increase the polling interval to avoid wasting resources due to frequent requests.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageDetectionTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageDetectionTaskResultResponse
        /// </returns>
        public GetImageDetectionTaskResultResponse GetImageDetectionTaskResultWithOptions(GetImageDetectionTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "GetImageDetectionTaskResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageDetectionTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of an image detection task created by CreateImageDetectionTask.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para>Call this operation to query the execution status and result of a specified image detection task, including AIGC detection labels and tamper detection results. Poll at intervals of 2 to 5 seconds until the task status changes to succeeded or failed.</para>
        /// <h2>Precautions</h2>
        /// <list type="bullet">
        /// <item><description>Ensure that you use a valid TaskId for the query.</description></item>
        /// <item><description>If the task is not complete, increase the polling interval to avoid wasting resources due to frequent requests.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageDetectionTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageDetectionTaskResultResponse
        /// </returns>
        public async Task<GetImageDetectionTaskResultResponse> GetImageDetectionTaskResultWithOptionsAsync(GetImageDetectionTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "GetImageDetectionTaskResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageDetectionTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of an image detection task created by CreateImageDetectionTask.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para>Call this operation to query the execution status and result of a specified image detection task, including AIGC detection labels and tamper detection results. Poll at intervals of 2 to 5 seconds until the task status changes to succeeded or failed.</para>
        /// <h2>Precautions</h2>
        /// <list type="bullet">
        /// <item><description>Ensure that you use a valid TaskId for the query.</description></item>
        /// <item><description>If the task is not complete, increase the polling interval to avoid wasting resources due to frequent requests.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageDetectionTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageDetectionTaskResultResponse
        /// </returns>
        public GetImageDetectionTaskResultResponse GetImageDetectionTaskResult(GetImageDetectionTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageDetectionTaskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of an image detection task created by CreateImageDetectionTask.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para>Call this operation to query the execution status and result of a specified image detection task, including AIGC detection labels and tamper detection results. Poll at intervals of 2 to 5 seconds until the task status changes to succeeded or failed.</para>
        /// <h2>Precautions</h2>
        /// <list type="bullet">
        /// <item><description>Ensure that you use a valid TaskId for the query.</description></item>
        /// <item><description>If the task is not complete, increase the polling interval to avoid wasting resources due to frequent requests.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageDetectionTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageDetectionTaskResultResponse
        /// </returns>
        public async Task<GetImageDetectionTaskResultResponse> GetImageDetectionTaskResultAsync(GetImageDetectionTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageDetectionTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and list of abnormal items for an individual income tax screenshot detection task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>Polling recommendation</b>: Set the polling interval to at least 5 seconds. Polling more frequently while the task is in <c>running</c> status does not return results faster.</description></item>
        /// <item><description><b>Total timeout</b>: If no result is obtained within 30 minutes after the task is created, the task is marked as <c>failed</c> with the Message <c>poll timeout: no result within 30m0s</c>.</description></item>
        /// <item><description><b>Desired state handling</b>: <c>succeeded</c> and <c>failed</c> are the final states of the task. The result does not change after the task reaches either state.</description></item>
        /// <item><description><b>Items is an empty array</b>: This indicates that no abnormal items are detected. It is not an error.</description></item>
        /// <item><description><b>Coordinates may be an empty array</b>: Some abnormalities are image-wide in nature (for example, quality issues affecting the entire image) and cannot be located within a specific bounding box. In this case, <c>Coordinates</c> is an empty array, but the abnormal item itself is still valid and should still be presented to the user.</description></item>
        /// <item><description><b>Stage is an open value set</b>: Future versions may introduce new <c>Stage</c> values. Display unknown values as-is. Do not perform whitelist validation on <c>Stage</c> or filter abnormal items based on it.</description></item>
        /// <item><description><b>quality stage</b>: A <c>Stage</c> value of <c>quality</c> indicates that the image quality is too low and the detection result has low confidence. Prompt the user to resubmit a clear original screenshot and run the detection again.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageIncomeTaxDetectionTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageIncomeTaxDetectionTaskResultResponse
        /// </returns>
        public GetImageIncomeTaxDetectionTaskResultResponse GetImageIncomeTaxDetectionTaskResultWithOptions(GetImageIncomeTaxDetectionTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "GetImageIncomeTaxDetectionTaskResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageIncomeTaxDetectionTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and list of abnormal items for an individual income tax screenshot detection task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>Polling recommendation</b>: Set the polling interval to at least 5 seconds. Polling more frequently while the task is in <c>running</c> status does not return results faster.</description></item>
        /// <item><description><b>Total timeout</b>: If no result is obtained within 30 minutes after the task is created, the task is marked as <c>failed</c> with the Message <c>poll timeout: no result within 30m0s</c>.</description></item>
        /// <item><description><b>Desired state handling</b>: <c>succeeded</c> and <c>failed</c> are the final states of the task. The result does not change after the task reaches either state.</description></item>
        /// <item><description><b>Items is an empty array</b>: This indicates that no abnormal items are detected. It is not an error.</description></item>
        /// <item><description><b>Coordinates may be an empty array</b>: Some abnormalities are image-wide in nature (for example, quality issues affecting the entire image) and cannot be located within a specific bounding box. In this case, <c>Coordinates</c> is an empty array, but the abnormal item itself is still valid and should still be presented to the user.</description></item>
        /// <item><description><b>Stage is an open value set</b>: Future versions may introduce new <c>Stage</c> values. Display unknown values as-is. Do not perform whitelist validation on <c>Stage</c> or filter abnormal items based on it.</description></item>
        /// <item><description><b>quality stage</b>: A <c>Stage</c> value of <c>quality</c> indicates that the image quality is too low and the detection result has low confidence. Prompt the user to resubmit a clear original screenshot and run the detection again.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageIncomeTaxDetectionTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageIncomeTaxDetectionTaskResultResponse
        /// </returns>
        public async Task<GetImageIncomeTaxDetectionTaskResultResponse> GetImageIncomeTaxDetectionTaskResultWithOptionsAsync(GetImageIncomeTaxDetectionTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "GetImageIncomeTaxDetectionTaskResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageIncomeTaxDetectionTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and list of abnormal items for an individual income tax screenshot detection task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>Polling recommendation</b>: Set the polling interval to at least 5 seconds. Polling more frequently while the task is in <c>running</c> status does not return results faster.</description></item>
        /// <item><description><b>Total timeout</b>: If no result is obtained within 30 minutes after the task is created, the task is marked as <c>failed</c> with the Message <c>poll timeout: no result within 30m0s</c>.</description></item>
        /// <item><description><b>Desired state handling</b>: <c>succeeded</c> and <c>failed</c> are the final states of the task. The result does not change after the task reaches either state.</description></item>
        /// <item><description><b>Items is an empty array</b>: This indicates that no abnormal items are detected. It is not an error.</description></item>
        /// <item><description><b>Coordinates may be an empty array</b>: Some abnormalities are image-wide in nature (for example, quality issues affecting the entire image) and cannot be located within a specific bounding box. In this case, <c>Coordinates</c> is an empty array, but the abnormal item itself is still valid and should still be presented to the user.</description></item>
        /// <item><description><b>Stage is an open value set</b>: Future versions may introduce new <c>Stage</c> values. Display unknown values as-is. Do not perform whitelist validation on <c>Stage</c> or filter abnormal items based on it.</description></item>
        /// <item><description><b>quality stage</b>: A <c>Stage</c> value of <c>quality</c> indicates that the image quality is too low and the detection result has low confidence. Prompt the user to resubmit a clear original screenshot and run the detection again.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageIncomeTaxDetectionTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageIncomeTaxDetectionTaskResultResponse
        /// </returns>
        public GetImageIncomeTaxDetectionTaskResultResponse GetImageIncomeTaxDetectionTaskResult(GetImageIncomeTaxDetectionTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageIncomeTaxDetectionTaskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and list of abnormal items for an individual income tax screenshot detection task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>Polling recommendation</b>: Set the polling interval to at least 5 seconds. Polling more frequently while the task is in <c>running</c> status does not return results faster.</description></item>
        /// <item><description><b>Total timeout</b>: If no result is obtained within 30 minutes after the task is created, the task is marked as <c>failed</c> with the Message <c>poll timeout: no result within 30m0s</c>.</description></item>
        /// <item><description><b>Desired state handling</b>: <c>succeeded</c> and <c>failed</c> are the final states of the task. The result does not change after the task reaches either state.</description></item>
        /// <item><description><b>Items is an empty array</b>: This indicates that no abnormal items are detected. It is not an error.</description></item>
        /// <item><description><b>Coordinates may be an empty array</b>: Some abnormalities are image-wide in nature (for example, quality issues affecting the entire image) and cannot be located within a specific bounding box. In this case, <c>Coordinates</c> is an empty array, but the abnormal item itself is still valid and should still be presented to the user.</description></item>
        /// <item><description><b>Stage is an open value set</b>: Future versions may introduce new <c>Stage</c> values. Display unknown values as-is. Do not perform whitelist validation on <c>Stage</c> or filter abnormal items based on it.</description></item>
        /// <item><description><b>quality stage</b>: A <c>Stage</c> value of <c>quality</c> indicates that the image quality is too low and the detection result has low confidence. Prompt the user to resubmit a clear original screenshot and run the detection again.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageIncomeTaxDetectionTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageIncomeTaxDetectionTaskResultResponse
        /// </returns>
        public async Task<GetImageIncomeTaxDetectionTaskResultResponse> GetImageIncomeTaxDetectionTaskResultAsync(GetImageIncomeTaxDetectionTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageIncomeTaxDetectionTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of an asynchronous image generation task and retrieves the image download URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation to query the execution status and result of an asynchronous image generation task created by <c>CreateImageTask</c>.</description></item>
        /// <item><description>Poll at intervals of 2 to 5 seconds until the task status changes to <c>succeeded</c> or <c>failed</c>.</description></item>
        /// <item><description>The image download URL (Url) returned after the task succeeds is a pre-signed URL that is valid for 1 hour.</description></item>
        /// <item><description>To ensure idempotence of the request, set the <c>ClientToken</c> parameter.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageTaskResultResponse
        /// </returns>
        public GetImageTaskResultResponse GetImageTaskResultWithOptions(GetImageTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetImageTaskResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of an asynchronous image generation task and retrieves the image download URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation to query the execution status and result of an asynchronous image generation task created by <c>CreateImageTask</c>.</description></item>
        /// <item><description>Poll at intervals of 2 to 5 seconds until the task status changes to <c>succeeded</c> or <c>failed</c>.</description></item>
        /// <item><description>The image download URL (Url) returned after the task succeeds is a pre-signed URL that is valid for 1 hour.</description></item>
        /// <item><description>To ensure idempotence of the request, set the <c>ClientToken</c> parameter.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageTaskResultResponse
        /// </returns>
        public async Task<GetImageTaskResultResponse> GetImageTaskResultWithOptionsAsync(GetImageTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetImageTaskResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of an asynchronous image generation task and retrieves the image download URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation to query the execution status and result of an asynchronous image generation task created by <c>CreateImageTask</c>.</description></item>
        /// <item><description>Poll at intervals of 2 to 5 seconds until the task status changes to <c>succeeded</c> or <c>failed</c>.</description></item>
        /// <item><description>The image download URL (Url) returned after the task succeeds is a pre-signed URL that is valid for 1 hour.</description></item>
        /// <item><description>To ensure idempotence of the request, set the <c>ClientToken</c> parameter.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageTaskResultResponse
        /// </returns>
        public GetImageTaskResultResponse GetImageTaskResult(GetImageTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageTaskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of an asynchronous image generation task and retrieves the image download URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation to query the execution status and result of an asynchronous image generation task created by <c>CreateImageTask</c>.</description></item>
        /// <item><description>Poll at intervals of 2 to 5 seconds until the task status changes to <c>succeeded</c> or <c>failed</c>.</description></item>
        /// <item><description>The image download URL (Url) returned after the task succeeds is a pre-signed URL that is valid for 1 hour.</description></item>
        /// <item><description>To ensure idempotence of the request, set the <c>ClientToken</c> parameter.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetImageTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageTaskResultResponse
        /// </returns>
        public async Task<GetImageTaskResultResponse> GetImageTaskResultAsync(GetImageTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of a sensitive information scan task and returns the details of the sensitive data discovered during the scan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation to query the execution status and result of a sensitive information scan task created by <c>CreateSensitiveScanTask</c>.</description></item>
        /// <item><description>Poll at intervals of 3 to 5 seconds until the task status changes to <c>completed</c> or <c>terminated</c>.</description></item>
        /// <item><description>The <c>ClientToken</c> parameter ensures the idempotence of the request. It is generated by the client, must be unique across different requests, supports ASCII characters, and cannot exceed 64 characters in length.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSensitiveScanResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSensitiveScanResultResponse
        /// </returns>
        public GetSensitiveScanResultResponse GetSensitiveScanResultWithOptions(GetSensitiveScanResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetSensitiveScanResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSensitiveScanResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of a sensitive information scan task and returns the details of the sensitive data discovered during the scan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation to query the execution status and result of a sensitive information scan task created by <c>CreateSensitiveScanTask</c>.</description></item>
        /// <item><description>Poll at intervals of 3 to 5 seconds until the task status changes to <c>completed</c> or <c>terminated</c>.</description></item>
        /// <item><description>The <c>ClientToken</c> parameter ensures the idempotence of the request. It is generated by the client, must be unique across different requests, supports ASCII characters, and cannot exceed 64 characters in length.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSensitiveScanResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSensitiveScanResultResponse
        /// </returns>
        public async Task<GetSensitiveScanResultResponse> GetSensitiveScanResultWithOptionsAsync(GetSensitiveScanResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetSensitiveScanResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSensitiveScanResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of a sensitive information scan task and returns the details of the sensitive data discovered during the scan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation to query the execution status and result of a sensitive information scan task created by <c>CreateSensitiveScanTask</c>.</description></item>
        /// <item><description>Poll at intervals of 3 to 5 seconds until the task status changes to <c>completed</c> or <c>terminated</c>.</description></item>
        /// <item><description>The <c>ClientToken</c> parameter ensures the idempotence of the request. It is generated by the client, must be unique across different requests, supports ASCII characters, and cannot exceed 64 characters in length.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSensitiveScanResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSensitiveScanResultResponse
        /// </returns>
        public GetSensitiveScanResultResponse GetSensitiveScanResult(GetSensitiveScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSensitiveScanResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and result of a sensitive information scan task and returns the details of the sensitive data discovered during the scan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation to query the execution status and result of a sensitive information scan task created by <c>CreateSensitiveScanTask</c>.</description></item>
        /// <item><description>Poll at intervals of 3 to 5 seconds until the task status changes to <c>completed</c> or <c>terminated</c>.</description></item>
        /// <item><description>The <c>ClientToken</c> parameter ensures the idempotence of the request. It is generated by the client, must be unique across different requests, supports ASCII characters, and cannot exceed 64 characters in length.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSensitiveScanResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSensitiveScanResultResponse
        /// </returns>
        public async Task<GetSensitiveScanResultResponse> GetSensitiveScanResultAsync(GetSensitiveScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSensitiveScanResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the task result of a video generation node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation to query the execution status and result of an asynchronous video generation task created by calling <c>CreateVideoTask</c>.</description></item>
        /// <item><description>Poll the task status at an interval of 2 to 5 seconds until the task status changes to <c>succeeded</c> or <c>failed</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoTaskResultResponse
        /// </returns>
        public GetVideoTaskResultResponse GetVideoTaskResultWithOptions(GetVideoTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetVideoTaskResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the task result of a video generation node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation to query the execution status and result of an asynchronous video generation task created by calling <c>CreateVideoTask</c>.</description></item>
        /// <item><description>Poll the task status at an interval of 2 to 5 seconds until the task status changes to <c>succeeded</c> or <c>failed</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoTaskResultResponse
        /// </returns>
        public async Task<GetVideoTaskResultResponse> GetVideoTaskResultWithOptionsAsync(GetVideoTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetVideoTaskResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the task result of a video generation node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation to query the execution status and result of an asynchronous video generation task created by calling <c>CreateVideoTask</c>.</description></item>
        /// <item><description>Poll the task status at an interval of 2 to 5 seconds until the task status changes to <c>succeeded</c> or <c>failed</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoTaskResultResponse
        /// </returns>
        public GetVideoTaskResultResponse GetVideoTaskResult(GetVideoTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoTaskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the task result of a video generation node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>Call this operation to query the execution status and result of an asynchronous video generation task created by calling <c>CreateVideoTask</c>.</description></item>
        /// <item><description>Poll the task status at an interval of 2 to 5 seconds until the task status changes to <c>succeeded</c> or <c>failed</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoTaskResultResponse
        /// </returns>
        public async Task<GetVideoTaskResultResponse> GetVideoTaskResultAsync(GetVideoTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and download URL of an invisible watermark embedding task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the execution status and result of an invisible watermark embedding task created by <c>CreateWatermarkEmbedTask</c>.</description></item>
        /// <item><description>Tasks are processed asynchronously on the server side. Call this operation to retrieve the latest status.</description></item>
        /// <item><description><b>Polling recommendations</b>: Ensure that the polling interval is at least 5 seconds. For video tasks, the expected completion time is approximately equal to the media duration (about 1x speed). Image tasks are completed within 5 minutes.</description></item>
        /// <item><description><b>Timeout mechanism</b>: The total timeout window for video tasks is 10 minutes, and for image tasks is 5 minutes. Tasks that are not completed within this period are marked as failed, and the corresponding error message is returned.</description></item>
        /// <item><description>When the task status is <c>succeeded</c> or <c>failed</c>, the task has reached a desired state, and the result no longer changes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWatermarkEmbedTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWatermarkEmbedTaskResultResponse
        /// </returns>
        public GetWatermarkEmbedTaskResultResponse GetWatermarkEmbedTaskResultWithOptions(GetWatermarkEmbedTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "GetWatermarkEmbedTaskResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWatermarkEmbedTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and download URL of an invisible watermark embedding task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the execution status and result of an invisible watermark embedding task created by <c>CreateWatermarkEmbedTask</c>.</description></item>
        /// <item><description>Tasks are processed asynchronously on the server side. Call this operation to retrieve the latest status.</description></item>
        /// <item><description><b>Polling recommendations</b>: Ensure that the polling interval is at least 5 seconds. For video tasks, the expected completion time is approximately equal to the media duration (about 1x speed). Image tasks are completed within 5 minutes.</description></item>
        /// <item><description><b>Timeout mechanism</b>: The total timeout window for video tasks is 10 minutes, and for image tasks is 5 minutes. Tasks that are not completed within this period are marked as failed, and the corresponding error message is returned.</description></item>
        /// <item><description>When the task status is <c>succeeded</c> or <c>failed</c>, the task has reached a desired state, and the result no longer changes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWatermarkEmbedTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWatermarkEmbedTaskResultResponse
        /// </returns>
        public async Task<GetWatermarkEmbedTaskResultResponse> GetWatermarkEmbedTaskResultWithOptionsAsync(GetWatermarkEmbedTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "GetWatermarkEmbedTaskResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWatermarkEmbedTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and download URL of an invisible watermark embedding task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the execution status and result of an invisible watermark embedding task created by <c>CreateWatermarkEmbedTask</c>.</description></item>
        /// <item><description>Tasks are processed asynchronously on the server side. Call this operation to retrieve the latest status.</description></item>
        /// <item><description><b>Polling recommendations</b>: Ensure that the polling interval is at least 5 seconds. For video tasks, the expected completion time is approximately equal to the media duration (about 1x speed). Image tasks are completed within 5 minutes.</description></item>
        /// <item><description><b>Timeout mechanism</b>: The total timeout window for video tasks is 10 minutes, and for image tasks is 5 minutes. Tasks that are not completed within this period are marked as failed, and the corresponding error message is returned.</description></item>
        /// <item><description>When the task status is <c>succeeded</c> or <c>failed</c>, the task has reached a desired state, and the result no longer changes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWatermarkEmbedTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWatermarkEmbedTaskResultResponse
        /// </returns>
        public GetWatermarkEmbedTaskResultResponse GetWatermarkEmbedTaskResult(GetWatermarkEmbedTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWatermarkEmbedTaskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and download URL of an invisible watermark embedding task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the execution status and result of an invisible watermark embedding task created by <c>CreateWatermarkEmbedTask</c>.</description></item>
        /// <item><description>Tasks are processed asynchronously on the server side. Call this operation to retrieve the latest status.</description></item>
        /// <item><description><b>Polling recommendations</b>: Ensure that the polling interval is at least 5 seconds. For video tasks, the expected completion time is approximately equal to the media duration (about 1x speed). Image tasks are completed within 5 minutes.</description></item>
        /// <item><description><b>Timeout mechanism</b>: The total timeout window for video tasks is 10 minutes, and for image tasks is 5 minutes. Tasks that are not completed within this period are marked as failed, and the corresponding error message is returned.</description></item>
        /// <item><description>When the task status is <c>succeeded</c> or <c>failed</c>, the task has reached a desired state, and the result no longer changes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWatermarkEmbedTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWatermarkEmbedTaskResultResponse
        /// </returns>
        public async Task<GetWatermarkEmbedTaskResultResponse> GetWatermarkEmbedTaskResultAsync(GetWatermarkEmbedTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWatermarkEmbedTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and extraction result of a dark watermark extraction task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>Polling recommendation</b>: Set the polling interval to at least 5 seconds. The task completion time is approximately equal to the duration of the carrier media (approximately 1x speed).</description></item>
        /// <item><description><b>Timeout handling</b>: The total timeout window for video tasks is 10 minutes, and for image tasks is 5 minutes. If a task is not completed within this time, the task status changes to <c>failed</c>.</description></item>
        /// <item><description><b>Desired state confirmation</b>: <c>succeeded</c> or <c>failed</c> is the final status. The result does not change after the task reaches either status.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWatermarkExtractTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWatermarkExtractTaskResultResponse
        /// </returns>
        public GetWatermarkExtractTaskResultResponse GetWatermarkExtractTaskResultWithOptions(GetWatermarkExtractTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "GetWatermarkExtractTaskResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWatermarkExtractTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and extraction result of a dark watermark extraction task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>Polling recommendation</b>: Set the polling interval to at least 5 seconds. The task completion time is approximately equal to the duration of the carrier media (approximately 1x speed).</description></item>
        /// <item><description><b>Timeout handling</b>: The total timeout window for video tasks is 10 minutes, and for image tasks is 5 minutes. If a task is not completed within this time, the task status changes to <c>failed</c>.</description></item>
        /// <item><description><b>Desired state confirmation</b>: <c>succeeded</c> or <c>failed</c> is the final status. The result does not change after the task reaches either status.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWatermarkExtractTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWatermarkExtractTaskResultResponse
        /// </returns>
        public async Task<GetWatermarkExtractTaskResultResponse> GetWatermarkExtractTaskResultWithOptionsAsync(GetWatermarkExtractTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "GetWatermarkExtractTaskResult",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWatermarkExtractTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and extraction result of a dark watermark extraction task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>Polling recommendation</b>: Set the polling interval to at least 5 seconds. The task completion time is approximately equal to the duration of the carrier media (approximately 1x speed).</description></item>
        /// <item><description><b>Timeout handling</b>: The total timeout window for video tasks is 10 minutes, and for image tasks is 5 minutes. If a task is not completed within this time, the task status changes to <c>failed</c>.</description></item>
        /// <item><description><b>Desired state confirmation</b>: <c>succeeded</c> or <c>failed</c> is the final status. The result does not change after the task reaches either status.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWatermarkExtractTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWatermarkExtractTaskResultResponse
        /// </returns>
        public GetWatermarkExtractTaskResultResponse GetWatermarkExtractTaskResult(GetWatermarkExtractTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWatermarkExtractTaskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and extraction result of a dark watermark extraction task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>Polling recommendation</b>: Set the polling interval to at least 5 seconds. The task completion time is approximately equal to the duration of the carrier media (approximately 1x speed).</description></item>
        /// <item><description><b>Timeout handling</b>: The total timeout window for video tasks is 10 minutes, and for image tasks is 5 minutes. If a task is not completed within this time, the task status changes to <c>failed</c>.</description></item>
        /// <item><description><b>Desired state confirmation</b>: <c>succeeded</c> or <c>failed</c> is the final status. The result does not change after the task reaches either status.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWatermarkExtractTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWatermarkExtractTaskResultResponse
        /// </returns>
        public async Task<GetWatermarkExtractTaskResultResponse> GetWatermarkExtractTaskResultAsync(GetWatermarkExtractTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWatermarkExtractTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses a batch C2PA trusted signing task for a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation pauses a batch trusted signing parent task for a bucket that is owned and still controllable by the currently authenticated account.</description></item>
        /// <item><description>The paused state is persisted to the database and remains effective after a service restart.</description></item>
        /// <item><description>If no files have been submitted to the trusted signing service, the task directly enters the <c>PAUSED</c> state. If submitted files exist, the task first enters the <c>PAUSING</c> state, stops scanning and new submissions, and continues to query the actual results of those files. After all results converge, the task enters the <c>PAUSED</c> state.</description></item>
        /// <item><description>Pausing does not interrupt an in-progress individual OSS or trusted signing service invoke, nor does it revoke signatures or metering that have already been completed.</description></item>
        /// <item><description>Invoking this operation repeatedly on a task that is already in the <c>PAUSING</c> or <c>PAUSED</c> state is idempotent and succeeds.</description></item>
        /// <item><description>Tasks in the <c>SUCCEEDED</c>, <c>FAILED</c>, <c>CANCELING</c>, or <c>CANCELED</c> state cannot be paused.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PauseC2paBucketSignTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PauseC2paBucketSignTaskResponse
        /// </returns>
        public PauseC2paBucketSignTaskResponse PauseC2paBucketSignTaskWithOptions(PauseC2paBucketSignTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "PauseC2paBucketSignTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseC2paBucketSignTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses a batch C2PA trusted signing task for a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation pauses a batch trusted signing parent task for a bucket that is owned and still controllable by the currently authenticated account.</description></item>
        /// <item><description>The paused state is persisted to the database and remains effective after a service restart.</description></item>
        /// <item><description>If no files have been submitted to the trusted signing service, the task directly enters the <c>PAUSED</c> state. If submitted files exist, the task first enters the <c>PAUSING</c> state, stops scanning and new submissions, and continues to query the actual results of those files. After all results converge, the task enters the <c>PAUSED</c> state.</description></item>
        /// <item><description>Pausing does not interrupt an in-progress individual OSS or trusted signing service invoke, nor does it revoke signatures or metering that have already been completed.</description></item>
        /// <item><description>Invoking this operation repeatedly on a task that is already in the <c>PAUSING</c> or <c>PAUSED</c> state is idempotent and succeeds.</description></item>
        /// <item><description>Tasks in the <c>SUCCEEDED</c>, <c>FAILED</c>, <c>CANCELING</c>, or <c>CANCELED</c> state cannot be paused.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PauseC2paBucketSignTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PauseC2paBucketSignTaskResponse
        /// </returns>
        public async Task<PauseC2paBucketSignTaskResponse> PauseC2paBucketSignTaskWithOptionsAsync(PauseC2paBucketSignTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "PauseC2paBucketSignTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseC2paBucketSignTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses a batch C2PA trusted signing task for a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation pauses a batch trusted signing parent task for a bucket that is owned and still controllable by the currently authenticated account.</description></item>
        /// <item><description>The paused state is persisted to the database and remains effective after a service restart.</description></item>
        /// <item><description>If no files have been submitted to the trusted signing service, the task directly enters the <c>PAUSED</c> state. If submitted files exist, the task first enters the <c>PAUSING</c> state, stops scanning and new submissions, and continues to query the actual results of those files. After all results converge, the task enters the <c>PAUSED</c> state.</description></item>
        /// <item><description>Pausing does not interrupt an in-progress individual OSS or trusted signing service invoke, nor does it revoke signatures or metering that have already been completed.</description></item>
        /// <item><description>Invoking this operation repeatedly on a task that is already in the <c>PAUSING</c> or <c>PAUSED</c> state is idempotent and succeeds.</description></item>
        /// <item><description>Tasks in the <c>SUCCEEDED</c>, <c>FAILED</c>, <c>CANCELING</c>, or <c>CANCELED</c> state cannot be paused.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PauseC2paBucketSignTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// PauseC2paBucketSignTaskResponse
        /// </returns>
        public PauseC2paBucketSignTaskResponse PauseC2paBucketSignTask(PauseC2paBucketSignTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PauseC2paBucketSignTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses a batch C2PA trusted signing task for a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation pauses a batch trusted signing parent task for a bucket that is owned and still controllable by the currently authenticated account.</description></item>
        /// <item><description>The paused state is persisted to the database and remains effective after a service restart.</description></item>
        /// <item><description>If no files have been submitted to the trusted signing service, the task directly enters the <c>PAUSED</c> state. If submitted files exist, the task first enters the <c>PAUSING</c> state, stops scanning and new submissions, and continues to query the actual results of those files. After all results converge, the task enters the <c>PAUSED</c> state.</description></item>
        /// <item><description>Pausing does not interrupt an in-progress individual OSS or trusted signing service invoke, nor does it revoke signatures or metering that have already been completed.</description></item>
        /// <item><description>Invoking this operation repeatedly on a task that is already in the <c>PAUSING</c> or <c>PAUSED</c> state is idempotent and succeeds.</description></item>
        /// <item><description>Tasks in the <c>SUCCEEDED</c>, <c>FAILED</c>, <c>CANCELING</c>, or <c>CANCELED</c> state cannot be paused.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PauseC2paBucketSignTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// PauseC2paBucketSignTaskResponse
        /// </returns>
        public async Task<PauseC2paBucketSignTaskResponse> PauseC2paBucketSignTaskAsync(PauseC2paBucketSignTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PauseC2paBucketSignTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a paused or pausing OSS Bucket batch C2PA trusted signing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation resumes a Bucket batch trusted signing parent task owned by the currently authenticated account.</description></item>
        /// <item><description>After resumption, the task continues execution from the saved scan cursor and per-file stage. It does not rebuild the object list or resubmit trusted signing service tasks that have already been persisted.</description></item>
        /// <item><description>This operation supports resuming from the <c>PAUSED</c> or <c>PAUSING</c> state. For tasks already in the <c>PROCESSING</c> state, repeated calls are idempotent and succeed.</description></item>
        /// <item><description>If the task was previously auto-paused due to failures in shared dependencies such as user OSS, internal OSS, or the trusted signing service, the pause error recorded on the parent task is cleared upon resumption. If the dependencies have not yet recovered, the task may enter the <c>PAUSING</c> or <c>PAUSED</c> state again with a new reason recorded.</description></item>
        /// <item><description>Before resuming a task that was paused due to permission issues, restore the OSS permissions of <c>AliyunServiceRoleForAIDeepSign</c> for the source prefix and output prefix. Otherwise, the task will be auto-paused again.</description></item>
        /// <item><description>Tasks in the <c>SUCCEEDED</c>, <c>FAILED</c>, <c>CANCELING</c>, or <c>CANCELED</c> state cannot be resumed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResumeC2paBucketSignTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeC2paBucketSignTaskResponse
        /// </returns>
        public ResumeC2paBucketSignTaskResponse ResumeC2paBucketSignTaskWithOptions(ResumeC2paBucketSignTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ResumeC2paBucketSignTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeC2paBucketSignTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a paused or pausing OSS Bucket batch C2PA trusted signing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation resumes a Bucket batch trusted signing parent task owned by the currently authenticated account.</description></item>
        /// <item><description>After resumption, the task continues execution from the saved scan cursor and per-file stage. It does not rebuild the object list or resubmit trusted signing service tasks that have already been persisted.</description></item>
        /// <item><description>This operation supports resuming from the <c>PAUSED</c> or <c>PAUSING</c> state. For tasks already in the <c>PROCESSING</c> state, repeated calls are idempotent and succeed.</description></item>
        /// <item><description>If the task was previously auto-paused due to failures in shared dependencies such as user OSS, internal OSS, or the trusted signing service, the pause error recorded on the parent task is cleared upon resumption. If the dependencies have not yet recovered, the task may enter the <c>PAUSING</c> or <c>PAUSED</c> state again with a new reason recorded.</description></item>
        /// <item><description>Before resuming a task that was paused due to permission issues, restore the OSS permissions of <c>AliyunServiceRoleForAIDeepSign</c> for the source prefix and output prefix. Otherwise, the task will be auto-paused again.</description></item>
        /// <item><description>Tasks in the <c>SUCCEEDED</c>, <c>FAILED</c>, <c>CANCELING</c>, or <c>CANCELED</c> state cannot be resumed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResumeC2paBucketSignTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeC2paBucketSignTaskResponse
        /// </returns>
        public async Task<ResumeC2paBucketSignTaskResponse> ResumeC2paBucketSignTaskWithOptionsAsync(ResumeC2paBucketSignTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ResumeC2paBucketSignTask",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeC2paBucketSignTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a paused or pausing OSS Bucket batch C2PA trusted signing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation resumes a Bucket batch trusted signing parent task owned by the currently authenticated account.</description></item>
        /// <item><description>After resumption, the task continues execution from the saved scan cursor and per-file stage. It does not rebuild the object list or resubmit trusted signing service tasks that have already been persisted.</description></item>
        /// <item><description>This operation supports resuming from the <c>PAUSED</c> or <c>PAUSING</c> state. For tasks already in the <c>PROCESSING</c> state, repeated calls are idempotent and succeed.</description></item>
        /// <item><description>If the task was previously auto-paused due to failures in shared dependencies such as user OSS, internal OSS, or the trusted signing service, the pause error recorded on the parent task is cleared upon resumption. If the dependencies have not yet recovered, the task may enter the <c>PAUSING</c> or <c>PAUSED</c> state again with a new reason recorded.</description></item>
        /// <item><description>Before resuming a task that was paused due to permission issues, restore the OSS permissions of <c>AliyunServiceRoleForAIDeepSign</c> for the source prefix and output prefix. Otherwise, the task will be auto-paused again.</description></item>
        /// <item><description>Tasks in the <c>SUCCEEDED</c>, <c>FAILED</c>, <c>CANCELING</c>, or <c>CANCELED</c> state cannot be resumed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResumeC2paBucketSignTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeC2paBucketSignTaskResponse
        /// </returns>
        public ResumeC2paBucketSignTaskResponse ResumeC2paBucketSignTask(ResumeC2paBucketSignTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeC2paBucketSignTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a paused or pausing OSS Bucket batch C2PA trusted signing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation resumes a Bucket batch trusted signing parent task owned by the currently authenticated account.</description></item>
        /// <item><description>After resumption, the task continues execution from the saved scan cursor and per-file stage. It does not rebuild the object list or resubmit trusted signing service tasks that have already been persisted.</description></item>
        /// <item><description>This operation supports resuming from the <c>PAUSED</c> or <c>PAUSING</c> state. For tasks already in the <c>PROCESSING</c> state, repeated calls are idempotent and succeed.</description></item>
        /// <item><description>If the task was previously auto-paused due to failures in shared dependencies such as user OSS, internal OSS, or the trusted signing service, the pause error recorded on the parent task is cleared upon resumption. If the dependencies have not yet recovered, the task may enter the <c>PAUSING</c> or <c>PAUSED</c> state again with a new reason recorded.</description></item>
        /// <item><description>Before resuming a task that was paused due to permission issues, restore the OSS permissions of <c>AliyunServiceRoleForAIDeepSign</c> for the source prefix and output prefix. Otherwise, the task will be auto-paused again.</description></item>
        /// <item><description>Tasks in the <c>SUCCEEDED</c>, <c>FAILED</c>, <c>CANCELING</c>, or <c>CANCELED</c> state cannot be resumed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResumeC2paBucketSignTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeC2paBucketSignTaskResponse
        /// </returns>
        public async Task<ResumeC2paBucketSignTaskResponse> ResumeC2paBucketSignTaskAsync(ResumeC2paBucketSignTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeC2paBucketSignTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Signs an image with a basic C2PA signature by using a platform-owned certificate, supports content integrity verification, and returns the download URL of the signed image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Signature types</h2>
        /// <list type="bullet">
        /// <item><description><b>Basic signature</b>: Signs with a platform-owned certificate and supports content integrity verification.</description></item>
        /// <item><description><b>Trusted signature</b>: In addition to integrity verification, the signing certificate chain can be verified through the C2PA official trust list.
        /// This operation provides basic signing. For trusted signing, call <c>CreateC2paSignTask</c> to create a task and call <c>GetC2paSignResult</c> to query the result.</description></item>
        /// </list>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>ImageUrl</c> is required and must be a publicly accessible HTTP/HTTPS URL.</description></item>
        /// <item><description>External image URLs are not currently supported. Only image URLs that are publicly accessible within the Chinese mainland are supported. Upload the image to an Alibaba Cloud OSS bucket in a region within the Chinese mainland first, and then use the pre-signed URL of the image as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single file or the URLs of multiple files</a>.</description></item>
        /// <item><description>Supported image formats: JPEG and PNG. Unsupported formats return the C2PA_FORMAT_UNSUPPORTED fault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SignUserImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SignUserImageResponse
        /// </returns>
        public SignUserImageResponse SignUserImageWithOptions(SignUserImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SignUserImage",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignUserImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Signs an image with a basic C2PA signature by using a platform-owned certificate, supports content integrity verification, and returns the download URL of the signed image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Signature types</h2>
        /// <list type="bullet">
        /// <item><description><b>Basic signature</b>: Signs with a platform-owned certificate and supports content integrity verification.</description></item>
        /// <item><description><b>Trusted signature</b>: In addition to integrity verification, the signing certificate chain can be verified through the C2PA official trust list.
        /// This operation provides basic signing. For trusted signing, call <c>CreateC2paSignTask</c> to create a task and call <c>GetC2paSignResult</c> to query the result.</description></item>
        /// </list>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>ImageUrl</c> is required and must be a publicly accessible HTTP/HTTPS URL.</description></item>
        /// <item><description>External image URLs are not currently supported. Only image URLs that are publicly accessible within the Chinese mainland are supported. Upload the image to an Alibaba Cloud OSS bucket in a region within the Chinese mainland first, and then use the pre-signed URL of the image as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single file or the URLs of multiple files</a>.</description></item>
        /// <item><description>Supported image formats: JPEG and PNG. Unsupported formats return the C2PA_FORMAT_UNSUPPORTED fault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SignUserImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SignUserImageResponse
        /// </returns>
        public async Task<SignUserImageResponse> SignUserImageWithOptionsAsync(SignUserImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SignUserImage",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignUserImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Signs an image with a basic C2PA signature by using a platform-owned certificate, supports content integrity verification, and returns the download URL of the signed image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Signature types</h2>
        /// <list type="bullet">
        /// <item><description><b>Basic signature</b>: Signs with a platform-owned certificate and supports content integrity verification.</description></item>
        /// <item><description><b>Trusted signature</b>: In addition to integrity verification, the signing certificate chain can be verified through the C2PA official trust list.
        /// This operation provides basic signing. For trusted signing, call <c>CreateC2paSignTask</c> to create a task and call <c>GetC2paSignResult</c> to query the result.</description></item>
        /// </list>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>ImageUrl</c> is required and must be a publicly accessible HTTP/HTTPS URL.</description></item>
        /// <item><description>External image URLs are not currently supported. Only image URLs that are publicly accessible within the Chinese mainland are supported. Upload the image to an Alibaba Cloud OSS bucket in a region within the Chinese mainland first, and then use the pre-signed URL of the image as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single file or the URLs of multiple files</a>.</description></item>
        /// <item><description>Supported image formats: JPEG and PNG. Unsupported formats return the C2PA_FORMAT_UNSUPPORTED fault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SignUserImageRequest
        /// </param>
        /// 
        /// <returns>
        /// SignUserImageResponse
        /// </returns>
        public SignUserImageResponse SignUserImage(SignUserImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SignUserImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Signs an image with a basic C2PA signature by using a platform-owned certificate, supports content integrity verification, and returns the download URL of the signed image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Signature types</h2>
        /// <list type="bullet">
        /// <item><description><b>Basic signature</b>: Signs with a platform-owned certificate and supports content integrity verification.</description></item>
        /// <item><description><b>Trusted signature</b>: In addition to integrity verification, the signing certificate chain can be verified through the C2PA official trust list.
        /// This operation provides basic signing. For trusted signing, call <c>CreateC2paSignTask</c> to create a task and call <c>GetC2paSignResult</c> to query the result.</description></item>
        /// </list>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><c>ImageUrl</c> is required and must be a publicly accessible HTTP/HTTPS URL.</description></item>
        /// <item><description>External image URLs are not currently supported. Only image URLs that are publicly accessible within the Chinese mainland are supported. Upload the image to an Alibaba Cloud OSS bucket in a region within the Chinese mainland first, and then use the pre-signed URL of the image as the input parameter of this operation. References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How to obtain the URL of a single file or the URLs of multiple files</a>.</description></item>
        /// <item><description>Supported image formats: JPEG and PNG. Unsupported formats return the C2PA_FORMAT_UNSUPPORTED fault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SignUserImageRequest
        /// </param>
        /// 
        /// <returns>
        /// SignUserImageResponse
        /// </returns>
        public async Task<SignUserImageResponse> SignUserImageAsync(SignUserImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SignUserImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the C2PA signature in an image and returns the content integrity verification status and issuer certificate trust information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Signature types</h2>
        /// <list type="bullet">
        /// <item><description><b>Basic signature</b>: Uses the platform\&quot;s own certificate for signing. Supports content integrity verification.</description></item>
        /// <item><description><b>Trusted signature</b>: In addition to integrity verification, the signing certificate chain can be verified through the C2PA official trust list.</description></item>
        /// </list>
        /// <h2>Verification result description</h2>
        /// <list type="bullet">
        /// <item><description>Content integrity verification checks whether the image and its signature-protected provenance information remain consistent with the state at the time of signing. It does not indicate that the visual content itself is authentic.</description></item>
        /// <item><description><c>VerificationState=Valid</c> indicates that the signature and data hash are valid and content integrity verification has passed. This alone cannot be used to determine that the signature is a trusted signature.</description></item>
        /// <item><description><c>VerificationState=Trusted</c> and <c>IssuerTrusted</c> present the certificate trust verification results. Whether a signature qualifies as a trusted signature as defined in this topic depends on whether the signing certificate chain can be verified through the C2PA official trust list, not solely on the certificate issuer name.</description></item>
        /// </list>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation verifies the C2PA (Coalition for Content Provenance and Authenticity) digital signature embedded in a specified image.</description></item>
        /// <item><description><c>ImageUrl</c> <b>does not currently support images from external networks. Only image URLs accessible over the China public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a China region first, and then use the presigned URL of the image as the input parameter for this operation.</b> References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyImageSignatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyImageSignatureResponse
        /// </returns>
        public VerifyImageSignatureResponse VerifyImageSignatureWithOptions(VerifyImageSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyImageSignature",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyImageSignatureResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the C2PA signature in an image and returns the content integrity verification status and issuer certificate trust information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Signature types</h2>
        /// <list type="bullet">
        /// <item><description><b>Basic signature</b>: Uses the platform\&quot;s own certificate for signing. Supports content integrity verification.</description></item>
        /// <item><description><b>Trusted signature</b>: In addition to integrity verification, the signing certificate chain can be verified through the C2PA official trust list.</description></item>
        /// </list>
        /// <h2>Verification result description</h2>
        /// <list type="bullet">
        /// <item><description>Content integrity verification checks whether the image and its signature-protected provenance information remain consistent with the state at the time of signing. It does not indicate that the visual content itself is authentic.</description></item>
        /// <item><description><c>VerificationState=Valid</c> indicates that the signature and data hash are valid and content integrity verification has passed. This alone cannot be used to determine that the signature is a trusted signature.</description></item>
        /// <item><description><c>VerificationState=Trusted</c> and <c>IssuerTrusted</c> present the certificate trust verification results. Whether a signature qualifies as a trusted signature as defined in this topic depends on whether the signing certificate chain can be verified through the C2PA official trust list, not solely on the certificate issuer name.</description></item>
        /// </list>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation verifies the C2PA (Coalition for Content Provenance and Authenticity) digital signature embedded in a specified image.</description></item>
        /// <item><description><c>ImageUrl</c> <b>does not currently support images from external networks. Only image URLs accessible over the China public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a China region first, and then use the presigned URL of the image as the input parameter for this operation.</b> References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyImageSignatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyImageSignatureResponse
        /// </returns>
        public async Task<VerifyImageSignatureResponse> VerifyImageSignatureWithOptionsAsync(VerifyImageSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyImageSignature",
                Version = "2026-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyImageSignatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the C2PA signature in an image and returns the content integrity verification status and issuer certificate trust information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Signature types</h2>
        /// <list type="bullet">
        /// <item><description><b>Basic signature</b>: Uses the platform\&quot;s own certificate for signing. Supports content integrity verification.</description></item>
        /// <item><description><b>Trusted signature</b>: In addition to integrity verification, the signing certificate chain can be verified through the C2PA official trust list.</description></item>
        /// </list>
        /// <h2>Verification result description</h2>
        /// <list type="bullet">
        /// <item><description>Content integrity verification checks whether the image and its signature-protected provenance information remain consistent with the state at the time of signing. It does not indicate that the visual content itself is authentic.</description></item>
        /// <item><description><c>VerificationState=Valid</c> indicates that the signature and data hash are valid and content integrity verification has passed. This alone cannot be used to determine that the signature is a trusted signature.</description></item>
        /// <item><description><c>VerificationState=Trusted</c> and <c>IssuerTrusted</c> present the certificate trust verification results. Whether a signature qualifies as a trusted signature as defined in this topic depends on whether the signing certificate chain can be verified through the C2PA official trust list, not solely on the certificate issuer name.</description></item>
        /// </list>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation verifies the C2PA (Coalition for Content Provenance and Authenticity) digital signature embedded in a specified image.</description></item>
        /// <item><description><c>ImageUrl</c> <b>does not currently support images from external networks. Only image URLs accessible over the China public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a China region first, and then use the presigned URL of the image as the input parameter for this operation.</b> References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyImageSignatureRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyImageSignatureResponse
        /// </returns>
        public VerifyImageSignatureResponse VerifyImageSignature(VerifyImageSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyImageSignatureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the C2PA signature in an image and returns the content integrity verification status and issuer certificate trust information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Signature types</h2>
        /// <list type="bullet">
        /// <item><description><b>Basic signature</b>: Uses the platform\&quot;s own certificate for signing. Supports content integrity verification.</description></item>
        /// <item><description><b>Trusted signature</b>: In addition to integrity verification, the signing certificate chain can be verified through the C2PA official trust list.</description></item>
        /// </list>
        /// <h2>Verification result description</h2>
        /// <list type="bullet">
        /// <item><description>Content integrity verification checks whether the image and its signature-protected provenance information remain consistent with the state at the time of signing. It does not indicate that the visual content itself is authentic.</description></item>
        /// <item><description><c>VerificationState=Valid</c> indicates that the signature and data hash are valid and content integrity verification has passed. This alone cannot be used to determine that the signature is a trusted signature.</description></item>
        /// <item><description><c>VerificationState=Trusted</c> and <c>IssuerTrusted</c> present the certificate trust verification results. Whether a signature qualifies as a trusted signature as defined in this topic depends on whether the signing certificate chain can be verified through the C2PA official trust list, not solely on the certificate issuer name.</description></item>
        /// </list>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation verifies the C2PA (Coalition for Content Provenance and Authenticity) digital signature embedded in a specified image.</description></item>
        /// <item><description><c>ImageUrl</c> <b>does not currently support images from external networks. Only image URLs accessible over the China public network are supported. Upload the image to an Alibaba Cloud OSS bucket in a China region first, and then use the presigned URL of the image as the input parameter for this operation.</b> References: <a href="https://www.alibabacloud.com/help/en/oss/user-guide/how-to-obtain-the-url-of-a-single-object-or-the-urls-of-multiple-objects">How do I obtain the URL of one or more objects?</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyImageSignatureRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyImageSignatureResponse
        /// </returns>
        public async Task<VerifyImageSignatureResponse> VerifyImageSignatureAsync(VerifyImageSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyImageSignatureWithOptionsAsync(request, runtime);
        }

    }
}
