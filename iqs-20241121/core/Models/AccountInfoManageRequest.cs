// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class AccountInfoManageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1159902965389687</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("quarkKey")]
        [Validation(Required=false)]
        public string QuarkKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("quarkName")]
        [Validation(Required=false)]
        public string QuarkName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("testQps")]
        [Validation(Required=false)]
        public int? TestQps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("testQueryPerDay")]
        [Validation(Required=false)]
        public int? TestQueryPerDay { get; set; }

    }

}
