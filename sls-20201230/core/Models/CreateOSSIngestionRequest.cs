// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateOSSIngestionRequest : TeaModel {
        /// <summary>
        /// <para>The OSS import configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public OSSIngestionConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>The job description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS import</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The job name. The naming conventions are as follows:</para>
        /// <para>The job name must be unique within the project.</para>
        /// <list type="bullet">
        /// <item><description><para>The name can contain only lowercase letters, digits, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>The name must start and end with a lowercase letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>The name must be 2 to 64 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingest-oss-123456</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The scheduling configuration. This parameter is optional. To meet specific timing requirements, such as importing data at 8:00 AM every Monday, use a cron expression.</para>
        /// </summary>
        [NameInMap("schedule")]
        [Validation(Required=false)]
        public Schedule Schedule { get; set; }

    }

}
