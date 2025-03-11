// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackMenuResponseBody : TeaModel {
        /// <summary>
        /// <para>The backup information list.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public DescribeBackMenuResponseBodyList List { get; set; }
        public class DescribeBackMenuResponseBodyList : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<DescribeBackMenuResponseBodyListList> List { get; set; }
            public class DescribeBackMenuResponseBodyListList : TeaModel {
                /// <summary>
                /// <para>The backup method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>**Logic **: logical backup</description></item>
                /// <item><description><b>phy</b>: physical backup</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>phy</para>
                /// </summary>
                [NameInMap("MenuName")]
                [Validation(Required=false)]
                public string MenuName { get; set; }

                /// <summary>
                /// <para>Indicates whether backup recovery is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Support")]
                [Validation(Required=false)]
                public bool? Support { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60C21BE4-EDFE-454C-95ED-3A5C74******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
