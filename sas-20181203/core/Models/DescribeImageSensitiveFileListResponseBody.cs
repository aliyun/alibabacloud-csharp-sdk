// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageSensitiveFileListResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The HTTP status code.
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
        public DescribeImageSensitiveFileListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageSensitiveFileListResponseBodyPageInfo : TeaModel {
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
            /// The number of entries returned per page. Default value: 20.
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
        /// An array that consists of the information about the sensitive files.
        /// </summary>
        [NameInMap("SensitiveFileList")]
        [Validation(Required=false)]
        public List<DescribeImageSensitiveFileListResponseBodySensitiveFileList> SensitiveFileList { get; set; }
        public class DescribeImageSensitiveFileListResponseBodySensitiveFileList : TeaModel {
            /// <summary>
            /// The suggestion.
            /// </summary>
            [NameInMap("Advice")]
            [Validation(Required=false)]
            public string Advice { get; set; }

            /// <summary>
            /// The key of the sensitive file type.
            /// </summary>
            [NameInMap("ClassKey")]
            [Validation(Required=false)]
            public string ClassKey { get; set; }

            /// <summary>
            /// The name of the sensitive file type.
            /// </summary>
            [NameInMap("ClassName")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            /// <summary>
            /// The number of scans that are performed on the sensitive file.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The description of the sensitive file.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The timestamp generated when the first scan was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            /// <summary>
            /// The timestamp generated when the last scan was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// The risk level. Valid values:
            /// 
            /// *   **high**
            /// *   **medium**
            /// *   **low**
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// The type of the alert for the sensitive file. Valid values:
            /// 
            /// *   **npm_token**: Node Package Manager (NPM) access token.
            /// *   **ftp_cfg**: FTP configuration.
            /// *   **google_oauth_key**: Google OAuth key.
            /// *   **planetscale_passwd**: PlanetScale password.
            /// *   **github_ssh_key**: GitHub SSH key.
            /// *   **msbuild_publish_profile**: MSBuild publish profile.
            /// *   **fastly_cdn_token**: Fastly CDN token.
            /// *   **ssh_private_key**: SSH private key.
            /// *   **aws_cli**: Amazon Web Services (AWS) CLI credential.
            /// *   **cpanel_proftpd**: cPanel ProFTPD credential.
            /// *   **postgresql_passwd**: PostgreSQL password file.
            /// *   **discord_client_cred**: Discord client credential.
            /// *   **rails_database**: Rails database configuration.
            /// *   **aws_access_key**: AWS access key.
            /// *   **esmtp_cfg**: Extended Simple Mail Transfer Protocol (ESMTP) configuration.
            /// *   **docker_registry_cfg**: Docker image repository configuration.
            /// *   **pem**: Privacy-Enhanced Mail (PEM).
            /// *   **common_cred**: common credential.
            /// *   **sftp_cfg**: Secure File Transfer Protocol (SFTP) connection configuration.
            /// *   **grafana_token**: Grafana token.
            /// *   **slack_token**: Slack token.
            /// *   **ec_private_key**: EC private key.
            /// *   **pypi_token**: upload token for the Python Package Index (PyPI).
            /// *   **finicity_token**: Finicity token.
            /// *   **k8s_client_key**: Kubernetes client private key.
            /// *   **git_cfg**: Git configuration.
            /// *   **django_key**: Django key.
            /// *   **jenkins_ssh**: Jenkins SSH configuration file.
            /// *   **openssh_private_key**: OpenSSH private key.
            /// *   **square_oauth**: OAuth credential for Square.
            /// *   **typeform_token**: Typeform token.
            /// *   **common_database_cfg**: general database connection configuration.
            /// *   **wordpress_database_cfg**: WordPress database configuration.
            /// *   **googlecloud_api_key**: API key for Google Cloud.
            /// *   **vscode_sftp**: VS Code SFTP configuration.
            /// *   **apache_htpasswd**: Apache htpasswd.
            /// *   **planetscale_token**: PlanetScale token.
            /// *   **contentful_preview_token**: preview token for Contentful.
            /// *   **php_database_cfg**: database password for a PHP application.
            /// *   **atom_remote_sync**: Atom remote synchronization configuration.
            /// *   **aws_session_token**: AWS session token.
            /// *   **atom_sftp_cfg**: Atom SFTP configuration.
            /// *   **asana_client_private_key**: Asana client key.
            /// *   **tencentcloud_ak**: secret ID of a third-party cloud.
            /// *   **rsa_private_key**: Rivest-Shamir-Adleman (RSA) private key.
            /// *   **github_personal_token**: personal access token for GitHub.
            /// *   **pgp**: Pretty Good Privacy (PGP) encrypted file.
            /// *   **stripe_skpk**: Stripe secret key.
            /// *   **square_token**: Square access token.
            /// *   **rails_carrierwave**: file upload credential for Rails Carrierwave.
            /// *   **dbeaver_database_cfg**: DBeaver database configuration.
            /// *   **robomongo_cred**: Robomongo credential.
            /// *   **github_oauth_token**: OAuth access token for GitHub.
            /// *   **pulumi_token**: Pulumi token.
            /// *   **ventrilo_voip**: Ventrilo VoIP server configuration.
            /// *   **macos_keychain**: macOS keychain.
            /// *   **amazon_mws_token**: Amazon MWS token.
            /// *   **dynatrace_token**: Dynatrace token.
            /// *   **java_keystore**: Java KeyStore (JKS).
            /// *   **microsoft_sdf**: Microsoft SQL Server Compact Edition (CE) database.
            /// *   **kubernetes_dashboard_cred**: user credential for Kubernetes Dashboard.
            /// *   **atlassian_token**: Atlassian token.
            /// *   **rdp**: remote desktop protocol (RDP).
            /// *   **mailgun_key**: Mailgun webhook signing key.
            /// *   **mailchimp_api_key**: API key for Mailchimp.
            /// *   **netrc_cfg**: .netrc configuration file.
            /// *   **openvpn_cfg**: OpenVPN client configuration.
            /// *   **github_refresh_token**: GitHub refresh token.
            /// *   **salesforce**: Salesforce credential.
            /// *   **sendinblue**: Sendinblue token.
            /// *   **pkcs_private_key**: PKCS#12 key.
            /// *   **rubyonrails_passwd**: Ruby on Rails password file.
            /// *   **filezilla_ftp**: FileZilla FTP configuration.
            /// *   **databricks_token**: Databricks token.
            /// *   **gitLab_personal_token**: personal access token for GitLab.
            /// *   **rails_master_key**: Rails master key.
            /// *   **sqlite**: SQLite3 or SQLite database.
            /// *   **firefox_logins**: Firefox logon configuration.
            /// *   **mailgun_private_token**: Mailgun private token.
            /// *   **joomla_cfg**: Joomla configuration.
            /// *   **hashicorp_terraform_token**: HashiCorp Terraform token.
            /// *   **jetbrains_ides**: JetBrains IDEs configuration.
            /// *   **heroku_api_key**: Heroku API key.
            /// *   **messagebird_token**: MessageBird token.
            /// *   **github_app_token**: GitHub app token.
            /// *   **hashicorp_vault_token**: HashiCorp Vault token.
            /// *   **pgp_private_key**: PGP private key.
            /// *   **sshpasswd**: SSH password.
            /// *   **huaweicloud_ak**: secret access key of a third-party cloud.
            /// *   **aws_s3cmd**: AWS S3cmd configuration.
            /// *   **php_config**: PHP configuration.
            /// *   **common_private_key**: private key of a common type.
            /// *   **microsoft_mdf**: Microsoft SQL Server database.
            /// *   **mediawiki_cfg**: MediaWiki configuration.
            /// *   **jenkins_cred**: Jenkins credential.
            /// *   **rubygems_cred**: RubyGems credential.
            /// *   **clojars_token**: Clojars token.
            /// *   **phoenix_web_passwd**: Phoenix web credential.
            /// *   **puttygen_private_key**: PuTTYgen private key.
            /// *   **google_oauth_token**: Google OAuth access token.
            /// *   **rubyonrails_cfg**: Ruby on Rails database configuration.
            /// *   **lob_api_key**: Lob API key.
            /// *   **pkcs_cred**: PKCS#12 certificate.
            /// *   **otr_private_key**: Off-the-Record Messaging (OTR) private key.
            /// *   **contentful_delivery_token**: delivery token for Contentful.
            /// *   **digital_ocean_tugboat**: DigitalOcean Tugboat configuration.
            /// *   **dsa_private_key**: Digital Signature Algorithm (DSA) private key.
            /// *   **rails_app_token**: Rails app token.
            /// *   **git_cred**: Git user credential.
            /// *   **newrelic_api_key**: user API key for New Relic.
            /// *   **github_hub**: hub configuration for storing GitHub tokens.
            /// *   **rubygem**: RubyGems token.
            /// </summary>
            [NameInMap("SensitiveFileKey")]
            [Validation(Required=false)]
            public string SensitiveFileKey { get; set; }

            /// <summary>
            /// The name of the alert type for the sensitive file.
            /// </summary>
            [NameInMap("SensitiveFileName")]
            [Validation(Required=false)]
            public string SensitiveFileName { get; set; }

            /// <summary>
            /// The number of unprocessed mirrors.
            /// </summary>
            [NameInMap("UnprocessedNum")]
            [Validation(Required=false)]
            public int? UnprocessedNum { get; set; }

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
