// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateBasicProjectRequest : TeaModel {
        /// <summary>
        /// <para>The create command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateBasicProjectRequestCreateCommand CreateCommand { get; set; }
        public class CreateBasicProjectRequestCreateCommand : TeaModel {
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
            /// <para>The offline compute source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2001</para>
            /// </summary>
            [NameInMap("ComputeSourceId")]
            [Validation(Required=false)]
            public long? ComputeSourceId { get; set; }

            /// <summary>
            /// <para>The project description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test project</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The project display name.</para>
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
            /// <para>The real-time compute source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2002</para>
            /// </summary>
            [NameInMap("StreamComputeSourceId")]
            [Validation(Required=false)]
            public long? StreamComputeSourceId { get; set; }

            /// <summary>
            /// <para>The project type. If this parameter is left empty, the default value GENERAL is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GENERAL</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The sandbox whitelist.</para>
            /// </summary>
            [NameInMap("WhiteLists")]
            [Validation(Required=false)]
            public List<CreateBasicProjectRequestCreateCommandWhiteLists> WhiteLists { get; set; }
            public class CreateBasicProjectRequestCreateCommandWhiteLists : TeaModel {
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

    }

}
