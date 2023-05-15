// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageSensitiveFileByKeyResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. If the 200 status code is returned, the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageSensitiveFileByKeyResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageSensitiveFileByKeyResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The key of the last data entry.
            /// </summary>
            [NameInMap("LastRowKey")]
            [Validation(Required=false)]
            public string LastRowKey { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the sensitive files.
        /// </summary>
        [NameInMap("SensitiveFileList")]
        [Validation(Required=false)]
        public List<DescribeImageSensitiveFileByKeyResponseBodySensitiveFileList> SensitiveFileList { get; set; }
        public class DescribeImageSensitiveFileByKeyResponseBodySensitiveFileList : TeaModel {
            /// <summary>
            /// The suggestion.
            /// </summary>
            [NameInMap("Advice")]
            [Validation(Required=false)]
            public string Advice { get; set; }

            /// <summary>
            /// The file path.
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// The timestamp when the first scan was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            /// <summary>
            /// The timestamp when the last scan was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// The digest of the image layer.
            /// </summary>
            [NameInMap("LayerDigest")]
            [Validation(Required=false)]
            public string LayerDigest { get; set; }

            /// <summary>
            /// The sensitive content.
            /// </summary>
            [NameInMap("Promt")]
            [Validation(Required=false)]
            public string Promt { get; set; }

            /// <summary>
            /// The risk level of the sensitive file. Valid values:
            /// 
            /// *   **high**
            /// *   **medium**
            /// *   **low**
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// The alert type of the sensitive file. Valid values:
            /// 
            /// *   **npm_token**: NPM Token
            /// *   **ftp_cfg**: FTP Config
            /// *   **google_oauth_key**: Google OAuth Key
            /// *   **planetscale_passwd**: Planetscale password
            /// *   **github_ssh_key**: Github SSH Key
            /// *   **msbuild_publish_profile**: MSBuild publish profile
            /// *   **fastly_cdn_token**: Fastly CDN Token
            /// *   **ssh_private_key**: SSH Private Key
            /// *   **aws_cli**: AWS CLI Credentials
            /// *   **cpanel_proftpd**: cPanel ProFTPd Credential
            /// *   **postgresql_passwd**: PostgreSQl Passwd
            /// *   **discord_client_cred**: Discord Client Credential
            /// *   **rails_database**: Rails Database Config
            /// *   **aws_access_key**: AWS Access Key
            /// *   **esmtp_cfg**: ESMTP Config
            /// *   **docker_registry_cfg**: Docker Registry Config
            /// *   **pem**: PEM
            /// *   **common_cred**: Common Credential
            /// *   **sftp_cfg**: SFTP Config
            /// *   **grafana_token**: Grafana Token
            /// *   **slack_token**: Slack Token
            /// *   **ec_private_key**: EC Private Key
            /// *   **pypi_token**: PyPI Token
            /// *   **finicity_token**: Finicity Token
            /// *   **k8s_client_key**: Kubernetes Client Key
            /// *   **git_cfg**: Git Config
            /// *   **django_key**: Django Key
            /// *   **jenkins_ssh**: Jenkins SSH Config
            /// *   **openssh_private_key**: OPENSSH Private Key
            /// *   **square_oauth**: Square OAuth Token
            /// *   **typeform_token**: Typeform Token
            /// *   **common_database_cfg**: Common Database Config
            /// *   **wordpress_database_cfg**: Wordpress Database Config
            /// *   **googlecloud_api_key**: Google Cloud API Key
            /// *   **vscode_sftp**: VSCode SFTP Config
            /// *   **apache_htpasswd**: Apache htpasswd
            /// *   **planetscale_token**: Planetscale Token
            /// *   **contentful_preview_token**: Contentful Preview Token
            /// *   **php_database_cfg**: PHP Database Config
            /// *   **atom_remote_sync**: Atom Remote Sync Config
            /// *   **aws_session_token**: AWS Session Token
            /// *   **atom_sftp_cfg**: Atom SFTP Config
            /// *   **asana_client_private_key**: Asana Client Private Key
            /// *   **tencentcloud_ak**: Tencent Cloud SecretId
            /// *   **rsa_private_key**: RSA Private Key
            /// *   **github_personal_token**: Github Personal Token
            /// *   **pgp**: PGP
            /// *   **stripe_skpk**: Stripe Secret Key
            /// *   **square_token**: Square Token
            /// *   **rails_carrierwave**: Rails Carrierwave Credential
            /// *   **dbeaver_database_cfg**: DBeaver Database Config
            /// *   **robomongo_cred**: Robomongo Credential
            /// *   **github_oauth_token**: Github OAuth Token
            /// *   **pulumi_token**: Pulumi Token
            /// *   **ventrilo_voip**: Ventrilo VoIP Server Config
            /// *   **macos_keychain**: macOS Keychain
            /// *   **amazon_mws_token**: Amazon MWS Token
            /// *   **dynatrace_token**: Dynatrace Token
            /// *   **java_keystore**: Java Keystore
            /// *   **microsoft_sdf**: Microsoft SDF
            /// *   **kubernetes_dashboard_cred**: Kubernetes Dashboard User Credential
            /// *   **atlassian_token**: Atlassian Token
            /// *   **rdp**: RDP
            /// *   **mailgun_key**: Mailgun Webhook Signing Key
            /// *   **mailchimp_api_key**: Mailchimp API Key
            /// *   **netrc_cfg**: .netrc config
            /// *   **openvpn_cfg**: OpenVPN Config
            /// *   **github_refresh_token**: Github Refresh Token
            /// *   **salesforce**: Salesforce Credential
            /// *   **sendinblue**: Sendinblue Token
            /// *   **pkcs_private_key**: PKCS Private Key
            /// *   **rubyonrails_passwd**: Ruby on Rails Passwd
            /// *   **filezilla_ftp**: FileZilla FTP Config
            /// *   **databricks_token**: Databricks Token
            /// *   **gitLab_personal_token**: GitLab Personal Token
            /// *   **rails_master_key**: Rails Master Key
            /// *   **sqlite**: SQLite3/SQLite Database
            /// *   **firefox_logins**: Firefox Login Config
            /// *   **mailgun_private_token**: Mailgun Private Token
            /// *   **joomla_cfg**: Joomla Config
            /// *   **hashicorp_terraform_token**: Hashicorp Terraform Token
            /// *   **jetbrains_ides**: Jetbrains IDEs Config
            /// *   **heroku_api_key**: Heroku API key
            /// *   **messagebird_token**: MessageBird Token
            /// *   **github_app_token**: Github App Token
            /// *   **hashicorp_vault_token**: Hashicorp Vault Token
            /// *   **pgp_private_key**: PGP Private Key
            /// *   **sshpasswd**: SSH password
            /// *   **huaweicloud_ak**: Huaei Cloud Access Key
            /// *   **aws_s3cmd**: AWS S3cmd Config
            /// *   **php_config**: php Config
            /// *   **common_private_key**: Common Private Key Type
            /// *   **microsoft_mdf**: Microsoft MDF
            /// *   **mediawiki_cfg**: MediaWiki Config
            /// *   **jenkins_cred**: Jenkins Credential
            /// *   **rubygems_cred**: Rubygems Credential
            /// *   **clojars_token**: Clojars Token
            /// *   **phoenix_web_passwd**: Phoenix Web Credential
            /// *   **puttygen_private_key**: PuTTYgen Private Key
            /// *   **google_oauth_token**: Google Oauth Token
            /// *   **rubyonrails_cfg**: Ruby On Rails Database Config
            /// *   **lob_api_key**: Lob API Key
            /// *   **pkcs_cred**: PKCS#12
            /// *   **otr_private_key**: OTR Private Key
            /// *   **contentful_delivery_token**: Contentful Delivery Token
            /// *   **digital_ocean_tugboat**: Digital Ocean Tugboat Config
            /// *   **dsa_private_key**: DSA Private Key
            /// *   **rails_app_token**: Rails App Token
            /// *   **git_cred**: Git User Credential
            /// *   **newrelic_api_key**: New Relic User API Key
            /// *   **github_hub**: Github Token
            /// *   **rubygem**: Rubygem Token
            /// </summary>
            [NameInMap("SensitiveFileKey")]
            [Validation(Required=false)]
            public string SensitiveFileKey { get; set; }

            /// <summary>
            /// The alert type name of the sensitive file.
            /// </summary>
            [NameInMap("SensitiveFileName")]
            [Validation(Required=false)]
            public string SensitiveFileName { get; set; }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
