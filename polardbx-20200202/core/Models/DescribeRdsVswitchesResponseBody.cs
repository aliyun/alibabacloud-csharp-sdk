// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeRdsVswitchesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeRdsVswitchesResponseBodyData Data { get; set; }
        public class DescribeRdsVswitchesResponseBodyData : TeaModel {
            [NameInMap("VswitchList")]
            [Validation(Required=false)]
            public List<DescribeRdsVswitchesResponseBodyDataVswitchList> VswitchList { get; set; }
            public class DescribeRdsVswitchesResponseBodyDataVswitchList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>16378</para>
                /// </summary>
                [NameInMap("AvailabeIpCount")]
                [Validation(Required=false)]
                public string AvailabeIpCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>172.16.0.0/24</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>describe</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>babac91eff704edf9bdccfaa6ba4efce</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>drdshbgae0han226</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public string IsDefault { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-j</para>
                /// </summary>
                [NameInMap("IzNo")]
                [Validation(Required=false)]
                public string IzNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>szt-backup</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>vpc id。</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf6lis7xmm****t9wrxb5</para>
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C458B1E8-1683-3645-B154-6BA32080EEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
