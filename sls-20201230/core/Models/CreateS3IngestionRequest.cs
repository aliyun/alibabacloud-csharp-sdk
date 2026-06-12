// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateS3IngestionRequest : TeaModel {
        /// <summary>
        /// <para>The configuration.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public S3IngestionConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>The description of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The name of the job. Follow these naming rules:</para>
        /// <para>Each job in the same project must have a unique name.</para>
        /// <list type="bullet">
        /// <item><description><para>Use only lowercase letters, digits, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>Start and end with a lowercase letter or digit.</para>
        /// </description></item>
        /// <item><description><para>Be 2 to 64 characters long.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("schedule")]
        [Validation(Required=false)]
        public Schedule Schedule { get; set; }

    }

}
