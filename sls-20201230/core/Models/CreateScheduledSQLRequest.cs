// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateScheduledSQLRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public ScheduledSQLConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>The description of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Create a scheduled SQL task</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali-test-scheduled-sql</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The job name. The name must be unique within a project.</para>
        /// <para>The naming convention is as follows:</para>
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
        /// <para>sql-123456789-123456</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The scheduling configuration for the job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("schedule")]
        [Validation(Required=false)]
        public Schedule Schedule { get; set; }

    }

}
