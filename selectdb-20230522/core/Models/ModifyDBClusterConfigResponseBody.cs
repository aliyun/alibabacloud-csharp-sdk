// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class ModifyDBClusterConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Access denied details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>failed</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Return data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyDBClusterConfigResponseBodyData Data { get; set; }
        public class ModifyDBClusterConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-7213c8*****</para>
            /// </summary>
            [NameInMap("DbClusterId")]
            [Validation(Required=false)]
            public string DbClusterId { get; set; }

            /// <summary>
            /// <para>Instance numeric ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6585</para>
            /// </summary>
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-7213c8*****</para>
            /// </summary>
            [NameInMap("DbInstanceName")]
            [Validation(Required=false)]
            public string DbInstanceName { get; set; }

            /// <summary>
            /// <para>Task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>107878719</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

        }

        /// <summary>
        /// <para>Dynamic code, currently not in use, please ignore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>Dynamic message, currently not in use, please ignore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>An error occurred while processing your request.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC854513-E85E-54F3-9842-B9CCD3308CDD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
