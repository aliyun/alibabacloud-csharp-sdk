// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetPublicDatasetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>This is description about dataset.</para>
        /// </summary>
        [NameInMap("About")]
        [Validation(Required=false)]
        public string About { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This are dataset access requirements.</para>
        /// </summary>
        [NameInMap("AccessRequirements")]
        [Validation(Required=false)]
        public string AccessRequirements { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This is dataset copyright.</para>
        /// </summary>
        [NameInMap("Copyright")]
        [Validation(Required=false)]
        public string Copyright { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This is dataset description.</para>
        /// </summary>
        [NameInMap("DatasetDescription")]
        [Validation(Required=false)]
        public string DatasetDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>西蒙斯基因组多样性计划</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>easygene.cn-beijing.aliyuncs.com</para>
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>yyyy/MM/dd HH:mm:ss</para>
        /// </summary>
        [NameInMap("LastModified")]
        [Validation(Required=false)]
        public string LastModified { get; set; }

        [NameInMap("Locations")]
        [Validation(Required=false)]
        public List<string> Locations { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DA980AD0-158F-44F3-847D-5EAB96C0EB6B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>源站更新后及时同步</para>
        /// </summary>
        [NameInMap("UpdateFrequency")]
        [Validation(Required=false)]
        public string UpdateFrequency { get; set; }

    }

}
