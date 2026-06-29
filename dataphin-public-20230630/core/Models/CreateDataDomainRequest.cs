// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateDataDomainRequest : TeaModel {
        /// <summary>
        /// <para>The create request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateDataDomainRequestCreateCommand CreateCommand { get; set; }
        public class CreateDataDomainRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The abbreviation of the data domain.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dm_code_name</para>
            /// </summary>
            [NameInMap("Abbreviation")]
            [Validation(Required=false)]
            public string Abbreviation { get; set; }

            /// <summary>
            /// <para>The ID of the data unit to which the data domain belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>545844456</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public long? BizUnitId { get; set; }

            /// <summary>
            /// <para>The description of the data domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name of the data domain.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>主题域测试</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The code of the data domain.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dm_code_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the parent data domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10232311</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
