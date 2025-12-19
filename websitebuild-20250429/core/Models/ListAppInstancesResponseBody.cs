// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppInstancesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dewuApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<AppInstanceAggregate> Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://check-result-file-sh.oss-cn-shanghai.aliyuncs.com/u6qw3gxzu3b7sbj/u6qw3gxzu3b7sbj.diff.zip?Expires=1740975709&OSSAccessKeyId=LTAI5tKUErVCETM4ev9SELNb&Signature=FP7dDnkrLlOZHmRRORVqbLOtv9c%3D">https://check-result-file-sh.oss-cn-shanghai.aliyuncs.com/u6qw3gxzu3b7sbj/u6qw3gxzu3b7sbj.diff.zip?Expires=1740975709&amp;OSSAccessKeyId=LTAI5tKUErVCETM4ev9SELNb&amp;Signature=FP7dDnkrLlOZHmRRORVqbLOtv9c%3D</a></para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dw+qdTi1EjVSWX/INJdYNw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultLimit")]
        [Validation(Required=false)]
        public bool? ResultLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
