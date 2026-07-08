// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribePurchasedDeviceResponseBody : TeaModel {
        /// <summary>
        /// <para>Device creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>Device description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx路口摄像头</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Space ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>348*****174-cn-qingdao</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Space name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试空间</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Device ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33763****77224964-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Device name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2117*****0447</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>Region where the space belongs, also known as the service center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>Device registration code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345*****67890</para>
        /// </summary>
        [NameInMap("RegisterCode")]
        [Validation(Required=false)]
        public string RegisterCode { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Device child type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>bullet (bullet camera)</para>
        /// </description></item>
        /// <item><description><para>dome (dome camera)</para>
        /// </description></item>
        /// <item><description><para>ptz (PTZ)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dome</para>
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// <para>Device type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ipc (camera)</para>
        /// </description></item>
        /// <item><description><para>platform</para>
        /// </description></item>
        /// <item><description><para>ied (intelligent device)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipc</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Device vendor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8yd*****qem</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
