// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class DescribeAppDomainDnsRecordResponseBody : TeaModel {
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
        /// <para>ish-intelligence-store-platform-admin-web</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://check-result-file-sh.oss-cn-shanghai.aliyuncs.com/vs1w2yd3p8264pz/vs1w2yd3p8264pz.diff.zip?Expires=1739592470&OSSAccessKeyId=LTAI5tKUErVCETM4ev9SELNb&Signature=3DRuMtCeTinVYxo7XAOEIOEmZGE%3D">https://check-result-file-sh.oss-cn-shanghai.aliyuncs.com/vs1w2yd3p8264pz/vs1w2yd3p8264pz.diff.zip?Expires=1739592470&amp;OSSAccessKeyId=LTAI5tKUErVCETM4ev9SELNb&amp;Signature=3DRuMtCeTinVYxo7XAOEIOEmZGE%3D</a></para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        [NameInMap("Module")]
        [Validation(Required=false)]
        public DescribeAppDomainDnsRecordResponseBodyModule Module { get; set; }
        public class DescribeAppDomainDnsRecordResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>*.com</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>A</para>
            /// </summary>
            [NameInMap("RecordType")]
            [Validation(Required=false)]
            public string RecordType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Maintenance</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

    }

}
