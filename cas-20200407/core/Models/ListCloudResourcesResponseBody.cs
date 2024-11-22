// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCloudResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The data returned for the request.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCloudResourcesResponseBodyData> Data { get; set; }
        public class ListCloudResourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The end date of the certificate bound to the cloud resource. The value is a timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1737795520000</para>
            /// </summary>
            [NameInMap("CertEndTime")]
            [Validation(Required=false)]
            public string CertEndTime { get; set; }

            /// <summary>
            /// <para>The ID of the certificate bound to the cloud resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12433121</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public long? CertId { get; set; }

            /// <summary>
            /// <para>The name of the certificate bound to the cloud resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>shop.amsaudio.cn</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The start date of the certificate bound to the cloud resource. The value is a timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1706259520000</para>
            /// </summary>
            [NameInMap("CertStartTime")]
            [Validation(Required=false)]
            public string CertStartTime { get; set; }

            /// <summary>
            /// <para>The AccessKey ID that is used to access cloud resources.</para>
            /// <remarks>
            /// <para> This parameter is returned only when you deploy certificates to cloud services of third-party clouds.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("CloudAccessId")]
            [Validation(Required=false)]
            public string CloudAccessId { get; set; }

            /// <summary>
            /// <para>The cloud service provider.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Tencent</description></item>
            /// <item><description>Huawei</description></item>
            /// <item><description>Aws</description></item>
            /// <item><description>aliyun</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun</para>
            /// </summary>
            [NameInMap("CloudName")]
            [Validation(Required=false)]
            public string CloudName { get; set; }

            /// <summary>
            /// <para>The cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALB</para>
            /// </summary>
            [NameInMap("CloudProduct")]
            [Validation(Required=false)]
            public string CloudProduct { get; set; }

            /// <summary>
            /// <para>The region ID of the cloud service provider to which the cloud resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("CloudRegion")]
            [Validation(Required=false)]
            public string CloudRegion { get; set; }

            /// <summary>
            /// <para>Indicates whether the cloud resource is the default resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DefaultResource")]
            [Validation(Required=false)]
            public int? DefaultResource { get; set; }

            /// <summary>
            /// <para>The domain name bound to the cloud resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.tkgeo.ru">www.tkgeo.ru</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Indicates whether HTTPS is enabled for the cloud resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes.</description></item>
            /// <item><description><b>0</b>: no.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnableHttps")]
            [Validation(Required=false)]
            public int? EnableHttps { get; set; }

            /// <summary>
            /// <para>The time when the cloud resource was created. The time is a timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1673423339000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the cloud resource was last modified. The time is a timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1696911946000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the cloud resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2356</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The instance ID of the cloud resource.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>nlb-rv05agjc97ovm14il5</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The listener ID of the cloud resource.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-jiugof6t23et66lsnc@443</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The listening port of the cloud resource.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8047</para>
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public string ListenerPort { get; set; }

            /// <summary>
            /// <para>The region ID of the cloud resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the cloud resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BUY</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates whether an Alibaba Cloud SSL certificate is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is required only when you deploy certificates to services of multiple clouds.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UseSsl")]
            [Validation(Required=false)]
            public int? UseSsl { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1666884372152785</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789ABC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>440</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
