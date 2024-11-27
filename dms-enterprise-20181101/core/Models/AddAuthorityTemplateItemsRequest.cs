// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddAuthorityTemplateItemsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<AddAuthorityTemplateItemsRequestItems> Items { get; set; }
        public class AddAuthorityTemplateItemsRequestItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2478****</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>237****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public int? InstanceId { get; set; }

            [NameInMap("PermissionTypes")]
            [Validation(Required=false)]
            public List<string> PermissionTypes { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSTANCE</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15***</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
