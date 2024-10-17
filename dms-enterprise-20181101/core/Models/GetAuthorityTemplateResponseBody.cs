// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetAuthorityTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the permission template.</para>
        /// </summary>
        [NameInMap("AuthorityTemplateView")]
        [Validation(Required=false)]
        public GetAuthorityTemplateResponseBodyAuthorityTemplateView AuthorityTemplateView { get; set; }
        public class GetAuthorityTemplateResponseBodyAuthorityTemplateView : TeaModel {
            /// <summary>
            /// <para>The resource information in the permission template.</para>
            /// </summary>
            [NameInMap("AuthorityTemplateItemList")]
            [Validation(Required=false)]
            public GetAuthorityTemplateResponseBodyAuthorityTemplateViewAuthorityTemplateItemList AuthorityTemplateItemList { get; set; }
            public class GetAuthorityTemplateResponseBodyAuthorityTemplateViewAuthorityTemplateItemList : TeaModel {
                [NameInMap("AuthorityTemplateItem")]
                [Validation(Required=false)]
                public List<GetAuthorityTemplateResponseBodyAuthorityTemplateViewAuthorityTemplateItemListAuthorityTemplateItem> AuthorityTemplateItem { get; set; }
                public class GetAuthorityTemplateResponseBodyAuthorityTemplateViewAuthorityTemplateItemListAuthorityTemplateItem : TeaModel {
                    /// <summary>
                    /// <para>Other information. For example, you can add the logon permission on an instance to the permission template.</para>
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
                    /// <para>The ID of the user who modified the resource.</para>
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
                    /// <item><description><b>SINGLE_TABLE</b>: physical table</description></item>
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
            /// <para>The time when the permission template was created. The time is in the yyyy-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the permission template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12***</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

            /// <summary>
            /// <para>The description of the permission template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This template is used for business testing.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the permission template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestTemplate</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
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
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
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
