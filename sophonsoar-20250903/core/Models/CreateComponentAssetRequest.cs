// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20250903.Models
{
    public class CreateComponentAssetRequest : TeaModel {
        /// <summary>
        /// <para>The name of the asset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shanghai-log-config</para>
        /// </summary>
        [NameInMap("ComponentAssetName")]
        [Validation(Required=false)]
        public string ComponentAssetName { get; set; }

        /// <summary>
        /// <para>Configuration information of the asset.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ComponentAssetValues")]
        [Validation(Required=false)]
        public List<CreateComponentAssetRequestComponentAssetValues> ComponentAssetValues { get; set; }
        public class CreateComponentAssetRequestComponentAssetValues : TeaModel {
            /// <summary>
            /// <para>Field name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>endpoint</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>Field value.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://logs.aliyuncs.com">http://logs.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

        /// <summary>
        /// <para>The name of the component.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// <para>The language type for receiving messages. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Resource directory member account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13760*****718726</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
