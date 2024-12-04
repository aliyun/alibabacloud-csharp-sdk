// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class SinkEventStoreConfiguration : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai-intranet.log.aliyuncs.com</para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>exampleStore</para>
        /// </summary>
        [NameInMap("eventStore")]
        [Validation(Required=false)]
        public string EventStore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>exampleProject</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::123456789:role/aliyunlogetlrole</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

    }

}
