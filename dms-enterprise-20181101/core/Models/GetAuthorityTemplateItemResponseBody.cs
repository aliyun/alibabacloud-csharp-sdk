// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetAuthorityTemplateItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The permission templates.</para>
        /// </summary>
        [NameInMap("AuthorityTemplateItemList")]
        [Validation(Required=false)]
        public GetAuthorityTemplateItemResponseBodyAuthorityTemplateItemList AuthorityTemplateItemList { get; set; }
        public class GetAuthorityTemplateItemResponseBodyAuthorityTemplateItemList : TeaModel {
            [NameInMap("AuthorityTemplateItem")]
            [Validation(Required=false)]
            public List<GetAuthorityTemplateItemResponseBodyAuthorityTemplateItemListAuthorityTemplateItem> AuthorityTemplateItem { get; set; }
            public class GetAuthorityTemplateItemResponseBodyAuthorityTemplateItemListAuthorityTemplateItem : TeaModel {
                /// <summary>
                /// <para>The additional information. For example, permissions to log on to an instance are added to the permission template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;permissionTypes&quot;: [
                ///             &quot;LOGIN&quot;
                ///           ]</para>
                /// </summary>
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <para>The ID of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43***</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>188****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12***</para>
                /// </summary>
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                /// <summary>
                /// <para>The ID of the user who modifies the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>51***</para>
                /// </summary>
                [NameInMap("ModifierId")]
                [Validation(Required=false)]
                public long? ModifierId { get; set; }

                /// <summary>
                /// <para>The type of the resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>INSTANCE</b>: instance</description></item>
                /// <item><description><b>LOGIC_DB</b>: logical database</description></item>
                /// <item><description><b>META_DB</b>: physical database</description></item>
                /// <item><description><b>LOGIC_TABLE</b>: logical table</description></item>
                /// <item><description><b>LOGIC_TABLE</b>: physical table</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INSTANCE</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ExampleTable</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The ID of the permission template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1563</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5B96E35F-A58E-5399-9041-09CF9A1E46EA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
