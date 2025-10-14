// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeStoragePoolInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeStoragePoolInfoResponseBodyData Data { get; set; }
        public class DescribeStoragePoolInfoResponseBodyData : TeaModel {
            [NameInMap("StoragePools")]
            [Validation(Required=false)]
            public List<DescribeStoragePoolInfoResponseBodyDataStoragePools> StoragePools { get; set; }
            public class DescribeStoragePoolInfoResponseBodyDataStoragePools : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>polar.mysql.x4.large</para>
                /// </summary>
                [NameInMap("Class")]
                [Validation(Required=false)]
                public string Class { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[pxc-xdb-s-pxcbj<b><b>xxnwp0wac2c4\&quot;,\&quot;pxc-xdb-s-pxcbjr3b8</b></b>p0wa1589\&quot;]</para>
                /// </summary>
                [NameInMap("DnIdList")]
                [Validation(Required=false)]
                public List<string> DnIdList { get; set; }

                /// <summary>
                /// <para>DN id</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-xdb-s-pxcshr****rh7fn2654fc</para>
                /// </summary>
                [NameInMap("DnIdString")]
                [Validation(Required=false)]
                public string DnIdString { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;appId\&quot;:\&quot;APP_ETLUP1E5FMI5ND5IFO8W\&quot;}</para>
                /// </summary>
                [NameInMap("Extra")]
                [Validation(Required=false)]
                public string Extra { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-08-27 23:19:52.0</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-09-02 16:52:47.0</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>none</para>
                /// </summary>
                [NameInMap("IdleDNIdList")]
                [Validation(Required=false)]
                public List<string> IdleDNIdList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-cacheapi</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pxc-xdb-s-hzr*****6j4se284344</para>
                /// </summary>
                [NameInMap("UnDeletableDNId")]
                [Validation(Required=false)]
                public string UnDeletableDNId { get; set; }

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
