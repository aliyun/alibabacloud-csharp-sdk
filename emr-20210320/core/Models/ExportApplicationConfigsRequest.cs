// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ExportApplicationConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The list of application configurations to export.</para>
        /// </summary>
        [NameInMap("ApplicationConfigFiles")]
        [Validation(Required=false)]
        public List<ApplicationConfigFile> ApplicationConfigFiles { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b933c5aac8fe****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ConfigScope")]
        [Validation(Required=false)]
        public string ConfigScope { get; set; }

        /// <summary>
        /// <para>The mode for exporting service configurations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>MODIFICATION</para>
        /// </description></item>
        /// <item><description><para>ALL</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MODIFICATION</para>
        /// </summary>
        [NameInMap("ExportMode")]
        [Validation(Required=false)]
        public string ExportMode { get; set; }

        /// <summary>
        /// <para>The file format of the exported application configurations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>JSON</para>
        /// </description></item>
        /// <item><description><para>XML</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>XML</para>
        /// </summary>
        [NameInMap("FileFormat")]
        [Validation(Required=false)]
        public string FileFormat { get; set; }

        [NameInMap("NodeGroupIds")]
        [Validation(Required=false)]
        public List<string> NodeGroupIds { get; set; }

        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
