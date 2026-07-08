// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribePurchasedDevicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of devices.</para>
        /// </summary>
        [NameInMap("Devices")]
        [Validation(Required=false)]
        public List<DescribePurchasedDevicesResponseBodyDevices> Devices { get; set; }
        public class DescribePurchasedDevicesResponseBodyDevices : TeaModel {
            /// <summary>
            /// <para>The time the device was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-28T17:00:17Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The device description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx路口摄像头</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the group to which the device belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>348*****174-cn-qingdao</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>Group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试空间</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>348*****380-cn-qingdao</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The device name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx路口摄像头</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2117*****0447</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The region to which the space belongs. This is the service center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The device registration code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234*****67890</para>
            /// </summary>
            [NameInMap("RegisterCode")]
            [Validation(Required=false)]
            public string RegisterCode { get; set; }

            /// <summary>
            /// <para>The device subtype. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>bullet (bullet camera)</para>
            /// </description></item>
            /// <item><description><para>dome (dome camera)</para>
            /// </description></item>
            /// <item><description><para>ptz (PTZ camera)</para>
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
            /// <para>The device type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ipc (camera)</para>
            /// </description></item>
            /// <item><description><para>platform (platform)</para>
            /// </description></item>
            /// <item><description><para>ied (intelligent edge device)</para>
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
            /// <para>The device vendor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>公司A</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of devices.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
