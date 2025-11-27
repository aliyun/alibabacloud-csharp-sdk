// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeMfaDevicesRequest : TeaModel {
        /// <summary>
        /// <para>The address of the AD office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn.misumi.pri</para>
        /// </summary>
        [NameInMap("AdDomain")]
        [Validation(Required=false)]
        public string AdDomain { get; set; }

        /// <summary>
        /// <para>The usernames of the convenience accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Valid values: 1 to 500.\
        /// Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Set the value to the token that is obtained from the previous query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The serial numbers of the virtual MFA devices.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2d9ae94-a64b-4a0d-8024-9519ca50****</para>
        /// </summary>
        [NameInMap("SerialNumbers")]
        [Validation(Required=false)]
        public List<string> SerialNumbers { get; set; }

    }

}
