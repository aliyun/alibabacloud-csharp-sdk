// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class ListServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E2B6A4C-6B83-4062-8B6F-AEEC1FC47DED</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The applications.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public ListServicesResponseBodyServices Services { get; set; }
        public class ListServicesResponseBodyServices : TeaModel {
            [NameInMap("Service")]
            [Validation(Required=false)]
            public List<ListServicesResponseBodyServicesService> Service { get; set; }
            public class ListServicesResponseBodyServicesService : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXXqn3ly@741623b4e915df8</para>
                /// </summary>
                [NameInMap("Pid")]
                [Validation(Required=false)]
                public string Pid { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a3</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

    }

}
