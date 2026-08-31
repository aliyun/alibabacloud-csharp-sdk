// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateDevProdProjectRequest : TeaModel {
        /// <summary>
        /// <para>The create command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateDevProdProjectRequestCreateCommand CreateCommand { get; set; }
        public class CreateDevProdProjectRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The business unit ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public long? BizUnitId { get; set; }

            /// <summary>
            /// <para>The ID of the offline compute source in the development environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2001</para>
            /// </summary>
            [NameInMap("DevComputeSourceId")]
            [Validation(Required=false)]
            public long? DevComputeSourceId { get; set; }

            /// <summary>
            /// <para>The description of the development environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev desc</para>
            /// </summary>
            [NameInMap("DevDescription")]
            [Validation(Required=false)]
            public string DevDescription { get; set; }

            /// <summary>
            /// <para>The ID of the real-time compute source in the development environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2002</para>
            /// </summary>
            [NameInMap("DevStreamComputeSourceId")]
            [Validation(Required=false)]
            public long? DevStreamComputeSourceId { get; set; }

            /// <summary>
            /// <para>The display name of the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>My project.</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_project</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("NameSpaceTag")]
            [Validation(Required=false)]
            public string NameSpaceTag { get; set; }

            /// <summary>
            /// <para>The ID of the offline compute source in the production environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2003</para>
            /// </summary>
            [NameInMap("ProdComputeSourceId")]
            [Validation(Required=false)]
            public long? ProdComputeSourceId { get; set; }

            /// <summary>
            /// <para>The description of the production environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod desc</para>
            /// </summary>
            [NameInMap("ProdDescription")]
            [Validation(Required=false)]
            public string ProdDescription { get; set; }

            /// <summary>
            /// <para>The ID of the real-time compute source in the production environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2004</para>
            /// </summary>
            [NameInMap("ProdStreamComputeSourceId")]
            [Validation(Required=false)]
            public long? ProdStreamComputeSourceId { get; set; }

            /// <summary>
            /// <para>The sandbox whitelist.</para>
            /// </summary>
            [NameInMap("WhiteLists")]
            [Validation(Required=false)]
            public List<CreateDevProdProjectRequestCreateCommandWhiteLists> WhiteLists { get; set; }
            public class CreateDevProdProjectRequestCreateCommandWhiteLists : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>IP</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

            }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
