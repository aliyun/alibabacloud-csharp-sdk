// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetProjectFeatureEntityResponseBody : TeaModel {
        /// <summary>
        /// <para>Feature entity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("FeatureEntityId")]
        [Validation(Required=false)]
        public string FeatureEntityId { get; set; }

        /// <summary>
        /// <para>Join ID used to associate with feature views.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_id</para>
        /// </summary>
        [NameInMap("JoinId")]
        [Validation(Required=false)]
        public string JoinId { get; set; }

        /// <summary>
        /// <para>Feature entity name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature_entity_1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project_1</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37D19490-AB69-567D-A852-407C94E510E9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34245</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
