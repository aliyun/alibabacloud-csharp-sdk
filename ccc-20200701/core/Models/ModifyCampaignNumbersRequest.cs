// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ModifyCampaignNumbersRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6badb397-<b><b>-</b></b>-21019d382a09</para>
        /// </summary>
        [NameInMap("CampaignId")]
        [Validation(Required=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3971876649-<b><b>-</b></b>-098763a382a09</para>
        /// </summary>
        [NameInMap("InstGroupId")]
        [Validation(Required=false)]
        public string InstGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("NumberList")]
        [Validation(Required=false)]
        public List<string> NumberList { get; set; }

    }

}
