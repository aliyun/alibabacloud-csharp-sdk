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
        /// <para>Creates an asynchronous image detection task that supports AIGC and tampering detection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an asynchronous image detection task that supports automatic classification, AIGC detection, and tampering detection.</description></item>
        /// <item><description>You must specify at least one of <c>ImageUrl</c> and <c>ObjectKey</c>. If both are specified, <c>ObjectKey</c> takes precedence.</description></item>
        /// <item><description>If you set <c>DetectType</c> to <c>auto</c>, the system automatically determines whether to perform AIGC detection or tampering detection based on the image content.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredType))
            {
                query["CredType"] = request.CredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectType))
            {
                query["DetectType"] = request.DetectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKey))
            {
                query["ObjectKey"] = request.ObjectKey;
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
        /// <para>Creates an asynchronous image detection task that supports AIGC and tampering detection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an asynchronous image detection task that supports automatic classification, AIGC detection, and tampering detection.</description></item>
        /// <item><description>You must specify at least one of <c>ImageUrl</c> and <c>ObjectKey</c>. If both are specified, <c>ObjectKey</c> takes precedence.</description></item>
        /// <item><description>If you set <c>DetectType</c> to <c>auto</c>, the system automatically determines whether to perform AIGC detection or tampering detection based on the image content.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredType))
            {
                query["CredType"] = request.CredType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetectType))
            {
                query["DetectType"] = request.DetectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKey))
            {
                query["ObjectKey"] = request.ObjectKey;
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
        /// <para>Creates an asynchronous image detection task that supports AIGC and tampering detection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an asynchronous image detection task that supports automatic classification, AIGC detection, and tampering detection.</description></item>
        /// <item><description>You must specify at least one of <c>ImageUrl</c> and <c>ObjectKey</c>. If both are specified, <c>ObjectKey</c> takes precedence.</description></item>
        /// <item><description>If you set <c>DetectType</c> to <c>auto</c>, the system automatically determines whether to perform AIGC detection or tampering detection based on the image content.</description></item>
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
        /// <para>Creates an asynchronous image detection task that supports AIGC and tampering detection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation creates an asynchronous image detection task that supports automatic classification, AIGC detection, and tampering detection.</description></item>
        /// <item><description>You must specify at least one of <c>ImageUrl</c> and <c>ObjectKey</c>. If both are specified, <c>ObjectKey</c> takes precedence.</description></item>
        /// <item><description>If you set <c>DetectType</c> to <c>auto</c>, the system automatically determines whether to perform AIGC detection or tampering detection based on the image content.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermark))
            {
                query["Watermark"] = request.Watermark;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermark))
            {
                query["Watermark"] = request.Watermark;
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
        /// <item><description>This operation creates an image sensitive information scan task. The system performs sensitive data identification on the specified image.</description></item>
        /// <item><description>You can specify the image to scan by using an image URL or an OSS ObjectKey.</description></item>
        /// <item><description>The image size cannot exceed 10 MB.</description></item>
        /// <item><description>You must specify at least one of ImageUrl and ObjectKey. If both are specified, ObjectKey takes precedence.</description></item>
        /// <item><description>When you use ObjectKey, make sure that the key belongs to the namespace of the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>You can use the ClientToken parameter to ensure the idempotence of the request.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKey))
            {
                query["ObjectKey"] = request.ObjectKey;
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
        /// <item><description>This operation creates an image sensitive information scan task. The system performs sensitive data identification on the specified image.</description></item>
        /// <item><description>You can specify the image to scan by using an image URL or an OSS ObjectKey.</description></item>
        /// <item><description>The image size cannot exceed 10 MB.</description></item>
        /// <item><description>You must specify at least one of ImageUrl and ObjectKey. If both are specified, ObjectKey takes precedence.</description></item>
        /// <item><description>When you use ObjectKey, make sure that the key belongs to the namespace of the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>You can use the ClientToken parameter to ensure the idempotence of the request.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKey))
            {
                query["ObjectKey"] = request.ObjectKey;
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
        /// <item><description>This operation creates an image sensitive information scan task. The system performs sensitive data identification on the specified image.</description></item>
        /// <item><description>You can specify the image to scan by using an image URL or an OSS ObjectKey.</description></item>
        /// <item><description>The image size cannot exceed 10 MB.</description></item>
        /// <item><description>You must specify at least one of ImageUrl and ObjectKey. If both are specified, ObjectKey takes precedence.</description></item>
        /// <item><description>When you use ObjectKey, make sure that the key belongs to the namespace of the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>You can use the ClientToken parameter to ensure the idempotence of the request.</description></item>
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
        /// <item><description>This operation creates an image sensitive information scan task. The system performs sensitive data identification on the specified image.</description></item>
        /// <item><description>You can specify the image to scan by using an image URL or an OSS ObjectKey.</description></item>
        /// <item><description>The image size cannot exceed 10 MB.</description></item>
        /// <item><description>You must specify at least one of ImageUrl and ObjectKey. If both are specified, ObjectKey takes precedence.</description></item>
        /// <item><description>When you use ObjectKey, make sure that the key belongs to the namespace of the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>You can use the ClientToken parameter to ensure the idempotence of the request.</description></item>
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
        /// <para>Determines whether an image is AI-generated and returns detection labels and confidence levels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation detects whether a specified image is AI-generated content (AIGC). You can specify the image to detect by using an image URL or an OSS ObjectKey.</description></item>
        /// <item><description>You must provide at least one of ImageUrl and ObjectKey. If both are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When you use the ObjectKey method, the system verifies whether the ObjectKey belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>This is a synchronous operation suitable for real-time detection of a single image. To perform asynchronous detection or credential detection at the same time, use the CreateImageDetectionTask operation.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKey))
            {
                query["ObjectKey"] = request.ObjectKey;
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
        /// <para>Determines whether an image is AI-generated and returns detection labels and confidence levels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation detects whether a specified image is AI-generated content (AIGC). You can specify the image to detect by using an image URL or an OSS ObjectKey.</description></item>
        /// <item><description>You must provide at least one of ImageUrl and ObjectKey. If both are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When you use the ObjectKey method, the system verifies whether the ObjectKey belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>This is a synchronous operation suitable for real-time detection of a single image. To perform asynchronous detection or credential detection at the same time, use the CreateImageDetectionTask operation.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKey))
            {
                query["ObjectKey"] = request.ObjectKey;
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
        /// <para>Determines whether an image is AI-generated and returns detection labels and confidence levels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation detects whether a specified image is AI-generated content (AIGC). You can specify the image to detect by using an image URL or an OSS ObjectKey.</description></item>
        /// <item><description>You must provide at least one of ImageUrl and ObjectKey. If both are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When you use the ObjectKey method, the system verifies whether the ObjectKey belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>This is a synchronous operation suitable for real-time detection of a single image. To perform asynchronous detection or credential detection at the same time, use the CreateImageDetectionTask operation.</description></item>
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
        /// <para>Determines whether an image is AI-generated and returns detection labels and confidence levels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation detects whether a specified image is AI-generated content (AIGC). You can specify the image to detect by using an image URL or an OSS ObjectKey.</description></item>
        /// <item><description>You must provide at least one of ImageUrl and ObjectKey. If both are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When you use the ObjectKey method, the system verifies whether the ObjectKey belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>This is a synchronous operation suitable for real-time detection of a single image. To perform asynchronous detection or credential detection at the same time, use the CreateImageDetectionTask operation.</description></item>
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
        /// <item><description>This operation detects and returns basic information about an image, including but not limited to the file name, image format (such as JPEG or PNG), file size, and resolution.</description></item>
        /// <item><description>You can specify the image to detect by providing an image URL or an OSS ObjectKey. If both ImageUrl and ObjectKey are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When using ObjectKey, ensure that the object belongs to the namespace of the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>The optional parameter ClientToken ensures the idempotence of the request. Generate a new unique value for each request.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKey))
            {
                query["ObjectKey"] = request.ObjectKey;
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
        /// <item><description>This operation detects and returns basic information about an image, including but not limited to the file name, image format (such as JPEG or PNG), file size, and resolution.</description></item>
        /// <item><description>You can specify the image to detect by providing an image URL or an OSS ObjectKey. If both ImageUrl and ObjectKey are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When using ObjectKey, ensure that the object belongs to the namespace of the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>The optional parameter ClientToken ensures the idempotence of the request. Generate a new unique value for each request.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKey))
            {
                query["ObjectKey"] = request.ObjectKey;
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
        /// <item><description>This operation detects and returns basic information about an image, including but not limited to the file name, image format (such as JPEG or PNG), file size, and resolution.</description></item>
        /// <item><description>You can specify the image to detect by providing an image URL or an OSS ObjectKey. If both ImageUrl and ObjectKey are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When using ObjectKey, ensure that the object belongs to the namespace of the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>The optional parameter ClientToken ensures the idempotence of the request. Generate a new unique value for each request.</description></item>
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
        /// <item><description>This operation detects and returns basic information about an image, including but not limited to the file name, image format (such as JPEG or PNG), file size, and resolution.</description></item>
        /// <item><description>You can specify the image to detect by providing an image URL or an OSS ObjectKey. If both ImageUrl and ObjectKey are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When using ObjectKey, ensure that the object belongs to the namespace of the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>The optional parameter ClientToken ensures the idempotence of the request. Generate a new unique value for each request.</description></item>
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
        /// <para>Queries the status and results of an image detection task, including AIGC detection labels and tamper detection results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Call this operation to query the execution status and results of an asynchronous detection task created by <c>CreateImageDetectionTask</c>. Poll at intervals of 2 to 5 seconds until the task status changes to <c>succeeded</c> or <c>failed</c>.</para>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>Use a valid <c>TaskId</c> for the query.</description></item>
        /// <item><description>If the task is not complete, increase the polling interval to avoid unnecessary resource consumption caused by frequent requests.</description></item>
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
        /// <para>Queries the status and results of an image detection task, including AIGC detection labels and tamper detection results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Call this operation to query the execution status and results of an asynchronous detection task created by <c>CreateImageDetectionTask</c>. Poll at intervals of 2 to 5 seconds until the task status changes to <c>succeeded</c> or <c>failed</c>.</para>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>Use a valid <c>TaskId</c> for the query.</description></item>
        /// <item><description>If the task is not complete, increase the polling interval to avoid unnecessary resource consumption caused by frequent requests.</description></item>
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
        /// <para>Queries the status and results of an image detection task, including AIGC detection labels and tamper detection results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Call this operation to query the execution status and results of an asynchronous detection task created by <c>CreateImageDetectionTask</c>. Poll at intervals of 2 to 5 seconds until the task status changes to <c>succeeded</c> or <c>failed</c>.</para>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>Use a valid <c>TaskId</c> for the query.</description></item>
        /// <item><description>If the task is not complete, increase the polling interval to avoid unnecessary resource consumption caused by frequent requests.</description></item>
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
        /// <para>Queries the status and results of an image detection task, including AIGC detection labels and tamper detection results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Call this operation to query the execution status and results of an asynchronous detection task created by <c>CreateImageDetectionTask</c>. Poll at intervals of 2 to 5 seconds until the task status changes to <c>succeeded</c> or <c>failed</c>.</para>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>Use a valid <c>TaskId</c> for the query.</description></item>
        /// <item><description>If the task is not complete, increase the polling interval to avoid unnecessary resource consumption caused by frequent requests.</description></item>
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
        /// <para>Embeds a C2PA digital signature into a user-uploaded image and returns the download URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Specify at least one of <c>ImageUrl</c> and <c>ObjectKey</c>. If both are specified, <c>ObjectKey</c> takes precedence.</description></item>
        /// <item><description>When you use <c>ObjectKey</c>, the system verifies that the <c>ObjectKey</c> belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>Supported image formats are JPEG and PNG. Unsupported formats return the <c>C2PA_FORMAT_UNSUPPORTED</c> error.</description></item>
        /// <item><description>If the original image already contains a C2PA signature, the system retains the original signature as an ingredient and appends a new signature.</description></item>
        /// <item><description>Use the <c>ClientToken</c> parameter to ensure idempotence. Make sure the value is unique across different requests and does not exceed 64 characters.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKey))
            {
                query["ObjectKey"] = request.ObjectKey;
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
        /// <para>Embeds a C2PA digital signature into a user-uploaded image and returns the download URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Specify at least one of <c>ImageUrl</c> and <c>ObjectKey</c>. If both are specified, <c>ObjectKey</c> takes precedence.</description></item>
        /// <item><description>When you use <c>ObjectKey</c>, the system verifies that the <c>ObjectKey</c> belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>Supported image formats are JPEG and PNG. Unsupported formats return the <c>C2PA_FORMAT_UNSUPPORTED</c> error.</description></item>
        /// <item><description>If the original image already contains a C2PA signature, the system retains the original signature as an ingredient and appends a new signature.</description></item>
        /// <item><description>Use the <c>ClientToken</c> parameter to ensure idempotence. Make sure the value is unique across different requests and does not exceed 64 characters.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKey))
            {
                query["ObjectKey"] = request.ObjectKey;
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
        /// <para>Embeds a C2PA digital signature into a user-uploaded image and returns the download URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Specify at least one of <c>ImageUrl</c> and <c>ObjectKey</c>. If both are specified, <c>ObjectKey</c> takes precedence.</description></item>
        /// <item><description>When you use <c>ObjectKey</c>, the system verifies that the <c>ObjectKey</c> belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>Supported image formats are JPEG and PNG. Unsupported formats return the <c>C2PA_FORMAT_UNSUPPORTED</c> error.</description></item>
        /// <item><description>If the original image already contains a C2PA signature, the system retains the original signature as an ingredient and appends a new signature.</description></item>
        /// <item><description>Use the <c>ClientToken</c> parameter to ensure idempotence. Make sure the value is unique across different requests and does not exceed 64 characters.</description></item>
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
        /// <para>Embeds a C2PA digital signature into a user-uploaded image and returns the download URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Specify at least one of <c>ImageUrl</c> and <c>ObjectKey</c>. If both are specified, <c>ObjectKey</c> takes precedence.</description></item>
        /// <item><description>When you use <c>ObjectKey</c>, the system verifies that the <c>ObjectKey</c> belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>Supported image formats are JPEG and PNG. Unsupported formats return the <c>C2PA_FORMAT_UNSUPPORTED</c> error.</description></item>
        /// <item><description>If the original image already contains a C2PA signature, the system retains the original signature as an ingredient and appends a new signature.</description></item>
        /// <item><description>Use the <c>ClientToken</c> parameter to ensure idempotence. Make sure the value is unique across different requests and does not exceed 64 characters.</description></item>
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
        /// <para>Verifies the C2PA digital signature in an image and returns the signature status and issuer information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation verifies the C2PA digital signature embedded in an image and returns the signature verification status, issuer trustworthiness, issuer information, and the complete content credentials manifest.</description></item>
        /// <item><description>You can specify the image to verify by using an image URL or an OSS ObjectKey. If both ImageUrl and ObjectKey are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When you use the ObjectKey method, the system verifies whether the ObjectKey belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>To ensure request idempotency, provide the ClientToken parameter. Ensure that the value is unique across different requests and does not exceed 64 characters.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKey))
            {
                query["ObjectKey"] = request.ObjectKey;
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
        /// <para>Verifies the C2PA digital signature in an image and returns the signature status and issuer information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation verifies the C2PA digital signature embedded in an image and returns the signature verification status, issuer trustworthiness, issuer information, and the complete content credentials manifest.</description></item>
        /// <item><description>You can specify the image to verify by using an image URL or an OSS ObjectKey. If both ImageUrl and ObjectKey are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When you use the ObjectKey method, the system verifies whether the ObjectKey belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>To ensure request idempotency, provide the ClientToken parameter. Ensure that the value is unique across different requests and does not exceed 64 characters.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKey))
            {
                query["ObjectKey"] = request.ObjectKey;
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
        /// <para>Verifies the C2PA digital signature in an image and returns the signature status and issuer information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation verifies the C2PA digital signature embedded in an image and returns the signature verification status, issuer trustworthiness, issuer information, and the complete content credentials manifest.</description></item>
        /// <item><description>You can specify the image to verify by using an image URL or an OSS ObjectKey. If both ImageUrl and ObjectKey are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When you use the ObjectKey method, the system verifies whether the ObjectKey belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>To ensure request idempotency, provide the ClientToken parameter. Ensure that the value is unique across different requests and does not exceed 64 characters.</description></item>
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
        /// <para>Verifies the C2PA digital signature in an image and returns the signature status and issuer information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation verifies the C2PA digital signature embedded in an image and returns the signature verification status, issuer trustworthiness, issuer information, and the complete content credentials manifest.</description></item>
        /// <item><description>You can specify the image to verify by using an image URL or an OSS ObjectKey. If both ImageUrl and ObjectKey are provided, ObjectKey takes precedence.</description></item>
        /// <item><description>When you use the ObjectKey method, the system verifies whether the ObjectKey belongs to the current caller. Cross-tenant access is not allowed.</description></item>
        /// <item><description>To ensure request idempotency, provide the ClientToken parameter. Ensure that the value is unique across different requests and does not exceed 64 characters.</description></item>
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
