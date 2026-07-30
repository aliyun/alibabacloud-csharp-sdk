// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InvoiceRuleAddRequest : TeaModel {
        /// <summary>
        /// <para>The list of entities.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("entities")]
        [Validation(Required=false)]
        public List<InvoiceRuleAddRequestEntities> Entities { get; set; }
        public class InvoiceRuleAddRequestEntities : TeaModel {
            /// <summary>
            /// <para>The ID of the available scope entity, such as an employee ID, department ID, role ID, or third-party department ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The name of the available scope entity, such as an employee name, department name, role name, or third-party department name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("entity_name")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            /// <summary>
            /// <para>The type of the available scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: employee.</description></item>
            /// <item><description>2: department.</description></item>
            /// <item><description>3: role.</description></item>
            /// <item><description>4: third-party department.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("entity_type")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        /// <summary>
        /// <para>The third-party invoice ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4854821</para>
        /// </summary>
        [NameInMap("third_part_id")]
        [Validation(Required=false)]
        public string ThirdPartId { get; set; }

    }

}
