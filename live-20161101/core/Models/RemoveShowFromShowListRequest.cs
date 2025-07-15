// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class RemoveShowFromShowListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description>If the production studio was created by calling the <a href="https://help.aliyun.com/document_detail/69338.html">CreateCaster</a> operation, check the value of the response parameter CasterId to obtain the ID.</description></item>
        /// <item><description>If the production studio was created by using the ApsaraVideo Live console, obtain the ID on the <b>Production Studio Management</b> page. To go to the page, log on to the <b>ApsaraVideo Live console</b> and click <b>Production Studios</b> in the left-side navigation pane.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can find the ID of the production studio in the Instance ID/Name column.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the episode.</para>
        /// <remarks>
        /// <para> You can obtain the ID by checking the value of the response parameter ShowId of the <a href="https://help.aliyun.com/document_detail/370861.html">AddShowIntoShowList</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("ShowId")]
        [Validation(Required=false)]
        public string ShowId { get; set; }

        /// <summary>
        /// <para>Specifies whether to remove multiple episodes at a time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: removes multiple episodes at a time.</description></item>
        /// <item><description>false: removes a single episode.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not configure this parameter or this parameter is left empty, a single episode is to be removed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isBatchMode")]
        [Validation(Required=false)]
        public bool? IsBatchMode { get; set; }

        /// <summary>
        /// <para>The IDs of episodes that you want to remove.</para>
        /// </summary>
        [NameInMap("showIdList")]
        [Validation(Required=false)]
        public List<string> ShowIdList { get; set; }

    }

}
