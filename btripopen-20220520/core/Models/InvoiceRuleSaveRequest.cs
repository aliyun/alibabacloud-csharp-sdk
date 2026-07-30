// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InvoiceRuleSaveRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the invoice title applies to all employees. Valid values: true and false. This parameter is deprecated. Use the new field scope instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("all_employe")]
        [Validation(Required=false)]
        public bool? AllEmploye { get; set; }

        /// <summary>
        /// <para>This parameter is not required when all_employe is set to true. Otherwise, this parameter is required.</para>
        /// </summary>
        [NameInMap("entities")]
        [Validation(Required=false)]
        public List<InvoiceRuleSaveRequestEntities> Entities { get; set; }
        public class InvoiceRuleSaveRequestEntities : TeaModel {
            /// <summary>
            /// <para>The entity ID. Valid values: 1 (employee ID), 2 (internal business travel department ID), 3 (third-party department ID). This parameter is required when all_employe is set to false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The entity name. This parameter is required when all_employe is set to false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The entity type. Valid values: 1 (employee), 2 (internal business travel department), 3 (third-party department). This parameter is required when all_employe is set to false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <para>The applicable scope. Valid values: 1 (all employees), 2 (partial), 3 (disabled). Either scope or all_employe is required. If scope has a value, all_employe does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public int? Scope { get; set; }

        /// <summary>
        /// <para>The third-party invoice ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i123</para>
        /// </summary>
        [NameInMap("third_part_id")]
        [Validation(Required=false)]
        public string ThirdPartId { get; set; }

    }

}
