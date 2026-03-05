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

        [NameInMap("NetInfoItems")]
        [Validation(Required=false)]
        public ModifyInstanceNetExpireTimeResponseBodyNetInfoItems NetInfoItems { get; set; }
        public class ModifyInstanceNetExpireTimeResponseBodyNetInfoItems : TeaModel {
            [NameInMap("NetInfoItem")]
            [Validation(Required=false)]
            public List<ModifyInstanceNetExpireTimeResponseBodyNetInfoItemsNetInfoItem> NetInfoItem { get; set; }
            public class ModifyInstanceNetExpireTimeResponseBodyNetInfoItemsNetInfoItem : TeaModel {
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

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
