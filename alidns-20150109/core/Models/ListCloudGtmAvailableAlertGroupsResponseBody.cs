// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListCloudGtmAvailableAlertGroupsResponseBody : TeaModel {
        [NameInMap("AlertGroups")]
        [Validation(Required=false)]
        public ListCloudGtmAvailableAlertGroupsResponseBodyAlertGroups AlertGroups { get; set; }
        public class ListCloudGtmAvailableAlertGroupsResponseBodyAlertGroups : TeaModel {
            [NameInMap("AlertGroup")]
            [Validation(Required=false)]
            public List<ListCloudGtmAvailableAlertGroupsResponseBodyAlertGroupsAlertGroup> AlertGroup { get; set; }
            public class ListCloudGtmAvailableAlertGroupsResponseBodyAlertGroupsAlertGroup : TeaModel {
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
