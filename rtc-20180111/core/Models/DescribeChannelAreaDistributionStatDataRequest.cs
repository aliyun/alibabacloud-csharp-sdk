// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelAreaDistributionStatDataRequest : TeaModel {
        /// <summary>
        /// <para>The app ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testappid</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The channel ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The timestamp when the channel was created. You can query data of the last 30 days. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614936817</para>
        /// </summary>
        [NameInMap("CreatedTs")]
        [Validation(Required=false)]
        public long? CreatedTs { get; set; }

        /// <summary>
        /// <para>The timestamp when the channel was released. The value is a UNIX timestamp in seconds. If this parameter is left empty, the current time is used.</para>
        /// <remarks>
        /// <para>If the specified channel release time is later than the actual release time, the data from the creation time to the actual release time is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1614936817</para>
        /// </summary>
        [NameInMap("DestroyedTs")]
        [Validation(Required=false)]
        public long? DestroyedTs { get; set; }

        /// <summary>
        /// <para>The name of the parent region. For example, the parent region of Shenzhen is Guangdong Province. If this parameter is left empty, global statistics at the country level are returned, such as China and the United Kingdom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>China_Zhejiang Province</para>
        /// </summary>
        [NameInMap("ParentArea")]
        [Validation(Required=false)]
        public string ParentArea { get; set; }

    }

}
