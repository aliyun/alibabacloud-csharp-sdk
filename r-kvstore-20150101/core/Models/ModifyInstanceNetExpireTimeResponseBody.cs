// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceNetExpireTimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Details about the extension period for which the classic network endpoint of the instance is retained.</para>
        /// </summary>
        [NameInMap("NetInfoItems")]
        [Validation(Required=false)]
        public ModifyInstanceNetExpireTimeResponseBodyNetInfoItems NetInfoItems { get; set; }
        public class ModifyInstanceNetExpireTimeResponseBodyNetInfoItems : TeaModel {
            [NameInMap("NetInfoItem")]
            [Validation(Required=false)]
            public List<ModifyInstanceNetExpireTimeResponseBodyNetInfoItemsNetInfoItem> NetInfoItem { get; set; }
            public class ModifyInstanceNetExpireTimeResponseBodyNetInfoItemsNetInfoItem : TeaModel {
                /// <summary>
                /// <para>The endpoint of the classic network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp1zxszhcgatnx****.redis.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The network type of the instance. The returned value is <b>Classic</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Classic</para>
                /// </summary>
                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                /// <summary>
                /// <para>The expiration time of the classic network endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-08-01T09:29:18Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The IP address of the instance in the classic network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.118.142.***</para>
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// <para>The port number that is used to connect to the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6379</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C4AF387-1EA3-4C84-8013-3F6B973EDDF5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
