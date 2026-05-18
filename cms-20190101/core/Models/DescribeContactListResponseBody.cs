// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeContactListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public DescribeContactListResponseBodyContacts Contacts { get; set; }
        public class DescribeContactListResponseBodyContacts : TeaModel {
            [NameInMap("Contact")]
            [Validation(Required=false)]
            public List<DescribeContactListResponseBodyContactsContact> Contact { get; set; }
            public class DescribeContactListResponseBodyContactsContact : TeaModel {
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public DescribeContactListResponseBodyContactsContactChannels Channels { get; set; }
                public class DescribeContactListResponseBodyContactsContactChannels : TeaModel {
                    [NameInMap("AliIM")]
                    [Validation(Required=false)]
                    public string AliIM { get; set; }

                    [NameInMap("DingWebHook")]
                    [Validation(Required=false)]
                    public string DingWebHook { get; set; }

                    [NameInMap("Mail")]
                    [Validation(Required=false)]
                    public string Mail { get; set; }

                    [NameInMap("SMS")]
                    [Validation(Required=false)]
                    public string SMS { get; set; }

                }

                [NameInMap("ChannelsState")]
                [Validation(Required=false)]
                public DescribeContactListResponseBodyContactsContactChannelsState ChannelsState { get; set; }
                public class DescribeContactListResponseBodyContactsContactChannelsState : TeaModel {
                    [NameInMap("AliIM")]
                    [Validation(Required=false)]
                    public string AliIM { get; set; }

                    [NameInMap("DingWebHook")]
                    [Validation(Required=false)]
                    public string DingWebHook { get; set; }

                    [NameInMap("Mail")]
                    [Validation(Required=false)]
                    public string Mail { get; set; }

                    [NameInMap("SMS")]
                    [Validation(Required=false)]
                    public string SMS { get; set; }

                }

                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public DescribeContactListResponseBodyContactsContactContactGroups ContactGroups { get; set; }
                public class DescribeContactListResponseBodyContactsContactContactGroups : TeaModel {
                    [NameInMap("ContactGroup")]
                    [Validation(Required=false)]
                    public List<string> ContactGroup { get; set; }

                }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06D5ECC2-B9BE-42A4-8FA3-1A610FB08B83</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
