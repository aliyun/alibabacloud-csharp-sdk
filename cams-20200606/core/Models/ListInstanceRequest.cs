// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The binding ID.</para>
        /// </summary>
        [NameInMap("BindId")]
        [Validation(Required=false)]
        public string BindId { get; set; }

        /// <summary>
        /// <para>The channel type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>whatsapp</b></para>
        /// </description></item>
        /// <item><description><para><b>messenger</b></para>
        /// </description></item>
        /// <item><description><para><b>instagram</b></para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;- <b>viber</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>VIBER</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aa</para>
        /// </summary>
        [NameInMap("FilterStr")]
        [Validation(Required=false)]
        public string FilterStr { get; set; }

        /// <summary>
        /// <para>The instance ID. Only non-Alibaba Cloud hosts are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-uf6wd7pkyjwxvlxfhk</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>viber_ins</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is bound.</para>
        /// </summary>
        [NameInMap("IsBind")]
        [Validation(Required=false)]
        public bool? IsBind { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public long? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>87</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The submission time. The format is YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-12 00:00:00</para>
        /// </summary>
        [NameInMap("SubmitTime")]
        [Validation(Required=false)]
        public string SubmitTime { get; set; }

    }

}
