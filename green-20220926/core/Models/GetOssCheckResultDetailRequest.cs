// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetOssCheckResultDetailRequest : TeaModel {
        /// <summary>
        /// <para>The bucket. Note: This parameter is actually required. If it is not provided, the API returns a 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-tmp</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>The media asset type. Note: This parameter is actually required. If it is not provided, the API returns a 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public int? MediaType { get; set; }

        /// <summary>
        /// <para>The object name. Note: This parameter is actually required. If it is not provided, the API returns a 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1748396909030.jpg</para>
        /// </summary>
        [NameInMap("Object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        /// <summary>
        /// <para>The parent task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P_RZQ66T</para>
        /// </summary>
        [NameInMap("ParentTaskId")]
        [Validation(Required=false)]
        public string ParentTaskId { get; set; }

        /// <summary>
        /// <para>The request ID of the query. Note: This parameter is actually required. If it is not provided, the API returns a 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62E97001-1255-50A9-8E1E-4FD05473D952</para>
        /// </summary>
        [NameInMap("QueryRequestId")]
        [Validation(Required=false)]
        public string QueryRequestId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The service code. Note: This parameter is actually required. If it is not provided, the API returns a 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>audio_media_detection_01</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

    }

}
