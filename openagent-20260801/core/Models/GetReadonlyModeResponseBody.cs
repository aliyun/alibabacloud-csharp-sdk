// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAgent20260801.Models
{
    public class GetReadonlyModeResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetReadonlyModeResponseBodyData Data { get; set; }
        public class GetReadonlyModeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configuration name. The value is fixed to readonly.</para>
            /// 
            /// <b>Example:</b>
            /// <para>readonly</para>
            /// </summary>
            [NameInMap("configName")]
            [Validation(Required=false)]
            public string ConfigName { get; set; }

            /// <summary>
            /// <para>Indicates whether a configuration record exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("exists")]
            [Validation(Required=false)]
            public bool? Exists { get; set; }

            /// <summary>
            /// <para>The last update time in ISO 8601 format. The value is null if no configuration record exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("gmtUpdate")]
            [Validation(Required=false)]
            public string GmtUpdate { get; set; }

            /// <summary>
            /// <para>The current effective read-only mode, returned as a string. A value of true indicates that the mode is enabled, and a value of false indicates that the mode is disabled. The value is true if not configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>The configuration value type. The value is fixed to BOOL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BOOL</para>
            /// </summary>
            [NameInMap("valueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
