// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListTopicRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the results to return.
        /// Valid values: 1 to 100000000.
        /// If you set this parameter to a value less than 1, the system uses 1 by default. If you set this parameter to a value greater than 100000000, the system uses 100000000 by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <para>The number of results to return on each page.
        /// Valid values: 10 to 50.
        /// If you set this parameter to a value less than 10, the system uses 10 by default. If you set this parameter to a value greater than 50, the system uses 50 by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTopicRequestTag> Tag { get; set; }
        public class ListTopicRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

        /// <summary>
        /// <para>The type of the topic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: normal topic</description></item>
        /// <item><description>fifo: FIFO topic</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("TopicType")]
        [Validation(Required=false)]
        public string TopicType { get; set; }

    }

}
