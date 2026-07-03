// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataSetRecordRequest : TeaModel {
        /// <summary>
        /// <para>The name of the uploaded dataset file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudsiem-dataset/1358117679873357_174338773****.csv</para>
        /// </summary>
        [NameInMap("DataSetFileName")]
        [Validation(Required=false)]
        public string DataSetFileName { get; set; }

        /// <summary>
        /// <para>The ID of the dataset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset-10iy8mbifnb4gniv****</para>
        /// </summary>
        [NameInMap("DataSetId")]
        [Validation(Required=false)]
        public string DataSetId { get; set; }

        /// <summary>
        /// <para>The content of the dataset records, in JSON array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;ip\&quot;:\&quot;1.1.1.1\&quot;,\&quot;userid\&quot;:\&quot;1234\&quot;,\&quot;name\&quot;:\&quot;a12401\&quot;},
        ///  {\&quot;ip\&quot;:\&quot;2.2.2.2\&quot;,\&quot;userid\&quot;:\&quot;33333\&quot;,\&quot;name\&quot;:\&quot;a12401\&quot;}]</para>
        /// </summary>
        [NameInMap("DataSetRecords")]
        [Validation(Required=false)]
        public string DataSetRecords { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The region where the Data Management center for threat analysis is located. Select a region for the management center based on the region of your asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: The asset is in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: The asset is in a region outside China.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member. An administrator can use this parameter to switch to the perspective of a specific member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
