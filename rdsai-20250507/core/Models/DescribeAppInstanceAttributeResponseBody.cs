// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeAppInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test-supabase</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>supabase</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pgm-2ze49qv594vi****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("EipStatus")]
        [Validation(Required=false)]
        public string EipStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rdsai.supabase.basic</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20241231</para>
        /// </summary>
        [NameInMap("InstanceMinorVersion")]
        [Validation(Required=false)]
        public string InstanceMinorVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("NatStatus")]
        [Validation(Required=false)]
        public string NatStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8.152. XXX.XXX:8000</para>
        /// </summary>
        [NameInMap("PublicConnectionString")]
        [Validation(Required=false)]
        public string PublicConnectionString { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329241C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-2zeaepb8k4ku05ov2****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>172.16.XXX.XXX:8000</para>
        /// </summary>
        [NameInMap("VpcConnectionString")]
        [Validation(Required=false)]
        public string VpcConnectionString { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
