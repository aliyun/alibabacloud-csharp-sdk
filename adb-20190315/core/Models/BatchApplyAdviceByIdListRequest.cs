// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class BatchApplyAdviceByIdListRequest : TeaModel {
        /// <summary>
        /// <para>The date when the optimization suggestions were generated. Specify the date in the <c>yyyyMMdd</c> format. The date is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20221115</para>
        /// </summary>
        [NameInMap("AdviceDate")]
        [Validation(Required=false)]
        public long? AdviceDate { get; set; }

        /// <summary>
        /// <para>The IDs of the optimization suggestions that you want to apply. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2589ff3-e86c-4f19-80c8-2aeb7dd9****,53414470-ebf4-4a53-a312-8a1ad8fd****,6e8dce84-fec8-4b0b-9c04-b0cea12c****,b3b9703d-55ca-47e0-96dd-6a4a9dbf****</para>
        /// </summary>
        [NameInMap("AdviceIdList")]
        [Validation(Required=false)]
        public string AdviceIdList { get; set; }

        /// <summary>
        /// <para>The action to be applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DROP_INDEX</para>
        /// </summary>
        [NameInMap("ApplyType")]
        [Validation(Required=false)]
        public string ApplyType { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately start the build task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BuildImmediately")]
        [Validation(Required=false)]
        public bool? BuildImmediately { get; set; }

        /// <summary>
        /// <para>The ID of the data warehouse cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the IDs of data warehouse clusters.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-uf6g8w25jacm7****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
