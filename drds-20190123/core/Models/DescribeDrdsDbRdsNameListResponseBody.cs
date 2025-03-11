// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDbRdsNameListResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the instances that are used to store the data of a database.</para>
        /// </summary>
        [NameInMap("InstanceNameList")]
        [Validation(Required=false)]
        public DescribeDrdsDbRdsNameListResponseBodyInstanceNameList InstanceNameList { get; set; }
        public class DescribeDrdsDbRdsNameListResponseBodyInstanceNameList : TeaModel {
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public List<string> InstanceName { get; set; }

        }

        /// <summary>
        /// <para>Indicates the ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E6FA2BF-05F2-44DD-95C0-D1B5B8xxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
