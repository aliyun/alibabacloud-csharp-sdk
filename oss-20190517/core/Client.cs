// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Oss20190517.Models;

namespace AlibabaCloud.SDK.Oss20190517
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayOss.Client();
            this._spi = _client;
            this._endpointRule = "";
        }


        public AbortBucketWormResponse AbortBucketWorm(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AbortBucketWormWithOptions(bucket, headers, runtime);
        }

        public async Task<AbortBucketWormResponse> AbortBucketWormAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AbortBucketWormWithOptionsAsync(bucket, headers, runtime);
        }

        public AbortBucketWormResponse AbortBucketWormWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortBucketWorm",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?worm",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<AbortBucketWormResponse>(Execute(params_, req, runtime));
        }

        public async Task<AbortBucketWormResponse> AbortBucketWormWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortBucketWorm",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?worm",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<AbortBucketWormResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AbortMultipartUploadResponse AbortMultipartUpload(string bucket, string key, AbortMultipartUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AbortMultipartUploadWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(string bucket, string key, AbortMultipartUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AbortMultipartUploadWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public AbortMultipartUploadResponse AbortMultipartUploadWithOptions(string bucket, string key, AbortMultipartUploadRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                query["uploadId"] = request.UploadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortMultipartUpload",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<AbortMultipartUploadResponse>(Execute(params_, req, runtime));
        }

        public async Task<AbortMultipartUploadResponse> AbortMultipartUploadWithOptionsAsync(string bucket, string key, AbortMultipartUploadRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                query["uploadId"] = request.UploadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortMultipartUpload",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<AbortMultipartUploadResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AppendObjectResponse AppendObject(string bucket, string key, AppendObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendObjectHeaders headers = new AppendObjectHeaders();
            return AppendObjectWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<AppendObjectResponse> AppendObjectAsync(string bucket, string key, AppendObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendObjectHeaders headers = new AppendObjectHeaders();
            return await AppendObjectWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public AppendObjectResponse AppendObjectWithOptions(string bucket, string key, AppendObjectRequest request, AppendObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Position))
            {
                query["position"] = request.Position;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CacheControl))
            {
                realHeaders["Cache-Control"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CacheControl);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ContentDisposition))
            {
                realHeaders["Content-Disposition"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ContentDisposition);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ContentEncoding))
            {
                realHeaders["Content-Encoding"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ContentEncoding);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ContentMD5))
            {
                realHeaders["Content-MD5"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ContentMD5);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Expires))
            {
                realHeaders["Expires"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Expires);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.MetaData))
            {
                realHeaders["x-oss-meta-*"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.MetaData);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Acl))
            {
                realHeaders["x-oss-object-acl"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Acl);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServerSideEncryption))
            {
                realHeaders["x-oss-server-side-encryption"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServerSideEncryption);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.StorageClass))
            {
                realHeaders["x-oss-storage-class"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.StorageClass);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AppendObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?append",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "binary",
                BodyType = "xml",
            };
            return TeaModel.ToObject<AppendObjectResponse>(Execute(params_, req, runtime));
        }

        public async Task<AppendObjectResponse> AppendObjectWithOptionsAsync(string bucket, string key, AppendObjectRequest request, AppendObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Position))
            {
                query["position"] = request.Position;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CacheControl))
            {
                realHeaders["Cache-Control"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CacheControl);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ContentDisposition))
            {
                realHeaders["Content-Disposition"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ContentDisposition);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ContentEncoding))
            {
                realHeaders["Content-Encoding"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ContentEncoding);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ContentMD5))
            {
                realHeaders["Content-MD5"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ContentMD5);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Expires))
            {
                realHeaders["Expires"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Expires);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.MetaData))
            {
                realHeaders["x-oss-meta-*"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.MetaData);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Acl))
            {
                realHeaders["x-oss-object-acl"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Acl);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServerSideEncryption))
            {
                realHeaders["x-oss-server-side-encryption"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServerSideEncryption);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.StorageClass))
            {
                realHeaders["x-oss-storage-class"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.StorageClass);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AppendObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?append",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "binary",
                BodyType = "xml",
            };
            return TeaModel.ToObject<AppendObjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CompleteBucketWormResponse CompleteBucketWorm(string bucket, CompleteBucketWormRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CompleteBucketWormWithOptions(bucket, request, headers, runtime);
        }

        public async Task<CompleteBucketWormResponse> CompleteBucketWormAsync(string bucket, CompleteBucketWormRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CompleteBucketWormWithOptionsAsync(bucket, request, headers, runtime);
        }

        public CompleteBucketWormResponse CompleteBucketWormWithOptions(string bucket, CompleteBucketWormRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WormId))
            {
                query["wormId"] = request.WormId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteBucketWorm",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<CompleteBucketWormResponse>(Execute(params_, req, runtime));
        }

        public async Task<CompleteBucketWormResponse> CompleteBucketWormWithOptionsAsync(string bucket, CompleteBucketWormRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WormId))
            {
                query["wormId"] = request.WormId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteBucketWorm",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<CompleteBucketWormResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CompleteMultipartUploadResponse CompleteMultipartUpload(string bucket, string key, CompleteMultipartUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CompleteMultipartUploadHeaders headers = new CompleteMultipartUploadHeaders();
            return CompleteMultipartUploadWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(string bucket, string key, CompleteMultipartUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CompleteMultipartUploadHeaders headers = new CompleteMultipartUploadHeaders();
            return await CompleteMultipartUploadWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public CompleteMultipartUploadResponse CompleteMultipartUploadWithOptions(string bucket, string key, CompleteMultipartUploadRequest request, CompleteMultipartUploadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingType))
            {
                query["encoding-type"] = request.EncodingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                query["uploadId"] = request.UploadId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompleteMultipartUpload.ToMap()))
            {
                body["completeMultipartUpload"] = request.CompleteMultipartUpload;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CompleteAll))
            {
                realHeaders["x-oss-complete-all"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CompleteAll);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ForbidOverwrite))
            {
                realHeaders["x-oss-forbid-overwrite"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ForbidOverwrite);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteMultipartUpload",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<CompleteMultipartUploadResponse>(Execute(params_, req, runtime));
        }

        public async Task<CompleteMultipartUploadResponse> CompleteMultipartUploadWithOptionsAsync(string bucket, string key, CompleteMultipartUploadRequest request, CompleteMultipartUploadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingType))
            {
                query["encoding-type"] = request.EncodingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                query["uploadId"] = request.UploadId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompleteMultipartUpload.ToMap()))
            {
                body["completeMultipartUpload"] = request.CompleteMultipartUpload;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CompleteAll))
            {
                realHeaders["x-oss-complete-all"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CompleteAll);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ForbidOverwrite))
            {
                realHeaders["x-oss-forbid-overwrite"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ForbidOverwrite);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteMultipartUpload",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<CompleteMultipartUploadResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CopyObjectResponse CopyObject(string bucket, string key)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyObjectHeaders headers = new CopyObjectHeaders();
            return CopyObjectWithOptions(bucket, key, headers, runtime);
        }

        public async Task<CopyObjectResponse> CopyObjectAsync(string bucket, string key)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyObjectHeaders headers = new CopyObjectHeaders();
            return await CopyObjectWithOptionsAsync(bucket, key, headers, runtime);
        }

        public CopyObjectResponse CopyObjectWithOptions(string bucket, string key, CopyObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySource))
            {
                realHeaders["x-oss-copy-source"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySource);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfMatch))
            {
                realHeaders["x-oss-copy-source-if-match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfModifiedSince))
            {
                realHeaders["x-oss-copy-source-if-modified-since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfModifiedSince);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfNoneMatch))
            {
                realHeaders["x-oss-copy-source-if-none-match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfNoneMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfUnmodifiedSince))
            {
                realHeaders["x-oss-copy-source-if-unmodified-since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfUnmodifiedSince);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ForbidOverwrite))
            {
                realHeaders["x-oss-forbid-overwrite"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ForbidOverwrite);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.MetaData))
            {
                realHeaders["x-oss-meta-*"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.MetaData);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.MetadataDirective))
            {
                realHeaders["x-oss-metadata-directive"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.MetadataDirective);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Acl))
            {
                realHeaders["x-oss-object-acl"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Acl);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServerSideEncryption))
            {
                realHeaders["x-oss-server-side-encryption"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServerSideEncryption);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.SseKeyId))
            {
                realHeaders["x-oss-server-side-encryption-key-id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.SseKeyId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.StorageClass))
            {
                realHeaders["x-oss-storage-class"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.StorageClass);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Tagging))
            {
                realHeaders["x-oss-tagging"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Tagging);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.TaggingDirective))
            {
                realHeaders["x-oss-tagging-directive"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.TaggingDirective);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<CopyObjectResponse>(Execute(params_, req, runtime));
        }

        public async Task<CopyObjectResponse> CopyObjectWithOptionsAsync(string bucket, string key, CopyObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySource))
            {
                realHeaders["x-oss-copy-source"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySource);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfMatch))
            {
                realHeaders["x-oss-copy-source-if-match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfModifiedSince))
            {
                realHeaders["x-oss-copy-source-if-modified-since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfModifiedSince);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfNoneMatch))
            {
                realHeaders["x-oss-copy-source-if-none-match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfNoneMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfUnmodifiedSince))
            {
                realHeaders["x-oss-copy-source-if-unmodified-since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfUnmodifiedSince);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ForbidOverwrite))
            {
                realHeaders["x-oss-forbid-overwrite"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ForbidOverwrite);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.MetaData))
            {
                realHeaders["x-oss-meta-*"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.MetaData);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.MetadataDirective))
            {
                realHeaders["x-oss-metadata-directive"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.MetadataDirective);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Acl))
            {
                realHeaders["x-oss-object-acl"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Acl);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServerSideEncryption))
            {
                realHeaders["x-oss-server-side-encryption"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServerSideEncryption);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.SseKeyId))
            {
                realHeaders["x-oss-server-side-encryption-key-id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.SseKeyId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.StorageClass))
            {
                realHeaders["x-oss-storage-class"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.StorageClass);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Tagging))
            {
                realHeaders["x-oss-tagging"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Tagging);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.TaggingDirective))
            {
                realHeaders["x-oss-tagging-directive"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.TaggingDirective);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<CopyObjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateSelectObjectMetaResponse CreateSelectObjectMeta(string bucket, string key, CreateSelectObjectMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSelectObjectMetaWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<CreateSelectObjectMetaResponse> CreateSelectObjectMetaAsync(string bucket, string key, CreateSelectObjectMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSelectObjectMetaWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public CreateSelectObjectMetaResponse CreateSelectObjectMetaWithOptions(string bucket, string key, CreateSelectObjectMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.SelectMetaRequest.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSelectObjectMeta",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSelectObjectMetaResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateSelectObjectMetaResponse> CreateSelectObjectMetaWithOptionsAsync(string bucket, string key, CreateSelectObjectMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.SelectMetaRequest.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSelectObjectMeta",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSelectObjectMetaResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteBucketResponse DeleteBucket(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBucketWithOptions(bucket, headers, runtime);
        }

        public async Task<DeleteBucketResponse> DeleteBucketAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBucketWithOptionsAsync(bucket, headers, runtime);
        }

        public DeleteBucketResponse DeleteBucketWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucket",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteBucketResponse> DeleteBucketWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucket",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteBucketCorsResponse DeleteBucketCors(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBucketCorsWithOptions(bucket, headers, runtime);
        }

        public async Task<DeleteBucketCorsResponse> DeleteBucketCorsAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBucketCorsWithOptionsAsync(bucket, headers, runtime);
        }

        public DeleteBucketCorsResponse DeleteBucketCorsWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketCors",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?cors",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketCorsResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteBucketCorsResponse> DeleteBucketCorsWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketCors",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?cors",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketCorsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteBucketEncryptionResponse DeleteBucketEncryption(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBucketEncryptionWithOptions(bucket, headers, runtime);
        }

        public async Task<DeleteBucketEncryptionResponse> DeleteBucketEncryptionAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBucketEncryptionWithOptionsAsync(bucket, headers, runtime);
        }

        public DeleteBucketEncryptionResponse DeleteBucketEncryptionWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketEncryption",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?encryption",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketEncryptionResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteBucketEncryptionResponse> DeleteBucketEncryptionWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketEncryption",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?encryption",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketEncryptionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteBucketInventoryResponse DeleteBucketInventory(string bucket, DeleteBucketInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBucketInventoryWithOptions(bucket, request, headers, runtime);
        }

        public async Task<DeleteBucketInventoryResponse> DeleteBucketInventoryAsync(string bucket, DeleteBucketInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBucketInventoryWithOptionsAsync(bucket, request, headers, runtime);
        }

        public DeleteBucketInventoryResponse DeleteBucketInventoryWithOptions(string bucket, DeleteBucketInventoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InventoryId))
            {
                query["inventoryId"] = request.InventoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketInventory",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?inventory",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketInventoryResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteBucketInventoryResponse> DeleteBucketInventoryWithOptionsAsync(string bucket, DeleteBucketInventoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InventoryId))
            {
                query["inventoryId"] = request.InventoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketInventory",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?inventory",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketInventoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteBucketLifecycleResponse DeleteBucketLifecycle(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBucketLifecycleWithOptions(bucket, headers, runtime);
        }

        public async Task<DeleteBucketLifecycleResponse> DeleteBucketLifecycleAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBucketLifecycleWithOptionsAsync(bucket, headers, runtime);
        }

        public DeleteBucketLifecycleResponse DeleteBucketLifecycleWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketLifecycle",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?lifecycle",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketLifecycleResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteBucketLifecycleResponse> DeleteBucketLifecycleWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketLifecycle",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?lifecycle",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketLifecycleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteBucketLoggingResponse DeleteBucketLogging(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBucketLoggingWithOptions(bucket, headers, runtime);
        }

        public async Task<DeleteBucketLoggingResponse> DeleteBucketLoggingAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBucketLoggingWithOptionsAsync(bucket, headers, runtime);
        }

        public DeleteBucketLoggingResponse DeleteBucketLoggingWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketLogging",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?logging",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketLoggingResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteBucketLoggingResponse> DeleteBucketLoggingWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketLogging",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?logging",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketLoggingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteBucketPolicyResponse DeleteBucketPolicy(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBucketPolicyWithOptions(bucket, headers, runtime);
        }

        public async Task<DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBucketPolicyWithOptionsAsync(bucket, headers, runtime);
        }

        public DeleteBucketPolicyResponse DeleteBucketPolicyWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketPolicy",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?policy",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketPolicyResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteBucketPolicyResponse> DeleteBucketPolicyWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketPolicy",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?policy",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketPolicyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteBucketReplicationResponse DeleteBucketReplication(string bucket, DeleteBucketReplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBucketReplicationWithOptions(bucket, request, headers, runtime);
        }

        public async Task<DeleteBucketReplicationResponse> DeleteBucketReplicationAsync(string bucket, DeleteBucketReplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBucketReplicationWithOptionsAsync(bucket, request, headers, runtime);
        }

        public DeleteBucketReplicationResponse DeleteBucketReplicationWithOptions(string bucket, DeleteBucketReplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketReplication",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?replication&comp=delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketReplicationResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteBucketReplicationResponse> DeleteBucketReplicationWithOptionsAsync(string bucket, DeleteBucketReplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketReplication",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?replication&comp=delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketReplicationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteBucketTagsResponse DeleteBucketTags(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBucketTagsWithOptions(bucket, headers, runtime);
        }

        public async Task<DeleteBucketTagsResponse> DeleteBucketTagsAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBucketTagsWithOptionsAsync(bucket, headers, runtime);
        }

        public DeleteBucketTagsResponse DeleteBucketTagsWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketTags",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?tagging",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketTagsResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteBucketTagsResponse> DeleteBucketTagsWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketTags",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?tagging",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketTagsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteBucketWebsiteResponse DeleteBucketWebsite(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBucketWebsiteWithOptions(bucket, headers, runtime);
        }

        public async Task<DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBucketWebsiteWithOptionsAsync(bucket, headers, runtime);
        }

        public DeleteBucketWebsiteResponse DeleteBucketWebsiteWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketWebsite",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?website",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketWebsiteResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteBucketWebsiteResponse> DeleteBucketWebsiteWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBucketWebsite",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?website",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteBucketWebsiteResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteLiveChannelResponse DeleteLiveChannel(string bucket, string channel)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLiveChannelWithOptions(bucket, channel, headers, runtime);
        }

        public async Task<DeleteLiveChannelResponse> DeleteLiveChannelAsync(string bucket, string channel)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLiveChannelWithOptionsAsync(bucket, channel, headers, runtime);
        }

        public DeleteLiveChannelResponse DeleteLiveChannelWithOptions(string bucket, string channel, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLiveChannel",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "?live",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteLiveChannelResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteLiveChannelResponse> DeleteLiveChannelWithOptionsAsync(string bucket, string channel, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLiveChannel",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "?live",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteLiveChannelResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteMultipleObjectsResponse DeleteMultipleObjects(string bucket, DeleteMultipleObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMultipleObjectsWithOptions(bucket, request, headers, runtime);
        }

        public async Task<DeleteMultipleObjectsResponse> DeleteMultipleObjectsAsync(string bucket, DeleteMultipleObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMultipleObjectsWithOptionsAsync(bucket, request, headers, runtime);
        }

        public DeleteMultipleObjectsResponse DeleteMultipleObjectsWithOptions(string bucket, DeleteMultipleObjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingType))
            {
                query["encoding-type"] = request.EncodingType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Delete.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMultipleObjects",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteMultipleObjectsResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteMultipleObjectsResponse> DeleteMultipleObjectsWithOptionsAsync(string bucket, DeleteMultipleObjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingType))
            {
                query["encoding-type"] = request.EncodingType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Delete.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMultipleObjects",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteMultipleObjectsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteObjectResponse DeleteObject(string bucket, string key, DeleteObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteObjectWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<DeleteObjectResponse> DeleteObjectAsync(string bucket, string key, DeleteObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteObjectWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public DeleteObjectResponse DeleteObjectWithOptions(string bucket, string key, DeleteObjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteObjectResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteObjectResponse> DeleteObjectWithOptionsAsync(string bucket, string key, DeleteObjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteObjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteObjectTaggingResponse DeleteObjectTagging(string bucket, string key, DeleteObjectTaggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteObjectTaggingWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<DeleteObjectTaggingResponse> DeleteObjectTaggingAsync(string bucket, string key, DeleteObjectTaggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteObjectTaggingWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public DeleteObjectTaggingResponse DeleteObjectTaggingWithOptions(string bucket, string key, DeleteObjectTaggingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteObjectTagging",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?tagging",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteObjectTaggingResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteObjectTaggingResponse> DeleteObjectTaggingWithOptionsAsync(string bucket, string key, DeleteObjectTaggingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteObjectTagging",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?tagging",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DeleteObjectTaggingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionsWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["regions"] = request.Regions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(Execute(params_, req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["regions"] = request.Regions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ExtendBucketWormResponse ExtendBucketWorm(string bucket, ExtendBucketWormRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExtendBucketWormWithOptions(bucket, request, headers, runtime);
        }

        public async Task<ExtendBucketWormResponse> ExtendBucketWormAsync(string bucket, ExtendBucketWormRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExtendBucketWormWithOptionsAsync(bucket, request, headers, runtime);
        }

        public ExtendBucketWormResponse ExtendBucketWormWithOptions(string bucket, ExtendBucketWormRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WormId))
            {
                query["wormId"] = request.WormId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendWormConfiguration.ToMap()))
            {
                body["extendWormConfiguration"] = request.ExtendWormConfiguration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExtendBucketWorm",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?wormExtend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ExtendBucketWormResponse>(Execute(params_, req, runtime));
        }

        public async Task<ExtendBucketWormResponse> ExtendBucketWormWithOptionsAsync(string bucket, ExtendBucketWormRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WormId))
            {
                query["wormId"] = request.WormId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendWormConfiguration.ToMap()))
            {
                body["extendWormConfiguration"] = request.ExtendWormConfiguration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExtendBucketWorm",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?wormExtend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ExtendBucketWormResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketAclResponse GetBucketAcl(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketAclWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketAclResponse> GetBucketAclAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketAclWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketAclResponse GetBucketAclWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketAcl",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?acl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketAclResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketAclResponse> GetBucketAclWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketAcl",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?acl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketAclResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketCorsResponse GetBucketCors(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketCorsWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketCorsResponse> GetBucketCorsAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketCorsWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketCorsResponse GetBucketCorsWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketCors",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?cors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketCorsResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketCorsResponse> GetBucketCorsWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketCors",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?cors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketCorsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketEncryptionResponse GetBucketEncryption(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketEncryptionWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketEncryptionResponse> GetBucketEncryptionAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketEncryptionWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketEncryptionResponse GetBucketEncryptionWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketEncryption",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?encryption",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketEncryptionResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketEncryptionResponse> GetBucketEncryptionWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketEncryption",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?encryption",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketEncryptionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketInfoResponse GetBucketInfo(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketInfoWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketInfoResponse> GetBucketInfoAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketInfoWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketInfoResponse GetBucketInfoWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketInfo",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?bucketInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketInfoResponse> GetBucketInfoWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketInfo",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?bucketInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketInventoryResponse GetBucketInventory(string bucket, GetBucketInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketInventoryWithOptions(bucket, request, headers, runtime);
        }

        public async Task<GetBucketInventoryResponse> GetBucketInventoryAsync(string bucket, GetBucketInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketInventoryWithOptionsAsync(bucket, request, headers, runtime);
        }

        public GetBucketInventoryResponse GetBucketInventoryWithOptions(string bucket, GetBucketInventoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InventoryId))
            {
                query["inventoryId"] = request.InventoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketInventory",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?inventory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketInventoryResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketInventoryResponse> GetBucketInventoryWithOptionsAsync(string bucket, GetBucketInventoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InventoryId))
            {
                query["inventoryId"] = request.InventoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketInventory",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?inventory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketInventoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketLifecycleResponse GetBucketLifecycle(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketLifecycleWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketLifecycleResponse> GetBucketLifecycleAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketLifecycleWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketLifecycleResponse GetBucketLifecycleWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketLifecycle",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?lifecycle",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketLifecycleResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketLifecycleResponse> GetBucketLifecycleWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketLifecycle",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?lifecycle",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketLifecycleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketLocationResponse GetBucketLocation(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketLocationWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketLocationResponse> GetBucketLocationAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketLocationWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketLocationResponse GetBucketLocationWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketLocation",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?location",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketLocationResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketLocationResponse> GetBucketLocationWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketLocation",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?location",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketLocationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketLoggingResponse GetBucketLogging(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketLoggingWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketLoggingResponse> GetBucketLoggingAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketLoggingWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketLoggingResponse GetBucketLoggingWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketLogging",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?logging",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketLoggingResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketLoggingResponse> GetBucketLoggingWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketLogging",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?logging",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketLoggingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketPolicyResponse GetBucketPolicy(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketPolicyWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketPolicyResponse> GetBucketPolicyAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketPolicyWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketPolicyResponse GetBucketPolicyWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketPolicy",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?policy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GetBucketPolicyResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketPolicyResponse> GetBucketPolicyWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketPolicy",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?policy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GetBucketPolicyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketRefererResponse GetBucketReferer(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketRefererWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketRefererResponse> GetBucketRefererAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketRefererWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketRefererResponse GetBucketRefererWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketReferer",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?referer",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketRefererResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketRefererResponse> GetBucketRefererWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketReferer",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?referer",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketRefererResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketReplicationResponse GetBucketReplication(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketReplicationWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketReplicationResponse> GetBucketReplicationAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketReplicationWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketReplicationResponse GetBucketReplicationWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketReplication",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?replication",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketReplicationResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketReplicationResponse> GetBucketReplicationWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketReplication",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?replication",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketReplicationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketReplicationLocationResponse GetBucketReplicationLocation(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketReplicationLocationWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketReplicationLocationResponse> GetBucketReplicationLocationAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketReplicationLocationWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketReplicationLocationResponse GetBucketReplicationLocationWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketReplicationLocation",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?replicationLocation",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketReplicationLocationResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketReplicationLocationResponse> GetBucketReplicationLocationWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketReplicationLocation",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?replicationLocation",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketReplicationLocationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketReplicationProgressResponse GetBucketReplicationProgress(string bucket, GetBucketReplicationProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketReplicationProgressWithOptions(bucket, request, headers, runtime);
        }

        public async Task<GetBucketReplicationProgressResponse> GetBucketReplicationProgressAsync(string bucket, GetBucketReplicationProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketReplicationProgressWithOptionsAsync(bucket, request, headers, runtime);
        }

        public GetBucketReplicationProgressResponse GetBucketReplicationProgressWithOptions(string bucket, GetBucketReplicationProgressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["rule-id"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketReplicationProgress",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?replicationProgress",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketReplicationProgressResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketReplicationProgressResponse> GetBucketReplicationProgressWithOptionsAsync(string bucket, GetBucketReplicationProgressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["rule-id"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketReplicationProgress",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?replicationProgress",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketReplicationProgressResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketRequestPaymentResponse GetBucketRequestPayment(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketRequestPaymentWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketRequestPaymentWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketRequestPaymentResponse GetBucketRequestPaymentWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketRequestPayment",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?requestPayment",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketRequestPaymentResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketRequestPaymentResponse> GetBucketRequestPaymentWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketRequestPayment",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?requestPayment",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketRequestPaymentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketTagsResponse GetBucketTags(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketTagsWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketTagsResponse> GetBucketTagsAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketTagsWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketTagsResponse GetBucketTagsWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketTags",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?tagging",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketTagsResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketTagsResponse> GetBucketTagsWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketTags",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?tagging",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketTagsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketTransferAccelerationResponse GetBucketTransferAcceleration(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketTransferAccelerationWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketTransferAccelerationResponse> GetBucketTransferAccelerationAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketTransferAccelerationWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketTransferAccelerationResponse GetBucketTransferAccelerationWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketTransferAcceleration",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?transferAcceleration",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketTransferAccelerationResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketTransferAccelerationResponse> GetBucketTransferAccelerationWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketTransferAcceleration",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?transferAcceleration",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketTransferAccelerationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketVersioningResponse GetBucketVersioning(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketVersioningWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketVersioningResponse> GetBucketVersioningAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketVersioningWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketVersioningResponse GetBucketVersioningWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketVersioning",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?versioning",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketVersioningResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketVersioningResponse> GetBucketVersioningWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketVersioning",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?versioning",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketVersioningResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketWebsiteResponse GetBucketWebsite(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketWebsiteWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketWebsiteResponse> GetBucketWebsiteAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketWebsiteWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketWebsiteResponse GetBucketWebsiteWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketWebsite",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?website",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketWebsiteResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketWebsiteResponse> GetBucketWebsiteWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketWebsite",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?website",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketWebsiteResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetBucketWormResponse GetBucketWorm(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBucketWormWithOptions(bucket, headers, runtime);
        }

        public async Task<GetBucketWormResponse> GetBucketWormAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBucketWormWithOptionsAsync(bucket, headers, runtime);
        }

        public GetBucketWormResponse GetBucketWormWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketWorm",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?worm",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketWormResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetBucketWormResponse> GetBucketWormWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBucketWorm",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?worm",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetBucketWormResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetLiveChannelHistoryResponse GetLiveChannelHistory(string bucket, string channel)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLiveChannelHistoryWithOptions(bucket, channel, headers, runtime);
        }

        public async Task<GetLiveChannelHistoryResponse> GetLiveChannelHistoryAsync(string bucket, string channel)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLiveChannelHistoryWithOptionsAsync(bucket, channel, headers, runtime);
        }

        public GetLiveChannelHistoryResponse GetLiveChannelHistoryWithOptions(string bucket, string channel, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveChannelHistory",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "?live&comp=history",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetLiveChannelHistoryResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetLiveChannelHistoryResponse> GetLiveChannelHistoryWithOptionsAsync(string bucket, string channel, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveChannelHistory",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "?live&comp=history",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetLiveChannelHistoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetLiveChannelInfoResponse GetLiveChannelInfo(string bucket, string channel)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLiveChannelInfoWithOptions(bucket, channel, headers, runtime);
        }

        public async Task<GetLiveChannelInfoResponse> GetLiveChannelInfoAsync(string bucket, string channel)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLiveChannelInfoWithOptionsAsync(bucket, channel, headers, runtime);
        }

        public GetLiveChannelInfoResponse GetLiveChannelInfoWithOptions(string bucket, string channel, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveChannelInfo",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "?live",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetLiveChannelInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetLiveChannelInfoResponse> GetLiveChannelInfoWithOptionsAsync(string bucket, string channel, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveChannelInfo",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "?live",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetLiveChannelInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetLiveChannelStatResponse GetLiveChannelStat(string bucket, string channel)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLiveChannelStatWithOptions(bucket, channel, headers, runtime);
        }

        public async Task<GetLiveChannelStatResponse> GetLiveChannelStatAsync(string bucket, string channel)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLiveChannelStatWithOptionsAsync(bucket, channel, headers, runtime);
        }

        public GetLiveChannelStatResponse GetLiveChannelStatWithOptions(string bucket, string channel, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveChannelStat",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "?live&comp=stat",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetLiveChannelStatResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetLiveChannelStatResponse> GetLiveChannelStatWithOptionsAsync(string bucket, string channel, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveChannelStat",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "?live&comp=stat",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetLiveChannelStatResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetObjectResponse GetObject(string bucket, string key, GetObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetObjectHeaders headers = new GetObjectHeaders();
            return GetObjectWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<GetObjectResponse> GetObjectAsync(string bucket, string key, GetObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetObjectHeaders headers = new GetObjectHeaders();
            return await GetObjectWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public GetObjectResponse GetObjectWithOptions(string bucket, string key, GetObjectRequest request, GetObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseCacheControl))
            {
                query["response-cache-control"] = request.ResponseCacheControl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseContentDisposition))
            {
                query["response-content-disposition"] = request.ResponseContentDisposition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseContentEncoding))
            {
                query["response-content-encoding"] = request.ResponseContentEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseContentLanguage))
            {
                query["response-content-language"] = request.ResponseContentLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseContentType))
            {
                query["response-content-type"] = request.ResponseContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseExpires))
            {
                query["response-expires"] = request.ResponseExpires;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AcceptEncoding))
            {
                realHeaders["Accept-Encoding"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AcceptEncoding);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfModifiedSince))
            {
                realHeaders["If-Modified-Since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfModifiedSince);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfNoneMatch))
            {
                realHeaders["If-None-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfNoneMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfUnmodifiedSince))
            {
                realHeaders["If-Unmodified-Since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfUnmodifiedSince);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Range))
            {
                realHeaders["Range"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Range);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "binary",
            };
            return TeaModel.ToObject<GetObjectResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetObjectResponse> GetObjectWithOptionsAsync(string bucket, string key, GetObjectRequest request, GetObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseCacheControl))
            {
                query["response-cache-control"] = request.ResponseCacheControl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseContentDisposition))
            {
                query["response-content-disposition"] = request.ResponseContentDisposition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseContentEncoding))
            {
                query["response-content-encoding"] = request.ResponseContentEncoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseContentLanguage))
            {
                query["response-content-language"] = request.ResponseContentLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseContentType))
            {
                query["response-content-type"] = request.ResponseContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseExpires))
            {
                query["response-expires"] = request.ResponseExpires;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AcceptEncoding))
            {
                realHeaders["Accept-Encoding"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AcceptEncoding);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfModifiedSince))
            {
                realHeaders["If-Modified-Since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfModifiedSince);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfNoneMatch))
            {
                realHeaders["If-None-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfNoneMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfUnmodifiedSince))
            {
                realHeaders["If-Unmodified-Since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfUnmodifiedSince);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Range))
            {
                realHeaders["Range"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Range);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "binary",
            };
            return TeaModel.ToObject<GetObjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetObjectAclResponse GetObjectAcl(string bucket, string key, GetObjectAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetObjectAclWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<GetObjectAclResponse> GetObjectAclAsync(string bucket, string key, GetObjectAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetObjectAclWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public GetObjectAclResponse GetObjectAclWithOptions(string bucket, string key, GetObjectAclRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetObjectAcl",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?acl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetObjectAclResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetObjectAclResponse> GetObjectAclWithOptionsAsync(string bucket, string key, GetObjectAclRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetObjectAcl",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?acl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetObjectAclResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetObjectMetaResponse GetObjectMeta(string bucket, string key, GetObjectMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetObjectMetaWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<GetObjectMetaResponse> GetObjectMetaAsync(string bucket, string key, GetObjectMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetObjectMetaWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public GetObjectMetaResponse GetObjectMetaWithOptions(string bucket, string key, GetObjectMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetObjectMeta",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?objectMeta",
                Method = "HEAD",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "none",
            };
            return TeaModel.ToObject<GetObjectMetaResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetObjectMetaResponse> GetObjectMetaWithOptionsAsync(string bucket, string key, GetObjectMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetObjectMeta",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?objectMeta",
                Method = "HEAD",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "none",
            };
            return TeaModel.ToObject<GetObjectMetaResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetObjectTaggingResponse GetObjectTagging(string bucket, string key, GetObjectTaggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetObjectTaggingWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<GetObjectTaggingResponse> GetObjectTaggingAsync(string bucket, string key, GetObjectTaggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetObjectTaggingWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public GetObjectTaggingResponse GetObjectTaggingWithOptions(string bucket, string key, GetObjectTaggingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetObjectTagging",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?tagging",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetObjectTaggingResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetObjectTaggingResponse> GetObjectTaggingWithOptionsAsync(string bucket, string key, GetObjectTaggingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetObjectTagging",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?tagging",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetObjectTaggingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetSymlinkResponse GetSymlink(string bucket, string key, GetSymlinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSymlinkWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<GetSymlinkResponse> GetSymlinkAsync(string bucket, string key, GetSymlinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSymlinkWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public GetSymlinkResponse GetSymlinkWithOptions(string bucket, string key, GetSymlinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSymlink",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?symlink",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetSymlinkResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetSymlinkResponse> GetSymlinkWithOptionsAsync(string bucket, string key, GetSymlinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSymlink",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?symlink",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<GetSymlinkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetVodPlaylistResponse GetVodPlaylist(string bucket, string channel, GetVodPlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetVodPlaylistWithOptions(bucket, channel, request, headers, runtime);
        }

        public async Task<GetVodPlaylistResponse> GetVodPlaylistAsync(string bucket, string channel, GetVodPlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetVodPlaylistWithOptionsAsync(bucket, channel, request, headers, runtime);
        }

        public GetVodPlaylistResponse GetVodPlaylistWithOptions(string bucket, string channel, GetVodPlaylistRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVodPlaylist",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "?vod",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "binary",
            };
            return TeaModel.ToObject<GetVodPlaylistResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetVodPlaylistResponse> GetVodPlaylistWithOptionsAsync(string bucket, string channel, GetVodPlaylistRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVodPlaylist",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "?vod",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "binary",
            };
            return TeaModel.ToObject<GetVodPlaylistResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public HeadObjectResponse HeadObject(string bucket, string key, HeadObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HeadObjectHeaders headers = new HeadObjectHeaders();
            return HeadObjectWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<HeadObjectResponse> HeadObjectAsync(string bucket, string key, HeadObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HeadObjectHeaders headers = new HeadObjectHeaders();
            return await HeadObjectWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public HeadObjectResponse HeadObjectWithOptions(string bucket, string key, HeadObjectRequest request, HeadObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfModifiedSince))
            {
                realHeaders["If-Modified-Since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfModifiedSince);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfNoneMatch))
            {
                realHeaders["If-None-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfNoneMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfUnmodifiedSince))
            {
                realHeaders["If-Unmodified-Since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfUnmodifiedSince);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HeadObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "HEAD",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "none",
            };
            return TeaModel.ToObject<HeadObjectResponse>(Execute(params_, req, runtime));
        }

        public async Task<HeadObjectResponse> HeadObjectWithOptionsAsync(string bucket, string key, HeadObjectRequest request, HeadObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfModifiedSince))
            {
                realHeaders["If-Modified-Since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfModifiedSince);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfNoneMatch))
            {
                realHeaders["If-None-Match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfNoneMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfUnmodifiedSince))
            {
                realHeaders["If-Unmodified-Since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.IfUnmodifiedSince);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HeadObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "HEAD",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "none",
            };
            return TeaModel.ToObject<HeadObjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public InitiateBucketWormResponse InitiateBucketWorm(string bucket, InitiateBucketWormRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InitiateBucketWormWithOptions(bucket, request, headers, runtime);
        }

        public async Task<InitiateBucketWormResponse> InitiateBucketWormAsync(string bucket, InitiateBucketWormRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InitiateBucketWormWithOptionsAsync(bucket, request, headers, runtime);
        }

        public InitiateBucketWormResponse InitiateBucketWormWithOptions(string bucket, InitiateBucketWormRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.InitiateWormConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitiateBucketWorm",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?worm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<InitiateBucketWormResponse>(Execute(params_, req, runtime));
        }

        public async Task<InitiateBucketWormResponse> InitiateBucketWormWithOptionsAsync(string bucket, InitiateBucketWormRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.InitiateWormConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitiateBucketWorm",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?worm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<InitiateBucketWormResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public InitiateMultipartUploadResponse InitiateMultipartUpload(string bucket, string key, InitiateMultipartUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitiateMultipartUploadHeaders headers = new InitiateMultipartUploadHeaders();
            return InitiateMultipartUploadWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(string bucket, string key, InitiateMultipartUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InitiateMultipartUploadHeaders headers = new InitiateMultipartUploadHeaders();
            return await InitiateMultipartUploadWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public InitiateMultipartUploadResponse InitiateMultipartUploadWithOptions(string bucket, string key, InitiateMultipartUploadRequest request, InitiateMultipartUploadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingType))
            {
                query["encoding-type"] = request.EncodingType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CacheControl))
            {
                realHeaders["Cache-Control"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CacheControl);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ContentDisposition))
            {
                realHeaders["Content-Disposition"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ContentDisposition);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ContentEncoding))
            {
                realHeaders["Content-Encoding"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ContentEncoding);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Expires))
            {
                realHeaders["Expires"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Expires);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ForbidOverwrite))
            {
                realHeaders["x-oss-forbid-overwrite"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ForbidOverwrite);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.SseDataEncryption))
            {
                realHeaders["x-oss-server-side-data-encryption"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.SseDataEncryption);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServerSideEncryption))
            {
                realHeaders["x-oss-server-side-encryption"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServerSideEncryption);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.SseKeyId))
            {
                realHeaders["x-oss-server-side-encryption-key-id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.SseKeyId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.StorageClass))
            {
                realHeaders["x-oss-storage-class"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.StorageClass);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Tagging))
            {
                realHeaders["x-oss-tagging"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Tagging);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitiateMultipartUpload",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?uploads",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<InitiateMultipartUploadResponse>(Execute(params_, req, runtime));
        }

        public async Task<InitiateMultipartUploadResponse> InitiateMultipartUploadWithOptionsAsync(string bucket, string key, InitiateMultipartUploadRequest request, InitiateMultipartUploadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingType))
            {
                query["encoding-type"] = request.EncodingType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CacheControl))
            {
                realHeaders["Cache-Control"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CacheControl);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ContentDisposition))
            {
                realHeaders["Content-Disposition"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ContentDisposition);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ContentEncoding))
            {
                realHeaders["Content-Encoding"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ContentEncoding);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Expires))
            {
                realHeaders["Expires"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Expires);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ForbidOverwrite))
            {
                realHeaders["x-oss-forbid-overwrite"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ForbidOverwrite);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.SseDataEncryption))
            {
                realHeaders["x-oss-server-side-data-encryption"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.SseDataEncryption);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServerSideEncryption))
            {
                realHeaders["x-oss-server-side-encryption"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServerSideEncryption);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.SseKeyId))
            {
                realHeaders["x-oss-server-side-encryption-key-id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.SseKeyId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.StorageClass))
            {
                realHeaders["x-oss-storage-class"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.StorageClass);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Tagging))
            {
                realHeaders["x-oss-tagging"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Tagging);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitiateMultipartUpload",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?uploads",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<InitiateMultipartUploadResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListBucketInventoryResponse ListBucketInventory(string bucket, ListBucketInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListBucketInventoryWithOptions(bucket, request, headers, runtime);
        }

        public async Task<ListBucketInventoryResponse> ListBucketInventoryAsync(string bucket, ListBucketInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListBucketInventoryWithOptionsAsync(bucket, request, headers, runtime);
        }

        public ListBucketInventoryResponse ListBucketInventoryWithOptions(string bucket, ListBucketInventoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContinuationToken))
            {
                query["continuation-token"] = request.ContinuationToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBucketInventory",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?inventory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListBucketInventoryResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListBucketInventoryResponse> ListBucketInventoryWithOptionsAsync(string bucket, ListBucketInventoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContinuationToken))
            {
                query["continuation-token"] = request.ContinuationToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBucketInventory",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?inventory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListBucketInventoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListBucketsResponse ListBuckets(ListBucketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListBucketsWithOptions(request, headers, runtime);
        }

        public async Task<ListBucketsResponse> ListBucketsAsync(ListBucketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListBucketsWithOptionsAsync(request, headers, runtime);
        }

        public ListBucketsResponse ListBucketsWithOptions(ListBucketsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["max-keys"] = request.MaxKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBuckets",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListBucketsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListBucketsResponse> ListBucketsWithOptionsAsync(ListBucketsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["max-keys"] = request.MaxKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBuckets",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListBucketsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListLiveChannelResponse ListLiveChannel(string bucket, ListLiveChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLiveChannelWithOptions(bucket, request, headers, runtime);
        }

        public async Task<ListLiveChannelResponse> ListLiveChannelAsync(string bucket, ListLiveChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLiveChannelWithOptionsAsync(bucket, request, headers, runtime);
        }

        public ListLiveChannelResponse ListLiveChannelWithOptions(string bucket, ListLiveChannelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["max-keys"] = request.MaxKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveChannel",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?live",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListLiveChannelResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListLiveChannelResponse> ListLiveChannelWithOptionsAsync(string bucket, ListLiveChannelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["max-keys"] = request.MaxKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveChannel",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?live",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListLiveChannelResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListMultipartUploadsResponse ListMultipartUploads(string bucket, ListMultipartUploadsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMultipartUploadsWithOptions(bucket, request, headers, runtime);
        }

        public async Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(string bucket, ListMultipartUploadsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMultipartUploadsWithOptionsAsync(bucket, request, headers, runtime);
        }

        public ListMultipartUploadsResponse ListMultipartUploadsWithOptions(string bucket, ListMultipartUploadsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delimiter))
            {
                query["delimiter"] = request.Delimiter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingType))
            {
                query["encoding-type"] = request.EncodingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyMarker))
            {
                query["key-marker"] = request.KeyMarker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxUploads))
            {
                query["max-uploads"] = request.MaxUploads;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadIdMarker))
            {
                query["upload-id-marker"] = request.UploadIdMarker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMultipartUploads",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?uploads",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListMultipartUploadsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListMultipartUploadsResponse> ListMultipartUploadsWithOptionsAsync(string bucket, ListMultipartUploadsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delimiter))
            {
                query["delimiter"] = request.Delimiter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingType))
            {
                query["encoding-type"] = request.EncodingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyMarker))
            {
                query["key-marker"] = request.KeyMarker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxUploads))
            {
                query["max-uploads"] = request.MaxUploads;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadIdMarker))
            {
                query["upload-id-marker"] = request.UploadIdMarker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMultipartUploads",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?uploads",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListMultipartUploadsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListObjectVersionsResponse ListObjectVersions(string bucket, ListObjectVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListObjectVersionsWithOptions(bucket, request, headers, runtime);
        }

        public async Task<ListObjectVersionsResponse> ListObjectVersionsAsync(string bucket, ListObjectVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListObjectVersionsWithOptionsAsync(bucket, request, headers, runtime);
        }

        public ListObjectVersionsResponse ListObjectVersionsWithOptions(string bucket, ListObjectVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delimiter))
            {
                query["delimiter"] = request.Delimiter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingType))
            {
                query["encoding-type"] = request.EncodingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyMarker))
            {
                query["key-marker"] = request.KeyMarker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["max-keys"] = request.MaxKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionIdMarker))
            {
                query["version-id-marker"] = request.VersionIdMarker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListObjectVersions",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListObjectVersionsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListObjectVersionsResponse> ListObjectVersionsWithOptionsAsync(string bucket, ListObjectVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delimiter))
            {
                query["delimiter"] = request.Delimiter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingType))
            {
                query["encoding-type"] = request.EncodingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyMarker))
            {
                query["key-marker"] = request.KeyMarker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["max-keys"] = request.MaxKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionIdMarker))
            {
                query["version-id-marker"] = request.VersionIdMarker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListObjectVersions",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListObjectVersionsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListObjectsResponse ListObjects(string bucket, ListObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListObjectsWithOptions(bucket, request, headers, runtime);
        }

        public async Task<ListObjectsResponse> ListObjectsAsync(string bucket, ListObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListObjectsWithOptionsAsync(bucket, request, headers, runtime);
        }

        public ListObjectsResponse ListObjectsWithOptions(string bucket, ListObjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delimiter))
            {
                query["delimiter"] = request.Delimiter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingType))
            {
                query["encoding-type"] = request.EncodingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["max-keys"] = request.MaxKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListObjects",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListObjectsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListObjectsResponse> ListObjectsWithOptionsAsync(string bucket, ListObjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delimiter))
            {
                query["delimiter"] = request.Delimiter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingType))
            {
                query["encoding-type"] = request.EncodingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["max-keys"] = request.MaxKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListObjects",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListObjectsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListObjectsV2Response ListObjectsV2(string bucket, ListObjectsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListObjectsV2WithOptions(bucket, request, headers, runtime);
        }

        public async Task<ListObjectsV2Response> ListObjectsV2Async(string bucket, ListObjectsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListObjectsV2WithOptionsAsync(bucket, request, headers, runtime);
        }

        public ListObjectsV2Response ListObjectsV2WithOptions(string bucket, ListObjectsV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContinuationToken))
            {
                query["continuation-token"] = request.ContinuationToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delimiter))
            {
                query["delimiter"] = request.Delimiter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingType))
            {
                query["encoding-type"] = request.EncodingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchOwner))
            {
                query["fetch-owner"] = request.FetchOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["max-keys"] = request.MaxKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartAfter))
            {
                query["start-after"] = request.StartAfter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListObjectsV2",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?list-type=2",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListObjectsV2Response>(Execute(params_, req, runtime));
        }

        public async Task<ListObjectsV2Response> ListObjectsV2WithOptionsAsync(string bucket, ListObjectsV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContinuationToken))
            {
                query["continuation-token"] = request.ContinuationToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delimiter))
            {
                query["delimiter"] = request.Delimiter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingType))
            {
                query["encoding-type"] = request.EncodingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchOwner))
            {
                query["fetch-owner"] = request.FetchOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["max-keys"] = request.MaxKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartAfter))
            {
                query["start-after"] = request.StartAfter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListObjectsV2",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?list-type=2",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListObjectsV2Response>(await ExecuteAsync(params_, req, runtime));
        }

        public ListPartsResponse ListParts(string bucket, string key, ListPartsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPartsWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<ListPartsResponse> ListPartsAsync(string bucket, string key, ListPartsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPartsWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public ListPartsResponse ListPartsWithOptions(string bucket, string key, ListPartsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            ListPartsShrinkRequest request = new ListPartsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncodingType))
            {
                request.EncodingTypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncodingType, "encoding-type", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingTypeShrink))
            {
                query["encoding-type"] = request.EncodingTypeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxParts))
            {
                query["max-parts"] = request.MaxParts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartNumberMarker))
            {
                query["part-number-marker"] = request.PartNumberMarker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                query["uploadId"] = request.UploadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListParts",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListPartsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListPartsResponse> ListPartsWithOptionsAsync(string bucket, string key, ListPartsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            ListPartsShrinkRequest request = new ListPartsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncodingType))
            {
                request.EncodingTypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncodingType, "encoding-type", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodingTypeShrink))
            {
                query["encoding-type"] = request.EncodingTypeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxParts))
            {
                query["max-parts"] = request.MaxParts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartNumberMarker))
            {
                query["part-number-marker"] = request.PartNumberMarker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                query["uploadId"] = request.UploadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListParts",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<ListPartsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public OptionObjectResponse OptionObject(string bucket, string key)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OptionObjectHeaders headers = new OptionObjectHeaders();
            return OptionObjectWithOptions(bucket, key, headers, runtime);
        }

        public async Task<OptionObjectResponse> OptionObjectAsync(string bucket, string key)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OptionObjectHeaders headers = new OptionObjectHeaders();
            return await OptionObjectWithOptionsAsync(bucket, key, headers, runtime);
        }

        public OptionObjectResponse OptionObjectWithOptions(string bucket, string key, OptionObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccessControlRequestHeaders))
            {
                realHeaders["Access-Control-Request-Headers"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccessControlRequestHeaders);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccessControlRequestMethod))
            {
                realHeaders["Access-Control-Request-Method"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccessControlRequestMethod);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Origin))
            {
                realHeaders["Origin"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Origin);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OptionObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "OPTIONS",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<OptionObjectResponse>(Execute(params_, req, runtime));
        }

        public async Task<OptionObjectResponse> OptionObjectWithOptionsAsync(string bucket, string key, OptionObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccessControlRequestHeaders))
            {
                realHeaders["Access-Control-Request-Headers"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccessControlRequestHeaders);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AccessControlRequestMethod))
            {
                realHeaders["Access-Control-Request-Method"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AccessControlRequestMethod);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Origin))
            {
                realHeaders["Origin"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Origin);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OptionObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "OPTIONS",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<OptionObjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PostObjectResponse PostObject(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PostObjectWithOptions(bucket, headers, runtime);
        }

        public async Task<PostObjectResponse> PostObjectAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PostObjectWithOptionsAsync(bucket, headers, runtime);
        }

        public PostObjectResponse PostObjectWithOptions(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "multiFormData",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PostObjectResponse>(Execute(params_, req, runtime));
        }

        public async Task<PostObjectResponse> PostObjectWithOptionsAsync(string bucket, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "multiFormData",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PostObjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PostVodPlaylistResponse PostVodPlaylist(string bucket, string channel, string playlist, PostVodPlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PostVodPlaylistWithOptions(bucket, channel, playlist, request, headers, runtime);
        }

        public async Task<PostVodPlaylistResponse> PostVodPlaylistAsync(string bucket, string channel, string playlist, PostVodPlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PostVodPlaylistWithOptionsAsync(bucket, channel, playlist, request, headers, runtime);
        }

        public PostVodPlaylistResponse PostVodPlaylistWithOptions(string bucket, string channel, string playlist, PostVodPlaylistRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostVodPlaylist",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "/" + playlist + "?vod",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PostVodPlaylistResponse>(Execute(params_, req, runtime));
        }

        public async Task<PostVodPlaylistResponse> PostVodPlaylistWithOptionsAsync(string bucket, string channel, string playlist, PostVodPlaylistRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostVodPlaylist",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "/" + playlist + "?vod",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PostVodPlaylistResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutBucketResponse PutBucket(string bucket, PutBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutBucketHeaders headers = new PutBucketHeaders();
            return PutBucketWithOptions(bucket, request, headers, runtime);
        }

        public async Task<PutBucketResponse> PutBucketAsync(string bucket, PutBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutBucketHeaders headers = new PutBucketHeaders();
            return await PutBucketWithOptionsAsync(bucket, request, headers, runtime);
        }

        public PutBucketResponse PutBucketWithOptions(string bucket, PutBucketRequest request, PutBucketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Acl))
            {
                realHeaders["x-oss-acl"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Acl);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.CreateBucketConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucket",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutBucketResponse> PutBucketWithOptionsAsync(string bucket, PutBucketRequest request, PutBucketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Acl))
            {
                realHeaders["x-oss-acl"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Acl);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.CreateBucketConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucket",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutBucketAclResponse PutBucketAcl(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutBucketAclHeaders headers = new PutBucketAclHeaders();
            return PutBucketAclWithOptions(bucket, headers, runtime);
        }

        public async Task<PutBucketAclResponse> PutBucketAclAsync(string bucket)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutBucketAclHeaders headers = new PutBucketAclHeaders();
            return await PutBucketAclWithOptionsAsync(bucket, headers, runtime);
        }

        public PutBucketAclResponse PutBucketAclWithOptions(string bucket, PutBucketAclHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Acl))
            {
                realHeaders["x-oss-acl"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Acl);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketAcl",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?acl",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketAclResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutBucketAclResponse> PutBucketAclWithOptionsAsync(string bucket, PutBucketAclHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Acl))
            {
                realHeaders["x-oss-acl"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Acl);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketAcl",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?acl",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketAclResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutBucketCorsResponse PutBucketCors(string bucket, PutBucketCorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutBucketCorsWithOptions(bucket, request, headers, runtime);
        }

        public async Task<PutBucketCorsResponse> PutBucketCorsAsync(string bucket, PutBucketCorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutBucketCorsWithOptionsAsync(bucket, request, headers, runtime);
        }

        public PutBucketCorsResponse PutBucketCorsWithOptions(string bucket, PutBucketCorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.CORSConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketCors",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?cors",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketCorsResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutBucketCorsResponse> PutBucketCorsWithOptionsAsync(string bucket, PutBucketCorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.CORSConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketCors",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?cors",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketCorsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutBucketEncryptionResponse PutBucketEncryption(string bucket, PutBucketEncryptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutBucketEncryptionWithOptions(bucket, request, headers, runtime);
        }

        public async Task<PutBucketEncryptionResponse> PutBucketEncryptionAsync(string bucket, PutBucketEncryptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutBucketEncryptionWithOptionsAsync(bucket, request, headers, runtime);
        }

        public PutBucketEncryptionResponse PutBucketEncryptionWithOptions(string bucket, PutBucketEncryptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.ServerSideEncryptionRule.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketEncryption",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?encryption",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketEncryptionResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutBucketEncryptionResponse> PutBucketEncryptionWithOptionsAsync(string bucket, PutBucketEncryptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.ServerSideEncryptionRule.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketEncryption",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?encryption",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketEncryptionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutBucketInventoryResponse PutBucketInventory(string bucket, PutBucketInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutBucketInventoryWithOptions(bucket, request, headers, runtime);
        }

        public async Task<PutBucketInventoryResponse> PutBucketInventoryAsync(string bucket, PutBucketInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutBucketInventoryWithOptionsAsync(bucket, request, headers, runtime);
        }

        public PutBucketInventoryResponse PutBucketInventoryWithOptions(string bucket, PutBucketInventoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InventoryId))
            {
                query["inventoryId"] = request.InventoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.InventoryConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketInventory",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?inventory",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketInventoryResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutBucketInventoryResponse> PutBucketInventoryWithOptionsAsync(string bucket, PutBucketInventoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InventoryId))
            {
                query["inventoryId"] = request.InventoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.InventoryConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketInventory",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?inventory",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketInventoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutBucketLifecycleResponse PutBucketLifecycle(string bucket, PutBucketLifecycleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutBucketLifecycleWithOptions(bucket, request, headers, runtime);
        }

        public async Task<PutBucketLifecycleResponse> PutBucketLifecycleAsync(string bucket, PutBucketLifecycleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutBucketLifecycleWithOptionsAsync(bucket, request, headers, runtime);
        }

        public PutBucketLifecycleResponse PutBucketLifecycleWithOptions(string bucket, PutBucketLifecycleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.LifecycleConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketLifecycle",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?lifecycle",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketLifecycleResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutBucketLifecycleResponse> PutBucketLifecycleWithOptionsAsync(string bucket, PutBucketLifecycleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.LifecycleConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketLifecycle",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?lifecycle",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketLifecycleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutBucketLoggingResponse PutBucketLogging(string bucket, PutBucketLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutBucketLoggingWithOptions(bucket, request, headers, runtime);
        }

        public async Task<PutBucketLoggingResponse> PutBucketLoggingAsync(string bucket, PutBucketLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutBucketLoggingWithOptionsAsync(bucket, request, headers, runtime);
        }

        public PutBucketLoggingResponse PutBucketLoggingWithOptions(string bucket, PutBucketLoggingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.BucketLoggingStatus.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketLogging",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?logging",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketLoggingResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutBucketLoggingResponse> PutBucketLoggingWithOptionsAsync(string bucket, PutBucketLoggingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.BucketLoggingStatus.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketLogging",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?logging",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketLoggingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutBucketPolicyResponse PutBucketPolicy(string bucket, PutBucketPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutBucketPolicyWithOptions(bucket, request, headers, runtime);
        }

        public async Task<PutBucketPolicyResponse> PutBucketPolicyAsync(string bucket, PutBucketPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutBucketPolicyWithOptionsAsync(bucket, request, headers, runtime);
        }

        public PutBucketPolicyResponse PutBucketPolicyWithOptions(string bucket, PutBucketPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = request.Policy,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketPolicy",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?policy",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutBucketPolicyResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutBucketPolicyResponse> PutBucketPolicyWithOptionsAsync(string bucket, PutBucketPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = request.Policy,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketPolicy",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?policy",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutBucketPolicyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutBucketRefererResponse PutBucketReferer(string bucket, PutBucketRefererRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutBucketRefererWithOptions(bucket, request, headers, runtime);
        }

        public async Task<PutBucketRefererResponse> PutBucketRefererAsync(string bucket, PutBucketRefererRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutBucketRefererWithOptionsAsync(bucket, request, headers, runtime);
        }

        public PutBucketRefererResponse PutBucketRefererWithOptions(string bucket, PutBucketRefererRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.RefererConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketReferer",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?referer",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketRefererResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutBucketRefererResponse> PutBucketRefererWithOptionsAsync(string bucket, PutBucketRefererRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.RefererConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketReferer",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?referer",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketRefererResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutBucketReplicationResponse PutBucketReplication(string bucket, PutBucketReplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutBucketReplicationWithOptions(bucket, request, headers, runtime);
        }

        public async Task<PutBucketReplicationResponse> PutBucketReplicationAsync(string bucket, PutBucketReplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutBucketReplicationWithOptionsAsync(bucket, request, headers, runtime);
        }

        public PutBucketReplicationResponse PutBucketReplicationWithOptions(string bucket, PutBucketReplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.ReplicationConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketReplication",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?replication&comp=add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketReplicationResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutBucketReplicationResponse> PutBucketReplicationWithOptionsAsync(string bucket, PutBucketReplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.ReplicationConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketReplication",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?replication&comp=add",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketReplicationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutBucketRequestPaymentResponse PutBucketRequestPayment(string bucket, PutBucketRequestPaymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutBucketRequestPaymentWithOptions(bucket, request, headers, runtime);
        }

        public async Task<PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(string bucket, PutBucketRequestPaymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutBucketRequestPaymentWithOptionsAsync(bucket, request, headers, runtime);
        }

        public PutBucketRequestPaymentResponse PutBucketRequestPaymentWithOptions(string bucket, PutBucketRequestPaymentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.RequestPaymentConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketRequestPayment",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?requestPayment",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketRequestPaymentResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutBucketRequestPaymentResponse> PutBucketRequestPaymentWithOptionsAsync(string bucket, PutBucketRequestPaymentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.RequestPaymentConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketRequestPayment",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?requestPayment",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketRequestPaymentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutBucketTagsResponse PutBucketTags(string bucket, PutBucketTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutBucketTagsWithOptions(bucket, request, headers, runtime);
        }

        public async Task<PutBucketTagsResponse> PutBucketTagsAsync(string bucket, PutBucketTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutBucketTagsWithOptionsAsync(bucket, request, headers, runtime);
        }

        public PutBucketTagsResponse PutBucketTagsWithOptions(string bucket, PutBucketTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Tagging.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketTags",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?tagging",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketTagsResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutBucketTagsResponse> PutBucketTagsWithOptionsAsync(string bucket, PutBucketTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Tagging.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketTags",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?tagging",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketTagsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutBucketTransferAccelerationResponse PutBucketTransferAcceleration(string bucket, PutBucketTransferAccelerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutBucketTransferAccelerationWithOptions(bucket, request, headers, runtime);
        }

        public async Task<PutBucketTransferAccelerationResponse> PutBucketTransferAccelerationAsync(string bucket, PutBucketTransferAccelerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutBucketTransferAccelerationWithOptionsAsync(bucket, request, headers, runtime);
        }

        public PutBucketTransferAccelerationResponse PutBucketTransferAccelerationWithOptions(string bucket, PutBucketTransferAccelerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.TransferAccelerationConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketTransferAcceleration",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?transferAcceleration",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketTransferAccelerationResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutBucketTransferAccelerationResponse> PutBucketTransferAccelerationWithOptionsAsync(string bucket, PutBucketTransferAccelerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.TransferAccelerationConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketTransferAcceleration",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?transferAcceleration",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketTransferAccelerationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutBucketVersioningResponse PutBucketVersioning(string bucket, PutBucketVersioningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutBucketVersioningWithOptions(bucket, request, headers, runtime);
        }

        public async Task<PutBucketVersioningResponse> PutBucketVersioningAsync(string bucket, PutBucketVersioningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutBucketVersioningWithOptionsAsync(bucket, request, headers, runtime);
        }

        public PutBucketVersioningResponse PutBucketVersioningWithOptions(string bucket, PutBucketVersioningRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.VersioningConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketVersioning",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?versioning",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketVersioningResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutBucketVersioningResponse> PutBucketVersioningWithOptionsAsync(string bucket, PutBucketVersioningRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.VersioningConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketVersioning",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?versioning",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketVersioningResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutBucketWebsiteResponse PutBucketWebsite(string bucket, PutBucketWebsiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutBucketWebsiteWithOptions(bucket, request, headers, runtime);
        }

        public async Task<PutBucketWebsiteResponse> PutBucketWebsiteAsync(string bucket, PutBucketWebsiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutBucketWebsiteWithOptionsAsync(bucket, request, headers, runtime);
        }

        public PutBucketWebsiteResponse PutBucketWebsiteWithOptions(string bucket, PutBucketWebsiteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.WebsiteConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketWebsite",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?website",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketWebsiteResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutBucketWebsiteResponse> PutBucketWebsiteWithOptionsAsync(string bucket, PutBucketWebsiteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.WebsiteConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutBucketWebsite",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/?website",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutBucketWebsiteResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutLiveChannelResponse PutLiveChannel(string bucket, string channel, PutLiveChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutLiveChannelWithOptions(bucket, channel, request, headers, runtime);
        }

        public async Task<PutLiveChannelResponse> PutLiveChannelAsync(string bucket, string channel, PutLiveChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutLiveChannelWithOptionsAsync(bucket, channel, request, headers, runtime);
        }

        public PutLiveChannelResponse PutLiveChannelWithOptions(string bucket, string channel, PutLiveChannelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.LiveChannelConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutLiveChannel",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "?live",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutLiveChannelResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutLiveChannelResponse> PutLiveChannelWithOptionsAsync(string bucket, string channel, PutLiveChannelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.LiveChannelConfiguration.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutLiveChannel",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "?live",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutLiveChannelResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutLiveChannelStatusResponse PutLiveChannelStatus(string bucket, string channel, PutLiveChannelStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutLiveChannelStatusWithOptions(bucket, channel, request, headers, runtime);
        }

        public async Task<PutLiveChannelStatusResponse> PutLiveChannelStatusAsync(string bucket, string channel, PutLiveChannelStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutLiveChannelStatusWithOptionsAsync(bucket, channel, request, headers, runtime);
        }

        public PutLiveChannelStatusResponse PutLiveChannelStatusWithOptions(string bucket, string channel, PutLiveChannelStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutLiveChannelStatus",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "?live",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutLiveChannelStatusResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutLiveChannelStatusResponse> PutLiveChannelStatusWithOptionsAsync(string bucket, string channel, PutLiveChannelStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutLiveChannelStatus",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + channel + "?live",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutLiveChannelStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutObjectResponse PutObject(string bucket, string key, PutObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutObjectHeaders headers = new PutObjectHeaders();
            return PutObjectWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<PutObjectResponse> PutObjectAsync(string bucket, string key, PutObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutObjectHeaders headers = new PutObjectHeaders();
            return await PutObjectWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public PutObjectResponse PutObjectWithOptions(string bucket, string key, PutObjectRequest request, PutObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ForbidOverwrite))
            {
                realHeaders["x-oss-forbid-overwrite"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ForbidOverwrite);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.MetaData))
            {
                realHeaders["x-oss-meta-*"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.MetaData);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Acl))
            {
                realHeaders["x-oss-object-acl"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Acl);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.SseDataEncryption))
            {
                realHeaders["x-oss-server-side-data-encryption"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.SseDataEncryption);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServerSideEncryption))
            {
                realHeaders["x-oss-server-side-encryption"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServerSideEncryption);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.SseKeyId))
            {
                realHeaders["x-oss-server-side-encryption-key-id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.SseKeyId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.StorageClass))
            {
                realHeaders["x-oss-storage-class"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.StorageClass);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Tagging))
            {
                realHeaders["x-oss-tagging"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Tagging);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "binary",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutObjectResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutObjectResponse> PutObjectWithOptionsAsync(string bucket, string key, PutObjectRequest request, PutObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ForbidOverwrite))
            {
                realHeaders["x-oss-forbid-overwrite"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ForbidOverwrite);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.MetaData))
            {
                realHeaders["x-oss-meta-*"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.MetaData);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Acl))
            {
                realHeaders["x-oss-object-acl"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Acl);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.SseDataEncryption))
            {
                realHeaders["x-oss-server-side-data-encryption"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.SseDataEncryption);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServerSideEncryption))
            {
                realHeaders["x-oss-server-side-encryption"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServerSideEncryption);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.SseKeyId))
            {
                realHeaders["x-oss-server-side-encryption-key-id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.SseKeyId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.StorageClass))
            {
                realHeaders["x-oss-storage-class"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.StorageClass);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Tagging))
            {
                realHeaders["x-oss-tagging"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Tagging);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "binary",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutObjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutObjectAclResponse PutObjectAcl(string bucket, string key, PutObjectAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutObjectAclHeaders headers = new PutObjectAclHeaders();
            return PutObjectAclWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<PutObjectAclResponse> PutObjectAclAsync(string bucket, string key, PutObjectAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutObjectAclHeaders headers = new PutObjectAclHeaders();
            return await PutObjectAclWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public PutObjectAclResponse PutObjectAclWithOptions(string bucket, string key, PutObjectAclRequest request, PutObjectAclHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Acl))
            {
                realHeaders["x-oss-object-acl"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Acl);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutObjectAcl",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?acl",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutObjectAclResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutObjectAclResponse> PutObjectAclWithOptionsAsync(string bucket, string key, PutObjectAclRequest request, PutObjectAclHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Acl))
            {
                realHeaders["x-oss-object-acl"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Acl);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutObjectAcl",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?acl",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutObjectAclResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutObjectTaggingResponse PutObjectTagging(string bucket, string key, PutObjectTaggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutObjectTaggingWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<PutObjectTaggingResponse> PutObjectTaggingAsync(string bucket, string key, PutObjectTaggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutObjectTaggingWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public PutObjectTaggingResponse PutObjectTaggingWithOptions(string bucket, string key, PutObjectTaggingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Tagging.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutObjectTagging",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?tagging",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutObjectTaggingResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutObjectTaggingResponse> PutObjectTaggingWithOptionsAsync(string bucket, string key, PutObjectTaggingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Tagging.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutObjectTagging",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?tagging",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutObjectTaggingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutSymlinkResponse PutSymlink(string bucket, string key)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutSymlinkHeaders headers = new PutSymlinkHeaders();
            return PutSymlinkWithOptions(bucket, key, headers, runtime);
        }

        public async Task<PutSymlinkResponse> PutSymlinkAsync(string bucket, string key)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutSymlinkHeaders headers = new PutSymlinkHeaders();
            return await PutSymlinkWithOptionsAsync(bucket, key, headers, runtime);
        }

        public PutSymlinkResponse PutSymlinkWithOptions(string bucket, string key, PutSymlinkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ForbidOverwrite))
            {
                realHeaders["x-oss-forbid-overwrite"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ForbidOverwrite);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Acl))
            {
                realHeaders["x-oss-object-acl"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Acl);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.StorageClass))
            {
                realHeaders["x-oss-storage-class"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.StorageClass);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.SymlinkTargetKey))
            {
                realHeaders["x-oss-symlink-target"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.SymlinkTargetKey);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutSymlink",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?symlink",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutSymlinkResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutSymlinkResponse> PutSymlinkWithOptionsAsync(string bucket, string key, PutSymlinkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ForbidOverwrite))
            {
                realHeaders["x-oss-forbid-overwrite"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ForbidOverwrite);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Acl))
            {
                realHeaders["x-oss-object-acl"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Acl);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.StorageClass))
            {
                realHeaders["x-oss-storage-class"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.StorageClass);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.SymlinkTargetKey))
            {
                realHeaders["x-oss-symlink-target"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.SymlinkTargetKey);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutSymlink",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?symlink",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<PutSymlinkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public RestoreObjectResponse RestoreObject(string bucket, string key, RestoreObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestoreObjectWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<RestoreObjectResponse> RestoreObjectAsync(string bucket, string key, RestoreObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestoreObjectWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public RestoreObjectResponse RestoreObjectWithOptions(string bucket, string key, RestoreObjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.RestoreRequest.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?restore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<RestoreObjectResponse>(Execute(params_, req, runtime));
        }

        public async Task<RestoreObjectResponse> RestoreObjectWithOptionsAsync(string bucket, string key, RestoreObjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.RestoreRequest.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key + "?restore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<RestoreObjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SelectObjectResponse SelectObject(string bucket, string key, SelectObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SelectObjectWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<SelectObjectResponse> SelectObjectAsync(string bucket, string key, SelectObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SelectObjectWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public SelectObjectResponse SelectObjectWithOptions(string bucket, string key, SelectObjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.SelectRequest.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SelectObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "binary",
            };
            return TeaModel.ToObject<SelectObjectResponse>(Execute(params_, req, runtime));
        }

        public async Task<SelectObjectResponse> SelectObjectWithOptionsAsync(string bucket, string key, SelectObjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.SelectRequest.ToMap()),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SelectObject",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "binary",
            };
            return TeaModel.ToObject<SelectObjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UploadPartResponse UploadPart(string bucket, string key, UploadPartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UploadPartWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<UploadPartResponse> UploadPartAsync(string bucket, string key, UploadPartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UploadPartWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public UploadPartResponse UploadPartWithOptions(string bucket, string key, UploadPartRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartNumber))
            {
                query["partNumber"] = request.PartNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                query["uploadId"] = request.UploadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadPart",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "binary",
                BodyType = "xml",
            };
            return TeaModel.ToObject<UploadPartResponse>(Execute(params_, req, runtime));
        }

        public async Task<UploadPartResponse> UploadPartWithOptionsAsync(string bucket, string key, UploadPartRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartNumber))
            {
                query["partNumber"] = request.PartNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                query["uploadId"] = request.UploadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadPart",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "binary",
                BodyType = "xml",
            };
            return TeaModel.ToObject<UploadPartResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UploadPartCopyResponse UploadPartCopy(string bucket, string key, UploadPartCopyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadPartCopyHeaders headers = new UploadPartCopyHeaders();
            return UploadPartCopyWithOptions(bucket, key, request, headers, runtime);
        }

        public async Task<UploadPartCopyResponse> UploadPartCopyAsync(string bucket, string key, UploadPartCopyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadPartCopyHeaders headers = new UploadPartCopyHeaders();
            return await UploadPartCopyWithOptionsAsync(bucket, key, request, headers, runtime);
        }

        public UploadPartCopyResponse UploadPartCopyWithOptions(string bucket, string key, UploadPartCopyRequest request, UploadPartCopyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartNumber))
            {
                query["partNumber"] = request.PartNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                query["uploadId"] = request.UploadId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySource))
            {
                realHeaders["x-oss-copy-source"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySource);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfMatch))
            {
                realHeaders["x-oss-copy-source-if-match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfModifiedSince))
            {
                realHeaders["x-oss-copy-source-if-modified-since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfModifiedSince);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfNoneMatch))
            {
                realHeaders["x-oss-copy-source-if-none-match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfNoneMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfUnmodifiedSince))
            {
                realHeaders["x-oss-copy-source-if-unmodified-since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfUnmodifiedSince);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceRange))
            {
                realHeaders["x-oss-copy-source-range"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceRange);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadPartCopy",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<UploadPartCopyResponse>(Execute(params_, req, runtime));
        }

        public async Task<UploadPartCopyResponse> UploadPartCopyWithOptionsAsync(string bucket, string key, UploadPartCopyRequest request, UploadPartCopyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["bucket"] = bucket;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartNumber))
            {
                query["partNumber"] = request.PartNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                query["uploadId"] = request.UploadId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySource))
            {
                realHeaders["x-oss-copy-source"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySource);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfMatch))
            {
                realHeaders["x-oss-copy-source-if-match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfModifiedSince))
            {
                realHeaders["x-oss-copy-source-if-modified-since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfModifiedSince);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfNoneMatch))
            {
                realHeaders["x-oss-copy-source-if-none-match"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfNoneMatch);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceIfUnmodifiedSince))
            {
                realHeaders["x-oss-copy-source-if-unmodified-since"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceIfUnmodifiedSince);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CopySourceRange))
            {
                realHeaders["x-oss-copy-source-range"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CopySourceRange);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadPartCopy",
                Version = "2019-05-17",
                Protocol = "HTTPS",
                Pathname = "/" + key,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "xml",
                BodyType = "xml",
            };
            return TeaModel.ToObject<UploadPartCopyResponse>(await ExecuteAsync(params_, req, runtime));
        }

    }
}
