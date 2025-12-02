// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20250903.Models
{
    public class UpdateComponentAssetRequest : TeaModel {
        /// <summary>
        /// <para>Asset name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_asset</para>
        /// </summary>
        [NameInMap("ComponentAssetName")]
        [Validation(Required=false)]
        public string ComponentAssetName { get; set; }

        /// <summary>
        /// <para>Asset UUID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1C5F11E9-<b><b>-51F0-</b></b>-43BB312A0557</para>
        /// </summary>
        [NameInMap("ComponentAssetUuid")]
        [Validation(Required=false)]
        public string ComponentAssetUuid { get; set; }

        /// <summary>
        /// <para>Configuration information of the asset.</para>
        /// </summary>
        [NameInMap("ComponentAssetValues")]
        [Validation(Required=false)]
        public List<UpdateComponentAssetRequestComponentAssetValues> ComponentAssetValues { get; set; }
        public class UpdateComponentAssetRequestComponentAssetValues : TeaModel {
            /// <summary>
            /// <para>Field name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lh_source</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>Field value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>device</para>
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

        /// <summary>
        /// <para>The language type for the request and response. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
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
