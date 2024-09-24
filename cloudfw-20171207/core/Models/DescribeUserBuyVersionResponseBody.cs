// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserBuyVersionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>119898001566xxxx</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1726934400000</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vipcloudfw-cn-xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>63</para>
        /// </summary>
        [NameInMap("IpNumber")]
        [Validation(Required=false)]
        public long? IpNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LogStatus")]
        [Validation(Required=false)]
        public bool? LogStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("LogStorage")]
        [Validation(Required=false)]
        public long? LogStorage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxOverflow")]
        [Validation(Required=false)]
        public long? MaxOverflow { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F71B03EE-xxxxx-91D79CC6AA1A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1692504764000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public bool? UserStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("VpcNumber")]
        [Validation(Required=false)]
        public long? VpcNumber { get; set; }

    }

}
