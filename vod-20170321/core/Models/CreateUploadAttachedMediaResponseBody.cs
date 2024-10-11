// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadAttachedMediaResponseBody : TeaModel {
        /// <summary>
        /// <para>The URL of the auxiliary media asset file. The URL is an Object Storage Service (OSS) URL and does not contain the information used for URL signing.</para>
        /// <para>You can use specify this value for the <c>FileUrl</c> parameter when you call the <a href="~~AddWatermark~~">AddWatermark</a> operation to create a watermark template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://<b><b>.oss-cn-shanghai.aliyuncs.com/watermark/</b></b>.mov</para>
        /// </summary>
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        /// <summary>
        /// <para>The ID of the auxiliary media asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>97dc17a5abc3668489b84ce9****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The URL of the auxiliary media asset.</para>
        /// <para>If a domain name for Alibaba Cloud CDN is specified, a CDN URL is returned. Otherwise, an OSS URL is returned.</para>
        /// <remarks>
        /// <para> If you enable the URL signing feature of ApsaraVideo VOD, you may be unable to access the returned URL of the auxiliary media asset by using a browser and the HTTP status code 403 may be returned. To resolve this issue, you can disable the <a href="https://help.aliyun.com/document_detail/86090.html">URL signing</a> feature or <a href="https://help.aliyun.com/document_detail/57007.html">generate a signed URL</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.aliyundoc.com/watermark/****.mov?auth_key=">http://example.aliyundoc.com/watermark/****.mov?auth_key=</a>****</para>
        /// </summary>
        [NameInMap("MediaURL")]
        [Validation(Required=false)]
        public string MediaURL { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73254DE5-F260-4720-D06856B63C01****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The upload URL.</para>
        /// <remarks>
        /// <para> The upload URL returned by this operation is Base64-encoded. Before you can use an SDK or an API operation to upload a media asset based on the upload URL, you must decode the upload URL by using the Base64 algorithm. You must parse the upload URL only if you use native OSS SDKs or OSS API for uploads.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LWNuLXNoYW5naGFpLmFsaXl1b****</para>
        /// </summary>
        [NameInMap("UploadAddress")]
        [Validation(Required=false)]
        public string UploadAddress { get; set; }

        /// <summary>
        /// <para>The upload credential.</para>
        /// <remarks>
        /// <para> The upload credential returned by this operation is Base64-encoded. Before you can use an SDK or an API operation to upload a media asset based on the upload credential, you must decode the upload credential by using the Base64 algorithm. You must parse the upload credential only if you use native OSS SDKs or OSS API for uploads.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>UzFnUjFxNkZ0NUIZTaklyNWJoQ00zdHF****</para>
        /// </summary>
        [NameInMap("UploadAuth")]
        [Validation(Required=false)]
        public string UploadAuth { get; set; }

    }

}
