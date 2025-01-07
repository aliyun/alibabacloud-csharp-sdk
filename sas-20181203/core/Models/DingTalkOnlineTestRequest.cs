// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DingTalkOnlineTestRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the DingTalk notification configuration.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeDingTalk~~">DescribeDingTalk</a> operation to obtain the ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2373</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
