// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ResumePhysicalNodeRequest : TeaModel {
        /// <summary>
        /// <para>The environment identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DEV: development environment </description></item>
        /// <item><description>PROD: production environment. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

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
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The request to resume scheduling.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResumeCommand")]
        [Validation(Required=false)]
        public ResumePhysicalNodeRequestResumeCommand ResumeCommand { get; set; }
        public class ResumePhysicalNodeRequestResumeCommand : TeaModel {
            /// <summary>
            /// <para>The list of node IDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NodeIdList")]
            [Validation(Required=false)]
            public List<string> NodeIdList { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102011</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

    }

}
