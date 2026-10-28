// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAgent20260801.Models
{
    public class UpdateReadonlyModeResponseBody : TeaModel {
        /// <summary>
        /// <para>The currently active configuration information.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateReadonlyModeResponseBodyData Data { get; set; }
        public class UpdateReadonlyModeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the configuration. The value is fixed to readonly.</para>
            /// 
            /// <b>Example:</b>
            /// <para>readonly</para>
            /// </summary>
            [NameInMap("configName")]
            [Validation(Required=false)]
            public string ConfigName { get; set; }

            /// <summary>
            /// <para>Indicates whether a configuration record already exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("exists")]
            [Validation(Required=false)]
            public bool? Exists { get; set; }

            /// <summary>
            /// <para>The last update time in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("gmtUpdate")]
            [Validation(Required=false)]
            public string GmtUpdate { get; set; }

            /// <summary>
            /// <para>The currently active configuration value, returned as the string true or false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>The type of the configuration value. The value is BOOL for this API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BOOL</para>
            /// </summary>
            [NameInMap("valueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. A value of true indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
