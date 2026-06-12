// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateETLRequest : TeaModel {
        /// <summary>
        /// <para>The detailed configuration of the data transformation job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public ETLConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>The description of the data transformation job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is ETL</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the data transformation job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls-test-etl</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The job name. The naming convention is as follows:</para>
        /// <para>The job name must be unique within the project.</para>
        /// <list type="bullet">
        /// <item><description><para>The name can contain only lowercase letters, digits, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>The name must start and end with a lowercase letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>The length must be 2 to 64 characters.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>etl-123456</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
